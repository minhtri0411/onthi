using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 3;
            List<PC> list = new List<PC>();
            for (int j = 0; j < i; j++)
            {
                Console.WriteLine("Nhap ten may tinh: ");
                PC p = PC.CreatePC(Console.ReadLine());
                list.Add(p);
            }

            Console.WriteLine("***\nCac may tinh da nhap: ");
            for (int j = 0; j < i; j++)
            {
                Console.WriteLine(list[j].GetPCInfo());
            }
        }
    }
}
