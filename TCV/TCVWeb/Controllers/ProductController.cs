using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TCVShared.Data;
using TCVShared.Helpers;
using TCVWeb.Models;
using System.Linq;
using System;
using System.Collections.Generic;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TCVWeb.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDBContext _dbContext;
        private readonly ILogger<ProductController> _logger;
        private readonly UserManager<AppUser> _userManager;

        public ProductController(AppDBContext dbContext,
    ILogger<ProductController> logger,
    UserManager<AppUser> userManager)
        {
            _dbContext = dbContext;
            _logger = logger;
            _userManager = userManager;

        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        //GET: Product/Detail/5
        public ActionResult Detail(int id)
        {
            ShopItem currentProduct = _dbContext.ShopItems.FirstOrDefault(product => product.Id == id);
            ShopItem[] otherSizeProduct = _dbContext.ShopItems.Where(product => product.SKU.Substring(10, 3) == currentProduct.SKU.Substring(10, 3)).ToArray();

            var additionalInfomation = new List<AdditionInfo>();
            additionalInfomation.Add(new AdditionInfo("Origin", currentProduct.SKU.Substring(4, 2)));
            additionalInfomation.Add(new AdditionInfo("Size", currentProduct.SKU.Substring(6, 1)));

            ViewData["additionalInfomation"] = additionalInfomation;

            ViewData["currentProduct"] = currentProduct;

            ViewData["otherSizeProduct"] = otherSizeProduct;

            if (_dbContext.ShopItems.Any(o => int.Parse(o.SKU.Substring(10,3)) == int.Parse(currentProduct.SKU.Substring(10,3)) + 1) == true) {
                ViewData["nextProduct"] = _dbContext.ShopItems.FirstOrDefault(o => int.Parse(o.SKU.Substring(10, 3)) == int.Parse(currentProduct.SKU.Substring(10, 3)) + 1);
            }
            else {
                ViewData["nextProduct"] = currentProduct;
            }

            if (_dbContext.ShopItems.Any(o => int.Parse(o.SKU.Substring(10, 3)) == int.Parse(currentProduct.SKU.Substring(10, 3)) - 1) == true){
                ViewData["previousProduct"] = _dbContext.ShopItems.FirstOrDefault(o => int.Parse(o.SKU.Substring(10, 3)) == int.Parse(currentProduct.SKU.Substring(10, 3)) - 1);
            }
            else {
                ViewData["previousProduct"] = currentProduct;
            }


            ViewData["suggestedProduct"] = _dbContext.ShopItems.Where(product => product.Id < 5 && product.SKU.Substring(6,1) == "S").ToArray();

            // Get comment;
            List<UserMessage> comments = _dbContext.UserMessages.Where(comment => comment.ThreadId == currentProduct.ThreadId).ToList();
            ViewData["comments"] = comments;

            return View();
        }

        public IActionResult Category(PagedList<ShopItem> model, int pageSize, int id, string from, string origin, int maxPrice, int minPrice, string style)
        {
            // Filter products  by category 
            var filterQuery = _dbContext.ShopItems.Where(x => model.Search == null && x.SKU.Substring(6,1) == "S");
            var selectQuery = filterQuery.OrderByDescending(x => x.Id).Skip((model.CurPage - 1) * model.PageSize).Take(model.PageSize);
            if (id == 0) {
                selectQuery = filterQuery.Where(x => x.SKU.Substring(0, 3) == "NUT").Skip((model.CurPage - 1) * model.PageSize).Take(model.PageSize);
            }
            else if (id == 1){
                selectQuery = filterQuery.Where(x => x.SKU.Substring(0, 3) == "VEG").Skip((model.CurPage - 1) * model.PageSize).Take(model.PageSize);
            }
            else if (id == 3){
                selectQuery = filterQuery.Where(x => x.SKU.Substring(0, 3) == "SEE").Skip((model.CurPage - 1) * model.PageSize).Take(model.PageSize);

            }
            else if (id == 2){
                selectQuery = filterQuery.Where(x => x.SKU.Substring(0, 3) == "FRU").Skip((model.CurPage - 1) * model.PageSize).Take(model.PageSize);
            }
            else {
            }

            // Filter products by export or import  
            if (from == "D") {
                selectQuery = filterQuery.Where(x => x.SKU.Substring(3, 1) == "D").Skip((model.CurPage - 1) * model.PageSize).Take(model.PageSize);
            }
            else if (from == "F") {
                selectQuery = filterQuery.Where(x => x.SKU.Substring(3, 1) == "F").Skip((model.CurPage - 1) * model.PageSize).Take(model.PageSize);
            }

            // Filter products by Origin
            if (origin == "VN")
            {
                selectQuery = filterQuery.Where(x => x.SKU.Substring(4, 2) == "VN").Skip((model.CurPage - 1) * model.PageSize).Take(model.PageSize);
            }
            else if (origin == "AU")
            {
                selectQuery = filterQuery.Where(x => x.SKU.Substring(4, 2) == "AU").Skip((model.CurPage - 1) * model.PageSize).Take(model.PageSize);
            }
            else if (origin == "IL")
            {
                selectQuery = filterQuery.Where(x => x.SKU.Substring(4, 2) == "IL").Skip((model.CurPage - 1) * model.PageSize).Take(model.PageSize);
            }
            // Filter product by prices 

            if (maxPrice != 0){
                selectQuery = filterQuery.Where(x => x.CurrentPrice >= minPrice && x.CurrentPrice <= maxPrice).Skip((model.CurPage - 1) * model.PageSize).Take(model.PageSize);
            }

            model.TotalRows = filterQuery.Count();
            model.Content = selectQuery.ToList();
            model.PageSize = pageSize != 0 ? pageSize : 12;


            if (style == "list"){
                ViewData["style"] = "list";
            }
            else {
                ViewData["style"] = "grid";
            }
            ViewData["categories"] = new String[] { "Hạt", "Thực phẩm", "Hoa quả sấy", "Nấm" };

            return View(model);
        }

        // GET: /Product/QuickView/<id>
        public IActionResult QuickView(int id)
        {
            ShopItem model = _dbContext.ShopItems.Find(id);

            return PartialView("_PartialQuickView", model);
        }

    }
}
