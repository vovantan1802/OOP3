using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    abstract class hinh
    {
        private float toaDoX;
        private float toaDoY;
        private string mauSac;

        public float ToaDoX { get => toaDoX; set => toaDoX = value; }
        public float ToaDoY { get => toaDoY; set => toaDoY = value; }
        public string MauSac { get => mauSac; set => mauSac = value; }

        public hinh()
        {
            this.ToaDoX = 0;
            this.ToaDoY = 0;
            this.MauSac = "";
        }

        public hinh(float toaDoX, float toaDoY, string mauSac)
        {
            this.ToaDoX = toaDoX;
            this.ToaDoY = toaDoY;
            this.MauSac = mauSac;
        }

        public virtual void nhap()
        {
            Console.WriteLine("Nhập tọa độ tâm X của hình: ");
            ToaDoX = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập tọa độ tâm Y của hình: ");
            ToaDoY = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập màu sắc của hình: ");
            MauSac = Console.ReadLine();
        }

        public abstract float dienTich();
    }
}
