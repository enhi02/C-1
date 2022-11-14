using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET1Slide3B
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khai báo một mảng 3 phần tử.
            // Mỗi phần tử là một mảng khác.
            string[][] teams = new string[3][];

            string[] ds1 = { "Teo", "Gai" };
            string[] ds2 = { "Ti", "Cu", "Bi" };
            string[] ds3 = { "Vy", "Kien", "An", "Minh" };
            // mang cua mang
            teams[0] = ds1;
            teams[1] = ds2;
            teams[2] = ds3;

            // Sử dụng vòng lặp for để in ra các phần tử của mảng.
            for (int row = 0; row < teams.Length; row++)
            {
                for (int col = 0; col < teams[row].Length; col++)
                {
                    Console.WriteLine("Element at [{0}],[{1}] = {2}", row, col, teams[row][col]);
                }
                Console.WriteLine("-------------");
            }
            Console.ReadLine();
        }
    }
}
