using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TCVShared.Data;
using TCVShared.Helpers;
using TCVWeb.Areas.Admin.Models;

namespace TCVWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Manager")]
    public class ProductController : Controller
    {
        private readonly ILogger _logger;
        private readonly AppDBContext _dbContext;

        public ProductController(
            ILogger<ProductController> logger,
            AppDBContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }
        public IActionResult Index(PagedList<ShopItem> model)
        {
            var filterQuery = _dbContext.ShopItems.Where(x => model.Search == null || x.Name.Contains(model.Search));
            var selectQuery = filterQuery.OrderByDescending(x => x.Id).Skip((model.CurPage - 1) * model.PageSize).Take(model.PageSize);

            model.TotalRows = filterQuery.Count();
            model.Content = selectQuery.ToList();

            return View(model);
        }
        public ActionResult DetailsProduct(int id)
        {
            var model = _dbContext.ShopItems.Find(id);
            if (model == null)
                return BadRequest();

            return View(model);
        }

        public ActionResult CreateProduct()
        {
            ViewBag.ItemCats = _dbContext.ItemCats.Select(x => new SelectItemModel() { id = x.Id, text = x.Name }).ToList();
            return View(new ShopItem());
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult CreateProduct(ShopItem model)
        {
            if (!ModelState.IsValid)
                return View(model);
            try
            {
                model.CreateTime = DateTime.Now;
                _dbContext.ShopItems.Add(model);

                if (model.ItemCats != null)
                {
                    foreach (var catId in model.ItemCats)
                    {
                        ShopItemTaxo newCat = new ShopItemTaxo()
                        {
                            TaxoId = catId,
                            ItemId = model.Id,
                        };
                        _dbContext.ShopItemTaxoes.Add(newCat);
                    }
                }

                if (!string.IsNullOrEmpty(model.ItemTags))
                {
                    string[] itemTags = model.ItemTags.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var tag in itemTags)
                    {
                        string trTag = tag.Trim();
                        Taxonomy taxo = _dbContext.ItemTags.FirstOrDefault(x => x.Name == trTag);
                        if (taxo == null)
                        {
                            taxo = new Taxonomy() { Type = TaxoType.ItemTag, Name = trTag };
                            _dbContext.Taxonomies.Add(taxo);
                            _dbContext.SaveChanges();
                        }

                        ShopItemTaxo newTag = new ShopItemTaxo()
                        {
                            TaxoId = taxo.Id,
                            ItemId = model.Id,
                        };
                        _dbContext.ShopItemTaxoes.Add(newTag);
                    }
                }
                _dbContext.SaveChanges();
                model = new ShopItem();
                return Redirect(Url.Action("Index", "Product"));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View();
            }
        }

        public ActionResult ProductDetails(int? id)
        {
            ShopItem model = _dbContext.ShopItems.Find(id);
            if (model == null)
                return BadRequest();

            return View(model);
        }

        public ActionResult ProductUpdate(int? id)
        {
            ShopItem model = _dbContext.ShopItems.Find(id);
            if (model == null)
                return BadRequest();

            model.ItemCats = model.Taxonomies.Where(x => x.ItemId == model.Id && x.Taxonomy.Type == TaxoType.ItemCat).Select(x => x.TaxoId).ToArray();
            model.ItemTags = string.Join(", ", model.Taxonomies.Where(x => x.ItemId == model.Id && x.Taxonomy.Type == TaxoType.ItemTag).Select(x => x.Taxonomy.Name).ToArray());
            ViewBag.ItemCats = _dbContext.ItemCats.Select(x => new SelectItemModel() { id = x.Id, text = x.Name, selected = model.ItemCats.Contains(x.Id) }).ToList();
            return View("ProductEdit", model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult ProductUpdate(ShopItem model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _dbContext.Entry(model).State = EntityState.Modified;
                    _dbContext.Entry(model).Property(x => x.AlbumId).IsModified = false;
                    _dbContext.Entry(model).Property(x => x.ThreadId).IsModified = false;
                    _dbContext.Entry(model).Property(x => x.CreateTime).IsModified = false;

                    _dbContext.SaveChanges();

                    // Remove all taxoes
                    var delItems = (from item in _dbContext.ShopItemTaxoes
                                    where item.ItemId == model.Id
                                    select item);

                    foreach (var item in delItems)
                        _dbContext.ShopItemTaxoes.Remove(item);

                    // Add cats
                    if (model.ItemCats != null)
                    {
                        foreach (var catId in model.ItemCats)
                        {
                            ShopItemTaxo newCat = new ShopItemTaxo()
                            {
                                TaxoId = catId,
                                ItemId = model.Id,
                            };
                            _dbContext.ShopItemTaxoes.Add(newCat);
                        }
                    }

                    // Add tags
                    if (!string.IsNullOrEmpty(model.ItemTags))
                    {
                        string[] ItemTags = model.ItemTags.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (var tag in ItemTags)
                        {
                            string trTag = tag.Trim();
                            Taxonomy taxo = _dbContext.ItemTags.FirstOrDefault(x => x.Name == trTag);
                            if (taxo == null)
                            {
                                taxo = new Taxonomy() { Type = TaxoType.ItemTag, Name = trTag };
                                _dbContext.Taxonomies.Add(taxo);
                                _dbContext.SaveChanges();
                            }

                            ShopItemTaxo newTag = new ShopItemTaxo()
                            {
                                TaxoId = taxo.Id,
                                ItemId = model.Id,
                            };

                            _dbContext.ShopItemTaxoes.Add(newTag);
                        }
                    }

                    _dbContext.SaveChanges();
                    return RedirectToAction("Index", "Product");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }

            ViewBag.ItemCats = _dbContext.ItemCats.Select(x => new SelectItemModel() { id = x.Id, text = x.Name, selected = model.ItemCats.Contains(x.Id) }).ToList();
            return View(model);
        }


        #region ItemCat

        public ActionResult ItemCatList(PagedList<Taxonomy> model)
        {
            var filterQuery = _dbContext.ItemCats.Where(x => model.Search == null || x.Name.Contains(model.Search));
            var selectQuery = filterQuery.OrderByDescending(x => x.Id).Skip((model.CurPage - 1) * model.PageSize).Take(model.PageSize);

            model.TotalRows = filterQuery.Count();
            model.Content = selectQuery.ToList();

            return View(model);
        }

        public ActionResult ItemCatCreate()
        {
            ViewBag.ParentId = new SelectList(_dbContext.ItemCats, "Id", "Name");
            return View("ItemCatEdit", new Taxonomy());
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult ItemCatCreate(Taxonomy model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.Type = TaxoType.ItemCat;
                    _dbContext.Taxonomies.Add(model);
                    _dbContext.SaveChanges();
                    return Json(new ModalFormResult() { Code = 1 });
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }

            ViewBag.ParentId = new SelectList(_dbContext.ItemCats, "Id", "Name");
            return View("ItemCatEdit", model);
        }

        public ActionResult ItemCatUpdate(int? id)
        {
            Taxonomy model = _dbContext.Taxonomies.Find(id);
            if (model == null)
                return BadRequest();

            ViewBag.ParentId = new SelectList(_dbContext.ItemCats, "Id", "Name");
            return View("ItemCatEdit", model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult ItemCatUpdate(Taxonomy model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _dbContext.Entry(model).State = EntityState.Modified;
                    model.Type = TaxoType.ItemCat;
                    _dbContext.SaveChanges();
                    return Json(new ModalFormResult() { Code = 1 });
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }

            ViewBag.ParentId = new SelectList(_dbContext.ItemCats, "Id", "Name");
            return View("ItemCatEdit", model);
        }

        #endregion
    }
}