using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TCVShared.Data;
using Microsoft.AspNetCore.Identity;
using TCVShared.Helpers;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TCVWeb.Controllers
{
    public class CheckoutController : Controller
    {
        private const string PromoCode = "FREE";

        private readonly AppDBContext _dbContext;
        private readonly ILogger<CartController> _logger;
        private readonly UserManager<AppUser> _userManager;

        public CheckoutController(AppDBContext dbContext,
                                ILogger<CartController> logger,
                                UserManager<AppUser> userManager
                                 )
        {
            _dbContext = dbContext;
            _logger = logger;
            _userManager = userManager;
        }

        // GET: /Checkout/
        public IActionResult Index(ShopCart model)
        {
            model = HttpContext.Session.GetObjectFromJson<ShopCart>("Cart");

            return View(model);
        }

        // GET : /Checkout/ApplyShippingFee
        public void ApplyShippingFee(string province, string district, string street) {
            var cart = HttpContext.Session.GetObjectFromJson<ShopCart>("Cart");
            if (province == "HCM"){
                if (district == "1" || district == "2"){
                    cart.ShippingFee = 0.0;
                }
                else {
                    cart.ShippingFee = 30000;
                }
            }
            HttpContext.Session.SetObjectAsJson("Cart", cart);

        }
        ////
        //// GET: /Checkout/
        //public IActionResult AddressAndPayment()
        //{
        //    return View();
        //}

        ////
        //// POST: /Checkout/AddressAndPayment

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> AddressAndPayment(
        //    [FromForm] Order order,
        //    CancellationToken requestAborted)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(order);
        //    }

        //    var formCollection = await HttpContext.Request.ReadFormAsync();

        //    try
        //    {
        //        if (string.Equals(formCollection["PromoCode"].FirstOrDefault(), PromoCode,
        //            StringComparison.OrdinalIgnoreCase) == false)
        //        {
        //            return View(order);
        //        }
        //        else
        //        {
        //            order.Username = HttpContext.User.Identity.Name;
        //            order.OrderDate = DateTime.Now;

        //            //Add the Order
        //            _dbContext.ShopOrders.Add(order);

        //            //Process the order
        //            var cart = ShoppingCart.GetCart(dbContext, HttpContext);
        //            await cart.CreateOrder(order);

        //            _logger.LogInformation("User {userName} started checkout of {orderId}.", order.Username, order.OrderId);

        //            // Save all changes
        //            await dbContext.SaveChangesAsync(requestAborted);

        //            return RedirectToAction("Complete", new { id = order.OrderId });
        //        }
        //    }
        //    catch
        //    {
        //        //Invalid - redisplay with errors
        //        return View(order);
        //    }
        //}

        ////
        //// GET: /Checkout/Complete

        //public async Task<IActionResult> Complete(int id)
        //{
        //    var userName = HttpContext.User.Identity.Name;

        //    // Validate customer owns this order
        //    bool isValid = await _dbContext.Orders.AnyAsync(
        //        o => o.OrderId == id &&
        //        o.Username == userName);

        //    if (isValid)
        //    {
        //        _logger.LogInformation("User {userName} completed checkout on order {orderId}.", userName, id);
        //        return View(id);
        //    }
        //    else
        //    {
        //        _logger.LogError(
        //            "User {userName} tried to checkout with an order ({orderId}) that doesn't belong to them.",
        //            userName,
        //            id);
        //        return View("Error");
        //    }
        //}
    }

}
