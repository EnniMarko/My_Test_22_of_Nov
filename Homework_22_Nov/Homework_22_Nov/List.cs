using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_22_Nov
{
    class List: IList
    {
        private ListNode _last;
        private ListNode _head;
        private int amount = 0;
       
        public List(int value )
        {
            _head = new ListNode
            {
                index = 0,
                Value = value
            };
            _last = _head;
        } //constructor
        public ListNode this[int index]// indexer
        {
            get
            {
                var x = _head;
                while (index != x.index)
                {
                    x = x.Next;
                }
                return x;
            }
            set {this[index] = value; }
        }
        public void AddInEnd(int value)
        {
            var last = new ListNode
            {
                Value = value,
                index = ++amount
            };

            _last.Next = last;
            _last = last;
        }
        public void AddToBeginning(int value)
        {
            amount++;
            for (int i =amount - 1; i>=0; i--)
            {
                this[i].index = i + 1;
            }
            var newhead = new ListNode
            {
                Value = value,
                index = 0,
                Next = _head
            };
            _head = newhead;
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
        public void Remove(int index)
        {
            if(((amount - 1) >= index )&& (0<=index))
            {
                if (index == _last.index)
                {
                    this[index - 1].Next = null;
                }
                else if(index == 0)
                {
                    _head = this[index + 1];
                }
                else
                {
                    this[index - 1].Next = this[index].Next;
                }
                amount--;
                for (int i = index+1; i <= _last.index; i++)
                {
                    this[i].index = i - 1;
                }
            }
            else
            {
                Console.WriteLine("you typed wrong index;");
            }
        }
       
        
    }
}
