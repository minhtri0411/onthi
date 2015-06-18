using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace onthi
{
   public class ChuPhien
    {
       public int GiaHienTai { get; set; }
       public int SoKhachHangConLai { get; set; }
       public List<IKhachHang> DanhSachKhachHang { get; set; }
       private String NguoiThangCuoc;

       public ChuPhien()
       {
           DanhSachKhachHang = new List<IKhachHang>();
       }
       public void Notify()
       {
           Console.WriteLine("So khach hang con lai : " + this.SoKhachHangConLai);
           if (SoKhachHangConLai == 1)
           {
               this.NguoiThangCuoc = DanhSachKhachHang[0].getTenKH();
               Console.WriteLine("Nguoi thang cuoc la : " + this.NguoiThangCuoc);
           }

           foreach (IKhachHang kh in DanhSachKhachHang)
           {
               kh.update(this);
           }
       }
       
       public String GetNguoiThangCuoc()
       {
           return this.NguoiThangCuoc;
       }
       public void Attach(IKhachHang kh)
       {
           this.DanhSachKhachHang.Add(kh);
           this.SoKhachHangConLai++;
       }
       public void Detach(IKhachHang kh)
       {
           this.DanhSachKhachHang.Remove(kh);
           this.SoKhachHangConLai--;
       }

       public void SetGiaKhoiDiem(int gia)
       {
           this.GiaHienTai = gia;
           Console.WriteLine("Gia khoi diem : " + this.GiaHienTai);
       }
       public void SetGiaHienTai(int gia)
       {
           this.GiaHienTai = gia;
           Console.WriteLine("Gia hien tai : " + this.GiaHienTai);
       }

    }
}
