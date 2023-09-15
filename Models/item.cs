//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace BaiTapLonWeb.Models
//{
//    public class item
//    {
//        MovieDataContext db = new MovieDataContext();
//        public int MaDD { get; set; }
//        public string TenDD { get; set; }
//        public string AnhDD { get; set; }
//        public double GiaBan { get; set; }
//        public int SoLuongMua { get; set; }
//        public item(int mdd, int sl)
//        {
//            MaDD = mdd;
//            PHIM ph = db.PHIMs.FirstOrDefault(p => p.MAPHIM == mdd);
//            TenDD = ph.TENPHIM;
//            AnhDD = ph.HINHANH;
//            GiaBan = Convert.ToDouble(ph.GIAVE.ToString());
//            SoLuongMua = sl;
//        }
//        public double ThanhTien
//        {
//            get { return SoLuongMua * GiaBan; }
//        }
//    }
//}