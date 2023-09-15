using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaiTapLonWeb.Models;

namespace BaiTapLonWeb.Controllers
{
    public class HomeController : Controller
    {
        MovieDataContext db = new MovieDataContext();
        public ActionResult Index(string searchString)
        {            
            var danhmuc = db.PHIMs.Select(p=>p);
            return View(danhmuc);

        }
        public ActionResult AllMovie()
        {
            var danhmuc = from p in db.PHIMs select p;
            return View(danhmuc);
        }
            
        public ActionResult MovieDetail(int id)
        {
            var chitiet = db.PHIMs.First(p=>p.MAPHIM==id);
            
            return View(chitiet);
        }
        public ActionResult AllShowtime()
        {
            var suatchieu = from s in db.SUATCHIEUs select s;
            return View(suatchieu);
        }
        
        public ActionResult TimKiem (string search)
        {
            var model = db.PHIMs.Where(n=>n.TENPHIM.Contains(search)).ToList();
            return View(model);
        }
        
        public List<GioHang> Laygiohang()
        {
            List<GioHang> lstGioHang = Session["Giohang"] as List<GioHang>;
            if(lstGioHang==null)
            {
                lstGioHang = new List<GioHang>();
                Session["Giohang"] = lstGioHang;
            }
            return lstGioHang;
        }
        public ActionResult ThemGiohang (int maphim , string strURL)
        {
            List<GioHang> lstGiohang = Laygiohang();
            GioHang phim = lstGiohang.Find(n => n.MaPhim == maphim);
            if(phim==null)
            {
                phim = new GioHang(maphim);
                lstGiohang.Add(phim);
                return Redirect(strURL);
            }
            else
            {
                phim.SoLuong++;
                return Redirect(strURL);
            }
         }
        private int TongSoLuong()
        {
            int tongsoluong = 0;
            List<GioHang> lstGiohang = Session["Giohang"] as List<GioHang>;
            if(lstGiohang!=null)
            {
                tongsoluong = lstGiohang.Sum(n => n.SoLuong);
            }
            return tongsoluong;
        }
        private double TongTien()
        {
            double tongtien = 0;
            List<GioHang> lstGiohang = Session["Giohang"] as List<GioHang>;
            if (lstGiohang != null)
            {
                tongtien = lstGiohang.Sum(n => n.ThanhTien);
            }
            return tongtien;
        }
        public ActionResult GioHang()
        {
            List<GioHang> lstGiohang = Laygiohang();
            if(lstGiohang.Count==0)
            {
                return RedirectToAction("Index", "Home");
            }
            ViewBag.tongsoluong = TongSoLuong();
            ViewBag.tongtien = TongTien();
            return View(lstGiohang);
        }
        public ActionResult XoaGioHang(int MaSp)
        {
            List<GioHang> lstGiohang = Laygiohang();
            GioHang phim = lstGiohang.SingleOrDefault(n => n.MaPhim == MaSp);
            if(phim !=null)
            {
                lstGiohang.RemoveAll(n => n.MaPhim == MaSp);
                return RedirectToAction("GioHang");
            }
            if(lstGiohang.Count==0)
            {
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("GioHang");
        }
        public ActionResult XoaTatCa()
        {
            List<GioHang> lstGiohang = Laygiohang();
            lstGiohang.Clear();
            return RedirectToAction("Index", "Home");
        }

    }
}