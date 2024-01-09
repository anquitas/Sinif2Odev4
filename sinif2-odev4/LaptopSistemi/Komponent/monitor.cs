using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LaptopSistemi.Komponent
{
    internal class monitor
    {
        string boyut;
        string tip;


        private monitor (string boyut, string tip)
        {
            this.boyut = boyut;
            this.tip = tip;
        }

        public static monitor yarat (string boyut) => new monitor (boyut, "ips");

        

        static int sayiKisminiDonder(string girdi)
        {
            string sayiKismi = Regex.Match(girdi, @"\d+").Value;
            return Convert.ToInt32(sayiKismi);
        }

        public void basitBilgi() => Console.WriteLine($"ekran boyutu: {boyut}");

        public void ayrintiBilgi()
        {
            Console.WriteLine("MONİTOR:");
            Console.WriteLine($"boyut: {boyut}");
            Console.WriteLine($"tip: {tip}");
            Console.WriteLine("---------------------");
        }


    }  //  monitor sınıfı sonu
}  //  namespace sonu
