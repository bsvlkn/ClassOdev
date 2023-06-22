using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ögrenci ö1 = new ögrenci();
            ö1.OgrenciAdi = "Tuna";
            ö1.OgrenciNumarasi = 23;
            ö1.DersNotu = 100;
            ö1.OgrenciBilgileri();
            Console.ReadLine();

            Kare1 k1 = new Kare1();
            k1.KenarUzunlugu = 50;
            k1.AlanHesapla();
            k1.CevreHesapla();
            Console.ReadLine();

            Dikdortgen d1 = new Dikdortgen();
            d1.Genislik = 50;
            d1.Uzunluk = 30;
            d1.AlanHesapla();
            d1.CevreHesapla();
            Console.ReadLine();

        }
    }
}
