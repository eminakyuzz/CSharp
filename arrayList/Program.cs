using System;
using System.Collections;
using System.Collections.Generic;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sytem.Collections namespace

            ArrayList liste = new ArrayList();
            // liste.Add("Elif");
            // liste.Add(23);
            // liste.Add(true);
            // liste.Add('A');

            // //içerisindeki verilere erişim
            // Console.WriteLine(liste[1]);

            // foreach (var item in liste)
            // {
            //     Console.WriteLine(item);
            // }

            //AddRange ---birden fazla elemanı toplu halde ekleme
            Console.WriteLine("*******AddRange*******");

            // string[] renkler = new string[]{"mavi","kırmızı","beyaz"};
            List<int> sayilar = new List<int>(){1,98,65,65,789,0,-6589};

            //liste.AddRange(renkler);
            liste.AddRange(sayilar);
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }


            //Sort----sıralama
            Console.WriteLine("******** Sort *********");
            liste.Sort();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            

            //Binary Search ---öncelikle sıralanmalı ve indexe öyle erişilmeli
            Console.WriteLine("-------- Binary Search -----------");
            var index = liste.BinarySearch(789);
            Console.WriteLine(index);
            

            //Reverse
            Console.WriteLine("--------- Reverse-----------");
            liste.Reverse();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Clear
            Console.WriteLine("-------- Clear ---------");
            liste.Clear();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }


        }
    }
}
