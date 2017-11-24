using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    abstract class File
    {
        protected int _realsize;
        public int Index = 0 ;
        public File this[int index]
        {
            get { return this[index]; }

            set { this[index] = value; }
        }
        public string Extension { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        //abstract  public void Print();
        public int GetRealSize(string size)
        {
            int modifier = 0;
            if (size.Contains("GB"))
            {
                modifier = 1000000000;
            }
            else if (size.Contains("MB"))
            {
                modifier = 1000000;
            }
            else if (size.Contains("kB"))
            {
                modifier = 1000;
            }
            else if (size.Contains("B"))
            {
                modifier = 1;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("SOMTHING IS GOING WROMG");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            int pos = 0;
            while (!Char.IsLetter(size[pos]))
            {
                ++pos;
            }

            int IntSize = int.Parse(size.Substring(0, size.Length - pos));
            IntSize *= modifier;
            return IntSize;
        }

    }
}
