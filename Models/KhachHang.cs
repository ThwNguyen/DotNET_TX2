using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnTapASP.Models
{
    public class KhachHang
    {
        public string maKH { get; set; }
        public string hoTen { get; set; }  
        public string diaChi {  get; set; }
        public string dienThoai {  get; set; }
        public int soLanMua { get; set; }
        public string khuyenMai
        { 
            get 
            { 
                if(soLanMua >= 10)
                {
                    return "Khách hàng thân thiết";
                }
                return "";
            }
        }
        public KhachHang() { }
        public KhachHang(string maKH, string hoTen, string diaChi, string dienThoai, int soLanMua)
        {
            this.maKH = maKH;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.dienThoai = dienThoai;
            this.soLanMua = soLanMua;
        }
    }
}