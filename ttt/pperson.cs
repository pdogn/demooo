using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ttt
{
    internal class pperson
    {
        public string Name { get; set; }
        public int age { get; set; }
        public string address { get; set; }

        public void nhap()
        {
            Console.WriteLine("Nhap ten: ");
            Name = Console.ReadLine();
            Console.WriteLine("nhap tuoi: ");
            age=int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap dia chi: ");
            address=Console.ReadLine();
        }

        public void xuat()
        {
            Console.Write("Ten: "+Name+" tuoi: "+age+" diaChi: "+address);
        }

    }
}
