using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tên: Nguyễn Tấn Chinh
// MSV: 2415053122301
// Lớp:: 225LTC01
namespace BT_Generic_Bai15
{
    internal class Bai15
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Dictionary<string, string> tuDien = new Dictionary<string, string>();
            tuDien.Add("hello", "xin chào");
            tuDien.Add("student", "sinh viên");
            tuDien.Add("computer", "máy tính");
            tuDien.Add("language", "ngôn ngữ");
            tuDien.Add("success", "thành công");

            Console.Write("Nhập từ tiếng Anh muốn tra nghĩa: ");
            string tuCanTra = Console.ReadLine().ToLower().Trim();

            if (tuDien.ContainsKey(tuCanTra))
            {
                string nghiaTiengViet = tuDien[tuCanTra];
                Console.WriteLine($"==> Nghĩa của '{tuCanTra}' là: {nghiaTiengViet}");
            }
            else
                Console.WriteLine("==> Rất tiếc, từ này chưa có trong từ điển!");

            Console.ReadKey();
        }
    }
}
