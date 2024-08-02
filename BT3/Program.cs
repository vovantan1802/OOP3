using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DSHinh list = new DSHinh();
            hinhCN hcn = new hinhCN();
            hinhTron ht = new hinhTron();
            hinhTamGiac hta = new hinhTamGiac();
            int chon = 0;
            string cnt = "";

            do
            {
                Console.WriteLine("Hình muốn nhập (1, 2, 3)_(hình CN, hình tròn, hình tam giác)");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        hcn.nhap();
                        list.nhap(hcn);
                        break;
                    case 2:
                        ht.nhap();
                        list.nhap(ht);
                        break;
                    case 3:
                        hta.nhap();
                        list.nhap(hta);
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Bạn có muốn tiếp tục nhập không?(Y/N)");
                cnt = Console.ReadLine();
            } while (cnt == "Y");

            list.hienThi();
            Console.ReadKey();
        }
    }
}
