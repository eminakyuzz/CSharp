using System;

namespace kurucu_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********Çalışan 1*******");
            Calisan calisan1 = new Calisan();
            calisan1.Ad="Ayşe"; 
            calisan1.SoyAd ="Kara";
            calisan1.No = 15664890;
            calisan1.Departman = "IT";

            calisan1.CalisanBilgileri();

            Console.WriteLine("*********Çalışan 2*******");

            Calisan calisan2 = new Calisan();                                                       
            calisan2.Ad = "Emin";                                                       
            calisan2.SoyAd = "Arslan";
            calisan2.No = 15685411;
            calisan2.Departman = "İnsan Kaynakları";

            calisan2.CalisanBilgileri();

            Console.WriteLine("*********Çalışan 3*******");
            Calisan calisan3 = new Calisan("Yunus Emre", "Türk", 15645689,"Turizm");
            calisan3.CalisanBilgileri();

            Console.WriteLine("*********Çalışan 4*******");
            Calisan calisan4 = new Calisan("Fatma","Arslan");
            calisan4.CalisanBilgileri();
        }
    }
    class Calisan
    {
        public string Ad { get; set; }
        public string SoyAd { get; set; }
        public int No { get; set; }
        public string Departman { get; set; }


        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.SoyAd = soyad;
            this.No = no;
            this.Departman = departman;                 
        }
        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.SoyAd = soyad;
                             
        }
        public Calisan(){}
        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı :{0}",Ad);
            Console.WriteLine("Çalışan Soyadı :{0}",SoyAd);
            Console.WriteLine("Çalışan Numarası :{0}",No);
            Console.WriteLine("Çalışan Departmanı :{0}",Departman);

        }
    }
    
    
}
