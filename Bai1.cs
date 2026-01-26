using System;
using System.Text;

namespace BaiTap
{
    class Bai1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập họ và tên: ");
            string ten = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(ten))
            {
                Console.WriteLine("Lỗi. Bạn chưa nhập tên!!!");
                Console.ReadKey();
                return;
            }

            ten = ten.Trim();
            string[] dsTu = ten.Split(' ');
            string kq = "";

            for (int i = 0; i < dsTu.Length; i++)
            {
                string tu = dsTu[i];

                if (!string.IsNullOrEmpty(tu))
                {
                    tu = tu.ToLower();

                    char kyTuDau = char.ToUpper(tu[0]);
                    string kyTuConLai = tu.Substring(1);

                    string ketQua = kyTuDau + kyTuConLai;

                    kq += ketQua + " ";
                }
            }

            kq = kq.Trim();

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Tên sau khi chuẩn hóa: " + kq);
            Console.ReadKey();
        }
    }
}