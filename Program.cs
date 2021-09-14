using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //№1 варіант 7
            /*
            Console.Write("r: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("h: ");
            double h = Convert.ToDouble(Console.ReadLine());

            double V = (Math.PI * r * r * h) / 3;
            Console.WriteLine($"V: {V}");
            */

            //№2 варіант 7
            /*
            Console.Write("nn: ");
            double nn = Convert.ToDouble(Console.ReadLine());
            Console.Write("nk: ");
            double nk = Convert.ToDouble(Console.ReadLine());

            if(0<=nn&&nn<=nk)
            { 

            double y = (nn*nn+Math.Pow(-1,nn-1)*2*nn-1)/(nn*nn+8);

            for(double i = nn+1 ; i < nk; i++)
            {
                y = (nn * nn + Math.Pow(-1, nn - 1) * 2 * nn - 1) / (nn * nn + 8);
            }

            Console.WriteLine($"Y: {y}");

            }
            else { Console.Write("Так не можна :("); }
            */

            //№3 варіант 17
            /*
            bool flag = true;

            Console.Write("x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            if(x1 == x2 || y1 == y2)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }

            Console.WriteLine(flag ? "TRUE" : "FALSE");  // output: Check
            */

            //№4 варіант 17
            /*
            Random rand = new Random();

            Console.Write("R: ");
            int R = Convert.ToInt32(Console.ReadLine());
            Console.Write("N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[N];
            int diff = 9999;
            int arrmin = 0;

            for(int i=0;i<N;i++)
            {
                arr[i] = rand.Next(10);
                Console.Write(arr[i]+" ");
            }

            for (int i = 0; i < N; i++)
            {
                if(Math.Abs(arr[i] - R)<diff)
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
            */

            Console.ReadKey();
        }
    }
}
