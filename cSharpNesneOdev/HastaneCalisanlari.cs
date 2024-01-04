using Okul;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul
{
    internal class HastaneCalisanlari : Hastane
    {
        public int SicilNo { get; }
        public int Ek_gosterge { get; set; }
        public string Calistigi_departman { get; set; }

        public HastaneCalisanlari(string isim, string soyad, int tcNo, string cinsiyet, int sicilNo, int ekGosterge, string calistigi_departman)
            : base(isim, soyad, tcNo, cinsiyet)
        {
            Calistigi_departman = calistigi_departman;
            Ek_gosterge = ekGosterge;
            SicilNo = sicilNo;
        }

        public override void BilgileriYazdir()
        {
            Console.WriteLine($"Hastane Çalışanı Bilgileri: {Isim}{Soyad}, T.C.: {TcNo}, Cinsiyet: {Cinsiyet}");
            Console.WriteLine($"Çalıştığı Departman: {Calistigi_departman},  Sicil No:{SicilNo}");
            
            Console.ReadKey();
        }

        public  void MaasHesapla()
        {

            double maas = 0;
            Ek_gosterge = 1500;
            if (Ek_gosterge== 1500)
                maas = 15000;
            else if (Ek_gosterge > 1500 && Ek_gosterge <= 2200)
                maas = 20000;
            else if (Ek_gosterge > 2200 && Ek_gosterge <= 3000)
                maas = 30000;
            else if (Ek_gosterge > 3000 && Ek_gosterge <= 3600)
                maas = 40000;


            Console.WriteLine($"Maaş: {maas} TL");

        }
    }
}
// Hastane class’ında hasta bilgilerini
//arraylistte tutan ve bu bilgileri yazdıran metotları tanımlayınız.
//HastaneCalisanlari class’ında maasHesapla metodu tanımlayınız (ek_gösterge
//durumu 1500 ise 15000TL, ek_gosterge 1500-2200 arasında 20000TL, ek_gosterge 2200-3000
//arasında 30000TL, ek_gosterge 3000-3600 arasında 40000TL maaş hesaplaması yapılacaktır.)
//doktor class’ında maas_hesapla metodu override edilerek uygulanacaktır.
