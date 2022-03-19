using System;

namespace hazir_metotlar_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
            string degisten2 = "CSharp";
            //Lenght---karakter sayısı
            Console.WriteLine(degisken.Length);


            //ToUpper -- tüm karakterleri büyük yapar ,,ToLower--tğm karakterleri küçük yapar
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());


            //Concat -- karakter serisinin sonuna istenildiği kadar değer atanabilir
            Console.WriteLine(string.Concat(degisken,"Merhaba"));
            

            //Compare--kıyaslama büyük küçük harfe gore 1 || 0 değerlerini alır , CompareTo--degiskenleri karakter sayılarına göre kıyaslar
            Console.WriteLine(degisken.CompareTo(degisten2)); //eşit ise 0 ; 1. degiskenin karakter sayısı fazla ise 1 döndürür
            Console.WriteLine(string.Compare(degisken,degisten2,true)); //büyük küçük harf duyarlı true
            Console.WriteLine(string.Compare(degisken,degisten2,false)); //büyük küçük harf duyarsız


            //Contains-- içinde olup olmama durumunu kontrol eder

            Console.WriteLine(degisken.Contains(degisten2)); //true || false döner

            //StarstWith--girilen değerle başlıyor mu ,, EndsWith---girilen değerle bitiyor mu
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!")); //true || false döner
            Console.WriteLine(degisken.StartsWith(degisten2)); //true || false döner

            //IndexOf
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("x"));

            //Insert -- istenilen indexten başlayarak karakter(ler) eklenilebilir
            Console.WriteLine(degisken.Insert(0,"Merhaba ! "));

            //LastIndexOf --girilen değerin son indexini getirir
            Console.WriteLine(degisken.LastIndexOf("i"));


            //PadLeft, PadRight
            Console.WriteLine(degisken + degisten2.PadLeft(30)); //degisken2'nin soluna 30 karekterlik boşluk koyar
            Console.WriteLine(degisken + degisten2.PadLeft(30, '*'));

            Console.WriteLine(degisken.PadRight(50) + degisten2);
            Console.WriteLine(degisken.PadRight(50,'-') + degisten2);

            //Remove
            Console.WriteLine(degisken.Remove(10)); 
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));



            //Reclace --istenilen karekteri verilen değerle değiştirir
            Console.WriteLine(degisken.Replace("CSharp","C#"));
            Console.WriteLine(degisken.Replace(" ","*"));


            //Split
            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring---girilen indexten istenilen kadar karakterleri getirir
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));
            

            Console.Write("Bir kelime giriniz: ");
            string kelime = Console.ReadLine();
            string kelime_ters = "";
            for (int i = kelime.Length-1; i >= 0; i--)
            {
                kelime_ters += kelime[i];
            }
            Console.WriteLine("\nKelimenin tersten yazılısı = " + kelime_ters);
            if (kelime_ters == kelime)
            {
                Console.WriteLine("\nGirilen kelime Palindromik bir kelimedir.");
            }
            else
            {
                Console.WriteLine("\nGirilen kelime Palindromik bir kelime değildir.");
            }









        }
    }
}
