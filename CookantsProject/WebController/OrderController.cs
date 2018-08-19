using CookantsEntity;
using CookantsEntity.Model;
using CookantsService.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using System.Net;
using System.Configuration;
using CookantsEntity.ViewModel;

namespace CoockantsWeb.Controllers
{
    public class OrderController : Controller
    {
        private CookAntsDbContext db = new CookAntsDbContext();
        private readonly IMenuItemService _menuItemService;
        private readonly IBusinessZoneService _businessZoneService;
        private readonly IMenuCategoryService _menuCategoryService;
        private readonly ISecurityUserService _securityUserService;
        private readonly IMenuScheduleService _menuScheduleService;
        private readonly IOrderService _orderService;


        public OrderController(IOrderService orderService, IMenuScheduleService menuScheduleService, IMenuItemService menuItemService, IBusinessZoneService businessZoneService, IMenuCategoryService menuCategoryService, ISecurityUserService securityUserService)
        {
            _menuItemService = menuItemService;
            _menuScheduleService = menuScheduleService;
            _businessZoneService = businessZoneService;
            _menuCategoryService = menuCategoryService;
            _securityUserService = securityUserService;
            _orderService = orderService;
        }
        public ActionResult Invoice(int? id)
        {
            InvoiceView invoice = _orderService.GetOrderByOrderId((int)id);
            return View(invoice);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult OrderInsert(FormCollection fc)
        {
            if (fc.Get("Quantity") != null && fc.Get("MenuItemId") != null)
            {
                SecurityUser user = _securityUserService.GetUserByUserName(User.Identity.Name);
                MenuItem menuItem = _menuItemService.GetMenuItemById(Convert.ToInt32(fc.Get("MenuItemId")));
                SecurityUser cook = _securityUserService.GetUserById(menuItem.CookId);
                int menusheduleId = Convert.ToInt32(fc.Get("MenuSheduleId")); 
                Order order = new Order();
                List<OrderItem> orderItems = new List<OrderItem>();
                OrderItem orderItem = new OrderItem();            
                order.AddressId = Convert.ToInt32(Session["CustomerAddressId"]);
                order.BusinessZoneId = user.BusinessZoneId;
                order.CustomerId = user.Id;
                order.DelivereyStatus = "Pending";
                order.DeliveryBoyId = cook.DeliveryBoyId;
                order.Phone = user.Phone;
                var pr = menuItem.CompanyPrice;
                var q = Convert.ToInt32(fc.Get("Quantity"));
                var subtotal = q * pr ;
                orderItem.OrderId = 0;
                orderItem.MenuItemId = menuItem.Id;
                orderItem.Quantity = Convert.ToInt32(fc.Get("Quantity"));
                orderItem.Price = subtotal;
                orderItems.Add(orderItem);
                order.OrderItems = orderItems;
                _orderService.OrderInsert(order, menusheduleId);
                Session.Remove("Cart");
                Session["orderId"] = order.Id;
                return RedirectToAction("Invoice", "Order", new { id = order.Id });

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }

    }
}