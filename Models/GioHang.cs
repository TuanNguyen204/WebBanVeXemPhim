using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaiTapLonWeb.Models;


namespace BaiTapLonWeb.Models
{
    public class GioHang
    {
        MovieDataContext db = new MovieDataContext();
        public int MaPhim { get; set; }
        public string TenPhim { get; set; }
        public string AnhBia { get; set; }
        public double Gia { get; set; }
        public int SoLuong { get; set; }
        public double ThanhTien
        {
            get { return SoLuong * Gia; }
        }
        public GioHang (int maphim)
        {
            MaPhim = maphim;
            PHIM phim = db.PHIMs.Single(n => n.MAPHIM == MaPhim);
            TenPhim = phim.TENPHIM;
            AnhBia = phim.HINHANH;
            Gia = double.Parse(phim.GIAVE.ToString());
            SoLuong = 1;

        }
    }
}