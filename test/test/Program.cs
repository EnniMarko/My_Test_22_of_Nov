using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string str = @"Text:file.txt(6B);Some string content
    Image: img.bmp(19MB); 1920х1080
    Text:data.txt(12B); Another string
    Text:data1.txt(7B); Yet another string
    Movie:logan.2017.mkv(19GB); 1920х1080; 2h12m";
            int count = 0;
            for (i = 0; i < str.Length; i++)
            {
                if(str[i]== '\n')
                {
                    count++;
                }
            }
            string[] sub = new string[count];
            for (int i = 0; i < sub.Length; i++)
            {
                if (sub[i].Contains("Image:"))
                {

                }
                if (sub[i].Contains("Movie"))
                {

                }
                if (sub[i].Contains("Text:"))
                {
                    
                }
            }
        }
    }
}
