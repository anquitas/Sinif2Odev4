using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LaptopSistemi.Komponent
{
    internal class islemci
    {
        //##  ALANLAR  ----------  ----------  ----------  ----------
        string tipi;
        double hizi;

        //##  NİTELİKLER  ----------  ----------  ----------  ----------
        string Tipi { get => tipi; }
        string Hizi { get => $"{hizi} ghz"; }

        //##  OLUŞTURUCULAR  ----------  ----------  ----------  ----------
        private islemci() { }

        private islemci(string tipi, double hizi)
        {
            this.tipi = tipi;
            this.hizi = hizi;
        }


        //##  METODLAR  ----------  ----------  ----------  ----------
        static public islemci yarat(string tipi) => new islemci(tipi, 4.2);
        //  sınıfa ait statik yaratıcı metod


        static string secimAl(string[] secenekler)
        {
            int secenekNumarasi = 1;
            foreach (string secenek in secenekler)
            {
                Console.WriteLine($"{secenekNumarasi} - {secenek}");
                secenekNumarasi++;
            }
            int secim = Convert.ToInt32(Console.ReadLine());
                return secenekler[secim - 1];
        }

        static int sayiKisminiDonder(string girdi)
        {
            string sayiKismi = Regex.Match(girdi, @"\d+").Value;
            return Convert.ToInt32(sayiKismi);
        }

        public void basitBilgi () => Console.WriteLine($"İşlemci: {Tipi}"); 

        public void ayrintiBilgi ()
        {
            Console.WriteLine("İŞLEMCİ:");
            Console.WriteLine($"tipi: {Tipi}");
            Console.WriteLine($"hızı: {Hizi}");
            Console.WriteLine("--------------------");
        }

    }  //  islemci sınıfı sonu
}  //  namespace sonu





