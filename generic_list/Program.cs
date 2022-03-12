using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count listenin içindeki eleman sayısını verir.
            
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);


            foreach (var item in sayiListesi)
            {
                Console.Write(item+" ");
                
            }
            
            foreach (var item in renkListesi)
            {
                Console.WriteLine(item+" ");
            }

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            //Listeden eleman çıkarma
            sayiListesi.Remove(4); //içine girilen değeri çıkarır
            renkListesi.Remove("Yeşil"); //yanlış yazılırsa hata döndürmüyor

            

            sayiListesi.RemoveAt(0); //index e göre eleman çıkarma
            renkListesi.RemoveAt(1); //index e göre eleman çıkarma


            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));


            //Liste İçerisinde Arama

            if (sayiListesi.Contains(10))
            {
                Console.WriteLine("10 liste içerisinde bulundu");
            }
            else
            {
                Console.WriteLine("10 liste içerisinde bulunamadı");
            }

            //Eleman ile index'e erişme;

            Console.WriteLine(renkListesi.BinarySearch("Sarı"));



            //Diziyi Liste'ye çevirme

            string[] hayvanlar = {"kedi","köpek","kuş"};

            List<string> hayvanListesi = new List<string>(hayvanlar);

            hayvanListesi.ForEach(item=> Console.WriteLine(item));

            //Tüm Listenin Temizlenmesi

            hayvanListesi.Clear();

            //******** Liste İçerisinde Nesne Tutmak
            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();
            Kullanıcılar kullanıcı1 = new Kullanıcılar(); //kullanıcı1 nesnesi oluşturuldu
            kullanıcı1.Isim = "Ayşe";
            kullanıcı1.Soyisim ="Yılmaz";
            kullanıcı1.Yas = 45 ;

            Kullanıcılar kullanıcı2 = new Kullanıcılar(); //kullanıcı2 nesnesi oluşturuldu
            kullanıcı2.Isim = "Emin";
            kullanıcı2.Soyisim ="Arslan";
            kullanıcı2.Yas = 23 ;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);


            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar(){
                Isim ="doğan",Soyisim ="şahin", Yas=25 
            });

            foreach (var kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı Adı :"+kullanıcı.Isim);    
                Console.WriteLine("Kullanıcı Adı :"+kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcı Adı :"+kullanıcı.Yas);
            }
        }
    }

    public class Kullanıcılar
    {
        private string isim ;
        private string soyisim ;
        private int yas ;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
