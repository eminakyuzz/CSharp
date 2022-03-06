using System;

namespace recursive_extension_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //rekürsif - öz yinelemeli fonksiyon-- kendş kendini çağıran fonksiyon
            //3^4
            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result*=3;
            }
            Console.WriteLine(result);

            Islemler instance = new();
            Console.WriteLine(instance.Expo(3,4));

            //Extension Metotalar---ve classlar static olmalı  
            string ifade = "emin arslan";
            bool sonuc =ifade.CheckSpaces();
            Console.WriteLine(sonuc);
            if (sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            }

            string isim = "emin arslan";
            Console.WriteLine(isim.MakeUpperCase());
            Console.WriteLine(isim.MakeLowerCase());


            int[] dizi = new int[] {5,9,4,7,62,598};
            dizi.SortArray();
            dizi.EkranaYazdir();

            int sayi = 45;
            Console.WriteLine(sayi.IsEvenNumber());

            Console.WriteLine(isim.GetFirstCharacter());
            
            string deneme = isim.Substring(0,9);
            Console.WriteLine(deneme);

            
            



            static void Yazdir(string metin)
            {
                Console.WriteLine(metin);
            }
        }
    }
    public class Islemler
    {
        public int Expo(int sayi, int üs) //faktöriyel
        {
            if (üs<2)
            {
                return sayi;
            }
            return Expo(sayi,üs-1)*sayi;
        }

    }
    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }
        public static string RemoveWhiteSpaces(this string param){
            string[] dizi = param.Split(" "); 
            return string.Join("",dizi);   
        }
        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param){
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void EkranaYazdir(this int[] param)
        {
            foreach (var item in param)
            {
                Console.WriteLine(item);
            }
        }
        public static bool IsEvenNumber(this int param)
        {
            return param%2==0;
        }

        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0,2) ;
        }







    }   
}
