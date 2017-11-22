using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Text : File
    {
        private int _index = 0;
        public string Content;
        public Text(string _name, string _extension, string _size, string _content)
        {
            Name = _name;
            Extension = _extension;
            Size = _size;
            Content = _content; 
            Index = _index;
            _index++;
        }
        public override void GetData()
        {
            throw new NotImplementedException();
        }

        public override void Print()
        {
            
        }
    }
}
