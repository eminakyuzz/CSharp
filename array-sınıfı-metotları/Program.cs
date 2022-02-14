using System;

namespace array_sınıfı_metotları
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort ---sıralama

            int[] sayiDizisi = {12,45,8,6,1,58,26,47};
            Console.WriteLine("******SIRASIZ*************");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("******SIRALI Liste*************");
            Array.Sort(sayiDizisi); 
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            //Console.WriteLine(sayiDizisi[0]);

            //Clear ---- verilen indexten başlayarak verilen değer kadar elemanı sıfırlar (değerini [0] yapar .)

            Console.WriteLine("******Array Clear*************");
            Array.Clear(sayiDizisi,4,3);  //4.index ten başla ve 3 elemanın değerini sıdırla.
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //Reverse
            Console.WriteLine("*************Reverse**************");
            Array.Reverse(sayiDizisi);
             foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //IndexOf --------içine veerilen değer eğer varsa index i döner yoksa -1 döner
            Console.WriteLine("**********IndexOf*************");
            Console.WriteLine("Aranan değer indexi :"+Array.IndexOf(sayiDizisi,8));

            //Resize --- yeniden boyutlandırma yapar.
            Console.WriteLine("*************Resize*************");
            Array.Resize<int>(ref sayiDizisi,9);

            sayiDizisi[8] = 999;
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            










        }
    }
}
