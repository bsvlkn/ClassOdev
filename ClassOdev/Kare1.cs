using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOdev
{
    public class Kare1
    {
        public int KenarUzunlugu;
        public void AlanHesapla()
        {
            Console.WriteLine("karenin Alanı = " + KenarUzunlugu * KenarUzunlugu);
        }
        public void CevreHesapla()
        {
            Console.WriteLine("Karenin çevresi = " + KenarUzunlugu * 4);
        }
    }
}
