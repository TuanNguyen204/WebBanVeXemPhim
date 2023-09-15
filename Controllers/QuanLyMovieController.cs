using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BaiTapLonWeb.Models;

namespace BaiTapLonWeb.Controllers
{
    public class QuanLyMovieController : Controller
    {
        MovieDataContext db = new MovieDataContext();

        // GET: /QuanLyMovie/
        public ActionResult Index()
        {
            return View();
        }
        // Movie
        public ActionResult AllMovie()
        {
            var List = db.PHIMs.ToList();
            return PartialView(List);
        }
        public ActionResult DetailsMovie(int id)
        {
            
            PHIM movie = db.PHIMs.FirstOrDefault(p=>p.MAPHIM==id);            
            return View(movie);
        }

        
        public ActionResult CreateMovie()
        {
            //var maTL = from tl in db.THELOAIs select tl;
            ViewData["THELOAI"] = new SelectList(db.THELOAIs, "MATL", "TENTL");
            return View();
        }
        [HttpPost]
        public ActionResult CreateMovie(PHIM newPhim, FormCollection collection)
        {
            var maPhim = int.Parse(collection["MAPHIM"]);
            var tenPhim = collection["TENPHIM"];
            var maTL = collection["THELOAI"];
            var ddPhim = collection["DAODIEN"];
            var motaPhim = collection["MOTA"];
            var giaVe = float.Parse(collection["GIAVE"]);
            var hinhAnh = collection["HINHANH"];
            if(string.IsNullOrEmpty(maPhim.ToString()))
            {
                ViewData["Loi_1"] = "Mã phim không được để trống";
            }
            if (string.IsNullOrEmpty(tenPhim))
            {
                ViewData["Loi_2"] = "Tên phim không được để trống";
            }
            if (string.IsNullOrEmpty(ddPhim))
            {
                ViewData["Loi_3"] = "Tên đạo diễn không được để trống";
            }
            if (string.IsNullOrEmpty(motaPhim))
            {
                ViewData["Loi_4"] = "Mô tả không được để trống";
            }
            if (string.IsNullOrEmpty(giaVe.ToString()))
            {
                ViewData["Loi_5"] = "Gia vé không được để trống";
            }
            if (string.IsNullOrEmpty(hinhAnh))
            {
                ViewData["Loi_6"] = "Hình ảnh không được để trống";
            }
            else
            {
                newPhim.MAPHIM = maPhim;
                newPhim.TENPHIM = tenPhim;
                newPhim.MATL = maTL;
                newPhim.DAODIEN = ddPhim;
                newPhim.MOTA = motaPhim;
                newPhim.GIAVE = giaVe;
                newPhim.HINHANH = hinhAnh;
                db.PHIMs.InsertOnSubmit(newPhim);
                db.SubmitChanges();
                return RedirectToAction("AllMovie");
            }
            return this.CreateMovie();
        }       

        
        public ActionResult EditMovie(int id)
        {            
            PHIM movie = db.PHIMs.First(p => p.MAPHIM == id);
            ViewData["THELOAI"] = new SelectList(db.THELOAIs, "MATL", "TENTL");
            return View(movie);
        }
        [HttpPost]
        public ActionResult EditMovie(int id, FormCollection collection)
        {
            
            var tenPhim = collection["TENPHIM"];
            var maTL = collection["THELOAI"];
            var ddPhim = collection["DAODIEN"];
            var motaPhim = collection["MOTA"];
            var giaVe = float.Parse(collection["GIAVE"]);
            var hinhAnh = collection["HINHANH"];

            PHIM editPhim = db.PHIMs.First(p => p.MAPHIM == id);
            if (string.IsNullOrEmpty(tenPhim))
            {
                ViewData["Loi_1"] = "Tên phim không được để trống";
            }
            if (string.IsNullOrEmpty(ddPhim))
            {
                ViewData["Loi_2"] = "Tên đạo diễn không được để trống";
            }
            if (string.IsNullOrEmpty(motaPhim))
            {
                ViewData["Loi_3"] = "Mô tả không được để trống";
            }
            if (string.IsNullOrEmpty(giaVe.ToString()))
            {
                ViewData["Loi_4"] = "Gia vé không được để trống";
            }
            if (string.IsNullOrEmpty(hinhAnh))
            {
                ViewData["Loi_5"] = "Hình ảnh không được để trống";
            }
            else
            {
                editPhim.TENPHIM = tenPhim;
                editPhim.MATL = maTL;
                editPhim.DAODIEN = ddPhim;
                editPhim.MOTA = motaPhim;
                editPhim.GIAVE = giaVe;
                editPhim.HINHANH = hinhAnh;
                db.SubmitChanges();
                return RedirectToAction("AllMovie");
            }
            return this.EditMovie(id);
        }
        
