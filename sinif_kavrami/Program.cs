using System;

namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            // class SinifAdi
            // {
            //     [Erişim Belirleyici][Veri Tipi] ÖzellikAdı;
            //     [Erişim Belirleyici][Geri Dönüş Değerinin Tipi] MetotAdi([Parametreler])
            //     {
            //         //Metot Gövdesi
            //     }
            // }

            Calisan calisan1 = new Calisan();
            calisan1.Ad="Ayşe";
            calisan1.SoyAd ="Kara";
            calisan1.No = 15664890;
            calisan1.Departman = "IT";

            calisan1.CalisanBilgileri();

            Console.WriteLine("****************");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Emin";
            calisan2.SoyAd = "Arslan";
            calisan2.No = 15685411;
            calisan2.Departman = "İnsan Kaynakları";

            calisan2.CalisanBilgileri();

        }
    }
    class Calisan
    {
        public string Ad { get; set; }
        public string SoyAd { get; set; }
        public int No { get; set; }
        public string Departman { get; set; }


        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı :{0}",Ad);
            Console.WriteLine("Çalışan Soyadı :{0}",SoyAd);
            Console.WriteLine("Çalışan Numarası :{0}",No);
            Console.WriteLine("Çalışan Departmanı :{0}",Departman);

        }
    }
}
