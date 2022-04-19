using System;

namespace Delegate
{
    class Program
    {
        /*
         *Delegateler bir nevi metod pointerlarıdır.
         *Yani metodları yönetirler
         *Delegate tipinden bir nesne türetip rahatlıkla işlemler yapmamızı sağlarlar.
         * 
         * Aşağıdaki örnekte çevre ve alan hesabı yapan metodlarımın ana metodum içerisinde delegateden nesne türetip parametre geçirerek kullandım.
         * Ayrıca Delegate ın  parametresi içindeki değişkenlerinde aşağıdakilerle aynı olma zorunluluğu yoktur.
         */

        delegate double Dikdörtgen(double x, double y);
        static void Main(string[] args)
        {
            Dikdörtgen test = new Dikdörtgen(alan);
            Console.WriteLine(test(5,7));
           
            Dikdörtgen test2 = new Dikdörtgen(cevre);
            Console.WriteLine(test2(10,25));
            Console.ReadKey();
        }
        static double cevre(double a, double b)
        {
            return 2 * (a + b);
        }
        static double alan(double a , double b)
        {
            return a * b;
        }
    }
}
