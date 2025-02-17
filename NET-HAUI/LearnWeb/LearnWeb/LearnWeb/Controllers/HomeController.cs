using LearnWeb.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;


namespace LearnWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        QLSinhVienEntities db = new QLSinhVienEntities();
        public ActionResult Index()
        {
            List<SinhVien> ls = db.SinhViens.ToList();
            ViewBag.ds = ls;
            return View();
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(SinhVien model, HttpPostedFileBase image)
        {
            // excute upload file
            if (image != null)
            {
                string PathRoot = Path.Combine(Server.MapPath("/Data/"), image.FileName);
                image.SaveAs(PathRoot);
                model.Url = image.FileName;
            }
            else
            {
                model.Url = string.Empty;
            }
           
            db.SinhViens.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");


        }

        public ActionResult Edit(int id)
        {
            var sv = db.SinhViens.Find(id);
            return View(sv);
        }
        [HttpPost]
        public ActionResult Edit( SinhVien model, HttpPostedFileBase image)
        {
            SinhVien sv = db.SinhViens.Find(model.Id);
            sv.Address = model.Address;
            sv.Name = model.Name;
            sv.Gender = model.Gender;
            if (image != null)
            {
                string PathRoot = Path.Combine(Server.MapPath("/Data/"), image.FileName);
                image.SaveAs(PathRoot);
                sv.Url = image.FileName;
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var sv = db.SinhViens.Find(id);
            db.SinhViens.Remove(sv);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult Detail(int id)
        {
            var detail = db.ChiTiets.Find(id);
            if (detail == null)
            {
                detail = new ChiTiet();
                detail.Details = "none";
                detail.Id = id;
            }
            return View(detail);
        }
        
      

    }
}