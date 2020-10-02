using System;

namespace Hệ_các_đối_tượng_hình_học
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap chieu dai: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ban kinh: ");
            double c = double.Parse(Console.ReadLine());
            Rectangle hcn = new Rectangle(a, b);
            Circle ht = new Circle(c);
            Console.WriteLine("Chu vi hinh chu nhat: {0}", Math.Round(hcn.Perimeter()));
            Console.WriteLine("Dien tich hinh chu nhat: {0}", Math.Round(hcn.Area()));
            Console.WriteLine("Chu vi hinh tron: {0}", Math.Round(ht.Perimeter()));
            Console.WriteLine("Dien tich hinh tron: {0}", Math.Round(ht.Area()));
        }
    }
}