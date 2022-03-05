using System;

namespace metot_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi = "999";

            int outSayi ;
            bool sonuc = int.TryParse(sayi,out outSayi);

            if (sonuc)
            {
                Console.WriteLine("Başarılı....");
                Console.Write(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız.....");
            }
        }
    }
}
