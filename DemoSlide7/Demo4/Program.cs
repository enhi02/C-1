using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4
{
    class Program
    {
        static void Main(string[] args)
        {
            string fpath = @"D:\Data.txt";
            StreamReader sr = new StreamReader(fpath);
            try
            {
                string txt;
                while((txt = sr.ReadLine()) != null)
                {
                    Console.WriteLine(txt);
                }
            }catch(Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
            Console.ReadLine();
        }
    }
}
