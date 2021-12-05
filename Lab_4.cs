using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Lab_4
    {
        class disk_phone
        {
            public string self_number { get; set; }
            public string brand { get; set; }

            public void call(string number)
            {
                Console.WriteLine("Rotate disk and call to " + number);
            }
        }

        class button_phone : disk_phone
        {
            public void call(string number)
            {
                Console.WriteLine("Push buttons and call to " + number);
            }
        }

        class black_white_phone : button_phone
        {
            public string resolution { get; set; }
        }

        class colorful_phone : black_white_phone
        {
            public int color_amounts { get; set; }
        }

        class smartphone : colorful_phone
        {
            public void call(string number)
            {
                Console.WriteLine("Touch the screen and call to " + number);
            }
        }

        class Program
        {
            static void print(smartphone print)
            {
                Console.WriteLine(print.self_number);
                Console.WriteLine(print.brand);
                Console.WriteLine(print.resolution);
                Console.WriteLine(print.color_amounts);
            }

            static void Main(string[] args)
            {
                smartphone Redmi = new smartphone();

                Redmi.self_number = "0503426017";
                Redmi.brand = "Xiaomi";
                Redmi.resolution = "1080 x 2400";
                Redmi.color_amounts = 16000000;

                print(Redmi);
                Redmi.call("0936235234");

                Console.ReadKey();

            }
        }
    }
}
