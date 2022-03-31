using System;

namespace struct_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdörtgen dikdörtgen = new Dikdörtgen();
            // dikdörtgen.KisaKenar = 3 ;
            // dikdörtgen.UzunKenar = 5 ;
            System.Console.WriteLine("class alan hesabı :{0}", dikdörtgen.AlanHesapla());

            Dikdörtgen_Struct dikdörtgen_struct = new Dikdörtgen_Struct(3,4); //struct newlenebilir ve böyle de kullanılabilir.
            
            System.Console.WriteLine("struct alan hesabı :{0}",dikdörtgen_struct.AlanHesapla());           
        }
    }
    class Dikdörtgen
    {
        public int KisaKenar;
        public int UzunKenar;

        // public Dikdörtgen()
        // {
        //     KisaKenar = 3 ;
        //     UzunKenar = 4 ;
        // }

        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }
    struct Dikdörtgen_Struct
    {
        public int KisaKenar;
        public int UzunKenar;

        public Dikdörtgen_Struct(int kisaKenar, int uzunKenar) //struct lar parametreli construct  yapabilir.
        {
            
            KisaKenar = kisaKenar;
            UzunKenar = uzunKenar ;
        }

        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }


    }
}
