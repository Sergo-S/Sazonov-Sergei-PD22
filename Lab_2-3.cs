using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //2.6 Перевірити істинність вислову: "Сума двох перших цифр даного чотиризначного числа рівна сумі двох його останніх цифр".
            /*
            Console.Write("n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int a = n/1000;
            int b = (n / 100)%10 ;
            int m = (n % 100) / 10 ;
            int k = (n % 100) % 10;
            if (a+b == m+k)
            {
                Console.Write(true);
            }
            else
            {
                Console.Write(false);
            }
           
            */

            //3.17 Дано дійсне число R і масив розміру N. Знайти елемент масиву, який найближчий (найдальший) від даного числа. 

            Random rand = new Random();

            Console.Write("R: ");
            int R = Convert.ToInt32(Console.ReadLine());
            Console.Write("N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[N];
            int diff = 9999;
            int arrmin = 0;

            for (int i = 0; i < N; i++)
            {
                arr[i] = rand.Next(10);
                Console.Write(arr[i] + " ");
            }

            for (int i = 0; i < N; i++)
            {
                if (Math.Abs(arr[i] - R) < diff)
                {
                    diff = Math.Abs(arr[i] - R);
                    arrmin = arr[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Найближчий: {arrmin}");

            for (int i = 0; i < N; i++)
            {
                if (Math.Abs(arr[i] - R) > diff)
                {
                    diff = Math.Abs(arr[i] - R);
                    arrmin = arr[i];
                }
            }
            Console.WriteLine($"Найдальший: {arrmin}");

            Console.ReadKey();
        }
    }
}
