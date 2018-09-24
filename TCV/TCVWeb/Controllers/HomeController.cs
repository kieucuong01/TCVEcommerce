using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TCVShared.Data;
using TCVShared.Helpers;
using TCVWeb.Models;

namespace TCVWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDBContext _dbContext;
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<AppUser> _userManager;

        public HomeController(AppDBContext dbContext,
            ILogger<HomeController> logger,
            UserManager<AppUser> userManager)
        {
            _dbContext = dbContext;
            _logger = logger;
            _userManager = userManager;
        }

        // GET: FeatureProduct 
        public IActionResult Index(PagedList<ShopItem> model)
        {
            var filterQuery = _dbContext.ShopItems.Where(x => model.Search == null);
            var selectQuery = filterQuery.OrderByDescending(x => x.Id).Skip((model.CurPage - 1) * model.PageSize).Take(model.PageSize);

            model.TotalRows = filterQuery.Count();
            model.Content = selectQuery.ToList();

            ViewData["categories"] = new String[] { "Hạt", "Rau củ", "Cây giống", "Trái Cây"  };

            var supplier = new Supplier();
            supplier.Name = "Kinh Do";
            supplier.Address = "https://i.doanhnhansaigon.vn/2015/07/16/mondelez-kinh-o-doanhnhans-1508412719.jpg";

            var supplier1 = new Supplier();
            supplier1.Name = "Kinh Do";
            supplier1.Address = "http://tonghoinn.vn/vnt_upload/news/07_2017/341111.jpg";

            var supplier2 = new Supplier();
            supplier2.Name = "Kinh Do";
            supplier2.Address = "http://snnptnt.binhthuan.gov.vn/wps/wcm/connect/a9cf2c0040d3c4bba3e5e30556390f18/logoKhuyennong-Khuyenngu.jpg?MOD=AJPERES&CACHEID=a9cf2c0040d3c4bba3e5e30556390f18";

            var supplier3 = new Supplier();
            supplier3.Name = "Kinh Do";
            supplier3.Address = "http://logodep.vn/wp-content/uploads/2017/01/thiet-ke-logo-cong-ty-hoi-nhap-_1292835984.jpg";

            var supplier4 = new Supplier();
            supplier4.Name = "Kinh Do";
            supplier4.Address = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSstGYeLddZ4B5W6AKFFq-GUBFyobEcvrnBTht5TD7IQ0-kPdqn";


            ViewData["brands"] = new Supplier[] { supplier, supplier1, supplier2, supplier3, supplier4, supplier, supplier3, supplier4 };

            return View(model);
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Help()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
