using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcProjeKampi.Controllers
{
    public class LoginController : Controller
    {
        Context context = new Context();
        AdminLoginManager adminloginmanager = new AdminLoginManager(new EfAdminDal());
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin admin)
        {

            //SHA1 sha1 = new SHA1CryptoServiceProvider();
            //string password = admin.AdminPassword;
            //string result = Convert.ToBase64String(sha1.ComputeHash(Encoding.UTF8.GetBytes(password)));
            //admin.AdminPassword = result;

            var adminuserinfo = adminloginmanager.GetAdmin(admin.AdminUserName, admin.AdminPassword);

            if (adminuserinfo != null)
            {
                FormsAuthentication.SetAuthCookie(adminuserinfo.AdminUserName, false);
                Session["AdminUserName"] = adminuserinfo.AdminUserName;
                return RedirectToAction("Index", "AdminCategory");
            }
            else
            {
                RedirectToAction("Index");
            }
            ViewBag.ErrorMessage = "Kullanıcı Adı veya Şifre Yanlış";
            return View();

        }
    }
}