using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaptopSistemi.Komponent;

namespace LaptopSistemi
{
    internal class lenovo : laptop
    {
        public override void yarat()
        {
            this.marka = "lenovo";
            ramEkle();
            islemciEkle();
            diskEkle();
            //monitorEkle();
            this.Monitor = monitor.yarat("17.3");
            ekranKartiEkle();
            //throw new NotImplementedException();

        }

        public override void islemciEkle()
        {
            base.islemciEkle();
        }

        public override double fiyatla() => fiyat + fiyat*0.10;
    }  //  lenovo sınıfı sonu
}  //  namespace sonu
