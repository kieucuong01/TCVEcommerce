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
    public class WishController : Controller
    {
        private readonly AppDBContext _dbContext;
        private readonly ILogger<WishController> _logger;
        private readonly UserManager<AppUser> _userManager;

        public WishController(AppDBContext dbContext,
    ILogger<WishController> logger,
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
    }
}
