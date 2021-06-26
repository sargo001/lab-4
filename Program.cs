using System;

namespace laba_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа 4.");
            int v = 32;
            Console.WriteLine(+((v % 9) + 1) + " Вариант");
            Console.Write("РАЗМЕР МАССИВА= ");
            var len = int.Parse(Console.ReadLine());
            var array = new int[len];
            Console.Write("N= ");
            var n = int.Parse(Console.ReadLine());
            Console.Write("K= ");
            var k = int.Parse(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)

            {
                Console.Write("Элемент (" + i + ") = ");
                array[i] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Заменить что кратно N на K");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % n == 0)
                {
                    array[i] = k;

                }
                Console.WriteLine(array[i]);
            }

           
            



        }
    }
}
