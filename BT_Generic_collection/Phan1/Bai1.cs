using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Generic_Bai1
{
    internal class Bai1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // 1. Tạo List<int>
            List<int> danhSachSo = new List<int>();

            // 2. Thêm 5 số bất kỳ (Dùng hàm .Add)
            danhSachSo.Add(25);
            danhSachSo.Add(11);
            danhSachSo.Add(6);
            danhSachSo.Add(100);
            danhSachSo.Add(18);

            // 3. In các phần tử ra màn hình
            Console.WriteLine("Danh sách các số nguyên đã thêm là:");
            foreach (int n in danhSachSo)
            {
                Console.Write(n + " ");
            }

            Console.ReadKey();
        }
    }
}
