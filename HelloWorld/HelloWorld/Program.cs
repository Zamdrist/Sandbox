using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.ReadLine();
            var y = AddMe(1, 2);
            var doc = new HtmlDocument();
            
        }

        private static int AddMe(int x, int y)
        {
            return x + y;

        }
    }
}
