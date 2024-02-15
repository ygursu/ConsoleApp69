using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace klavyedengirilensayininkarsilastirilma
{
    class Program
    {
        static void Main(string[] args)
        {

            //Klavyeden girilen iki sayıyı karşılaştıran C# programını yazın. ( Hangisinin büyük olduğunu söyleyecek)

            Console.WriteLine("Lütfen 1. sayıyı giriniz");
            int sayi1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 2. sayıyı giriniz");
            int sayi2 = Int32.Parse(Console.ReadLine());

            if (sayi1 > sayi2)
            {
                Console.WriteLine("1. sayı 2. sayıdan büyük");
            }
            else if (sayi2 > sayi1)
            {
                Console.WriteLine("2. sayı 1. sayıdan büyük");
            }
            else
            {
                Console.WriteLine("1. sayı 2. sayıya eşit");
            }

            Console.ReadLine();


        }
    }
}
