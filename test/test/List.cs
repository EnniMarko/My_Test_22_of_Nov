using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class List
    {
        private ListNode _last;
        private ListNode _head;
        private int _index = 0;
       
        public List(int value )
        {
            _head = new ListNode
            {
               
                Value = value
            };
            _last = _head;
        }
        public void Add(int value)
        {
            var last = new ListNode
            {
                Value = value,
                index = ++_index
            };

            _last.Next = last;
            _last = last;
        }
        public void Print()
        {
            var x = _head;
            while(x != null)
            {

                Console.WriteLine(x.Value);
                x = x.Next;
            }
        }
        public ListNode this[int index]
        {
            get
            {
                var x = _head;
                while (index != _index)
                {
                    x = x.Next;
                }
                return x;
            }
        }
        
    }
}
