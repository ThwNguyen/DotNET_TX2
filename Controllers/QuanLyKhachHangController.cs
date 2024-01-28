using OnTapASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnTapASP.Controllers
{
    public class QuanLyKhachHangController : Controller
    {
        List<KhachHang> danhsach = new List<KhachHang>();
        public QuanLyKhachHangController()
        { 
            KhachHang kh1 = new KhachHang("Kh01", "Khách hàng 1", "Hà Nội", "0977652", 1);
            KhachHang kh2 = new KhachHang("Kh02", "Khách hàng 2", "Quảng Ninh", "0947654", 20);
            KhachHang kh3 = new KhachHang("Kh03", "Khách hàng 3", "Hải Phòng", "0987653", 15);
            KhachHang kh4 = new KhachHang("Kh04", "Khách hàng 4", "Hà Nội", "0937655", 3);
            KhachHang kh5 = new KhachHang("Kh05", "Khách hàng 5", "Hải Phòng", "0927653", 5);
            danhsach.Add(kh1);
            danhsach.Add(kh2);
            danhsach.Add(kh3);
            danhsach.Add(kh4);
            danhsach.Add(kh5);
        }
        // GET: QuanLyKhachHang
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NhapDuLieuKhacHang()
        {
            string maKH = Request["maKH"];
            string hoTen = Request["hoTen"];
            string diaChi = Request["diaChi"];
            string dienThoai = Request["dienThoai"];
            int soLanMua = int.Parse(Request["soLanMua"]);
            KhachHang kh = new KhachHang(maKH, hoTen, diaChi, dienThoai, soLanMua);
            return View(kh);
        }
        public ActionResult HienThiDanhSach()
        {
            List<KhachHang> dsLanMua = new List<KhachHang>();
            List<KhachHang> dsDiaChi = new List<KhachHang>();
            foreach (var item in danhsach)
            {
                if(item.diaChi == "Hải Phòng")
                {
                    dsDiaChi.Add(item);
                }
                if(item.soLanMua >= 10)
                {
                    dsLanMua.Add(item);
                }
            }
            ViewBag.dsDC = dsDiaChi;
            ViewBag.dsLM = dsLanMua;
            return View();
        }
    }
}