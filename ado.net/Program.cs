using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ado.net
{
    
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ENVNconnector connector = new ENVNconnector();
                List<string> dsTenChuyenDe = connector.getListTenChuDe();
                Console.WriteLine("\nDanh sach chuyen de : \n");
                foreach (string s in dsTenChuyenDe)
                {
                    Console.WriteLine(s);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("\n\nCo loi, xem lai chuong trinh, SQL server bat len chua?");
            }
        }
    }
}
