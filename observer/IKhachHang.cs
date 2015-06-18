using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onthi
{
    public interface IKhachHang
    {
        void update(ChuPhien cp);
        void raGia(int gia);
        int getMoiDuaRa();
        string getTenKH();
    }

}
