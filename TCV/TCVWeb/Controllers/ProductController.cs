using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TCVShared.Data;
using TCVShared.Helpers;
using TCVWeb.Models;
using System.Linq;

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

        public IActionResult Category()
        {
            return View();
        }
    }
}
