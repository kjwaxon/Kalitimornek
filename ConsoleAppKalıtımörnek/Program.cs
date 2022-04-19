using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKalıtımörnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Samsung s = new Samsung();
            s.isim = "S21";
            s.isletimsistemi = "Android 12";
            s.hafızaalanı = 256;
            s.telefoninfo();


            Console.ReadKey();
        }
    }
}
