using System;

namespace static_sinif_ve_uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Çalışan Sayısı :{0}",Calisan.CalisanSayisi);
            Calisan calisan  = new Calisan("Emin","Arslan","IT");

            System.Console.WriteLine("Çalışan Sayısı :{0}",Calisan.CalisanSayisi);

            Calisan calisan1  = new Calisan("Emin","Arslan","IT");
            Calisan calisan2  = new Calisan("Emin","Arslan","IT");
            System.Console.WriteLine("Çalışan Sayısı :{0}",Calisan.CalisanSayisi);
            
            
            System.Console.WriteLine(Islemler.Topla(1,20));
            System.Console.WriteLine(Islemler.Cikar(1,20));

        }
    }
    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }

        private string Isim ;
        private string SoyIsım;
        private string Departman;

        static Calisan()
        {
            calisanSayisi=0;
        }

        public Calisan(string ısim, string soyIsım, string departman)
        {
            Isim = ısim;
            SoyIsım = soyIsım;
            Departman = departman;
            calisanSayisi++;
        }
  
    }
    static class Islemler
    {
        public static long Topla (int sayi1, int sayi2)
        {
            return sayi1+sayi2;
        }
        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1-sayi2;
        }
    }
}
