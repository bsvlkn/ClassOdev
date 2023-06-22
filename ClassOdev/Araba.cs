using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOdev
{
    public class Araba
    {
        public string Renk;
        public string Yakit;
        public int KapiSayisi;

    }
    public class Sedan : Araba
    {
        public int KoltukSayis;
        public void ArabaTanitim()
        {
            Console.WriteLine("Arabanın rengi: " + Renk);
            Console.WriteLine("Arabanın yakıtı: " + Yakit);
            Console.WriteLine("Arabanın kapı sayısı: " + KapiSayisi);
            Console.WriteLine("Arabanın koltuk sayısı "+ KoltukSayis);
        }
       
    }
    public class SporAraba : Araba
    {
        public string Modifiye;
        public void ArabaTanitim()
        {
            Console.WriteLine("Arabanın rengi: " + Renk);
            Console.WriteLine("Arabanın yakıtı: " + Yakit);
            Console.WriteLine("Arabanın kapı sayısı: " + KapiSayisi);
            Console.WriteLine("Arabadaki modifiye: " + Modifiye);
        }
    }

    

}
