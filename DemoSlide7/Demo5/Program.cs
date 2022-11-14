using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5
{
    class Program
    {
        public static void showScore(float avg)
        {
            if (avg < 0)
            {
                throw (new MyException("Average score must be greater than 0"));
            }
            else
            {
                Console.WriteLine("Average score: {0}", avg);
            }
        }
        static void Main(string[] args)
        {
            try
            {
                //OK
                showScore(7.5F);
                //Exception
                showScore(-10.0F);
            }catch(MyException me)
            {
                Console.Write("{0}", me.Message);
            }
            Console.ReadLine();
        }
    }
}
