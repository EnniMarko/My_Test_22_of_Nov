using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main()// Так и не понял, где у меня ошибка в сортировке
        {
            
            string str = @"Text:file.txt(6B);Some string content
Image:img.bmp(19MB);1920х1080
Text:data.txt(12B);Another string
Text:data1.txt(7B);Yet another string
Movie:logan.2017.mkv(19GB);1920х1080;2h12m";
            int subStringCount = 1;
            for (int i = 0; i < str.Length; i++)
            {
                if(str[i]== '\n')
                {
                    subStringCount++;
                }
            }
            string[] sub = new string[subStringCount];
            sub = str.Split('\n');
            Image[] images = new Image[100];
            int imagesCount = 0;
            Text[] texts = new Text[100];
            int textsCount = 0;
            Movie[] movies = new Movie[100];//just to check how it works
            int moviesCount = 0; 
            for (int i = 0; i < sub.Length; i++)
            {                
                if (sub[i].Contains("Image:"))
                {                   
                    images[imagesCount] = new Image(sub[i]);
                    imagesCount++;
                }
                if (sub[i].Contains("Movie"))
                {
                    movies[moviesCount] = new Movie(sub[i]);
                    moviesCount++;
                }
                if (sub[i].Contains("Text:"))
                {
                    texts[textsCount] = new Text(sub[i]);
                    textsCount++;
                }
            }
            Image.BubbleSort(images);
            Text.BubbleSort(texts);
            Movie.BubbleSort(movies);
            Image.Print(images);
            Text.Print(texts);
            Movie.Print(movies);
            Console.Read();

        }
    }
}
