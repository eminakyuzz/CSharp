using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> kullanıcılar = new Dictionary<int, string>();
            kullanıcılar.Add(1,"ayse yilmaz");
            kullanıcılar.Add(45,"veli ali");
            kullanıcılar.Add(4,"deniz arda");
            kullanıcılar.Add(7,"hüseyin rahmi");

            //Dizinin elemanlarına erişim
            Console.WriteLine("------------Dizi Elamnlarına Erişism---------------");
            Console.WriteLine(kullanıcılar[45]);
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item);
            }

            //Count
            Console.WriteLine("--------- Count ---------");
            Console.WriteLine(kullanıcılar.Count);

            //Contains -- var mı --- bool değer döndürür
            Console.WriteLine("******** Contains *********");
            Console.WriteLine(kullanıcılar.ContainsKey(7));
            Console.WriteLine(kullanıcılar.ContainsValue("emin arslan"));

            //Remove -- eleman çıkarma
            Console.WriteLine("********* Remove***********");
            kullanıcılar.Remove(4);

            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item.Value);
                Console.WriteLine(item.Key);
            }

            //Keys
            Console.WriteLine("********* Keys ***********");

            foreach (var item in kullanıcılar.Keys)
            {
                Console.WriteLine(item);
            }

            //Values
            Console.WriteLine("********* Values ***********");

            foreach (var item in kullanıcılar.Values)
            {
                Console.WriteLine(item);
            }


        }
    }
}
