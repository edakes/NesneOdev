using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul
{
    internal class Hasta:Hastane
    {
        public DateTime Yatis_tarihi { get; set; }
        public string Poliklinik_belgesi { get; set; }

        public Hasta(DateTime yatis_tarihi, string poliklinik_belgesi,string isim,string soyad,int tcNo, string cinsiyet)
            :base(isim,soyad,tcNo,cinsiyet)
        {
            Yatis_tarihi = yatis_tarihi;
            Poliklinik_belgesi = poliklinik_belgesi;
        }

        public override void BilgileriYazdir()
        {
            Console.WriteLine($"Hasta Bilgileri: {Isim}{Soyad}, T.C.: {TcNo}, Cinsiyet: {Cinsiyet}");
            Console.WriteLine($"Yatış Tarihi: {Yatis_tarihi.ToShortDateString()}");
            Console.WriteLine("Poliklinik Bilgisi:"+ Poliklinik_belgesi );
            Console.WriteLine("***********");
            Console.ReadKey();
        }
    }
}

