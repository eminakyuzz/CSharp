using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //ekrandan girilen sayıya kadar olan tek sayıları yazdır.
            // Console.Write("Limit sayıyı giriniz:");
            // int sayi = Convert.ToInt32(Console.ReadLine());
            // for (int i = 1; i <= sayi; i++)
            // {
            //     if (i % 2 ==1)
                
            //         Console.WriteLine(i);


            // }

            //1-1000 arası tek sayıların ve çift sayıların kendi içlerindeki toplamlarını ayrı ayrı yazdır.

            // int tekToplam = 0 ;
            // int ciftToplam = 0 ;

            // for (int i = 0; i <= 1000; i++)
            // {
            //     if (i % 2 == 0)
            //     {
            //         ciftToplam +=i ;
            //     }
            //     else
            //         tekToplam +=i ;
            // }

            // Console.WriteLine("Tek sayıların toplamı :"+ tekToplam);
            // Console.WriteLine("Çift sayıların topplamı : "+ ciftToplam);


            // girilen bir sayı için 10'a kadar çarpımlarını yazma.
            // Console.Write("sayı gir :");
            // int n = Convert.ToInt32(Console.ReadLine().Trim());
            // for (int i = 1; i <= 10; i++)
            // {
            //     int a = i*n;
            //     Console.WriteLine(n + " x " + i +" = " + a);
            // }


            
            //hackerrank staircase 
            //     #
            //    ##
            //   ###
            //  ####  

            // Console.Write("sayı : ");
            // int sayi = int.Parse(Console.ReadLine());
            // for (int i = 0; i <= sayi; i++)
            // {
            //     for (int j = 0; j > i; j--)
            //     {
            //         Console.Write(" ");
            //     }
            //     for (int k = 0; k < i; k++)
            //     {
            //         Console.Write("#");
            //     }
            //     Console.WriteLine();
            // }


            //While loop
            // 1'den başlayarak consoledan gelen sayı dahil ortalama hesaplama ve console yazdırma  

            Console.Write("Limit sayıyı girin : ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;            
            while (sayac <= sayi)
            {
                toplam += sayac ;
                sayac ++ ;
            }
            Console.WriteLine(toplam);
            Console.WriteLine(toplam/sayi);


            //a'dan z'ye kadar tüm harflerin console yazdırımı
            char character = 'a';

            while (character <= 'z')
            {
                Console.WriteLine(character);
                character ++ ;
            }

            Console.WriteLine("**************Foreach*****************");


            string[] arabalar = {"renault","mercedes","toyota","opel",};
            foreach (var item in arabalar)
            {
                Console.WriteLine(item);
            }


            




        }
    }
}
