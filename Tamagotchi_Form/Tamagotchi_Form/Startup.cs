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
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            WindowsPet w = new WindowsPet();
            w.Show();
            this.Hide();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            TextReader tr = new StreamReader("C:/SavedFilePokePet.txt");

            string ActionTime = tr.ReadLine();
            string boredom = tr.ReadLine();
            string energy = tr.ReadLine();
            string Exercisetime = tr.ReadLine();
            string fitnesslevel = tr.ReadLine();
            string hunger = tr.ReadLine();
            string idleness = tr.ReadLine();
            string Ignoretime = tr.ReadLine();
            string mood = tr.ReadLine();
            string sleep = tr.ReadLine();
            string sleeptime = tr.ReadLine();
            string thirst = tr.ReadLine();

            //Convert the strings to int
            stat.Actiontime = Convert.ToInt32(ActionTime);
            stat.boredom = Convert.ToInt32(boredom);
            stat.energy = Convert.ToInt32(energy);
            stat.Exercisetime = Convert.ToInt32(Exercisetime);
            stat.fitnesslevel = Convert.ToInt32(fitnesslevel);
            stat.hunger = Convert.ToInt32(hunger);
            stat.idleness = Convert.ToInt32(idleness);
            stat.IgnoreTime = Convert.ToInt32(Ignoretime);
            stat.mood = Convert.ToInt32(mood);
            stat.sleep = Convert.ToInt32(sleep);
            stat.Sleeptime = Convert.ToInt32(sleeptime);
            stat.thirst = Convert.ToInt32(thirst);


            // close the stream
            tr.Close();

            WindowsPet w = new WindowsPet();
            w.Show();
            this.Hide();
        }

        private void Help_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Users/user/Desktop/Dropbox/Tamagotchi Assignment/Instruction.docx");
        }
    }
}
