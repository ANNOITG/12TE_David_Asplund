using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._1
{
    class Program
    {
        static void Hello(string namn)
        {
            Console.WriteLine("Hello " + namn + "!");
        }
        static void Main(string[] args)
        {
            Hello("");
            Console.ReadKey();
        }
    }
}
