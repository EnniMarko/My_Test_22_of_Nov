using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_22_Nov
{
    interface IList
    {
        ListNode this[int index] { get; set; }
        void AddInEnd(int value);
        void Remove(int index);
    }
}
