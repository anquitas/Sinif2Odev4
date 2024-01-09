using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LaptopSistemi.Komponent
{
    internal class ekranKarti
    {
        //##  ALANLAR  ----------  ----------  ----------  ----------
        bool paylasimliMi = false;
        int bellek = 8;



        //##  NİTELİKLER  ----------  ----------  ----------  ----------
        public string PaylasimliMi { get => paylasimliMi ? "paylaşımlı" : "paylaşımsız"; }
        public string Bellek { get => $"{bellek} gb"; }



        //##  OLUŞTURUCULAR  ----------  ----------  ----------  ----------
        private ekranKarti(bool paylasimliMi) => this.paylasimliMi = paylasimliMi;



        //##  METODLAR  ----------  ----------  ----------  ----------
        public static ekranKarti yarat(bool paylasimliMi) => new ekranKarti(paylasimliMi);
        //  sınıfa ait statik yaratıcı metod

        public void basitBilgi() => Console.WriteLine($"paylaşımlı mı: {PaylasimliMi}");

        public void ayrintiBilgi()
        {
            Console.WriteLine("EKRAN KARTI:");
            Console.WriteLine($"paylaşımlı mı: {PaylasimliMi}");
            Console.WriteLine($"bellek: {Bellek}");
            Console.WriteLine("---------------------");
        }


    }  //ekranKarti sınıfı sonu
}  //  namespace sonu


//##  ALANLAR  ----------  ----------  ----------  ----------
//##  NİTELİKLER  ----------  ----------  ----------  ----------
//##  OLUŞTURUCULAR  ----------  ----------  ----------  ----------
//##  METODLAR  ----------  ----------  ----------  ----------


