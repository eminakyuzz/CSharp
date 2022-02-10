using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atama ve işlemli atama

            int x = 3;
            int y = 4;

            y = y+2;
            Console.WriteLine(y);
            y += 2 ;
            Console.WriteLine(y);
            y/=1;
            Console.WriteLine(y);
            x*=2;
            Console.WriteLine(x);

            //Mantıksal Opetarörler
            // || veya, && ve , ! değil 

            bool isSucces = true;
            bool isCompleted = false;
            if(isSucces && isCompleted)
                Console.WriteLine("Perfect");
            if(isSucces || isCompleted)
                Console.WriteLine("Great");
            if(isSucces && !isCompleted)
                Console.WriteLine("Fine");
            
            
            Console.WriteLine("************İlişkisel Operatörler***************");
            //İlişkisel Operatörler
            // <, > , <= , >= , == , !=
            int a = 3;
            int b = 4;
            bool sonuc =  a<b;           // a b' den küçük ise true olsun---true kabul edildi
            Console.WriteLine(sonuc);

            sonuc = a>b;
            Console.WriteLine(sonuc);
            
            sonuc = a>=b;
            Console.WriteLine(sonuc);

            sonuc = a<=b;
            Console.WriteLine(sonuc);
             
            sonuc = a==b;
            Console.WriteLine(sonuc);

            sonuc = a!=b;
            Console.WriteLine(sonuc);

            
            Console.WriteLine("********Aritmetik Operatörler************");
            //Aritmetik Operatörler
            // / , * , + , - , 

            int sayi1 = 40;
            int sayi2 = 20;
            int sonuc1 = sayi1/sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1*sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1-sayi2;
            Console.WriteLine(sonuc1);

            
            sonuc1 = sayi1++ ;
            Console.WriteLine(sonuc1);

            // % : mod alır
            int sonuc2 = 20%3;
            Console.WriteLine(sonuc2);



        }
    }
}
