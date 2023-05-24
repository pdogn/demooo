using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ttt
{
    internal class Program
    {
        static List<studentt> list = new List<studentt>();
        static void Main(string[] args)
        {
            list.Add(new studentt("a",13,"aa",3,4));
            list.Add(new studentt("d", 15, "sdf", 4, 4));
            list.Add(new studentt("f", 11, "sdv", 6, 33));
            list.Add(new studentt("c", 10, "gtd", 4, 6));
            list.Add(new studentt("b", 4, "tgg", 1, 12));
            int chon;
            do
            {
                
                Console.WriteLine("1. them sv");
                Console.WriteLine("2. hien thi dssv");
                Console.WriteLine("3. xoa sv");
                Console.WriteLine("4. sua sv");
                Console.WriteLine("5. sap xep ");
                Console.WriteLine("6. sap xep toan ");
                Console.WriteLine("7. sap xep dia chi ");
                Console.WriteLine("8. tim sv theo tuoi ");
                Console.WriteLine("9. exits!");
                Console.WriteLine("Nhap lua chon: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        themSV();
                        break;
                    case 2:
                        xuatSV();
                        break;
                    case 3:
                        xoa();
                        break;
                    case 4:
                        sua();
                        break;
                    case 5:
                        sapxepT();
                        break;
                    case 6:
                        sortT();
                        break;
                    case 7:
                        sortadr();
                        break;
                    case 8:
                        timT();
                        break;
                }
                if (chon == 9)
                {
                    break;
                }
            }while(true);
        }
        static void themSV()
        {
            studentt st = new studentt();
            st.nhap();
            int d = 0;
            foreach(studentt t in list)
            {
                if (t.Name.Equals(st.Name))
                {
                    d++;
                }
            }
            if(d == 0)
            {
                list.Add(st);
                Console.WriteLine("THEM THANH CONG");
            }
            else
            {
                Console.WriteLine("ten bi trung! KHONG THE THEM\n");
            }
        }

        static void xuatSV()
        {
            foreach(studentt t in list)
            {
                Console.WriteLine(t);
            }
        }

        static void xoa()
        {
            Console.WriteLine("Nhap ten sv can xoa: ");
            string nn = Console.ReadLine();

            int d = 0,dd=0;
            foreach (studentt t in list)
            {
                if (t.Name.Equals(nn))
                {
                    d++;
                    dd=list.IndexOf(t);
                }
            }
            if (d == 0)
            {
                Console.WriteLine("Khong ton taiii sv nay.");

            }
            else
            {
                list.RemoveAt(dd);
                Console.WriteLine("XOA THANH CONG");
                Console.WriteLine("ds sau khi xoa: ");
                xuatSV();
            }
        }
        static void sua()
        {
            Console.WriteLine("Nhap ten sv can sua: ");
            string nm=Console.ReadLine();

            int d = 0;
            foreach(studentt t in list)
            {
                if (t.Name.Equals(nm))
                {
                    d++;
                    Console.WriteLine("ten moi: ");
                    t.Name=Console.ReadLine();
                    Console.WriteLine("tuoi moi: ");
                    t.age = int.Parse(Console.ReadLine());
                    Console.WriteLine("diachi moi: ");
                    t.address = Console.ReadLine();
                    Console.WriteLine("toan moi: ");
                    t.toan = float.Parse(Console.ReadLine());
                    Console.WriteLine("ly moi: ");
                    t.ly = float.Parse(Console.ReadLine());
                }
            }
            if(d == 0)
            {
                Console.WriteLine("Khong tim thay sv can sua");
            }
        }
        static void sapxepT()
        {
            list.Sort();
        }

        static void sortT()
        {
            list.Sort(delegate (studentt s1, studentt s2)
            {
                return s1.toan.CompareTo(s2.toan);
            });

            Console.WriteLine("sap xep theo diem toan: ");
            xuatSV();
        }

        static void sortadr()
        {
            list.Sort(delegate(studentt s1, studentt s2)
            {
                return (s1.address.CompareTo(s2.address));
            });
            Console.WriteLine("sap xep theo dia chi: ");
            xuatSV();
        }
        static void timT()
        {
            Console.WriteLine("nhap tuoi sv can tim: ");
            int tt = int.Parse(Console.ReadLine());
            int d = 0;
            foreach(studentt s in list)
            {
                if (s.age.Equals(tt))
                {
                    d++;
                    Console.WriteLine(s);
                }
            }
            if (d == 0)
            {
                Console.WriteLine("Tuoi khong dung!");
            }
        }
    }
}
