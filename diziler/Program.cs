using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            // //Dizi tanımlama
            // string[] renkler = new string[5];   //5 elemanlı dizi tanımlaması

            // string[] animals = {"cat","dog","elepahnt"};

            // int [] dizi;
            // dizi= new int[5];

            // //Dizilere değer atama ve erişim

            // renkler[0] = "mavi";
            // dizi[3] = 10 ; 
            // Console.WriteLine(animals[1]);
            // Console.WriteLine(renkler[0]);
            // Console.WriteLine(dizi[3]);

            //Düngülerde dizi kulanımı
            //klavyeden girilen n tane sayının ortalamasını hesaplayan program
            // Console.Write("Dizinin eleman sayısını giriniz : ");
            // int diziUzunlugu = int.Parse(Console.ReadLine());
            // Console.WriteLine("Dizi Uzunluğu :" + diziUzunlugu);

            // int [] sayıDizisi = new int[diziUzunlugu];
            // for (int i = 0; i < diziUzunlugu; i++)
            // {
            //     Console.Write("Lütfen {0}.sayıyı giriniz ", i+1);
            //     sayıDizisi[i] = int.Parse(Console.ReadLine());
            // }

            // double toplam = 0;
            // foreach (var sayı in sayıDizisi)
            // {
            //     toplam += sayı ;
            // }

            // Console.WriteLine("Ortalama :"+toplam/diziUzunlugu);





            //klavyeden girilen n tane sayının ortaalamasını hesaplayan program

            // //kullanıcıdan dizi uzunluğunun alınması
            // Console.Write("Ortalaması hesaplanacak dizi uzunluğu :");
            // int diziUzunlugu = int.Parse(Console.ReadLine());
            // Console.WriteLine("Dizi Uzunluğu :"+diziUzunlugu);
            
            // //dizinin yaratılması
            // int[] sayilar = new int[diziUzunlugu];

            // //kullanıcıdan değer alınması ve diziye atanması
            // for (int i = 0; i < diziUzunlugu; i++)
            // {
            //     Console.WriteLine("Lütfen {0}. sayıyı giriniz :" , i+1);
            //     sayilar[i] = int.Parse(Console.ReadLine());

            // }

            // //dizideki elemanların ortalamasının alınması
            // int toplam = 0;
            
            // foreach (var sayi in sayilar)
            // {
            //     toplam += sayi ; //dizideki elemanların toplamını alıyor
            // }

            // Console.WriteLine("Ortalama :"+ toplam/diziUzunlugu );



            //Kullanıcının girdiği sayıların negatiflik pozitiflik ve sıfır oranlarını bulan program


            Console.Write("Oluşturulacak dizi uzunluğunu giriniz :");
            int diziUzunlugu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("dizi uzunluğu :"+ diziUzunlugu);


            //dizinin oluşturulması

            int[] sayilar = new int[diziUzunlugu];

            // kullanıcıdan eleman alınarak diziye ekleme yapılması

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz :", i+1);
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

           

            double nSayiMiktari = 0;
            double pSayiMiktari = 0;
            double zSayiMiktari = 0;

            foreach (var item in sayilar)
            {
                if (item<0)
                {
                    nSayiMiktari +=1;
                }
                if (item>0)
                {
                    pSayiMiktari +=1;
                }
                if (item==0)
                {
                    zSayiMiktari +=1;
                }
            }

            //türlerine göre sayıların miktarlarının yazdırılması
            Console.WriteLine("Negatif Sayı Miktarı :"+nSayiMiktari);
            Console.WriteLine("Pozitif Sayı Miktarı :"+pSayiMiktari);
            Console.WriteLine("Sıfır Sayı Miktarı :"+zSayiMiktari);

            //türlerine göre sayı oranları
            Console.WriteLine("**************Oranlar****************");
            Console.WriteLine("Negatif Sayı oranı :"+nSayiMiktari/diziUzunlugu);
            Console.WriteLine("Pozitif Sayı Miktarı :"+pSayiMiktari/diziUzunlugu);
            Console.WriteLine("Sıfır Sayı Miktarı :"+zSayiMiktari/diziUzunlugu);







            





            














        }
    }
}
