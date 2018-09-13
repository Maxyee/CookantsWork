using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CookantsEntity;
using CookantsEntity.Model;
using CookantsService.Services;

namespace CoockantsWeb.Controllers
{
    public class FoodController : Controller
    {
        private CookAntsDbContext db = new CookAntsDbContext();
        private readonly IMenuItemService _menuItemService;
        private readonly IBusinessZoneService _businessZoneService;
        private readonly IMenuCategoryService _menuCategoryService;
        private readonly ISecurityUserService _securityUserService;
        private readonly IMenuScheduleService _menuScheduleService;
        private readonly IOrderService _orderService;
        private readonly IAddressService _addressService;
        private readonly ISubZoneService _subZoneService;
        private readonly IBusinessAreaService _businessAreaService;

        public FoodController(IBusinessAreaService businessAreaService,ISubZoneService subZoneService,IAddressService addressService,IOrderService orderService, IMenuScheduleService menuScheduleService, IMenuItemService menuItemService, IBusinessZoneService businessZoneService, IMenuCategoryService menuCategoryService, ISecurityUserService securityUserService)
        {
            _businessAreaService = businessAreaService;
            _menuItemService = menuItemService;
            _subZoneService = subZoneService;
            _menuScheduleService = menuScheduleService;
            _businessZoneService = businessZoneService;
            _menuCategoryService = menuCategoryService;
            _securityUserService = securityUserService;
            _orderService = orderService;
            _addressService = addressService;
        }
        public ActionResult Index(int? id)
        {
            try
            {
                if(id == null && User.Identity.Name != null)
                {
                    var businessZone = _subZoneService.GetSubZoneById(1);
                    ViewBag.Address = businessZone;
                    var menus = _menuItemService.GetMenuShedule((int)businessZone.BusinessZoneId).ToList();
                    return View(menus);

                }
                else if(id == null && User.Identity.Name==null)
                {
                    var businessZone = _subZoneService.GetSubZoneById((int)1);
                    ViewBag.Address = businessZone;
                    var menus = _menuItemService.GetMenuShedule((int)businessZone.BusinessZoneId).ToList();
                    return View(menus);

                }
                else
                {
                    var businessZone = _subZoneService.GetSubZoneById((int)id);
                    ViewBag.Address = businessZone;
                    var menus = _menuItemService.GetMenuShedule((int)businessZone.BusinessZoneId).ToList();
                    return View(menus);
                }
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public ActionResult Details(int? id)
        {
            var menu = _menuScheduleService.GetMenuScheduleById((int)id);
            return PartialView("_Details", menu);

        }
        public ActionResult Order(FormCollection fc)
        {
            if (System.Web.HttpContext.Current.User.Identity.IsAuthenticated)
            {
                var menu = _menuItemService.GetMenuItemById(Convert.ToInt32(fc.Get("MenuItems.Id")));
                Session["Image"] = menu.RootUrl;
                Session["ItemName"] = menu.Name;
                Session["ItemId"] = Convert.ToInt32(fc.Get("MenuItems.Id"));
                Session["Quantity"] = Convert.ToInt32(fc.Get("Quantity"));
                Session["Subtotal"] = menu.CompanyPrice * Convert.ToInt32(fc.Get("Quantity"));

                return RedirectToAction("OrderList", "Account");
            }
            else
            {
                return RedirectToAction("Login", "Account");

            }
        }
        [HttpPost]
        public ActionResult GetOrderInfo(FormCollection fc)
        {
            if(fc.Get("Quantity") !=null && fc.Get("Quantity") != null && Session["ItemId"]!=null)
            {
                var email = User.Identity.Name;
                SecurityUser user = _securityUserService.GetUserByUserName(email);
                MenuItem menuItem = _menuItemService.GetMenuItemById(Convert.ToInt32(Session["ItemId"]));
                SecurityUser cook = _securityUserService.GetUserById(menuItem.CookId);
                Order order = new Order();
                List<OrderItem> orderItems = new List<OrderItem>();
                OrderItem orderItem = new OrderItem();
                order.AddressId = Convert.ToInt32(fc.Get("address"));
                order.BusinessZoneId = user.BusinessZoneId;
                order.CustomerId = user.Id;
                order.DelivereyStatus = "Pending";
                order.DeliveryBoyId = cook.DeliveryBoyId;
                order.Phone = user.Phone;
                order.DelivereyDate = DateTime.Today;


                orderItem.OrderId = 0;
                orderItem.MenuItemId = menuItem.Id;
                orderItem.Quantity = Convert.ToInt32(fc.Get("Quantity"));
                orderItem.Price = Convert.ToInt32(Session["Subtotal"]);
                orderItems.Add(orderItem);
                order.OrderItems = orderItems;
               // _orderService.OrderInsert(order);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("MyOrderList", "Account");
        }

    }
}
