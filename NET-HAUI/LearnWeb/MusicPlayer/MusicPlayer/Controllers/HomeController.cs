using MusicPlayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace MusicPlayer.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Login(MusicPlayer.Models.Login model)
        {
            MuSicEntities db = new MuSicEntities();
            MusicPlayer.Models.Login login = db.Logins.Find(model.Username);
            while(login != null && model.Password == login.Password)
            {
                
            }
            return RedirectToAction("Index");
        }

    }
}