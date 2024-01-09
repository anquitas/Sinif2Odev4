using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaptopSistemi.Komponent;

namespace LaptopSistemi
{
    internal class dell : laptop
    {

        public override void yarat()
        {
            this.marka = "dell";
            ramEkle();
            islemciEkle();
            //diskEkle();
            Disk = disk.yarat("SSD");
            monitorEkle();
            ekranKartiEkle();
            //throw new NotImplementedException();
        }

        public override void islemciEkle()
        {
            base.islemciEkle();
        }

        public override double fiyatla() => fiyat + fiyat * 0.13;
    }  //  dell sınıfı sonu
}  //  namespace sonu
