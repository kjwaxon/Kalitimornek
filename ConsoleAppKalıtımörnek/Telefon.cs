using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKalıtımörnek
{
    public class Telefon
    {
        public string isim;
        public string isletimsistemi;
        public int hafızaalanı;

        public void telefoninfo()
        {
            Console.WriteLine("Telefonun ismi : "+isim);
            Console.WriteLine("Telefonun işletim sistemi : " + isletimsistemi);
            Console.WriteLine("Telefonun hafıza alanı : {0} gb",hafızaalanı);
        }
    }
}
