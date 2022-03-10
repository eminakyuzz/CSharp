using System;

namespace OdevBir
{
    class Program
    {
        static void Main(string[] args)
        {

            //Soru1

            Console.Write("Dizi Uzunluğu Giriniz :");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            Console.WriteLine("dizi uzunluğu : " + diziUzunlugu);
            
            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lütfen {0}.sayıyı giriniz ", i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }
            
            //cift sayıları yazdırma
            Console.WriteLine("*******Çift sayılar********");
            foreach (var item in sayiDizisi)
            {
                if (item%2==0)
                {
                    Console.WriteLine(item);
                }
                else
                    continue;
            }

            //Soru2

            Console.Write("1. pozitif sayıyı giriniz (Dizi Uzunluğu) :");
            int n = int.Parse(Console.ReadLine());
            Console.Write("2. pozitif sayıyı giriniz :");
            int m = int.Parse(Console.ReadLine());

            //n uzunluğunda dizinin tanımlanması
            int[] dizi = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Lütfen {0}.sayıyı giriniz ", i+1);
                dizi[i] = int.Parse(Console.ReadLine());
            }
            //m'e eşit veya tam bölünenlerin ekrana yazdırılması

            foreach (var j in dizi)
            {
                if (j==m || j%m==0)
                {
                    Console.WriteLine(j);
                }
                else
                    continue;
            }

            //Soru3
            Console.Write("Kelime sayısını giriniz :");
            int sayi = int.Parse(Console.ReadLine());
            string[] kelimeler = new string[sayi];

            for (int i = 0; i < sayi; i++)
            {
                Console.Write("Lütfen {0}.kelimeyi giriniz ", i+1);
                kelimeler[i] = Console.ReadLine();
            }

            Array.Reverse(kelimeler);

            foreach (var item in kelimeler)
            {
                Console.WriteLine(item);
            }

            //Soru4
            Console.Write("Bir Cümle Girin :");
            string cumle = Console.ReadLine();
            cumle.Trim();
            Console.WriteLine(cumle);
            Console.WriteLine("cümle uzunluğu :"+cumle.Length);


            Console.WriteLine(cumle+"\n");
            string liste =  "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ"
                           +"abcçdefgğhiıjklmnoöprsştuüvyz";
 
            int sayac = 0;
            for (int i = 0; i < cumle.Length; i++)
            {
                //karakter katarkter kontrol ediyoruz.
                if (liste.Contains(cumle[i]))
                {
                    sayac++;
                }
            }
            Console.WriteLine("Yukarıdaki ifadede toplam {0} \ntane  harf vardır.", sayac);

            //kelime sayısı:
            string[] diziCumle = cumle.Split(" ");
            Console.Write("kelime sayısı :"+ diziCumle.Length);
            



            
        }
    }
}
