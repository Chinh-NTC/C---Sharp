using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tên: Nguyễn Tấn Chinh
// MSV: 2415053122301
// Lớp:: 225LTC01
namespace BT_Generic_Bai2
{
    internal class Bai2
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<int> danhSachSo = new List<int>();

            Console.WriteLine("Bài 2:");
            // 1. Nhập các số nguyên (Ví dụ nhập 5 số từ bàn phím)
            Console.WriteLine("Nhập vào 5 số nguyên:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Nhập số thứ {i + 1}: ");
                int n = int.Parse(Console.ReadLine());
                danhSachSo.Add(n);
            }

            // 2. Tính tổng các số nguyên trong List
            int tg = danhSachSo.Sum();

            Console.WriteLine("Tổng các số nguyên trong List là: "+tg);

            Console.ReadKey();
        }
    }
}
