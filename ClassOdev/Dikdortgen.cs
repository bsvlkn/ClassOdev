using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOdev
{
    public class Dikdortgen
    {
        public int Uzunluk;
        public int Genislik;

        public void AlanHesapla()
        {
            Console.WriteLine("Dikdörtgenin alanı:" + Uzunluk * Genislik);
        }
        public void CevreHesapla()
        {
            Console.WriteLine("Dikdörtgen çevresi:" + 2 * (Uzunluk + Genislik));
        }
    }
}
}
