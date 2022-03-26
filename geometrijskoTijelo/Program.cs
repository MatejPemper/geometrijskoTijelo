using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometrijskoTijelo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GeoTijelo.brojac);
            Kugla x = new Kugla();
            Console.WriteLine(GeoTijelo.brojac);
            Kvadar y = new Kvadar();
            Console.WriteLine(GeoTijelo.brojac);
            Kocka z = new Kocka();
            Console.WriteLine(GeoTijelo.brojac);


            Console.ReadKey();

        }
    }
}
