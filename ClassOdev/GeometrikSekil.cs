using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOdev
{
    public class GeometrikSekil
    {
        
    }
    public class Dikdörtgen:GeometrikSekil
    {
        public int Uzunluk;
        public int Genislik;
        public void AlanHesapla()
        {
            Console.WriteLine("Dikdörtgen alan: " + Uzunluk*Genislik);
        }

    }
    public class Kare:GeometrikSekil
    {
        public int KenarUzunlugu;
        public void AlanHesapla()
        {
            Console.WriteLine("Karenin alanı: " + KenarUzunlugu*KenarUzunlugu);
        }

    }
}
