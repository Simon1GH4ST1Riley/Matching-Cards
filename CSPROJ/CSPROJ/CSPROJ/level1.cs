using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSPROJ
{
    public partial class level1 : Form
    {


        //Variables

        int score;
        int Duration;
        int rightClicks;
        int wrongClicks;
        PictureBox FC, SC;
        private Player P1 = BackPoint.AllPlayers.GetChosenPlayer();
        public Button StartButton;
        public Main main;

        //list of cards
        Image[] pics = new Image[2];
        Random log = new Random();

        private void fillIMGS()
        {
            int[] temp = new int[pics.Length];
            foreach (PictureBox c in tableLayoutPanel1.Controls)
            {
                int rand = log.Next(0, pics.Length);
                if (temp[rand] == 2)
                {
                    for (int i = 0; i < temp.Length; i++)
                    {
                        if (temp[i] < 2)
                        {
                            rand = i;
                            break;
                        }

                    }
                }


                c.Image = pics[rand];
                c.Tag = rand;
                temp[rand] += 1;



            }

        }
        private void AssignIMGS()
        {
            pics[0] = Properties.Resources.level5_a;
            pics[1] = Properties.Resources.level5_b;


        }
        public level1()
        {

            AssignIMGS();
            InitializeComponent();
        }
        private void matching(PictureBox picture)
        {

            if (FC == null)
            {
                FC = picture;
                FC.Enabled = false;
                FC.Image = pics[int.Parse(FC.Tag.ToString())];
            }
            else
            {
                if (FC != null && SC == null)
                {
                    SC = picture;
                    SC.Image = pics[int.Parse(SC.Tag.ToString())];
                    SC.Enabled = false;
                }

                if (FC.Image.Equals(SC.Image))
                {
                    score++;
                    rightClicks++;
                    main.UpdateScore(score);
                    main.UpdateNORC(rightClicks);

                    FC = null;
                    SC = null;
                }
                else
                {
                    timer3.Start();
                }
            }

        }
        private void level1_Load(object sender, EventArgs e)
        {
            main.Updatelevel(1);
          
                   

            


            fillIMGS();

            foreach (PictureBox picture in tableLayoutPanel1.Controls)
            {
                picture.Enabled = false;
            }
            timer2.Start();

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            //updating duration evry second
            Duration++;
            main.UpdateDuration(Duration);
            //updating data to the main when the level is finished
            if (rightClicks == 2)
            {
                P1._score += this.score;
                P1._Maxlvl += 1;
                P1._Duration += this.Duration;
                timer1.Stop();
                ExitButton.Enabled = false;
                Level2 lvl2 = new Level2();
                lvl2.lvl1 = this;
                lvl2.main = this.main;
                lvl2.StartButton = this.StartButton;
                lvl2.Show();

                
                

            }






        }

      

        private void ExitButton_Click(object sender, EventArgs e)
        {

            StartButton.Enabled = true;
            this.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            matching(sender as PictureBox);
        }

      

        private void level1_FormClosed(object sender, FormClosedEventArgs e)
        {
            StartButton.Enabled = true;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            timer1.Start();
            foreach (PictureBox picture in tableLayoutPanel1.Controls)
            {
                picture.Enabled = true;
                //make  the courser shape (hand)
                picture.Cursor = Cursors.Hand;
                picture.Image = Properties.Resources.level5_cover;
            }

        }
        
        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            wrongClicks += 1;
            main.UpdateNOWC(wrongClicks);
            FC.Image = Properties.Resources.level5_cover;
            SC.Image = Properties.Resources.level5_cover;
            FC.Enabled = true;
            SC.Enabled = true;
            FC = null;
            SC = null;
        }


    }

}
