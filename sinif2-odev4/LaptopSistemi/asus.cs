using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using LaptopSistemi.Komponent;

namespace LaptopSistemi
{
    internal class asus : laptop
    {

        public override void yarat()
        {
            this.marka = "asus";
            ramEkle();
            islemciEkle();
            Islemci = islemci.yarat("i7");
            diskEkle();
            monitorEkle();
            ekranKartiEkle();
            //throw new NotImplementedException();
        }

        public override double fiyatla() => fiyat + fiyat * 0.15;

        public override void islemciEkle()
        {  // çok şekillilik için  //  sadece i5 ten yüksek seçim sağlar
            Console.WriteLine("işlemci seçiniz");
            string secim = secimAl(new string[] { "i5", "i7" });
            Islemci = islemci.yarat(secim);
        }

        static int sayiKisminiDonder(string girdi)
        {  //  stringin başındaki sayı kısmını dönderen regex fonksiyonu
            string sayiKismi = Regex.Match(girdi, @"\d+").Value;
            return Convert.ToInt32(sayiKismi);
        }

        static string secimAl(string[] secenekler)
        {  //  dizi kullanarak geçici bir seçim menüsü oluşturur, seçilen seçeneği string olarak dönderir
            int secenekNumarasi = 1;
            foreach (string secenek in secenekler)
            {
                Console.WriteLine($"{secenekNumarasi} - {secenek}");
                secenekNumarasi++;
            }
            int secim = Convert.ToInt32(Console.ReadLine());
            return secenekler[secim - 1];
        }
    }  //  asus sınıfı sonu
}  //  namespace sonu
