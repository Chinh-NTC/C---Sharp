using System;
using System.Text;

namespace BaiTapGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int[] mangInt = { 10, 5, 8, 20 };
            Console.WriteLine("--- Mảng số nguyên ---");
            MyGenericClass<int>.Display(mangInt);

            string[] mangString = { "Đà Nẵng", "Hà Nội", "Sài Gòn" };
            Console.WriteLine("\n--- Mảng chuỗi ---");
            MyGenericClass<string>.Display(mangString);

            Student[] mangSV = {
                new Student("An", 20),
                new Student("Bình", 19)
            };
            Console.WriteLine("\n--- Mảng Sinh Viên ---");
            MyGenericClass<Student>.Display(mangSV);

            Console.ReadKey();
        }
    }
}