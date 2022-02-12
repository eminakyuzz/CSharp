using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {

            // try
            // {
            //     Console.WriteLine("bir sayı giriniz:");
            //     int sayı = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("Girilen sayı :"+ sayı);
            // }
            // catch(Exception ex)
            // {
            //     Console.WriteLine("Hata :" + ex.Message.ToString());
            // }
            // finally
            // {
            //     Console.WriteLine("İşlem Tamamlandı!");
            // }
            
            Console.WriteLine("*******************************");

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("mksd");
                int a = int.Parse("555555555555555555555555555");
            }
            catch (ArgumentNullException ex)
            {
                
                Console.WriteLine("boş değer girdiniz");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("veri tipi uygun değil");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("çok küçük ya da çok büyük bir değer girdiniz!!!!!!!!!");
                Console.WriteLine(ex);
            }
        }
    }
}
