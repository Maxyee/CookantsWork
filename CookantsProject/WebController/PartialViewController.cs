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
    public class PartialViewController : Controller
    {
        private readonly IMenuItemService _menuItemService;
        private readonly IBusinessZoneService _businessZoneService;
        private readonly IMenuCategoryService _menuCategoryService;
        private readonly IBusinessAreaService _businessAreaService;
        private readonly IAboutUsService _aboutUsService;
        private readonly IAddressService _addressService;
        private readonly IMenuScheduleService _menuScheduleService;
        private readonly ISecurityUserService _securityUserService;
        private readonly ISliderService _sliderService;

        public PartialViewController(ISliderService sliderService,ISecurityUserService securityUserService,IMenuScheduleService menuScheduleService, IAddressService addressService, IAboutUsService aboutUsService, IMenuItemService menuItemService, IBusinessZoneService businessZoneService, IMenuCategoryService menuCategoryService, IBusinessAreaService businessAreaService)
        {
            _securityUserService = securityUserService;
            _menuItemService = menuItemService;
            _aboutUsService = aboutUsService;
            _businessZoneService = businessZoneService;
            _menuCategoryService = menuCategoryService;
            _businessAreaService = businessAreaService;
            _addressService = addressService;
            _menuScheduleService = menuScheduleService;
            _sliderService = sliderService;
        }
        // GET: PartialView
        [ChildActionOnly]
        public ActionResult Index()
        {
            var aboutUs = _aboutUsService.GetDetails(2);
            return PartialView(aboutUs);
        }
        [ChildActionOnly]
        public ActionResult BusinessArea()
        {
            var businessArea = _businessAreaService.GetAll();
            return PartialView(businessArea);
        }
        [ChildActionOnly]
        public ActionResult Slider()
        {
            var slider = _sliderService.GetAll();
            return PartialView(slider);
        }
        public ActionResult Sidebar()
        {
            if(Session["AddressId"] != null)
            {
                var id = Session["AddressId"];
                var menus = _securityUserService.GetAllCookWithPointAndBusinessZone((int)id);
                return PartialView(menus.ToList());
            }
            else
            {
               // SecurityUserWithPoint
                //Address addressId = _addressService.GetAddressById((int)Session["AddressId"]);
                var menus = _securityUserService.GetAllCookWithPointAndBusinessZone(1);
                return PartialView(menus.ToList());
            }
           
        }
    }
}
