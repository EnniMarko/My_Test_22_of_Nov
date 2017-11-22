using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new List(5);
            x.Add(4);
            x.Add(7);
            x.Add(8);
            x.Add(100);
            x.Print();
            Console.Read();
            
            Console.WriteLine("============================ \n"+ x[3]);
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
