using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    internal class hinhCN:hinh
    {
        protected float chieuDai;
        protected float chieuRong;

        public hinhCN()
        {
            this.chieuDai = 0;
            this.chieuRong = 0;
        }

        public hinhCN(float toaDoX, float toaDoY, string mauSac, float chieuDai, float chieuRong):base(toaDoX, toaDoY, mauSac)
        {
            this.chieuDai = chieuDai;
            this.chieuRong = chieuRong;
        }

        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("Nhập chiều dài HCN: ");
            chieuDai = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập chiều rộng HCN: ");
            chieuRong = float.Parse(Console.ReadLine());
        }

        public override float dienTich()
        {
            return chieuDai * chieuRong;
        }
    }
}
