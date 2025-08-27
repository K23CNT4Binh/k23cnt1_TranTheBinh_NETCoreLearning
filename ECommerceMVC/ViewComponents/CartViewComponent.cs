using ECommerceMVC.Helpers;
using ECommerceMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ECommerceMVC.ViewComponents
{
    public class CartViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<CartItem> cartItemList = HttpContext.Session.Get<List<CartItem>>(MySetting.CART_KEY)
                                          ?? new List<CartItem>();

            var model = new CartModel
            {
                Quantity = cartItemList.Sum(p => p.SoLuong),
                Total = cartItemList.Sum(p => p.ThanhTien)
            };

            return View("CartPanel", model);
        }
    }
}