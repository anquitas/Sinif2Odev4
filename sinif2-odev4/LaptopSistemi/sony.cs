using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaptopSistemi.Komponent;


namespace LaptopSistemi
{
    internal class sony: laptop
    {

        public override void yarat()
        {
            this.marka = "sony";
            ramEkle();
            //islemciEkle();
            diskEkle();
            monitorEkle();
            this.Islemci = islemci.yarat("i5"); //düzelt
            ekranKartiEkle();
            //throw new NotImplementedException();
        }
        public override void islemciEkle()
        {
            base.islemciEkle();
        }


        public override double fiyatla() => fiyat + fiyat * 0.09;
    }  //  sony sınıfı sonu
}  //  namespace sonu
