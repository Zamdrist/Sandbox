using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.ReadLine();
            var y = AddMe(1, 2);
        }

        private static int AddMe(int x, int y)
        {
            return x + y;

        }
    }
}
