using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsolUygulama
{
    class KonsolUygulamasi
    {
        //##  ALANLAR  ----------  ----------  ----------  ----------
        string _uygulamaIsmi;  //  uygulmanın ismi
        int aktifMenuID = 0;
        List<int> menuNavYigit = new List<int>();

        List<menu> _menuler = new List<menu>();  //  uygulamada kullanılacak menüler
        String[] _komutlar = { ":q", ":geri" };  //  navigasyon seçenekleri

        public delegate void fonksiyonListesi(int fonksiyonNumarasi);
        List<fonksiyonListesi> fonksList = new List<fonksiyonListesi>();






        //##  NİTELİKLER  ----------  ----------  ----------  ----------
        public string UygulamaIsmi { get { return _uygulamaIsmi; } }  //  uygulama ismine dışarıdan erişim  //  saltOkunu
        List<menu> Menuler { get { return _menuler; } }  //  menülere dışarıdan erişim  //  saltOkunur



        //##  OLUŞTURUCULAR  ----------  ----------  ----------  ----------
        private KonsolUygulamasi() { }  //  uygulama ismi olmadan
        private KonsolUygulamasi(string uygulamaIsmi) { this._uygulamaIsmi = uygulamaIsmi; }  //  uygulama ismi ile



        //##  METODLAR  ----------  ----------  ----------  ----------
        public void basla() => menuyeGit(0);  //  anamenüyü başlatır

        public static KonsolUygulamasi yarat() => new KonsolUygulamasi();  
        //instance dönderen yaratıcı fonksiyon

        //public void menuEkle(menu eklenecekMenu, fonksiyonListesi menuFonksiyonu) => _menuler.Add(eklenecekMenu);
        public void menuEkle(menu eklenecekMenu) => _menuler.Add(eklenecekMenu);
        //  yaratılan menüyü konsol uygulamasına ekler


        public string girdiAl(string gosterilecekMetin)
        {  //  girdi almak için basit bir fonksiyon
            Console.WriteLine(gosterilecekMetin);
                return Console.ReadLine();
        }


        public void menuyuUygula(int menuID)
        {  //  menüyü aktive eder
            Menuler[menuID].yazdir();
            aktifMenuID = menuID;
            menuNavYigit.Add(menuID);
        }



        public bool komutAl(out string metin)
        {  //  komutu analiz eder
            string girdi = Console.ReadLine();
            if (girdi[0] == ':')
            {
                //int komutNo = Array.IndexOf(_komutlar, komut);
                metin = girdi.Substring(1);
                return true;
            }
            metin = girdi;
            return false;
        }



        public void menuyeGit(int menuID)
        {  //  istenilen menüye navigasyonu sağlar
            menuNavYigit.Add(menuID);
            aktifMenuID = menuID;
            bool menuyuGoster = true;
            bool komutMu = false;

            while (menuyuGoster)
            {  //  kapatılmadığı sürece menüyü tekrarlar
                string girdi = "";
                menuyuUygula(menuID);
                komutMu = komutAl(out girdi);
                Console.Clear();
                if (komutMu == false)

                    secimYap(int.Parse(girdi));
                else if (komutMu == true)     
                    menuyuGoster = komutUygular(girdi);
            }
        }


        public bool komutUygular(string komut)
        {  //  komutları içeren fonksiyon
            switch (komut)
            {
                case "q":
                    Environment.Exit(0);
                    break;
                case "": return false;
                case "geri":
                    return false;
            } return true;
        }





        public void secimYap(int secim) => _menuler[aktifMenuID].secimYap(secim);  
        // menüde aksiyon yapılmasını sağlamak için seçim yapar



        static string secimAl(string[] secenekler)
        {   //  dizi kullanarak geçici bir seçim menüsü oluşturur, seçilen seçeneği string olarak dönderir
            int secenekNumarasi = 1;
            foreach (string secenek in secenekler)
            {
                Console.WriteLine($"{secenekNumarasi} - {secenek}");
                secenekNumarasi++;
            }
            int secim = Convert.ToInt32(Console.ReadLine());
                return secenekler[secim - 1];
        }

    }
}
