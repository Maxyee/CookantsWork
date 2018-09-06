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
    public class TermsConditionController : Controller
    {
        private readonly ITermsService _termsAndCondition;
        public TermsConditionController(ITermsService termsAndCondition)
        {

            _termsAndCondition = termsAndCondition;
        }
        // GET: About Us
        public ActionResult Index()
        {
            var terms = _termsAndCondition.GetAll();
            return View(terms);
        }
    }
}
