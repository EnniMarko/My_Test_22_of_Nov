﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Text : File
    {
        static private int _index = 0;
        public string Content;
        public Text(string str)
        {
            int k = 0;
            int j = 0;
            j = str.IndexOf(".", 5);
            int z = j - 5;
            Name = str.Substring(5, z);
            k = j + 1;
            j = str.IndexOf('(', k);
            z = j - k;
            Extension = str.Substring(k, z);
            k = j + 1;
            j = str.IndexOf(')', k);
            z = j - k;
            Size = str.Substring(k, z);
            k = j + 2;
            j = str.Length - 1;
            z = j - k;
            Content = str.Substring(k, z);
            _realsize = GetRealSize(Size);
            Index = _index++;
        }
        public static void Print(Text[] arr)
        {
            Console.WriteLine("Movies:");
            int i = 0;
            while(arr[i]!= null)
            {
                Console.WriteLine("\t" + arr[i].Name + "." + arr[i].Extension);
                Console.WriteLine("\t\tExtension:" + arr[i].Extension);
                Console.WriteLine("\t\tSize:" + arr[i].Size);
                Console.WriteLine("\t\tContent:" + arr[i].Content);
                i++;
            }
        }
        public static void BubbleSort(Text[] array)
        {
            int count = 0;
            while (array[count] != null)
            {
                count++;
            }
            Text[] buf = new Text[count];
            for (int j = 0; j < count; j++)
            {
                buf[j] = array[count];
            }
            array = buf;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j + 1] != null)
                    {
                        if (array[j]._realsize < array[j + 1]._realsize)
                        {
                            var temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                    else break;
                }
            }
            
        }
    }
}
