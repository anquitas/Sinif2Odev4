using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;  //regex

namespace LaptopSistemi.Komponent
{
    internal class ram
    {
        //##  ALANLAR  ----------  ----------  ----------  ----------
        int hafiza;
        int veriYoluHizi;

        //##  NİTELİKLER  ----------  ----------  ----------  ----------
        public string Hafiza { get => $"{hafiza} gb"; }
        public string VeriYoluHizi { get => $"{veriYoluHizi} ghz"; }


        //##  OLUŞTURUCULAR  ----------  ----------  ----------  ----------
        private ram () { }

        private ram (int hafiza, int veriYoluHizi) { 
            this.hafiza = hafiza; 
            this.veriYoluHizi = veriYoluHizi;
        }

        //##  METODLAR  ----------  ----------  ----------  ----------
        static public ram yarat (int hafiza)
        {  //  sınıfa ait statik yaratıcı fonksiyon
            return new ram (hafiza, 3200);
        } 


        public void basitBilgi() => Console.WriteLine($"hafıza: {Hafiza}");

        public void ayrintiBilgi()
        {
            Console.WriteLine("RAM:");
            Console.WriteLine($"hafıza: {Hafiza}");
            Console.WriteLine($"hızı: {VeriYoluHizi}");
            Console.WriteLine("---------------------");
        }
    }  //  ram sınıfı sonu
}  // namespace sonu





