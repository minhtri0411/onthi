using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onthi
{
    class Program
    {
        static void Main(string[] args)
        {
            ChuPhien cp = new ChuPhienDauGia();
            //ChuPhien cg = new ChuPhienGiaoDich();

            KhachHang1 kh1 = new KhachHang1();
            KhachHang2 kh2 = new KhachHang2();

            cp.Attach(kh1);
            cp.Attach(kh2);

            Console.WriteLine("Nhap gia khoi diem : ");
            int giakhoidiem = int.Parse(Console.ReadLine());
            cp.SetGiaKhoiDiem(giakhoidiem);
            while (true)
            {
                for (int i = 0; i < cp.DanhSachKhachHang.Count; i++ )
                {
                    IKhachHang kh = cp.DanhSachKhachHang[i];

                    Console.WriteLine(kh.getTenKH());
                    int ragia = int.Parse(Console.ReadLine());
                    kh.raGia(ragia);

                    if (kh.getMoiDuaRa() == 0)
                    {
                        cp.Detach(kh);
                        i--;
                    }
                    else
                    {
                        cp.SetGiaHienTai(kh.getMoiDuaRa());
                    }
                    cp.Notify();
                }
            }
        }
    }
}
