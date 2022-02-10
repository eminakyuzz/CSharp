using System;

namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = " ";

            byte b=5;       // bellekte 1 byte yer kaplar      0-255 arası değer alabilir

            sbyte c=10;     // bellekte 1 byte yer kaplar     -128 ile +127 arası değer alabilir

            short s=5;      // bellekte 2 byte yer kaplar -32.768 le +32.768 arası değer alabilir

            ushort us =5;   // bellekte 2 bute yer kaplar  0- 65.365 arası değer alabilir

            Int16 i16 =2;   // bellkete 2 byte yer kaplar  

            int i = 4;      // 4 byte

            Int32 i32 = 2;  // 4 byte

            Int64 i64 =2;   // 8 byte

            uint ui=2;      // 4 byte

            long l = 4;      // 8 byte

            ulong ul = 4 ;   // 8 byte

            float f= 5;     // 4 byte

            double d = 5.15;   // 8 byte

            decimal de= 5;     // 16 byte

            char karakter = 'a'; // 2 byte

            string str = "Emin"; // sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "abas";
            object o2 = 'd';
            object o3 = 54;
            object o4 = 45.45;


            //string ifadeler

            string str1 = string.Empty;
            str1 = "Emin ";
            string Name= "Emin";
            string LastName= "Arslan";
            string FullName = Name+" "+LastName;

            // integer tanımlama şekilleri

            int i1 =5;
            int i2 =6;
            int i3 =i1*i2;

            // boolean

            bool bool1 = 10<2;      // false atama
            bool bool2 = 10>2;      // true atama


            //Değişken Dönüşümleri
            
            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString(); // int20 ' yi string değere dönüştürdü
            Console.WriteLine(yeniDeger);


            int int21 = int20 + Convert.ToInt32(str20);  //str20 ' yi int32' ye dönüştürdü
            Console.WriteLine(int21+" "+"Convert Metodu");

            int int22 = int20 + int.Parse(str20);  //str20' yi integer' a dönüştürdü 
            Console.WriteLine(int22+" "+"Parse Metodu");

            string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dateTime);

            string dateTime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(dateTime2);


            // saat
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);

            
        }
    }
}
