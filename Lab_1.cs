using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        
        static void ArrayReverse(int[] arr , int N)
        {
            for(int i=N-1; i>=0; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }
        
        static void Main(string[] args)
        {
            //1.4
            
            Random rand = new Random();

            Console.Write("N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[N];
            

            for (int i = 0; i < N; i++)
            {
                arr[i] = rand.Next(10);
                Console.Write(arr[i] + " ");
            }
            Console.ReadLine();
            ArrayReverse(arr, N);
            
        }
    }
}
