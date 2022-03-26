using geometrijskoTijelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometrijskoTijelo
{
    internal class GeoTijelo
    {
        double Volumen, Oplosje;
        public static int brojac = 0;

        public GeoTijelo()
        {
            brojac++;
        }
    }

    class Kugla : GeoTijelo
    {
    }

    class Kvadar : GeoTijelo
    {
    }

    class Kocka : Kvadar
    {
    }
}