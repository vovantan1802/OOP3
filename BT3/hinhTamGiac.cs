using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    internal class hinhTamGiac:hinh
    {
        protected float canh1;
        protected float canh2;
        protected float canh3;
        public float p;

        public hinhTamGiac()
        {
            this.canh1 = 0;
            this.canh2 = 0;
            this.canh3 = 0;
        }

        public hinhTamGiac(float toaDoX, float toaDoY, string mauSac, float canh1, float canh2, float canh3):base(toaDoX, toaDoY, mauSac)
        {
            this.canh1 = canh1;
            this.canh2 = canh2;
            this.canh3 = canh3;
        }

        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("Nhập chiều dài cạnh thứ nhất: ");
            canh1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập chiều dài cạnh thứ hai: ");
            canh2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập chiều dài cạnh thứ ba: ");
            canh3 = float.Parse(Console.ReadLine());
        }

        public override float dienTich()
        {
            p = (canh1 + canh2 + canh3) / 2;
            return (float)(Math.Sqrt(p*(p-canh1)* (p - canh2)* (p - canh3)));
        }
    }
}
