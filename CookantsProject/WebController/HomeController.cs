using CookantsEntity;
using CookantsEntity.Model;
using CookantsEntity.ViewModel;
using CookantsService;
using CookantsService.Services;
using Facebook;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace CoockantsWeb.Controllers
{
    public class HomeController : Controller
    {
        private CookAntsDbContext db = new CookAntsDbContext();
        private readonly ISecurityUserService _securityUserService;
        private readonly ISubZoneService _subZoneServices;
        private readonly IMenuItemService _menuItemService;


        public HomeController( IMenuItemService menuItemService, ISecurityUserService securityUserService , ISubZoneService subZoneServices)
        {
            _menuItemService = menuItemService;       
            _securityUserService = securityUserService;         
            _subZoneServices = subZoneServices;          
        }  
        // GET: Index
        public ActionResult Index()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }

        }
  
        public ActionResult HomeChefProfile(int? id)
        {
            
            try
            {
                SecurityUser securityuser = _securityUserService.GetCookById((int)id);
                if (securityuser == null)
                {
                    return RedirectToAction("Index", "Home");
                }
                ViewBag.Address = securityuser.BusinessZones.BusinessAreas.Name;
                var menus = _menuItemService.GetMenuSchedulByUserId(securityuser.Id);
                return View(menus);
            }
            catch(Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public JsonResult GetAllSubZone()
        {
            return Json(db.SubZones.ToList(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetAllBusinessZone()
        {
            return Json(db.BusinessZones.ToList(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetSubZoneByBusinessAreaId(string BusinessAreaId)
        {
            int Id = Convert.ToInt32(BusinessAreaId);
            var BusinessZone = _subZoneServices.GetAllByAreaId(Id);
            return Json(BusinessZone);
        }




    }
}
