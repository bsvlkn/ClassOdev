using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOdev
{
    class ögrenci
    {
        public string OgrenciAdi;
        public int OgrenciNumarasi;
        public double DersNotu;

        public void OgrenciBilgileri()
        {
            Console.WriteLine("Öğrenci adı: " + OgrenciAdi + ' ' + "Öğrenci numarası: " + OgrenciNumarasi);



        }
        public void DersNotunuGuncelle()
        {
            Console.WriteLine("Ders Notu:" + DersNotu);
        }

    }
}
