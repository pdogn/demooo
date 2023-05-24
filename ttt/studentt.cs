using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ttt
{
    internal class studentt:pperson, IComparable
    {
        public float toan { get; set; }
        public float ly { get; set; }
        public studentt()
        {

        }
        public studentt(string name, int age, string address, float toan, float ly)
        {
            Name = name;
            this.age = age;
            this.address = address;
            this.toan = toan;
            this.ly = ly;
        }
        public void nhap()
        {
            base.nhap();
            Console.WriteLine("Diem toan: ");
            toan=float.Parse(Console.ReadLine());
            Console.WriteLine("Diem Ly: ");
            ly=float.Parse(Console.ReadLine());
        }

        public void xuat()
        {
            base.xuat();
            Console.WriteLine(" toan: "+toan+" ly: "+ly);
        }

        public override string ToString()
        {
            return "ten: " + Name + " tuoi: " + age + " diaChi: " + address + " toan: " + toan + " Ly: " + ly;
        }

        public int CompareTo(object obj)
        {
            studentt other = (studentt)obj; 
            return ly.CompareTo( other.ly);
        }

        
    }
}
