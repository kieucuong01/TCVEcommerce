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
            var productModel = _dbContext.ShopItems.FirstOrDefault(product => product.Id == id);
            return View(productModel);
        }

        public IActionResult Category()
        {
            return View();
        }
    }
}
