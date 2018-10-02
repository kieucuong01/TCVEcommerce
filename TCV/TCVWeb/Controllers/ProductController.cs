using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TCVShared.Data;
using TCVShared.Helpers;
using TCVWeb.Models;
using System.Linq;
using System;

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
            if (_dbContext.ShopItems.Any(o => o.Id == id + 1) == true) {
                ViewData["nextProduct"] = _dbContext.ShopItems.FirstOrDefault(product => product.Id == id + 1);
            }
            else {
                ViewData["nextProduct"] = _dbContext.ShopItems.FirstOrDefault(product => product.Id == 1);
            }

            if (_dbContext.ShopItems.Any(o => o.Id == id - 1) == true){
                ViewData["previousProduct"] = _dbContext.ShopItems.FirstOrDefault(product => product.Id == id - 1);
            }
            else {
                ViewData["previousProduct"] = _dbContext.ShopItems.FirstOrDefault(product => product.Id == 1);
            }

            ViewData["currentProduct"] = _dbContext.ShopItems.FirstOrDefault(product => product.Id == id);
            ViewData["suggestedProduct"] = new ShopItem[5]{ _dbContext.ShopItems.FirstOrDefault(product => product.Id == 1),
                                                            _dbContext.ShopItems.FirstOrDefault(product => product.Id == 2),
                                                            _dbContext.ShopItems.FirstOrDefault(product => product.Id == 3),
            _dbContext.ShopItems.FirstOrDefault(product => product.Id == 4),
                _dbContext.ShopItems.FirstOrDefault(product => product.Id == 5)};
        
            return View();
        }

        public IActionResult Category(int id, string from, string origin, int maxPrice, int minPrice, string style)
        {
            PagedList<ShopItem> model = new PagedList<ShopItem>();
            // Filter products  by category 
            var filterQuery = _dbContext.ShopItems.Where(x => model.Search == null);
            var selectQuery = filterQuery.OrderByDescending(x => x.Id).Skip((model.CurPage - 1) * model.PageSize).Take(model.PageSize);
            if (id == 0) {
                selectQuery = _dbContext.ShopItems.Where(x => x.SKU.Substring(0, 3) == "NUT").Skip((model.CurPage - 1) * model.PageSize).Take(model.PageSize);
            }
            else if (id == 1){
                selectQuery = _dbContext.ShopItems.Where(x => x.SKU.Substring(0, 3) == "VEG").Skip((model.CurPage - 1) * model.PageSize).Take(model.PageSize);
            }
            else if (id == 3){
                selectQuery = _dbContext.ShopItems.Where(x => x.SKU.Substring(0, 3) == "SEE").Skip((model.CurPage - 1) * model.PageSize).Take(model.PageSize);

            }
            else if (id == 2){
                selectQuery = _dbContext.ShopItems.Where(x => x.SKU.Substring(0, 3) == "FRU").Skip((model.CurPage - 1) * model.PageSize).Take(model.PageSize);
            }
            else {
            }

            // Filter products by export or import  
            if (from == "D") {
                selectQuery = _dbContext.ShopItems.Where(x => x.SKU.Substring(3, 1) == "D").Skip((model.CurPage - 1) * model.PageSize).Take(model.PageSize);
            }
            else if (from == "F") {
                selectQuery = _dbContext.ShopItems.Where(x => x.SKU.Substring(3, 1) == "F").Skip((model.CurPage - 1) * model.PageSize).Take(model.PageSize);
            }

            // Filter products by Origin
            if (origin == "VN")
            {
                selectQuery = _dbContext.ShopItems.Where(x => x.SKU.Substring(4, 2) == "VN").Skip((model.CurPage - 1) * model.PageSize).Take(model.PageSize);
            }
            else if (origin == "AU")
            {
                selectQuery = _dbContext.ShopItems.Where(x => x.SKU.Substring(4, 2) == "AU").Skip((model.CurPage - 1) * model.PageSize).Take(model.PageSize);
            }
            else if (origin == "IL")
            {
                selectQuery = _dbContext.ShopItems.Where(x => x.SKU.Substring(4, 2) == "IL").Skip((model.CurPage - 1) * model.PageSize).Take(model.PageSize);
            }
            // Filter product by prices 

            if (maxPrice != 0){
                selectQuery = _dbContext.ShopItems.Where(x => x.CurrentPrice >= minPrice && x.CurrentPrice <= maxPrice).Skip((model.CurPage - 1) * model.PageSize).Take(model.PageSize);
            }

            model.TotalRows = filterQuery.Count();
            model.Content = selectQuery.ToList();

            if (style == "list"){
                ViewData["style"] = "list";
            }
            else {
                ViewData["style"] = "grid";
            }
            ViewData["categories"] = new String[] { "Hạt", "Rau củ", "Trái Cây", "Cây giống" };

            return View(model);
        }
    }
}
