using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onthi
{
    public class KhachHang2 : IKhachHang
    {
        private int giaCuaTui;

        public void update(ChuPhien cp)
        {
            Console.WriteLine("Khach hang 2: Gia hien tai la : " + cp.GiaHienTai);
            Console.WriteLine("Khach hang 2: Nguoi thang cuoc : " + cp.GetNguoiThangCuoc());
        }



        public void raGia(int gia)
        {
            this.giaCuaTui = gia;
        }


        public int getMoiDuaRa()
        {
            return this.giaCuaTui;
        }


        public string getTenKH()
        {
            return "Khach hang 2 ";
        }
    }

}
