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
    public class CateringServiceController : Controller
    {

        private readonly ICaterService _caterService;
        private readonly IAboutUsService _aboutUsService;
        public CateringServiceController(IAboutUsService aboutUsService, ICaterService caterService)
        {
            _caterService = caterService;
            _aboutUsService = aboutUsService;
        }
        // GET: CateringService/Create
        public ActionResult Index()
        {
            return View();
        }

        // POST: CateringService/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "Id,Name,Email,Phone,Quantity,Budget,CreateDate,IsAgree")] Cater cater)
        {
            if (ModelState.IsValid)
            {
                _caterService.Insert(cater);              
                return RedirectToAction("Index");
            }
            return View(cater);
        }

      
    }
}
