using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    class student
    {
        private string studentID { get; set; }
        private string name { get; set; }
        private int age { get; set; }
        private string gender { get; set; }
        private string city { get; set; }

        public void output()
        {
            Console.WriteLine($"{this.studentID}\t{this.name}\t{this.age}\t{this.gender}\t{city}");
        }

        public void input()
        {
            Console.Write("Nhap ID SV: ");
            this.studentID = Console.ReadLine();
            Console.Write("nhap ten Sv: ");
            name = Console.ReadLine();
            if(name.Length<6 || name.Length > 40)
            {
                while(name.Length < 6|| name.Length > 40)
                {
                    Console.WriteLine("---ten tu 6=>40 ky tu---");
                    Console.Write("nhap ten SV");
                    name = Console.ReadLine();
                }
            }
            else
            {
                this.name = name;
            }
            Console.Write("Nhap tuoi SV: ");
            age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                while (age < 18)
                {
                    Console.WriteLine("---------Nhap tuoi lon hon 18----------");
                    Console.Write("Nhao tuoi SV: ");
                    age = Convert.ToInt32(Console.ReadLine());

                }
            }
            else
            {
                this.age = age;
            }
            Console.Write("Gioi Tinh: ");
            gender = Console.ReadLine();
            if (gender == "nam" || gender == "Nam" || gender == "nu" || gender == "Nu")
            {
                this.gender = gender;
            }
            else
            {
                while(gender == "nam" || gender == "Nam" || gender == "nu" || gender == "Nu")
                {
                    Console.WriteLine("---------GIOI TINH NAM OR NU----------");
                    Console.Write("Gioi TInh");
                    gender = Console.ReadLine();
                }
            }
            Console.Write("THANH PHO: ");
            city = Console.ReadLine();
            if(city.Length < 4 || city.Length > 40)
            {
                while(city.Length <4 || city.Length > 40)
                {
                    Console.WriteLine("----Ten TP tu 4 ==> 40 ky tu-------");
                    Console.Write("thanh pho: ");
                    city = Console.ReadLine();
                }
            }
            else
            {
                this.city = city;
            }
        }
    }
}
