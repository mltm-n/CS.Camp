using System;

namespace ValueAndReference
{
    class Program
    {
        static void Main(string[] args)
        {

            //array, class, interface - referans tip
            //int, decimal, float, double, bool - değer tip
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);

            /*       stack                      heap
             *!101! sayilar1  -------> !101! [10,20,30]  //101, 102 oldu.
             *!102! sayilar2 --------> !102! [100,200,300] //ilk sayi(100), 999 oldu.
             **/
        }
    }
}
