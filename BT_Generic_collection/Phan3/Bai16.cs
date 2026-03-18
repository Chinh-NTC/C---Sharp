using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tên: Nguyễn Tấn Chinh
// MSV: 2415053122301
// Lớp:: 225LTC01
namespace BT_Generic_Bai16
{
    internal class Bai16
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập vào một chuỗi: ");
            string input = Console.ReadLine();

            Dictionary<char, int> countDict = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (c == ' ') continue;

                if (countDict.ContainsKey(c))
                    countDict[c]++;
                else
                    countDict.Add(c, 1);
            }

            Console.WriteLine("\nKết quả đếm:");
            foreach (KeyValuePair<char, int> entry in countDict)
            {
                Console.WriteLine($"{entry.Key} : {entry.Value}");
            }

            Console.ReadKey();
        }
    }
}
