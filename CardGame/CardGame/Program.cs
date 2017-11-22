using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Program
    {
        public enum Suit
        {
            clumb = 1, hearts, spades, diamonds
        }
        public enum Rank
        {
            six, seven, eight, nine, ten, jack, queen, king, ace
        }
        public struct Card
        {
            public Suit suit;
            public Rank rank;
        }
        
        static void PrintCards(Card[] _pack)
        {
            for (int i = 0; i < _pack.Length; i++)
            {
                Console.WriteLine(_pack[i].suit + "   \t" + _pack[i].rank);
            }
        }
        static int PointsCount(Card[] hand)
        {
            int points = 0;
            int aceInHandCount = 0;
            if ((hand.Length == 2) && (hand[0].rank == Rank.ace) && (hand[1].rank == Rank.ace))
            {
                return 21;
            }
            
                for (int i = 0; i < hand.Length; i++)
                {
                    if (hand[i].rank == Rank.ace)
                    {
                        points += 11;
                        aceInHandCount++;
                    }
                    else if (hand[i].rank == Rank.eight)
                    {
                        points += 8;
                    }
                    else if (hand[i].rank == Rank.jack)
                    {
                        points += 2;
                    }
                    else if (hand[i].rank == Rank.king)
                    {
                        points += 4;
                    }
                    else if (hand[i].rank == Rank.nine)
                    {
                        points += 9;
                    }
                    else if (hand[i].rank == Rank.queen)
                    {
                        points += 3;
                    }
                    else if (hand[i].rank == Rank.seven)
                    {
                        points += 7;
                    }
                    else if (hand[i].rank == Rank.six)
                    {
                        points += 6;
                    }
                    else if (hand[i].rank == Rank.ten)
                    {
                        points += 10;
                    }

                    while((points > 21)&&(aceInHandCount>0)) //check if more then 21 points, count aces 
                    //like 1, but not like 11 
                {
                    points -= 10;
                    aceInHandCount--;
                }
                
            }
                return points;
        }
        static void ShufflePack(Card[] _pack)
        {
            Random rand = new Random();
            for (int i = 35; i > 0; i--)//randomise(shuffle)
            {
                int random = rand.Next(0, i + 1);
                var temp = _pack[random];
                _pack[random] = _pack[i];
                _pack[i] = temp;
            }
        }
        static Card[] GeneratePack()
        {
            Card[] _pack = new Card[36];
            int i = 0;
            foreach (var suitName in Enum.GetNames(typeof(Suit)))
            {
                foreach (var rankName in Enum.GetNames(typeof(Rank)))
                {

                    _pack[i] = new Card();
                    _pack[i].suit = (Suit)Enum.Parse(typeof(Suit), suitName);
                    _pack[i].rank = (Rank)Enum.Parse(typeof(Rank), rankName);
                    i++;
                }
            }
            return _pack;
        }
        static Card[] AddCardTo(Card[] Hand,  ref Card[] FromPack)
        {
            var buff = Hand;
            Hand = new Card[Hand.Length + 1];
            for (int i = 0; i < buff.Length; i++)
            {
                Hand[i] = buff[i];
            }
            Hand[buff.Length] = FromPack[0];
            buff = FromPack;
            FromPack = new Card[FromPack.Length - 1];
            for (int i = 0; i < buff.Length -1; i++)
            {
                FromPack[i] = buff[i+1];
            }
            return Hand;
        }
        static bool? ComparePoints(int points1, int points2)
        {
            if (points1 > 21 && points2 < 21)
            {
                return false;
            }
            else if (points1 < 21 && points2 > 21)
            {
                return true;
            }
            else if( points1>21 && points2>21)
            {
                return (points1 < points2) ? true : false; 
            }
            if (points1 > points2)
            {
                return true;
            }
            else if (points2 > points1)
            {
                return false;
            }
            else return null;
        }
        static void Help()
        {
            Console.WriteLine(@"game has 36 cards
cost of cards in points: Ace - 11 points; King - 4 points; Lady - 3 points; Jack - 2 points; The other cards at their value
2 players (you and computer)
the goal of the game is to collect 21 points
at first you should enter who receives first cards 
you and computer receive 2 cards
after that one of you decide what do you want? get one more card or stop receiving cards (depends on who started the game first)
also the computer must make the same decision
if one of you receive 21 points or 2 aces, game is over and win player with 21 points or 2 aces
if one of players receive more than 21 points game is over, but at the end of round (example: you receive first cards and after that receive third card and has more than 21 points, so in this way computer should also make decision stop receiving the third card or get one more because you received first cards, you started the game first)
if both of you have more than 21 points game is over and win player with fewer points
*after game make possible to continue and start new one (example: you or computer won the game and system ask you “Do you want to start new game? Yes\No”, you print “Yes” and new game is starting
*if you decide to completely stop the game (print “No”), you must view games score (example: you won 3 times, computer won 2 times)
");
            Console.Read();
        }
        static void Main()
        {
            int timesCompWon=0;
            int timesMeWon = 0;
            Flag:
            Console.WriteLine("Do you want to see rules?(Yes/No)");
           // if (ToContinue())
            //{
            //    Help();
            //}
            bool CompInGame = true;
            bool PlayerInGame = true;
            Card[] Pack = GeneratePack();
            ShufflePack(Pack);
            Card[] MyHand = new Card[0];
            Card[] CompHand = new Card[0];
            MyHand = AddCardTo(MyHand, ref Pack);
            MyHand = AddCardTo(MyHand, ref Pack);
            CompHand = AddCardTo(CompHand, ref Pack);
            CompHand = AddCardTo(CompHand, ref Pack);
            bool whoFirstTurn = WhoFirstTurn();
            if (whoFirstTurn)
            {
                while ((PlayerInGame || CompInGame))
                {
                    
                    if (PlayerInGame&&whoFirstTurn)
                    {
                        Console.WriteLine("computer has"+CompHand.Length+"cards \n here is you cards: ");
                        PrintCards(MyHand);
                        Console.WriteLine("Your points is: " + PointsCount(MyHand) + "\t do you want to continue recieving cards?(Yes/No)");
                        if (ToContinue())
                        {
                            MyHand = AddCardTo(MyHand, ref Pack);
                            if (PointsCount(MyHand) > 21)
                            {
                                PlayerInGame = false;
                                PrintCards(MyHand);
                                Console.WriteLine("You have more than 21 points(" + PointsCount(MyHand) + "), you can't make turns anymore");
                            }
                        }
                        else
                        {
                            PlayerInGame = false;
                        }
                    }
                    if (CompInGame)
                    {
                        if (PointsCount(CompHand)> 15)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("Computer doesn't need cards anymore, he has"+ CompHand.Length + " cards now" );
                            Console.BackgroundColor = ConsoleColor.Black;
                            CompInGame = false;
                        }
                        else
                        {
                             CompHand = AddCardTo(CompHand, ref Pack);
                        }
                    }
                    if ( PlayerInGame && (!(whoFirstTurn) ) )
                    {
                        Console.WriteLine("computer has" + CompHand.Length + "cards \n here is you cards: ");
                        PrintCards(MyHand);
                        Console.WriteLine("Your points is: " + PointsCount(MyHand) + "\t do you want to continue recieving cards?(Yes/No)");
                        if (ToContinue())
                        {
                            MyHand = AddCardTo(MyHand, ref Pack);
                            if (PointsCount(MyHand) > 21)
                            {
                                PlayerInGame = false;
                                PrintCards(MyHand);
                                Console.WriteLine("You have more than 21 points(" + PointsCount(MyHand) + "), you can't make turns anymore");
                            }
                        }
                        else
                        {
                            PlayerInGame = false;
                        }
                    }
                }
                bool? win = ComparePoints(PointsCount(MyHand), PointsCount(CompHand));
              
                if(win == null)
                {
                    Console.WriteLine("Noone wins this time");
                }
                else if(win==true)
                {
                    Console.WriteLine("Congratulations! Player wins With score you:{0}, computer:{1}", PointsCount(MyHand), PointsCount(CompHand) );
                }
                else
                {
                    Console.WriteLine("Computer wins With score you:{0}, computer:{1}",PointsCount(MyHand),PointsCount(CompHand) );
                    Console.WriteLine("Computer cards:");
                    PrintCards(CompHand);
                }
            }
            Console.WriteLine("Do you want to continue?(yes/no)");
            if (ToContinue())
            {
                Console.Clear();
                goto Flag;
            }
            else
            {
                Console.WriteLine("Computer won {0} times" ,timesCompWon);
                Console.WriteLine("You won {0} times" , timesMeWon);
            }
        }
        static bool WhoFirstTurn()//true - Player, false - computer;
        {
            bool res = true;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Who will get cards first you(type: Me) or Computer(type: He)");         
                string str = Console.ReadLine();
                if ((str == "he") || (str == "He") || (str == "HE"))
                {
                    res = false;
                }
                else if ((str == "me") || (str == "Me") || (str == "ME"))
                {
                    res = true;
                }
                else
                {
                    Console.WriteLine("I didn't understand you, try once again, please:");
                    Console.Read();
                    continue;
                }
                break;
            }  
            return res;
        }
        static bool ToContinue()//true - yes
        {
            bool res;
            while (true)
            {
                string str = Console.ReadLine();
                if ((str == "yes") || (str == "Yes") || (str == "YES"))
                {
                    res = true;
                }
                else if ((str == "no") || (str == "No") || (str == "NO"))
                {
                    res = false;
                }
                else
                {
                    Console.WriteLine("I didn't understand you, try once again, please:");
                    Console.Read();
                    continue;
                }
                break;
            }
            return res;
        }
}
        
}
