using System;

namespace karar_yapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            //Expression -- kontrol edilmek istenen durum
            switch (month)
            {
                
                case 1:
                    Console.WriteLine("Ocak");
                    break;

                case 2:
                    Console.WriteLine("Şubat");
                    break;

                case 3:
                    Console.WriteLine("Mart");
                    break;

                case 4:
                    Console.WriteLine("Nisan");
                    break;


                default:
                break;
            }
            switch (month)
            {
                case 12: 
                case 1:
                case 2:
                    Console.WriteLine("Kış mevsimi");
                    break;

                case 3: 
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar mevsimi");
                    break;
                

                default:
                break;
            }
        }
    }
}
