using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul
{
    internal class Hastane
    {
        public string Isim { get; set; }
        public string Soyad { get; set; }
        public int TcNo { get; }
        public string Cinsiyet { get; set; }

        public Hastane(string isim, string soyad, int tcNo, string cinsiyet)
        {
            TcNo = tcNo;
            Isim = isim;
            Soyad = soyad;
            Cinsiyet = cinsiyet;
        }
        public ArrayList hastaBilgileri;

        public Hastane()
        {
            hastaBilgileri = new ArrayList();
        }

        public virtual void BilgileriYazdir()
        {
            Console.WriteLine($"Hasta Bilgileri: {Isim}{Soyad}, T.C.: {TcNo}, Cinsiyet: {Cinsiyet}");
            Console.WriteLine("***********");
            Console.ReadKey();
        }

        public void HastaBilgileriniYazdir()
        {
            Console.WriteLine("Hastane Hasta Bilgileri:");

            //foreach (var hasta in hastaBilgileri)
            //{
            //    if (hasta is Hastane)
            //    {
            //        ((Hastane)hasta).BilgileriYazdir();
            //    }
            //    else if (hasta is HastaneCalisanlari)
            //    {
            //        ((HastaneCalisanlari)hasta).BilgileriYazdir();
            //    }
            //    else if (hasta is Doktor)
            //    {
            //        ((Doktor)hasta).BilgileriYazdir();
            //    }

            //    Console.WriteLine();
            //}
        }
    }
}