        public ActionResult DeleteMovie(int id)
        {
            
            PHIM movie = db.PHIMs.FirstOrDefault(p => p.MAPHIM == id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        
        [HttpPost]
        
        public ActionResult DeleteMovie(int id, FormCollection collection)
        {
            PHIM delMovie = db.PHIMs.Where(p => p.MAPHIM == id).First();
            db.PHIMs.DeleteOnSubmit(delMovie);
            db.SubmitChanges();
            return RedirectToAction("AllMovie");
        }

        
        public ActionResult AllShowtime()
        {
            var List = db.SUATCHIEUs.ToList();
            return PartialView(List);
        }
        
        public ActionResult EditShowtime(int id)
        {
            ViewData["PHONG"] = new SelectList(db.PHONGs, "MAPHONG", "TENPHONG");
            ViewData["PHIM"] = new SelectList(db.PHIMs, "MAPHIM", "TENPHIM");
            SUATCHIEU suatchieu = db.SUATCHIEUs.First(s => s.MASUAT == id);
            return View(suatchieu);
        }
        [HttpPost]
        public ActionResult EditShowtime(int id, FormCollection collection)
        {
            var ngayChieu = DateTime.Parse(collection["NGAYCHIEU"]);
            var maPhong = int.Parse(collection["PHONG"]);
            var maPhim = int.Parse(collection["PHIM"]);
            SUATCHIEU editShow = db.SUATCHIEUs.Where(s => s.MASUAT == id).FirstOrDefault();

            if (string.IsNullOrEmpty(ngayChieu.ToString()))
            {
                ViewData["Loi"] = "Ngày chiếu không được để trống";
            }
            else
            {
                editShow.NGAYCHIEU = ngayChieu;
                editShow.MAPHONG = maPhong;
                editShow.MAPHIM = maPhim;
                UpdateModel(editShow);
                db.SubmitChanges();
                return RedirectToAction("AllShowtime");
            }
            return this.EditShowtime(id);
        }
        public ActionResult DeleteShowtime(int id)
        {
            SUATCHIEU movie = db.SUATCHIEUs.FirstOrDefault(p => p.MASUAT == id);
            
            return View(movie);
        }
        
        [HttpPost]
        public ActionResult DeleteShowtime(int id, FormCollection collection)
        {
            var delShow = db.SUATCHIEUs.Where(s => s.MASUAT == id).First();
            db.SUATCHIEUs.DeleteOnSubmit(delShow);
            db.SubmitChanges();
            return RedirectToAction("AllShowtime");
        }

        public ActionResult CreateShowtime()
        {
            ViewData["PHONG"] = new SelectList(db.PHONGs, "MAPHONG", "TENPHONG");
            ViewData["PHIM"] = new SelectList(db.PHIMs, "MAPHIM", "TENPHIM");
            return View();
        }
        [HttpPost]
        public ActionResult CreateShowtime(SUATCHIEU newSuat, FormCollection collection)
        {
            var maSuat = int.Parse(collection["MASUAT"]);
            var ngayChieu = DateTime.Parse(collection["NGAYCHIEU"]);
            var maPhong = int.Parse(collection["PHONG"]);
            var maPhim = int.Parse(collection["PHIM"]);

            if (string.IsNullOrEmpty(maSuat.ToString()))
            {
                ViewData["Loi_1"] = "Mã suất chiếu không được để trống";
            }    
            if (string.IsNullOrEmpty(ngayChieu.ToString()))
            {
                ViewData["Loi_2"] = "Ngày chiếu không được để trống";
            }           
            else
            {
                newSuat.MASUAT = maSuat;
                newSuat.NGAYCHIEU = ngayChieu;
                newSuat.MAPHONG = maPhong;
                newSuat.MAPHIM = maPhim;
                db.SUATCHIEUs.InsertOnSubmit(newSuat);
                db.SubmitChanges();
                return RedirectToAction("AllShowtime");
            }
            return this.CreateShowtime();
        }

    }
}
