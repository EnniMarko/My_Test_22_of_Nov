using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Movies : File
    {
       
        public string Resolution;
        string Length;
        private int _index = 0;
        public Movies(string _name, string _extension, string _size, string _resolution,string _length)
        {
            Name = _name;
            Extension = _extension;
            Size = _size;
            Resolution = _resolution;
            Length = _length;
            Index = _index;
            _index++;
        }

        public override void GetData()
        {
            throw new NotImplementedException();
        }

        public override void Print()
        {
            throw new NotImplementedException();
        }
    }
}
