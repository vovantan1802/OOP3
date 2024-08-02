using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BT3
{
    internal class DSHinh
    {
        protected ArrayList listCN;
        protected ArrayList listTron;
        protected ArrayList listTamGiac;
        public float toaDoX;
        public float toaDoY;
        public string mauSac;
        public float dienTich;

        public DSHinh()
        {
            listCN = new ArrayList();
            listTron = new ArrayList();
            listTamGiac = new ArrayList();
        }

        public void nhap(hinhCN cn)
        {
            listCN.Add(cn);
        }
        public void nhap(hinhTron ht)
        {
            listTron.Add(ht);
        }
        public void nhap(hinhTamGiac ta)
        {
            listTamGiac.Add(ta);
        }

        public void hienThi()
        {
            toaDoX = 0;
            toaDoY = 0;
            mauSac = "";
            dienTich = 0;
            Console.WriteLine("Hình chữ nhật-------------------------------------");
            foreach(hinhCN h in listCN)
            {
                Console.WriteLine("Tọa độ tâm của hình: ({0}, {1})", h.ToaDoX, h.ToaDoY);
                Console.WriteLine("Màu sắc của hình: {0}",h.MauSac);
                Console.WriteLine("Diện tích của hình: {0}", h.dienTich());
                if (h.dienTich() > dienTich)
                {
                    toaDoX = h.ToaDoX;
                    toaDoY = h.ToaDoY;
                    mauSac = h.MauSac;
                    dienTich = h.dienTich();
                }
            }
            Console.WriteLine("Hình có diện tích lớn nhất là:");
            Console.WriteLine("Tọa độ tâm: ({0}, {1})", toaDoX, toaDoY);
            Console.WriteLine("Màu sắc: {0}", mauSac);
            Console.WriteLine("Diện tích: {0}", dienTich);
          

            toaDoX = 0;
            toaDoY = 0;
            mauSac = "";
            dienTich = 0;
            Console.WriteLine("Hình tròn-------------------------------------");
            foreach (hinhTron h in listTron)
            {
                Console.WriteLine("Tọa độ tâm của hình: ({0}, {1})", h.ToaDoX, h.ToaDoY);
                Console.WriteLine("Màu sắc của hình: {0}", h.MauSac);
                Console.WriteLine("Diện tích của hình: {0}", h.dienTich());
                if (h.dienTich() > dienTich)
                {
                    toaDoX = h.ToaDoX;
                    toaDoY = h.ToaDoY;
                    mauSac = h.MauSac;
                    dienTich = h.dienTich();
                }
            }
            Console.WriteLine("Hình có diện tích lớn nhất là:");
            Console.WriteLine("Tọa độ tâm: ({0}, {1})", toaDoX, toaDoY);
            Console.WriteLine("Màu sắc: {0}", mauSac);
            Console.WriteLine("Diện tích: {0}", dienTich);


            toaDoX = 0;
            toaDoY = 0;
            mauSac = "";
            dienTich = 0;
            Console.WriteLine("Hình tam giác-------------------------------------");
            foreach (hinhTamGiac h in listTamGiac)
            {
                Console.WriteLine("Tọa độ tâm của hình: ({0}, {1})", h.ToaDoX, h.ToaDoY);
                Console.WriteLine("Màu sắc của hình: {0}", h.MauSac);
                Console.WriteLine("Diện tích của hình: {0}", h.dienTich());
                if (h.dienTich() > dienTich)
                {
                    toaDoX = h.ToaDoX;
                    toaDoY = h.ToaDoY;
                    mauSac = h.MauSac;
                    dienTich = h.dienTich();
                }
            }
            Console.WriteLine("Hình có diện tích lớn nhất là:");
            Console.WriteLine("Tọa độ tâm: ({0}, {1})", toaDoX, toaDoY);
            Console.WriteLine("Màu sắc: {0}", mauSac);
            Console.WriteLine("Diện tích: {0}", dienTich);
        }
    }
}
