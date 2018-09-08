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
    public class FaqController : Controller
    {
        private CookAntsDbContext db = new CookAntsDbContext();
        private readonly IMenuItemService _menuItemService;
        private readonly IBusinessZoneService _businessZoneService;
        private readonly IMenuCategoryService _menuCategoryService;
        private readonly ISecurityUserService _securityUserService;
        private readonly IFaqService _faqService;
        public FaqController(IFaqService faqService ,IMenuItemService menuItemService, IBusinessZoneService businessZoneService, IMenuCategoryService menuCategoryService, ISecurityUserService securityUserService)
        {
            _faqService = faqService;
            _menuItemService = menuItemService;
            _businessZoneService = businessZoneService;
            _menuCategoryService = menuCategoryService;
            _securityUserService = securityUserService;
        }
        // GET: Faq
        public ActionResult Index()
        {
            var menuitem = _faqService.GetAll();
            return View(menuitem);
        }

        // GET: Faq/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Faq faq = db.Faqs.Find(id);
            if (faq == null)
            {
                return HttpNotFound();
            }
            return View(faq);
        }

        // GET: Faq/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Faq/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Question,Answer,RoleId,CreateDate,UpdatedDate,IsActive")] Faq faq)
        {
            if (ModelState.IsValid)
            {
                db.Faqs.Add(faq);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(faq);
        }

        // GET: Faq/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Faq faq = db.Faqs.Find(id);
            if (faq == null)
            {
                return HttpNotFound();
            }
            return View(faq);
        }

        // POST: Faq/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Question,Answer,RoleId,CreateDate,UpdatedDate,IsActive")] Faq faq)
        {
            if (ModelState.IsValid)
            {
                db.Entry(faq).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(faq);
        }

        // GET: Faq/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Faq faq = db.Faqs.Find(id);
            if (faq == null)
            {
                return HttpNotFound();
            }
            return View(faq);
        }

        // POST: Faq/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Faq faq = db.Faqs.Find(id);
            db.Faqs.Remove(faq);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
