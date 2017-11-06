using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    enum genres
    {
        rock,soul,pop, folk
    }
    struct song
    {
        public string Name;
        public string Authors;
        public int LengthInSeconds;
        public genres Genre;
    }
    class Program
    {
        static song[] method(song[] x)
        {

            Console.WriteLine("do you want to add or delete?(add,delete)");
            string str = Console.ReadLine();
            if (str ==" delete")
            {
                Console.WriteLine("choose index of song you want to delete: ");
                int c = int.Parse(Console.ReadLine());
                for (int i = 0; i < x.Length; i++)
                {
                    
                }
            }
            else if( str == "add")
            {

            }
            return x;
        } 
        static void Main()
        {
            string t = "Theos";
            song[] songlist = new song[5];
            songlist[0].Authors = "mary poppins";
            songlist[1].Authors = t;
            songlist[2].Authors = "unknown";
            songlist[3].Authors = "some drunk guy";
            songlist[4].Authors = "Metallica";
            songlist[0].Genre = genres.folk;
            songlist[1].Genre = genres.pop;
            songlist[2].Genre = genres.rock;
            songlist[3].Genre = genres.soul;
            songlist[4].Genre = genres.rock;
            songlist[0].LengthInSeconds = 120;
            songlist[1].LengthInSeconds = 130;
            songlist[2].LengthInSeconds = 159;
            songlist[3].LengthInSeconds = 123;
            songlist[4].LengthInSeconds = 160;
            songlist[0].Name = "test";
            songlist[1].Name = "sets4";
            songlist[2].Name = "unknown";
            songlist[3].Name = "i am drunk";
            songlist[4].Name = "heaven";
            int door; 
            if(int.TryParse(Console.ReadLine(), out  door))
            {
                Console.WriteLine("you choosed {0} song {1}", door, songlist[door].Name);
                songlist[door].Name = Console.ReadLine();
                for (int j = 0; j <5 ; j++)
                {
                    Console.WriteLine(songlist[j].Name +"\t"+ songlist[j].Authors+"\t"+ songlist[j].Genre+"\t"+ songlist[j].LengthInSeconds+"seconds");
                } 
            }
            else
            {
                Console.WriteLine("WRONG NUMBER");
            }
            int number =0 , max = 0;

            for (int j = 0; j < 5; j++)
            {
                if (max < songlist[j].LengthInSeconds)
                {
                    number = j;                    
                    max = songlist[j].LengthInSeconds;
                }
            }
            Console.WriteLine("the longest song is:");
            Console.WriteLine(songlist[number].Name + "\t" + songlist[number].Authors + "\t" + songlist[number].Genre + "\t" + songlist[number].LengthInSeconds + "seconds");
            Console.WriteLine();
            Console.WriteLine("plese now type the genre you want(rock,soul,pop, folk):");
            string factor = Console.ReadLine();
           var x =Enum.Parse((typeof(genres)), factor);
            for (int j = 0; j < 5; j++)
                {
                if((genres)x == songlist[j].Genre )
                    {
                    Console.WriteLine(songlist[j].Name + "\t" + songlist[j].Authors + "\t" + songlist[j].Genre + "\t" + songlist[j].LengthInSeconds + "seconds");
                    }
                }
            Console.ReadLine();
            //4
            Console.WriteLine("do you want to add or delete songs?(yes,no)");
            if (Console.ReadLine() == "yes")
            {
                method(songlist);   
            }           
        }
    }
}