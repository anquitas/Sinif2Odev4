using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using KonsolUygulama;
using LaptopSistemi;

namespace sinif2_odev4
{
    
    internal class Program
    {

        static KonsolUygulamasi uygulama = KonsolUygulamasi.yarat();
        static List<laptop> laptoplar = new List<laptop>();
        static void Main(string[] args)
        {
            _init_();
            uygulama.basla();
        }
        
        
        public static void _init_ () {  //  genel init fonksiyonu tanımı
            menu Temp;
            //  giriş menüsü
            Temp = menu.yarat(
                "laptop alım sistemi",
                new string[] { "laptop ekle", "laptoplar", "ram ekle" },
                menu0_komutlar
            );
            uygulama.menuEkle(Temp);
        }

        public static void menu0_komutlar(int secimNumarasi)
        {  //  menu0 için menu sistemine özel callback fonksiyonu tanımı 
            
            switch (secimNumarasi)
            {
                case 1:
                    laptopOlustur();
                    laptoplar[laptoplar.Count - 1].bilgi();
                    break;
                case 2:
                    laptoplariGoruntule();
                    string secim = Console.ReadLine();
                    int secim_int = Convert.ToInt32( secim );
                    laptoplar[secim_int-1].bilgi();
                    Console.WriteLine( "ayrıntılı bilgiyi görüntülemek istermisiniz(e/h)" );
                    if (Console.ReadLine() == "e")
                    {
                        Console.Clear();
                        laptoplar[secim_int-1].ayrintiliBilgi();
                    }
                    break;
                case 3:
                    laptoplariGoruntule();
                    string secim2 = Console.ReadLine();
                    int secim2_int = Convert.ToInt32(secim2);
                    laptoplar[secim2_int-1].ramTakviye();
                    break;
                case 4:
                    
                    break;
            }
            Console.ReadKey();
        }
        

        static void laptopOlustur ()
        {  //  laptoplar arasından seçim yaparak laptopları oluşturur ve laptop listesine ekler
            Console.Clear();
            Console.WriteLine("");
            string marka = secimAl(new string[] {"dell", "asus", "lenovo", "sony"});
            laptop temp;
            switch (marka)
            {
                case "dell":
                    temp = new dell();
                    temp.yarat();
                    laptoplar.Add(temp);
                    break;
                case "asus":
                    temp = new dell();
                    temp.yarat();
                    laptoplar.Add(temp);
                    break;
                case "lenovo":
                    temp = new dell();
                    temp.yarat();
                    laptoplar.Add(temp);
                    break;
                case "sony":
                    temp = new dell();
                    temp.yarat();
                    laptoplar.Add(temp);
                    break;
            }

        }


        static string secimAl(string[] secenekler)
        {  //  basit seçim alma fonksiyonu
            int secenekNumarasi = 1;
            foreach (string secenek in secenekler)
            {
                Console.WriteLine($"{secenekNumarasi} - {secenek}");
                secenekNumarasi++;
            }
            int secim = Convert.ToInt32(Console.ReadLine());
            return secenekler[secim - 1];
        }

        static public void laptoplariGoruntule ()
        {  //  kayıtlı laptopları yazdırır
            int i = 1;
            foreach (laptop lapt in laptoplar)
            {
                Console.WriteLine($"{i} - {lapt.Marka}");
            }
        }
    }  //  program sınıfı sonu
}  //  namespace sonu
