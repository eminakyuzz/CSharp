using System;

namespace hazir_metotlar_datetime_math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);
            Console.WriteLine(DateTime.Now.DayOfWeek); //haftanın gününü string olarak getirdi
            Console.WriteLine(DateTime.Now.DayOfYear); //yılın kaçıncı gününde olduğunu getirdi

            Console.WriteLine(DateTime.Now.ToLongDateString()); //11 Mart 2022 Cuma
            Console.WriteLine(DateTime.Now.ToShortDateString()); //11.03.2022 

            Console.WriteLine(DateTime.Now.ToLongTimeString()); // 20:51:37
            Console.WriteLine(DateTime.Now.ToShortTimeString()); //20:57

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(3));
            Console.WriteLine(DateTime.Now.AddYears(9));

            //DateTime Format--formatlamak için ToString kullanılır
            Console.WriteLine(DateTime.Now.ToString("dd")); // 25 int gün olarak getirir
            Console.WriteLine(DateTime.Now.ToString("ddd")); //Sat günün string karşılığını getirir.
            Console.WriteLine(DateTime.Now.ToString("dddd")); //Saturday günün tamamını string olarak getirir

            Console.WriteLine(DateTime.Now.ToString("MM")); // 03 ay getirme 
            Console.WriteLine(DateTime.Now.ToString("MMM")); // Mar
            Console.WriteLine(DateTime.Now.ToString("MMMMM")); //March

            Console.WriteLine(DateTime.Now.ToString("yy")); // 22
            Console.WriteLine(DateTime.Now.ToString("yyyy")); // 2022

            System.Console.WriteLine("*****Math Kütüphanesi*****");
            //Math Kütüphanesi
            Console.WriteLine(Math.Abs(-25)); //mutlak alır
            Console.WriteLine(Math.Sin(30)); //sinüs hesabı yapar
            Console.WriteLine(Math.Cos(30)); 
            Console.WriteLine(Math.Tan(30));

            Console.WriteLine(Math.Ceiling(22.3)); //girilen değerden büyük  en küçük tam sayıyı getirir;
            Console.WriteLine(Math.Round(22.3)); // 22--en yakın değere yuvarlar
            Console.WriteLine(Math.Round(22.7)); //23
            Console.WriteLine(Math.Round(22.5));
            Console.WriteLine(Math.Floor(22.7)); //girilen değerden küçük en büyük tam sayıyı getirir

            System.Console.WriteLine(Math.Max(5,56));
            System.Console.WriteLine(Math.Min(5,56));

            System.Console.WriteLine(Math.Pow(3,4)); // 3^4'ü verir --81
            System.Console.WriteLine(Math.Sqrt(49)); //karekök alır
            System.Console.WriteLine(Math.Log(9)); // girilen değerin e tabanındaki logaritmik karşılığı
            System.Console.WriteLine(Math.Exp(3)); // girilen değerin e üssü değerini verir
            System.Console.WriteLine(Math.Log10(100)); // girilen değerin loaritma 10 tabanındaki karşılığı



        }
    }
}
