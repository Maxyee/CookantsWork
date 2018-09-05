using CookantsEntity;
using CookantsEntity.Model;
using CookantsEntity.ViewModel;
using CookantsService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoockantsWeb.Controllers
{
    public class ShoppingCartController : Controller
    {
        private CookAntsDbContext db = new CookAntsDbContext();
        // GET: CartController
        private readonly IMenuItemService _menuItemService;

        public ShoppingCartController(IMenuItemService menuItemService)
        {
            _menuItemService = menuItemService;
          
        }
        public ActionResult Cart()
        {
            //var menu = _menuScheduleService.GetMenuScheduleById((int)id);
            //return PartialView("_Details", menu);
            return PartialView("_Cart");
        }
        [HttpPost]
        public JsonResult Add(MenuSchedule mo)
        {
            MenuItem menuitem = _menuItemService.GetMenuItemById(mo.MenuItemId);

            bool status = false;
            if (Session["cart"] == null)
            {
                List<Cart> li = new List<Cart>
                {
                    new Cart(db.MenuItems.Find(mo.MenuItemId),mo)
                };
                Session["cart"] = li;
                Session["count"] = mo.Quantity; 
                Session["Amount"] = mo.Quantity * menuitem.CompanyPrice;
                status = true;
            }
            else
            {
                List<Cart> li = (List<Cart>)Session["cart"];
                int check = isExistingCheck(mo.MenuItemId);
                var qantityse = Convert.ToInt32(Session["count"]) + mo.Quantity;
                if (check == 0 && qantityse <= 5)
                {
                    li[check].Quantity += mo.Quantity;
                    status = true;
                    Session["count"] = li[check].Quantity;
                    Session["Amount"] = qantityse * menuitem.CompanyPrice;
                }
                else
                {
                    status = false;
                }
                Session["cart"] = li;
            }
            return Json(new
            {
                totalquantity = Session["count"],
                status = status
            });
        }
        public ActionResult Remove()
        {       
            try
            {
                if (Session["cart"] != null)
                {
                    Session.Remove("Cart");
                    Session.Remove("count");
                    var routeValues = HttpContext.Request.Url;

                    return RedirectToAction("Index", "Food", new { id = 13 });
                }
            }
            catch(Exception ex)
            {
                return RedirectToAction("Index", "Home", new { id = 13 });

            }
            return RedirectToAction("Index", "Food", new { id = 13 });
        }
        private int isExistingCheck(int? id)
        {
            List<Cart> ls = (List<Cart>)Session["cart"];
            for (int i = 0; i < ls.Count; i++)
            {
                if (ls[i].MenuItem.Id == id) return 0;
            
            }
            return -1;
        }
    }
}