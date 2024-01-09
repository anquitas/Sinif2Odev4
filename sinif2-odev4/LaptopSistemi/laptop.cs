using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using LaptopSistemi.Komponent;

namespace LaptopSistemi
{
    internal abstract class laptop
    {
        //##  ALANLAR  ----------  ----------  ---------  ----------
        protected string marka;
        protected double fiyat = 10000;

        //kompozisyon yöntemi ile laptop parçalarını laptop sınıfları içerisinde tuttum
        protected ram[] Ram = new ram[2];
        protected disk Disk;
        protected islemci Islemci;
        protected monitor Monitor;
        protected ekranKarti EkranKarti;


        //##  NİTELİKLER  ----------  ----------  ---------  ----------
        public string Marka { get => marka; }  //  kapsülleme

        //##  OLUŞTURUCULAR  ----------  ----------  ---------  ----------
        protected laptop() { }

        //##  METODLAR  ----------  ----------  ---------  ----------

        public abstract void yarat();  //  alt sınıflarda implemente edilmek üzere ayrılmış
        public abstract double fiyatla();  //  alt sınıflarda implemente edilmek üzere ayrılmış



        #region komponent yarat ve ekle
        public void ramEkle()
        {
            Console.WriteLine("ram seçiniz");
            string secim = secimAl(new string[] { "8 gb", "16 gb" });
            int ramMiktari = sayiKisminiDonder(secim);
            Ram[0] = ram.yarat(ramMiktari);
        }

        public void ramTakviye() {
            Console.WriteLine("ram seçiniz");
            string secim = secimAl(new string[] { "8 gb", "16 gb" });
            int ramMiktari = sayiKisminiDonder(secim);
            Ram[1] = ram.yarat(ramMiktari);
        }



        public virtual void islemciEkle()
        {  //  çok şekillilik gereksinimi
            Console.WriteLine("işlemci seçiniz");
            string secim = secimAl(new string[] { "i3","i5", "i7" });
            Islemci = islemci.yarat(secim);

        }



        public void diskEkle()
        {
            Console.WriteLine("disk seçiniz");
            string secim = secimAl(new string[] { "HDD", "SSD" });
            Disk = disk.yarat(secim);   
        }



        public void monitorEkle()
        {
            Console.WriteLine("monitör ekle");
            string secim = secimAl(new string[] { "15.6", "17.3" });
            Monitor = monitor.yarat(secim);
        }



        public void ekranKartiEkle()
        {
            Console.WriteLine("ekran kartı ekle");
            string secim = secimAl(new string[] { "paylaşımlı", "paylaşımsız" });
            if(secim == "paylaşımlı")
                EkranKarti = ekranKarti.yarat(true);
            else EkranKarti = ekranKarti.yarat(false);
        }
        #endregion



        #region bilgilendirme
        public void bilgi () //  laptopun özet bilgisi
        {  
            Console.WriteLine("LAPTOPUNUZ:");
            Ram[0].basitBilgi();
            if (Ram[1] != null) Ram[1].basitBilgi();
            Disk.basitBilgi();
            Islemci.basitBilgi();
            Monitor.basitBilgi();
            EkranKarti.basitBilgi();
            Console.WriteLine($"fiyat: {fiyatla()}");
            Console.ReadKey();
            Console.Clear();
        }



        public void ayrintiliBilgi()  //  laptopun ayrıntılı bilgisi
        {  
            Console.WriteLine("LAPTOPUNUZ:");
            Ram[0].ayrintiBilgi();
            if (Ram[1] != null) Ram[1].ayrintiBilgi();
            Disk.ayrintiBilgi();
            Islemci.ayrintiBilgi();
            Monitor.ayrintiBilgi();
            EkranKarti.ayrintiBilgi();
            Console.WriteLine($"fiyat: {fiyatla()}");
            Console.ReadKey();
            Console.Clear();
        }
        #endregion



        #region araç metodlar
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

        static string bilgiAl(string sorulacakSoru)
        {  //  basit bilgi alma fonksiyonu
            Console.WriteLine(sorulacakSoru);
            Console.ReadLine();
            return sorulacakSoru;
        }

        static int sayiKisminiDonder(string girdi)
        {  //  stringin başındaki sayı kısmını dönderen regex fonksiyonu
            string sayiKismi = Regex.Match(girdi, @"\d+").Value;
            return Convert.ToInt32(sayiKismi);
        }
        #endregion
    }  //  laptop sınıfı sonu
}  //  namespace sonu
