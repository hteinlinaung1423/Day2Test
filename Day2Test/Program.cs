using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2;
            int result = 0;
            result = a + b;
            int i2 = 25;
            double d = 23445533455534555;
            Console.WriteLine(result);
            Console.WriteLine("*\n**\n***");
            Console.WriteLine('=');
            Console.WriteLine("{0:0,0000.00}", d);
            double x = 123;
            double y = 33.334;
            Console.WriteLine("{0}    {1}", x, y);
            Console.WriteLine("{0:0.0}    {1:0.0} :with zero", x, y);
            Console.WriteLine("{0:#.#}    {1:#.#}  :with #", x, y);
            Console.WriteLine("{0:0000}", x);
            Console.WriteLine("{0:0}", x);
            Console.WriteLine("{0:###00}", x);
            long l = 2;
            int i = 5;
            i = (int)l;//Type Cast
            Console.WriteLine(i2);
            Console.WriteLine("I'm Htein Lin Aung from Myanmar.");
        }
    }
}
