using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    public class DSNhanVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh;
        public string DiaChi { get; set; }
        public string PhongBan { get; set; }
        public string Hinh;
        public string GioiTinh;
        public string SoDT;
        public string Mail;
        public DSNhanVien()
        { }
        public DSNhanVien(string maso, string hoten, DateTime ngaysinh, string dchi, string phongBan, string gt, string sdt, string mail)
        {
            this.MaSo = maso;
            this.HoTen = hoten;
            this.NgaySinh = ngaysinh;
            this.DiaChi = dchi;
            this.PhongBan = phongBan;
            this.GioiTinh = gt;
            this.SoDT = sdt;
            this.Mail = mail;
        }
        public override string ToString()
        {
            string s = "Mã số:" + MaSo + "\n" + "Họ tên:" + HoTen + "\n"
                + "Ngày sinh:" + NgaySinh.ToString() + "\n"
                +"Địa chỉ:"+DiaChi+"\n"
                +"Phòng ban"+ PhongBan+"\n"
                + "Giới tính:" + GioiTinh + "\n"
                + "Số DT:" + SoDT + "\n"
                + "Mail:" + Mail + "\n";
            return s;

        }
    }
}
