using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Images : File
    {
        private int _index = 0;
        public string Resolution;
        public Images(string _name, string _extension, string _size, string _resolution)
        {
            Name = _name;
            Extension = _extension;
            Size = _size;
            Resolution = _resolution;
            Index =  _index;
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
