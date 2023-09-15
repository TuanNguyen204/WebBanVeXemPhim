using BaiTapLonWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTapLonWeb.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        public ActionResult Index()
        {
            return View();

        }
        public ActionResult DangNhap()
        {
                return View();

        }

        [HttpPost]
        public ActionResult DangNhap(string username, string password)
        {
            MovieDataContext db = new MovieDataContext();
            int demTaiKhoan = db.KHACHHANGs.Count(k => k.TK.ToLower() == username.ToLower() && k.MK.ToLower() == password);
           
            if (demTaiKhoan==1)
            {
                Session["username"] = username;
                ViewBag.user = username;
                TempData["error"] = new KHACHHANG();
                if (username == "admin")
                {
                    return RedirectToAction("Index", "QuanLyMovie");
                }
                return RedirectToAction("DaDangNhap", "Admin");
            }
            else
            {
                TempData["error"] = "Tài khoản đăng nhập không đúng";
                return View();
            }
        }
        public ActionResult DangKy()
        {
            return View();
        }
        public ActionResult DaDangNhap()
        {
            if (Session["username"] == null)
                return RedirectToAction("Index");
            return View();
        }
        public ActionResult Thoat()
        {
            if(Session["username"] == null);
            return RedirectToAction("DangNhap");
        }

	}
}