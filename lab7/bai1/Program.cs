using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class PrintHelper
    {
        public delegate void BeforPrint(int x);

        public event BeforPrint BeforPrintEvent;

        public PrintHelper()
        {

        }

        public void PrintNumber(int num)
        {
            if (BeforPrintEvent != null)
            {
                BeforPrintEvent(num);
            }

            Console.WriteLine("Num: {0,-12:N0}", num);

        }

        public void PrintDecimal(int dec)
        {
            if (BeforPrintEvent != null)
            {
                BeforPrintEvent(dec);
            }

            Console.WriteLine("Decimal: {0:G}", dec);

        }

        public void PrintMoney(int money)
        {
            if (BeforPrintEvent == null)
            {
                BeforPrintEvent(money);
            }


            Console.WriteLine("Money: {0:C", money);
        }

        public void PrintTemperature(int num)
        {
            if (BeforPrintEvent == null)
            {
                BeforPrintEvent(num);
            }

            Console.WriteLine("Temperature: {0,4:N1}", num);

        }

        public void PrintHecxadecimal(int dec)
        {
            if (BeforPrintEvent == null)
            {
                BeforPrintEvent(dec);
            }

            Console.WriteLine("Hecxadecimal: {0:X}", dec);
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap so bat ky: ");
            n = int.Parse(Console.ReadLine());

            PrintHelper hp = new PrintHelper();

            hp.BeforPrintEvent += new BeforPrint(hp.PrintHecxadecimal);
            hp.BeforPrintEvent += new BeforPrint(hp.PrintDecimal);
            hp.BeforPrintEvent += new BeforPrint(hp.PrintMoney);
            hp.BeforPrintEvent += new BeforPrint(hp.PrintNumber);
            hp.BeforPrintEvent += new BeforPrint(hp.PrintTemperature);
            hp.BeforPrintEvent(n);

            Console.ReadKey();
        }
    }
}
