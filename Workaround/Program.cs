using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();
            // Vatandas vatandas1= new Vatandas();//instance oluşturduk.


            SelamVer(isim: "Ahmet");
            SelamVer(isim: "Ayşe");
            SelamVer(isim: "Engin");
            SelamVer();


            int sonuc = Topla();

            //Diziler / Arrays
            string ogrenci1 = "Engin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";


            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";
            ogrenciler = new string[4];
            ogrenciler[3] = "İlker";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }
            //referans tipler stackde adres tutar heap de değer tutar 
            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;//hafızadaki sehirler 2 artık sehirler 1 in stack adresini tutuyor
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FisrtName = "GALİP";
            person1.LastName = "DOĞAN";
            person1.DateOfBirthYear = 1986;
            person1.NationalIdentity = 123;


            Person person2 = new Person();
            person2.FisrtName = "Murat";


            //değer tipler referans gibi değildir sadece atanan değeri tutar
            int sayi1 = 10;
            int sayi2 = 20;
            sayi2 = sayi1;
            sayi1 = 30;
            //            sayi2 ??//değeri 10 olarak kalır

            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }
            //Generic Collection (array yerine gelen yeni teknoloji)
            List<string> yenisehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yenisehirler1.Add("Adana 1");
            foreach (var sehir in yenisehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);





            Console.ReadLine();
        }
        //resharper -- eklenti adı
        static void SelamVer(string isim = "isimsiz")//void metodlar işi yapar değer döndürmez
        {

            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 5, int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + sonuc);
            return sonuc;
        }

        private static void Degiskenler()
        {
            string mesaj = "Selam";
            double tutar = 100000;//genelde db den gelir
            int sayi = 100;
            bool girisYapmismi = false;

            string ad = "Galip";
            string soyad = "Doğan";
            int dogumYili = 1986;
            long tcNo = 12345678910;

            Console.WriteLine(tutar * 1.18);
            Console.WriteLine(tutar * 1.18);
        }
    }
    //Pascal Casing kelimelerin ilk harfi büyük
    public class Vatandas
    {
        public string Ad { get; set; }
        public string SoyAd { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}
