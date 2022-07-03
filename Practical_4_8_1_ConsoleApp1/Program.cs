using System;

namespace Practical_4_8_1_ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue; // объявдение переменной минимума
            Console.Write(" Введите длину последовательности :");
            int length = int.Parse(Console.ReadLine()); // объявление длины массива
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write(" Введите числа :");
                array[i] = int.Parse(Console.ReadLine());

            }
            {
                for (int i = 0; i < length; i++) //цикл проверки минимума
                    if (array[i] < min)
                    {
                        min = array[i];
                    }
            }
            Console.WriteLine(" Минимальное число в последовательности :{0}", min);
            Console.ReadLine();
        }
    }
}
