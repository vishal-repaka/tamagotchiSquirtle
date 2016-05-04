using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class stat
    {
        public static int hunger = 40;
        public static int mood = 100;
        public static int sleep = 40;
        public static int thirst = 40;
        public static int boredom = 100;

        public static void statchangerB()
        {
            boredom = boredom - 5;

            if (boredom <= 40)
            {
                mood = mood - 1;
            }

            if (boredom < 0)
            {
                boredom = 0;
            }

        }


        public static void statchangerH()
        {
            hunger = hunger - 1;

            if (hunger <= 10)
            {
                mood = mood - 5;
            }

        }

        public static void statchangerM()
        {
            mood = mood - 1;
        }

        public static void statchangerS()
        {
            sleep = sleep - 1;

            if (sleep <= 10)
            {
                mood = mood - 5;
            }
        }

        public static void statchangerT()
        {
            thirst = thirst - 1;

            if (thirst <= 10)
            {
                mood = mood - 5;
            }
        }

    }

    class mood
    {
        

        public static void moodcheck()
        {
           
                    if (stat.mood > 70)
                    {
                        Console.WriteLine("Pet is happy");
                    }
                 
                    else if (stat.mood > 50)
                    {
                        Console.WriteLine("Pet is neutral");
                    }
                  
                    else if (stat.mood > 40)
                    {
                        Console.WriteLine("Pet is lonely");
                    }
                  
                    else if (stat.mood > 10)
                    {
                        Console.WriteLine("Pet is sad");
                    }
                    
                    else if (stat.mood > 1)
                    {
                        Console.WriteLine("Pet is angry");
                    }
                   
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
           int oldtime = 0;
                
            
            while (true)
            {
                Console.Clear();
                Int32 tc = Environment.TickCount;
                mood.moodcheck();
                Console.WriteLine("mood = " + stat.mood);
                Console.WriteLine("hunger = " + stat.hunger);
                Console.WriteLine("thirst = " + stat.thirst);
                Console.WriteLine("sleep = " + stat.sleep);
                Console.WriteLine("bordeom = " + stat.boredom);

                if (tc > oldtime + 900)
                {
                    stat.statchangerB();
                    stat.statchangerH();
                    stat.statchangerS();
                    stat.statchangerT();
                    stat.statchangerM();
                    oldtime = tc;
                }

                if (stat.mood < 0)
                {
                    break;
                }

                System.Threading.Thread.Sleep(1000);
               


            }

            Console.WriteLine("Pet has ran away");
            Console.ReadLine();
        }
    }
}
