using System;
using System.Text;

namespace BaiTap
{
    class Bai3
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập chuỗi cần kiểm tra: ");
            string input = Console.ReadLine();

            if (input == null)
            {
                Console.WriteLine("Kết luận: Chuỗi không đối xứng (Do bị null)");
                Console.ReadKey();
                return;
            }
            string chuoiSach = input.Replace(" ", "").ToLower();

            bool laDoiXung = true; 
            int n = chuoiSach.Length;

            for (int i = 0; i < n / 2; i++)
            {
                char dau = chuoiSach[i];
                char cuoi = chuoiSach[n - 1 - i];

                if (dau != cuoi)
                {
                    laDoiXung = false; 
                    break; 
                }
            }
            Console.WriteLine("--------------------------");
            if (laDoiXung == true)
                Console.WriteLine("KẾT QUẢ: Đây LÀ chuỗi đối xứng!");
            else
                Console.WriteLine("KẾT QUẢ: Đây KHÔNG PHẢI chuỗi đối xứng.");

            Console.ReadKey();
        }
    }
}