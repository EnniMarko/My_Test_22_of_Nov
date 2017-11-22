using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_22_Nov
{
    class Program
    {
        static void Main()
        {
            var x = new List(5);
            x.AddInEnd(4);
            x.AddInEnd(7);
            x.AddInEnd(8);
            x.AddInEnd(100);
            x.AddToBeginning(1000);
            x.Remove(0);
            x.Print();

            Console.Read();

            Console.WriteLine("============================ \n"+ x[3].Value );
            
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
