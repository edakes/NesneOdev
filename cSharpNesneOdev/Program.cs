using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hastane hastane = new Hastane("ayşe","gül",11111,"KADIN");
            Doktor doktor=new Doktor("mehmet","metin",1458796,"erkek",25,"3",40000,"çocuk doktoru");
            Hasta hasta = new Hasta(new DateTime(2021,02,21), "doktor", "ahmet", "seva", 121412, "ERKEK");
            HastaneCalisanlari hastaneCalisanlari = new HastaneCalisanlari("sevim","duyar",1256585,"kadın",256,15000,"ortopedi");


           
            hastane.BilgileriYazdir();
       
            hasta.BilgileriYazdir();
            
            hastaneCalisanlari.BilgileriYazdir();
            hastaneCalisanlari.MaasHesapla();
            Console.WriteLine("***********");

            doktor.BilgileriYazdir();
            doktor.Maashesapla();
            Console.WriteLine("***********");


            Console.ReadKey();

        }
    }
}
