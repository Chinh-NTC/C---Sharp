using System;
using System.Text;

namespace BaiTap
{
    class Bai7
    {
        public static void run()
        {
            Console.WriteLine("Bai 7");
            Console.Write("Nhập họ và tên: ");
            string hoTen = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(hoTen))
                Console.WriteLine("Lỗi.Chuỗi null hoặc rỗng, không thể thực hiện tách!");
            else
            {
                string[] mangKetQua = hoTen.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (mangKetQua == null || mangKetQua.Length == 0)
                    Console.WriteLine("Lỗi.Mảng kết quả rỗng, không có từ nào để in.");
                else
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine($"Tìm thấy {mangKetQua.Length} từ trong chuỗi:");

                    foreach (string tu in mangKetQua)
                        Console.WriteLine(tu);
                    Console.WriteLine("---------------------------------");
                }
            }

            Console.ReadKey();
        }
    }
}