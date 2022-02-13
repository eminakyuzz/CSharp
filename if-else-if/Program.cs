using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
             int time = DateTime.Now.Hour;
            // if(time>=6 && time<11)
            //     Console.WriteLine("günaydın!");
            // else if (time<=18)
            //     Console.WriteLine("iyi günler!");
            // else
            //     Console.WriteLine("iyi geceler!");
            
            //string sonuc = time<=18 ? "iyi günler...." :"iyi geceler....";  //18'den küçükse soru işaretinden sonraki ilk kod çalışır.
           // Console.WriteLine(sonuc);
            
            string sonuc ;
            sonuc = time>=6 && time<11 ? "günaydın": time<= 18 ? "iyi günler" :"iyi geceler"; 
            Console.WriteLine(sonuc);


            int sayi1 = 20;
            int sayi2 = 2;

            int sonuc2 = sayi1 % sayi2;
            Console.WriteLine("mod :" +sonuc2);



        }
    }
}
