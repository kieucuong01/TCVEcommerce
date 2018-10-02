using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TCVShared.Data;
using TCVShared.Helpers;
using TCVWeb.Models;
using System.Linq;
using Microsoft.AspNetCore.Session;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TCVWeb.Controllers
{
    public class CartController : Controller
    {
        private readonly AppDBContext _dbContext;
        private readonly ILogger<CartController> _logger;
        private readonly UserManager<AppUser> _userManager;

        public CartController(AppDBContext dbContext,
                                ILogger<CartController> logger,
                                UserManager<AppUser> userManager)
        {
            _dbContext = dbContext;
            _logger = logger;
            _userManager = userManager;

        }

        private int isExisting(int id){
            return -1;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }
    }
}
