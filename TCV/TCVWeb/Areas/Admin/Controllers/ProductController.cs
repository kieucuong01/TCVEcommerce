using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
    [Authorize(Roles = "Manager,Operator")]
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

        public ActionResult CreateProduct()
        {
            ViewBag.ItemCats = _dbContext.ItemCats.Select(x => new SelectItemModel() { id = x.Id, text = x.Name }).ToList();
            var export = _dbContext.Exports.Where(x => x.ParentId != null).Select(x => new SelectExportModel() { id = x.Id, text = x.Name, parentId = x.ParentId, parentText = x.ParentName }).ToList();
            //List<string> exportPlace = new List<string>();
            foreach (var item in export)
            {
                item.parentText = _dbContext.Taxonomies.FirstOrDefault(x => x.Id == item.parentId).Name;
                //exportPlace.Add(item.parentText);
            }
            ViewBag.Export = export;
            //ViewBag.ExportPlace = exportPlace.Distinct();
            ViewBag.SizeList = _dbContext.Sizes.Select(x => new SelectItemModel() { id = x.Id, text = x.Name }).ToList();
            ViewBag.IdLast = _dbContext.ShopItems.OrderByDescending(x=>x.Id).Select(x => x.Id).FirstOrDefault();
            var test = _dbContext.ShopItems.LastOrDefault();
            return View(new ShopItem());
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult CreateProduct(ShopItem model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.ItemCats = _dbContext.ItemCats.Select(x => new SelectItemModel() { id = x.Id, text = x.Name }).ToList();
                var export = _dbContext.Exports.Where(x => x.ParentId != null).Select(x => new SelectExportModel() { id = x.Id, text = x.Name, parentId = x.ParentId, parentText = x.ParentName }).ToList();
                foreach (var item in export)
                {
                    item.parentText = _dbContext.Taxonomies.FirstOrDefault(x => x.Id == item.parentId).Name;
                }
                ViewBag.Export = export;
                ViewBag.SizeList = _dbContext.Sizes.Select(x => new SelectItemModel() { id = x.Id, text = x.Name }).ToList();

                ViewBag.IdLast = _dbContext.ShopItems.OrderByDescending(x => x.Id).Select(x => x.Id).FirstOrDefault();
                ModelState.AddModelError("Thông tin sản phẩm lỗi. Vui lòng nhập lại.", "Error");
                return RedirectToAction("CreateProduct", "Product", new { area = "Admin" });
            }
            if (model.SKU == null)
            {
                ViewBag.ItemCats = _dbContext.ItemCats.Select(x => new SelectItemModel() { id = x.Id, text = x.Name }).ToList();
                var export = _dbContext.Exports.Where(x => x.ParentId != null).Select(x => new SelectExportModel() { id = x.Id, text = x.Name, parentId = x.ParentId, parentText = x.ParentName }).ToList();
                foreach (var item in export)
                {
                    item.parentText = _dbContext.Taxonomies.FirstOrDefault(x => x.Id == item.parentId).Name;
                }
                ViewBag.Export = export;
                ViewBag.SizeList = _dbContext.Sizes.Select(x => new SelectItemModel() { id = x.Id, text = x.Name }).ToList();

                ViewBag.IdLast = _dbContext.ShopItems.OrderByDescending(x => x.Id).Select(x => x.Id).FirstOrDefault();
                ModelState.AddModelError("Thông tin sản phẩm lỗi. Vui lòng nhập lại.", "Error");
                return RedirectToAction("CreateProduct", "Product", new { area = "Admin" });
            }
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
                if (model.Exports != null)
                {
                    foreach (var catId in model.Exports)
                    {
                        ShopItemTaxo newCat = new ShopItemTaxo()
                        {
                            TaxoId = catId,
                            ItemId = model.Id,
                        };
                        _dbContext.ShopItemTaxoes.Add(newCat);
                    }
                }
                if (model.ExportsPlace != null)
                {
                    foreach (var catId in model.ExportsPlace)
                    {
                        ShopItemTaxo newCat = new ShopItemTaxo()
                        {
                            TaxoId = catId,
                            ItemId = model.Id,
                        };
                        _dbContext.ShopItemTaxoes.Add(newCat);
                    }
                }
                if (model.SizeProduct != null)
                {
                    foreach (var catId in model.SizeProduct)
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
                //model = new ShopItem();
                return Redirect(Url.Action("DetailsProduct", "Product", new { id = model.Id }));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View();
            }
        }

        public ActionResult DetailsProduct(int? id)
        {
            ShopItem model = _dbContext.ShopItems.Find(id);
            model.Attributes = _dbContext.ShopItemAttribs.Where(x => x.ItemId == id).ToList();
            if (model == null)
                return BadRequest();

            return View(model);
        }

        public ActionResult UpdateProduct(int? id)
        {
            ShopItem model = _dbContext.ShopItems.Find(id);
            if (model == null)
                return BadRequest();

            model.ItemCats = (from x in _dbContext.Taxonomies
                              join y in _dbContext.ShopItemTaxoes on x.Id equals y.TaxoId
                              where y.ItemId == id && x.Type == TaxoType.ItemCat
                              select x.Id).ToArray();
            model.Exports = (from x in _dbContext.Taxonomies
                             join y in _dbContext.ShopItemTaxoes on x.Id equals y.TaxoId
                             where y.ItemId == id && x.Type == TaxoType.Export
                             select x.Id).ToArray();
            model.ExportsPlace = (from x in _dbContext.Taxonomies
                                  join y in _dbContext.ShopItemTaxoes on x.Id equals y.TaxoId
                                  where y.ItemId == id && x.Type == TaxoType.Export
                                  select x.Id).ToArray();
            model.SizeProduct = (from x in _dbContext.Taxonomies
                                 join y in _dbContext.ShopItemTaxoes on x.Id equals y.TaxoId
                                 where y.ItemId == id && x.Type == TaxoType.Size
                                 select x.Id).ToArray();

            var itemTags = (from x in _dbContext.Taxonomies
                            join y in _dbContext.ShopItemTaxoes on x.Id equals y.TaxoId
                            where y.ItemId == id && x.Type == TaxoType.ItemTag
                            select x.Name).ToArray();

            model.ItemTags = string.Join(", ", itemTags);

            model.Status = model.Status;

            ViewBag.ItemCats = _dbContext.ItemCats.Select(x => new SelectItemModel() { id = x.Id, text = x.Name, selected = model.ItemCats.Contains(x.Id) }).ToList();
            var export = _dbContext.Exports.Where(x => x.ParentId != null).Select(x => new SelectExportModel() { id = x.Id, text = x.Name, parentId = x.ParentId, parentText = x.ParentName, selected = model.ExportsPlace.Contains(x.Id), selectedParent = model.Exports.Contains(x.Id) }).ToList();
            foreach (var item in export)
            {
                item.parentText = _dbContext.Taxonomies.FirstOrDefault(x => x.Id == item.parentId).Name;
            }
            ViewBag.Export = export;
            ViewBag.SizeList = _dbContext.Sizes.Select(x => new SelectItemModel() { id = x.Id, text = x.Name, selected = model.SizeProduct.Contains(x.Id) }).ToList();
            ViewBag.IdLast = model.SKU.Substring(12, model.SKU.Length - 12);
            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult UpdateProduct(ShopItem model)
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
                    if (model.Exports != null)
                    {
                        foreach (var catId in model.Exports)
                        {
                            ShopItemTaxo newCat = new ShopItemTaxo()
                            {
                                TaxoId = catId,
                                ItemId = model.Id,
                            };
                            _dbContext.ShopItemTaxoes.Add(newCat);
                        }
                    }
                    if (model.ExportsPlace != null)
                    {
                        foreach (var catId in model.ExportsPlace)
                        {
                            ShopItemTaxo newCat = new ShopItemTaxo()
                            {
                                TaxoId = catId,
                                ItemId = model.Id,
                            };
                            _dbContext.ShopItemTaxoes.Add(newCat);
                        }
                    }
                    if (model.SizeProduct != null)
                    {
                        foreach (var catId in model.SizeProduct)
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
                    return RedirectToAction("DetailsProduct", "Product", new { id = model.Id });
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }

            ViewBag.ItemCats = _dbContext.ItemCats.Select(x => new SelectItemModel() { id = x.Id, text = x.Name, selected = model.ItemCats.Contains(x.Id) }).ToList();
            return View(model);
        }

        public ActionResult DeleteProduct(int? id)
        {
            ShopItem model = _dbContext.ShopItems.Find(id);
            if (model == null)
                return BadRequest();

            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult DeleteProduct(ShopItem model)
        {
            try
            {
                _dbContext.Entry(model).State = EntityState.Deleted;
                _dbContext.SaveChanges();
                return Json(new ModalFormResult() { Code = 1 });
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

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
                    if (model.Parent != null)
                        model.Parent.Name = _dbContext.Taxonomies.Find(model.ParentId).Name;
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



        #region Export

        public ActionResult ExportList(PagedList<Taxonomy> model)
        {
            var filterQuery = _dbContext.Exports.Where(x => model.Search == null || x.Name.Contains(model.Search));
            var selectQuery = filterQuery.OrderByDescending(x => x.Id).Skip((model.CurPage - 1) * model.PageSize).Take(model.PageSize);

            model.TotalRows = filterQuery.Count();
            model.Content = selectQuery.ToList();

            return View(model);
        }

        public ActionResult ExportCreate()
        {
            ViewBag.ParentId = new SelectList(_dbContext.Exports, "Id", "Name");
            return View("ExportEdit", new Taxonomy());
        }


        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult ExportCreate(Taxonomy model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.Type = TaxoType.Export;
                    if (model.Parent != null)
                        model.Parent.Name = _dbContext.Taxonomies.Find(model.ParentId).Name;
                    _dbContext.Taxonomies.Add(model);
                    _dbContext.SaveChanges();
                    return Json(new ModalFormResult() { Code = 1 });
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }

            ViewBag.ParentId = new SelectList(_dbContext.Exports, "Id", "Name");
            return View("ExportEdit", model);
        }

        public ActionResult ExportUpdate(int? id)
        {
            Taxonomy model = _dbContext.Taxonomies.Find(id);
            if (model == null)
                return BadRequest();

            ViewBag.ParentId = new SelectList(_dbContext.Exports, "Id", "Name");
            return View("ExportEdit", model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult ExportUpdate(Taxonomy model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _dbContext.Entry(model).State = EntityState.Modified;
                    model.Type = TaxoType.Export;
                    _dbContext.SaveChanges();
                    return Json(new ModalFormResult() { Code = 1 });
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }

            ViewBag.ParentId = new SelectList(_dbContext.Exports, "Id", "Name");
            return View("ExportEdit", model);
        }

        #endregion


        #region SizeProduct

        public ActionResult SizeProductList(PagedList<Taxonomy> model)
        {
            var filterQuery = _dbContext.Sizes.Where(x => model.Search == null || x.Name.Contains(model.Search));
            var selectQuery = filterQuery.OrderByDescending(x => x.Id).Skip((model.CurPage - 1) * model.PageSize).Take(model.PageSize);

            model.TotalRows = filterQuery.Count();
            model.Content = selectQuery.ToList();

            return View(model);
        }

        public ActionResult SizeProductCreate()
        {
            ViewBag.ParentId = new SelectList(_dbContext.Sizes, "Id", "Name");
            return View("SizeProductEdit", new Taxonomy());
        }


        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult SizeProductCreate(Taxonomy model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.Type = TaxoType.Size;
                    if (model.Parent != null)
                        model.Parent.Name = _dbContext.Taxonomies.Find(model.ParentId).Name;
                    _dbContext.Taxonomies.Add(model);
                    _dbContext.SaveChanges();
                    return Json(new ModalFormResult() { Code = 1 });
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }

            ViewBag.ParentId = new SelectList(_dbContext.Sizes, "Id", "Name");
            return View("SizeProductEdit", model);
        }

        public ActionResult SizeProductUpdate(int? id)
        {
            Taxonomy model = _dbContext.Taxonomies.Find(id);
            if (model == null)
                return BadRequest();

            ViewBag.ParentId = new SelectList(_dbContext.Sizes, "Id", "Name");
            return View("SizeProductEdit", model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult SizeProductUpdate(Taxonomy model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _dbContext.Entry(model).State = EntityState.Modified;
                    model.Type = TaxoType.Size;
                    _dbContext.SaveChanges();
                    return Json(new ModalFormResult() { Code = 1 });
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }

            ViewBag.ParentId = new SelectList(_dbContext.Sizes, "Id", "Name");
            return View("SizeProductEdit", model);
        }

        #endregion

        #region ItemAttr

        public ActionResult ItemAttrList(PagedList<ShopAttrib> model)
        {
            var filterQuery = _dbContext.ShopAttribs.Where(x => model.Search == null || x.Name.Contains(model.Search));
            var selectQuery = filterQuery.OrderByDescending(x => x.Id).Skip((model.CurPage - 1) * model.PageSize).Take(model.PageSize);

            model.TotalRows = filterQuery.Count();
            model.Content = selectQuery.ToList();

            return View(model);
        }

        public ActionResult ItemAttrCreate()
        {
            return View("ItemAttrEdit", new ShopAttrib());
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult ItemAttrCreate(ShopAttrib model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _dbContext.ShopAttribs.Add(model);
                    _dbContext.SaveChanges();
                    return Json(new ModalFormResult() { Code = 1 });
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }

            return View("ItemAttrEdit", model);
        }

        public ActionResult ItemAttrUpdate(int? id)
        {
            ShopAttrib model = _dbContext.ShopAttribs.Find(id);
            if (model == null)
                return BadRequest();

            return View("ItemAttrEdit", model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult ItemAttrUpdate(ShopAttrib model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _dbContext.Entry(model).State = EntityState.Modified;
                    _dbContext.SaveChanges();
                    return Json(new ModalFormResult() { Code = 1 });
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }

            return View("ItemAttrEdit", model);
        }

        #endregion

        #region ShopItemAttrib

        public ActionResult ShopItemAttrCreate(int? id)
        {
            ShopItem item = _dbContext.ShopItems.Find(id);
            if (item == null)
                return BadRequest();

            //ViewBag.MediaAlbum = item.MediaAlbum;
            var mediaAlbum = _dbContext.MediaAlbums.Where(x => x.Id == item.AlbumId).Include(x => x.MediaFiles).SingleOrDefault();
            var mediaFile = mediaAlbum.MediaFiles;
            foreach (var item1 in mediaAlbum.MediaFiles)
                item1.FileLink = Path.Combine("https://localhost:44336/media", item1.FullPath);

            ViewBag.MediaAlbum = mediaAlbum;

            ShopItemAttrib model = new ShopItemAttrib() { ItemId = item.Id, Values = "[]" };

            ViewBag.AttrId = new SelectList(_dbContext.ShopAttribs, "Id", "Title");
            return View("ShopItemAttrEdit", model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult ShopItemAttrCreate(ShopItemAttrib model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    ShopAttrib attr = _dbContext.ShopAttribs.Find(model.AttrId);
                    if (attr != null)
                    {
                        foreach (var item in model.ValuesList)
                            item.Name = attr.Name;
                        model.OnUpdateValues();
                    }

                    _dbContext.ShopItemAttribs.Add(model);
                    _dbContext.SaveChanges();

                    return Json(new ModalFormResult() { Code = 1 });
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }

            ViewBag.AttrId = new SelectList(_dbContext.ShopAttribs, "Id", "Title");
            return View("ShopItemAttrEdit", model);
        }

        public ActionResult ShopItemAttrUpdate(int? id)
        {
            ShopItemAttrib model = _dbContext.ShopItemAttribs.Find(id);
            if (model == null)
                return BadRequest();

            //ViewBag.MediaAlbum = model.ShopItem.MediaAlbum;
            ViewBag.AttrId = new SelectList(_dbContext.ShopAttribs, "Id", "Title");
            return View("ShopItemAttrEdit", model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult ShopItemAttrUpdate(ShopItemAttrib model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    ShopAttrib attr = _dbContext.ShopAttribs.Find(model.AttrId);
                    if (attr != null)
                    {
                        foreach (var item in model.ValuesList)
                            item.Name = attr.Name;
                        model.OnUpdateValues();
                    }

                    _dbContext.Entry(model).State = EntityState.Modified;
                    _dbContext.SaveChanges();

                    return Json(new ModalFormResult() { Code = 1 });
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }

            ViewBag.AttrId = new SelectList(_dbContext.ShopAttribs, "Id", "Title");
            return View("ShopItemAttrEdit", model);
        }

        public ActionResult ShopItemAttrDelete(int? id)
        {
            ShopItemAttrib model = _dbContext.ShopItemAttribs.Find(id);
            if (model == null)
                return BadRequest();

            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult ShopItemAttrDelete(ShopItemAttrib model)
        {
            try
            {
                _dbContext.Entry(model).State = EntityState.Deleted;
                _dbContext.SaveChanges();
                return Json(new ModalFormResult() { Code = 1 });
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            return View(model);
        }

        #endregion

        #region Order
        public ActionResult Orders(PagedList<ShopOrder> model)
        {
            var filterQuery = _dbContext.ShopOrders.Where(x => model.Search == null || x.AppUser.UserName.Contains(model.Search));
            var selectQuery = filterQuery.OrderByDescending(x => x.Id).Skip((model.CurPage - 1) * model.PageSize).Take(model.PageSize);

            model.TotalRows = filterQuery.Count();
            model.Content = selectQuery.ToList();
            foreach (var user in model.Content)
            {
                user.AppUser = _dbContext.Users.FirstOrDefault(x => x.Id == user.UserId);
            }

            return View(model);
        }

        public ActionResult DetailsOrder(int? id)
        {
            ShopOrder model = _dbContext.ShopOrders.Where(x => x.Id == id).Include(y => y.Items).Include(x => x.AppUser).SingleOrDefault();
            var orderItem = _dbContext.OrderItems.Include(x => x.ShopItem).Include(x => x.ShopOrder).ToString();
            foreach (var item in model.Items)
            {
                var item1 = _dbContext.OrderItems.Include(x => x.ShopItem).Where(x => x.Id == item.Id).SingleOrDefault();
                item.ShopItem = item1.ShopItem;
            }

            if (model == null)
                return BadRequest();

            return View(model);
        }

        public ActionResult UpdateOrder(int id)
        {
            ShopOrder order = _dbContext.ShopOrders.Where(x => x.Id == id).SingleOrDefault();
            UpdateOrderModel orderItemModel = new UpdateOrderModel
            {
                Id = order.Id,
                OrderStatus = order.OrderStatus,
                PaymentStatus = order.PaymentStatus
            };
            return View(orderItemModel);
        }

        [HttpPost]
        public ActionResult UpdateOrder(UpdateOrderModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    ShopOrder order = _dbContext.ShopOrders.Where(x => x.Id == model.Id).SingleOrDefault();
                    order.OrderStatus = model.OrderStatus;
                    order.PaymentStatus = model.PaymentStatus;
                    _dbContext.SaveChanges();
                    return Json(new ModalFormResult() { Code = 1 });
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }
            return View(model);
        }

        [HttpPost]
        public ShopItem SearchItem(string id)
        {
            ShopItem model = _dbContext.ShopItems.Where(x => x.SKU == id).SingleOrDefault();
            return model;
        }

        public ActionResult AddOrderItem()
        {
            return View(new ShopItem());
        }

        [HttpPost]
        public ActionResult AddOrderItem(int id, string masp, int sl)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (sl <= 0)
                    {
                        ModelState.AddModelError("", "Số lượng không hợp lệ");
                        return View();
                    }

                    ShopItem modelItem = _dbContext.ShopItems.Where(x => x.SKU == masp).FirstOrDefault();
                    ShopOrder shopOrder = _dbContext.ShopOrders.Include(x => x.Items).Where(x => x.Id == 42).SingleOrDefault();
                    OrderItem orderItem = _dbContext.OrderItems.Where(x => x.ItemId == modelItem.Id).FirstOrDefault();


                    shopOrder.AdjustPrice = shopOrder.AdjustPrice + modelItem.CurrentPrice * sl;
                    shopOrder.CreateTime = DateTime.Now;
                    shopOrder.ShippingFee = 30000;
                    shopOrder.GrandTotalPrice = shopOrder.AdjustPrice + shopOrder.ShippingFee;

                    _dbContext.SaveChanges();

                    if (orderItem != null)
                    {
                        orderItem.Quantity = orderItem.Quantity + sl;
                        _dbContext.OrderItems.Update(orderItem);
                    }
                    else
                    {
                        OrderItem orderItemNew = new OrderItem
                        {
                            Quantity = sl,
                            ItemId = modelItem.Id,
                            OrderId = id,
                            ShopItem = modelItem,
                            ShopOrder = shopOrder,
                        };
                        _dbContext.OrderItems.Add(orderItemNew);
                    }

                    _dbContext.SaveChanges();

                    return View();
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }
            return View();
        }

        public ActionResult UpdateOrderItem(int id)
        {
            OrderItem orderItem = _dbContext.OrderItems.Where(x => x.Id == id).Include(x => x.ShopItem).Include(x => x.ShopOrder).SingleOrDefault();
            UpdateOrderItemModel orderItemModel = new UpdateOrderItemModel
            {
                Id = orderItem.Id,
                ItemName = orderItem.ShopItem.Name,
                CurrentPrice = orderItem.ShopItem.CurrentPrice,
                Quantity = orderItem.Quantity,
            };
            return View(orderItemModel);
        }

        [HttpPost]
        public ActionResult UpdateOrderItem(UpdateOrderItemModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (model.Quantity <= 0)
                    {
                        ModelState.AddModelError("", "Số lượng không hợp lệ");
                        return View(model);
                    }
                    OrderItem orderItem = _dbContext.OrderItems.Where(x => x.Id == model.Id).Include(x => x.ShopItem).Include(x => x.ShopOrder).SingleOrDefault();
                    var temp = orderItem.Quantity;
                    orderItem.Quantity = model.Quantity;
                    orderItem.ShopOrder.AdjustPrice = orderItem.ShopOrder.AdjustPrice + orderItem.ShopItem.CurrentPrice * (model.Quantity-temp);
                    orderItem.ShopOrder.CreateTime = DateTime.Now;
                    orderItem.ShopOrder.ShippingFee = 30000;
                    orderItem.ShopOrder.GrandTotalPrice = orderItem.ShopOrder.AdjustPrice + orderItem.ShopOrder.ShippingFee;
                    _dbContext.SaveChanges();
                    return Json(new ModalFormResult() { Code = 1 });
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }
            return View(model);
        }

        #endregion
    }
}