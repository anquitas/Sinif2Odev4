using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LaptopSistemi.Komponent
{
    internal class disk
    {
        //##  ALANLAR  ----------  ----------  ----------  ----------
        string tip;
        int okumaHizi;
        int yazmaHizi;



        //##  OLUŞTURUCULAR  ----------  ----------  ----------  ----------
        private disk(string tip, int okumaHizi, int yazmaHizi)
        {
            this.tip = tip;
            this.okumaHizi = okumaHizi;
            this.yazmaHizi = yazmaHizi;
        }



        //##  METODLAR  ----------  ----------  ----------  ----------
        public static disk yarat(string secim)
        {  //  sınıfa ait statik yaratıcı metod
            if (secim == "SSD")
                return new disk(secim, 350, 250);
            else
                return new disk(secim, 3500, 3000);
        }



        public void basitBilgi() => Console.WriteLine($"disk: {tip}");



        public void ayrintiBilgi()
        {
            Console.WriteLine("DİSK:");
            Console.WriteLine($"tip: {tip}");
            Console.WriteLine($"okuma hızı: {okumaHizi}");
            Console.WriteLine($"yazma hızı: {yazmaHizi}");
            Console.WriteLine("---------------------");
        }

    }  //  disk sınıfı sonu
}  //  namespace sonu
