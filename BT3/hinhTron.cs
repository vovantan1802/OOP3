using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    internal class hinhTron:hinh
    {
        protected float banKinh;

        public hinhTron()
        {
            this.banKinh = 0;
        }

        public hinhTron(float toaDoX, float toaDoY, string mauSac, float banKinh) : base(toaDoX, toaDoY, mauSac)
        {
            this.banKinh = banKinh;
        }

        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("Nhập bán kính hình tròn: ");
            banKinh = float.Parse(Console.ReadLine());
        }

        public override float dienTich()
        {
            return (float)(Math.PI * banKinh * banKinh);
        }
    }
}
