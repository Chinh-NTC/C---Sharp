using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Generic_Bai11
{
    class Student
    {
        public int Id;
        public string Name;

        public Student(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }

    internal class Bai11
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<Student> dsSinhVien = new List<Student>();
            Student sv1 = new Student(11222, "Nguyễn Văn An");
            dsSinhVien.Add(sv1);

            dsSinhVien.Add(new Student(22211, "Trần Thị Bình"));
            dsSinhVien.Add(new Student(32233, "Lê Văn Cường"));

            Console.WriteLine("----- DANH SÁCH SINH VIÊN -----");
            Console.WriteLine("{0,-10} {1,-20}", "Mã SV", "Họ tên");

            foreach (Student sv in dsSinhVien)
            {
                Console.WriteLine("{0,-10} {1,-20}", sv.Id, sv.Name);
            }

            Console.ReadKey();
        }
    }
}
