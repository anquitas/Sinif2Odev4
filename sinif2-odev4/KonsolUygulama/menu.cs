using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KonsolUygulama
{
    class menu
    {
        //##  ALANLAR  ----------  ----------  ----------  ----------
        string _baslik;
        List<string> _secenekler = new List<string>();  //  seçenekler string listesi

        //callback yapabilmek için
        public delegate void fonksiyonListesi(int fonksiyonNumarasi);
        public delegate void bilgiFonksiyonu();

        public fonksiyonListesi fonksList;
        public bilgiFonksiyonu menuBilgisi;



        //##  NİTELİKLER  ----------  ----------  ----------  ----------
        string Baslik { get { return _baslik; } }  //  menü başlığına erişim
        int secenekSayisi { get { return _secenekler.Count; } }  //  seçenek sayısını dinamik olarak verir


        //##  OLUŞTURUCULAR  ----------  ----------  ----------  ----------
        #region oluşturucular
        private menu() { }

        private menu(string baslik) { this._baslik = baslik; }  //  asıl oluşturucu
        #endregion



        //##  METODLAR  ----------  ----------  ----------  ----------
        private void secenekEkle(string[] secenekler)  // bir dizi string'i seçenek listesine ekler
        { foreach (string secenek in secenekler) _secenekler.Add(secenek); }  

        public static menu yarat(string baslik, string[] secenekler)
        {  //  instance dönderen yaratıcı fonksiyon
            menu temp = new menu(baslik);
            temp.secenekEkle(secenekler);
            return temp;
        }

        public static menu yarat(string baslik, string[] secenekler, fonksiyonListesi fonksList)
        {  //  instance dönderen yaratıcı fonksiyon
            menu temp = new menu(baslik);
            temp.secenekEkle(secenekler);
            temp.fonksList = fonksList;
            return temp;
        }

        public static menu yarat(string baslik, string[] secenekler, fonksiyonListesi fonksList, bilgiFonksiyonu bilgiFonks)
        {  //  instance dönderen yaratıcı fonksiyon
            menu temp = new menu(baslik);
            temp.secenekEkle(secenekler);
            temp.fonksList = fonksList;
            temp.menuBilgisi = bilgiFonks;
                return temp;
        }

        public void yazdir()
        {  //  menü seçeneklerini ekrana yazdırır
            Console.Clear();
            Console.WriteLine(Baslik);
            bilgiYazdir();
            int secenekNumarasi = 0;

            foreach (string secenek in _secenekler)
            {
                secenekNumarasi++;
                Console.WriteLine(secenekNumarasi + " " + secenek);
            }
        }

        public void secimYap(int secim) => fonksList(secim);  // menüye bağlı menü fonksiyonundan seçim yapar


        public void bilgiYazdir()
            { if (menuBilgisi != null) menuBilgisi(); }  // eğer varsa menüye ait menü fonksiyonunu aktive eder


    }
}
