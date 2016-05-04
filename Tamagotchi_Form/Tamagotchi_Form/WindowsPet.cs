using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class WindowsPet : Form
    {
        public WindowsPet()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------Actions------------------------------------------------//
        private void Pat_Click(object sender, EventArgs e)
        {
            if (stat.energy >= 1)
            {
                stat.idleness = 0;
                Pat.Enabled = false;
                stat.energy--;
                StatTimer.Enabled = false;
                Petting.Enabled = true;
                visibleoff();
                StatCheck.Enabled = false;
                PetPat.Visible = true;
            }
            else
            {
                MessageBox.Show("You do no have enough energy \nfor your pat your pet");
            }
        }

        private void Sleep1_Click(object sender, EventArgs e)
        {
            if (stat.sleep < 85)
            {
                stat.idleness = 0;
                visibleoff();
                Exercising.Enabled = false;
                Eating.Enabled = false;
                Drinking.Enabled = false;
                Ignoring.Enabled = false;
                IdleCount.Enabled = false;
                Petting.Enabled = false;
                StatCheck.Enabled = false;
                TirednessChanger.Enabled = false;
                StatTimer.Enabled = false;
                Feed.Enabled = false;
                Drink.Enabled = false;
                Pat.Enabled = false;
                Exercise.Enabled = false;
                Ignore.Enabled = false;
                Sleep1.Enabled = false;
                PetSleep.Visible = true;
                SleepCount.Enabled = true;
                stat.energy = stat.energy + 5;
                sleep();
            }
            else
            {
                MessageBox.Show("Sleep status has to be lower than 85 \nbefore you can put your pet to sleep");
            }


        }
       
        private void Feed_Click(object sender, EventArgs e)
        {
            if (stat.energy >= 1)
            {
                stat.idleness = 0;
                Feed.Enabled = false;
                stat.energy--;
                StatTimer.Enabled = false;
                Eating.Enabled = true;
                visibleoff();
                StatCheck.Enabled = false;
                PetEat.Visible = true;
            }
            else
            {
                MessageBox.Show("You do no have enough energy \nto feed your pet");
            }
        }

        private void Exercise_Click(object sender, EventArgs e)
        {
            if (stat.energy >= 3)
            {
                stat.idleness = 0;
                stat.fitnesslevel = stat.fitnesslevel + 2;
                Exercise.Enabled = false;
                visibleoff();
                StatTimer.Enabled = false;
                Exercising.Enabled = true;
                StatCheck.Enabled = false;
                PetExercise.Visible = true;
                stat.energy = stat.energy - 3;

            }
            else
            {
                MessageBox.Show("You do not have enough energy \nto exercise");
            }
        }

        private void Drink_Click(object sender, EventArgs e)
        {
            if (stat.energy >= 1)
            {
                stat.idleness = 0;
                Drink.Enabled = false;
                stat.energy--;
                StatTimer.Enabled = false;
                Drinking.Enabled = true;
                visibleoff();
                StatCheck.Enabled = false;
                PetDrinking.Visible = true;
            }
            else
            {
                MessageBox.Show("You do no have enough energy \nfor your pet to drink");
            }
        }
        
        private void Ignore_Click(object sender, EventArgs e)
        {
            stat.idleness = 0;
            visibleoff();
            StatCheck.Enabled = false;
            PetIgnored.Visible = true;
            Ignoring.Enabled = true;
            stat.Actiontime = 6;

        }
                

        //--------------------------------------------------------------Funtions---------------------------------------------------------//
        public void sleep()
        {
            StatTimer.Enabled = false;
            stat.mood = stat.mood + 20;
            stat.sleep = 100;
            SleepT.Text = stat.sleep.ToString();
            if (stat.mood > 100)
            {
                stat.mood = 100;

            }


        }

        private void visibleoff()
        {
            Pet.Visible = false;
            PetSleep.Visible = false;
            PetExercise.Visible = false;
            PetLonely.Visible = false;
            PetEat.Visible = false;
            PetDrinking.Visible = false;
            PetPat.Visible = false;
            FeelingGood.Visible = false;
            PetPat.Visible = false;
            PetSad.Visible = false;
            PetIdle.Visible = false;
            PetIdle2.Visible = false;
            PetIgnored.Visible = false;
        }
        
        private void Save_Click(object sender, EventArgs e)
        {
            TextWriter text = new StreamWriter("C:/SavedFilePokePet.txt");
            text.WriteLine(stat.Actiontime.ToString());
            text.WriteLine(stat.boredom.ToString());
            text.WriteLine(stat.energy.ToString());
            text.WriteLine(stat.Exercisetime.ToString());
            text.WriteLine(stat.fitnesslevel.ToString());
            text.WriteLine(stat.hunger.ToString());
            text.WriteLine(stat.idleness.ToString());
            text.WriteLine(stat.IgnoreTime.ToString());
            text.WriteLine(stat.mood.ToString());
            text.WriteLine(stat.sleep.ToString());
            text.WriteLine(stat.Sleeptime.ToString());
            text.WriteLine(stat.thirst.ToString());

            text.Close();
        }

        //--------------------------------------------------------------------Timers-----------------------------------------------------------------------------//
        private void Ignoring_Tick(object sender, EventArgs e)
        {
            stat.Actiontime--;
            stat.mood = stat.mood - 3;
            if (stat.Actiontime <= 0)
            {
                stat.Actiontime = 5;
                Ignoring.Enabled = false;
                StatCheck.Enabled = true;
                visibleoff();
            }
        }

        private void IdleCount_Tick(object sender, EventArgs e)
        {
            stat.idleness++;
        }

        private void Drinking_Tick(object sender, EventArgs e)
        {
            stat.Actiontime--;
            stat.thirst = stat.thirst + 10;
            stat.mood = stat.mood + 2;

            if (stat.thirst > 100)
            {
                visibleoff();
                stat.thirst = 100;
                Pet.Visible = true;
                Drinking.Enabled = false;
                stat.Actiontime = 5;
                StatTimer.Enabled = true;
                StatCheck.Enabled = true;
                Drink.Enabled = true;
                MessageBox.Show("Pet is not thirsty");
            }

            if (stat.Actiontime == 0)
            {
                visibleoff();

                Drinking.Enabled = false;
                stat.Actiontime = 5;
                StatTimer.Enabled = true;
                StatCheck.Enabled = true;
                Drink.Enabled = true;
            }

        }

        private void Textchanger_Tick(object sender, EventArgs e)
        {
            BoredomT.Text = stat.boredom.ToString();

            HungerT.Text = stat.hunger.ToString();

            SleepT.Text = stat.sleep.ToString();

            ThirstT.Text = stat.thirst.ToString();

            EnergyT.Text = stat.energy.ToString();

            if (stat.mood < 0)
            {
                stat.mood = 0;
            }

            MoodT.Text = stat.mood.ToString();
        }

        private void Exercising_Tick(object sender, EventArgs e)
        {
            stat.Exercisetime--;
            stat.sleep--;
            stat.boredom = stat.boredom + 3;
            stat.mood = stat.mood + 2;


            if (stat.Exercisetime == 0)
            {
                visibleoff();
                Exercise.Enabled = true;
                StatCheck.Enabled = true;
                StatTimer.Enabled = true;
                stat.Exercisetime = 20;
                Exercising.Enabled = false;
                PetExercise.Visible = false;
            }

        }

        private void FitChanger_Tick(object sender, EventArgs e)
        {
            if (stat.fitnesslevel > 0)
            {
                stat.fitnesslevel--;
            }
            else
            {
                MessageBox.Show("Please train your pet, its \nfitness level is at 0");
            }

        }

        private void MoodCheck_Tick(object sender, EventArgs e)
        {
            if (stat.mood > 100)
            {
                stat.mood = 100;

            }
        }

        private void BoredomCheck_Tick(object sender, EventArgs e)
        {
            if (stat.boredom > 100)
            {
                stat.boredom = 100;

            }
        }

        private void TirednessChanger_Tick(object sender, EventArgs e)
        {
            stat.statchangerS();
            if (stat.sleep <= 0)
            {
                stat.sleep = 0;
                Sleep1.PerformClick();

            }
        }

        private void Petting_Tick(object sender, EventArgs e)
        {
            stat.Actiontime--;
            stat.mood = stat.mood + 5;
            stat.boredom++;

            if (stat.hunger > 100)
            {
                visibleoff();
                stat.mood = 100;
                Pet.Visible = true;
                Petting.Enabled = false;
                stat.Actiontime = 5;
                StatTimer.Enabled = true;
                StatCheck.Enabled = true;
                Pat.Enabled = true;
            }

            if (stat.Actiontime == 0)
            {
                visibleoff();

                Petting.Enabled = false;
                stat.Actiontime = 5;
                StatTimer.Enabled = true;
                StatCheck.Enabled = true;
                Pat.Enabled = true;
            }
        }

        private void Eating_Tick(object sender, EventArgs e)
        {

            stat.Actiontime--;
            stat.hunger = stat.hunger + 10;
            stat.mood = stat.mood + 2;

            if (stat.hunger > 100)
            {
                visibleoff();
                stat.hunger = 100;
                Pet.Visible = true;
                Eating.Enabled = false;
                stat.Actiontime = 5;
                StatTimer.Enabled = true;
                StatCheck.Enabled = true;
                Feed.Enabled = true;
                MessageBox.Show("Pet is full");
            }

            if (stat.Actiontime == 0)
            {
                visibleoff();

                Eating.Enabled = false;
                stat.Actiontime = 5;
                StatTimer.Enabled = true;
                StatCheck.Enabled = true;
                Feed.Enabled = true;
            }
        }

        private void SleepCount_Tick(object sender, EventArgs e)
        {
            stat.Sleeptime--;
            SleepC.Visible = true;
            SleepC.Text = stat.Sleeptime.ToString();
            if (stat.Sleeptime == 0)
            {
                visibleoff();
                Pet.Visible = true;
                SleepCount.Enabled = false;
                TirednessChanger.Enabled = true;
                stat.Sleeptime = 60;
                StatTimer.Enabled = true;
                Feed.Enabled = true;
                Drink.Enabled = true;
                Pat.Enabled = true;
                SleepC.Visible = false;
                Exercise.Enabled = true;
                Ignore.Enabled = true;
                Sleep1.Enabled = true;
            }
        }

        private void StatCheck_Tick(object sender, EventArgs e)
        {
            if (stat.mood < 20 || stat.hunger < 20 || stat.thirst < 20 || stat.boredom < 20)
            {
                FeelingGood.Visible = false;
                Pet.Visible = false;
                PetSad.Visible = true;
            }
            
            else if (stat.fitnesslevel >= 1 && stat.mood >= 80 && stat.boredom >= 80)
            {
                Pet.Visible = false;
                PetSad.Visible = false;
                FeelingGood.Visible = true;
            }

            else if (stat.idleness >= 120 && stat.idleness < 180)
            {
                FeelingGood.Visible = false;
                Pet.Visible = false;
                PetSad.Visible = false;
                PetIdle.Visible = false;
                PetIdle2.Visible = true;

            }


            else if (stat.idleness >= 180)
            {
                FeelingGood.Visible = false;
                Pet.Visible = false;
                PetSad.Visible = false;
                PetIdle.Visible = true;
            }


            else if (stat.boredom < 50 && stat.mood < 50 && stat.idleness > 100 )
            {
                Pet.Visible = false;
                PetSad.Visible = false;
                FeelingGood.Visible = false;
                PetLonely.Visible = true;
            }

            else
            {
                Pet.Visible = true;
                PetSad.Visible = false;
                FeelingGood.Visible = false;
                PetLonely.Visible = false;

            }
        }

        private void StatTimer_Tick_1(object sender, EventArgs e)
        {
            stat.statchangerB();
            stat.statchangerH();
            stat.statchangerT();
            if (stat.mood <= 0)
            {
                Pet.Visible = false;
                StatTimer.Enabled = false;
                this.Hide();
                MessageBox.Show("Your Pet has ran away \n Take Better Care Next Time!");
                Startup s = new Startup();
                s.Show();

                
            }
            stat.statchangerM();
        }
    }
}
