using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul
{
    internal class Doktor:HastaneCalisanlari
    {
        public int BransNo { get; set; }
        public string DiplomaNo { get; }
    
    public Doktor( string isim,string soyad,int tcNo,string cinsiyet, int bransNo ,string diplomaNo,int ekGosterge,string calistigi_departman)
            :base(isim,soyad,tcNo,cinsiyet,bransNo,ekGosterge,calistigi_departman) 
            
    {
            BransNo = bransNo;
            DiplomaNo = diplomaNo;
            
    }
        public override void BilgileriYazdir()
        {
            Console.WriteLine($"Doktor Bilgileri: {Isim}{Soyad}, T.C.: {TcNo}, Cinsiyet: {Cinsiyet}");
            Console.WriteLine($"Çalıştığı Departman: {Calistigi_departman}");
            Console.WriteLine($"Doktor Bilgileri: Branş Numarası: {BransNo}, Sicil No:{SicilNo}");
            
            Console.ReadKey();
        }
        public void Maashesapla()
        {

            double maas = 0;
            Ek_gosterge = 3600;
            if (Ek_gosterge == 1500)
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
