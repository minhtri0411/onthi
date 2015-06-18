using ado.net.connected;
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
            // LẤY DỮ LIỆU THEO CÁCH CONNECTED
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("GET DATA BY CONNECTED MODEL");
                Console.ForegroundColor = ConsoleColor.White;
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

            // LẤY DỮ LIỆU THEO CÁCH DISCONNECTED

            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("GET DATA BY DISCONNECTED MODEL");
                Console.ForegroundColor = ConsoleColor.White;
                disconnected.ENVNDisconnectedConnector cntor = new disconnected.ENVNDisconnectedConnector();
                List<string> dsTCD = cntor.getListTenChuDe();
                Console.WriteLine("\nDanh sach chuyen de : \n");
                foreach (string s in dsTCD)
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
