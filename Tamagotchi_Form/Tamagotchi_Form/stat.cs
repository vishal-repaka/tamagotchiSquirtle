using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class stat
    {
        public static int hunger = 100;
        public static int mood = 100;
        public static int sleep = 100;
        public static int thirst = 100;
        public static int boredom = 100;
        public static int energy = 10;
        public static int Sleeptime = 60;
        public static int Actiontime = 5;
        public static int Exercisetime = 20;
        public static int fitnesslevel = 0;
        public static int idleness = 0;
        public static int IgnoreTime = 0;

        public static void statchangerB()
        {
            boredom = boredom - 2;

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

            if (hunger < 0)
            {
                hunger = 0;
            }

        }

        public static void statchangerM()
        {
            mood = mood - 1;

            if (mood > 90)
            {

            }
        }

        public static void statchangerS()
        {
            sleep = sleep - 1;

            if (sleep <= 10)
            {
                mood = mood - 5;
            }
            if (sleep < 0)
            {
                sleep = 0;
            }
        }

        public static void statchangerT()
        {
            thirst = thirst - 1;

            if (thirst <= 10)
            {
                mood = mood - 5;
            }

            if (thirst < 0)
            {
                thirst = 0;
            }
        }

    }
}
