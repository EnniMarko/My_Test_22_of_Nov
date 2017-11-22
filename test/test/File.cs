using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    abstract class File
    {
        protected int Index = 0 ;
        public int this[int index]
        {
            get { return this[index]; }

            set { this[index] = value; }
        }
        public string Extension { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        abstract  public void Print();
        abstract public void GetData();
    }
}
