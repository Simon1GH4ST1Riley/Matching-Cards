using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSPROJ
{
    public partial class Level2 : Form
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
        public level1 lvl1; 

        //list of cards
        Image[] pics = new Image[3];
        Random log = new Random();
        private void fillIMGS()
        {
            int[] temp = new int[pics.Length];
            foreach (PictureBox picture in tableLayoutPanel1.Controls)
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


                picture.Image = pics[rand];
                picture.Tag = rand;
                temp[rand] += 1;



            }

        }


        private void AssignIMGS()
        {
            pics[0] = Properties.Resources.level5_a;
            pics[1] = Properties.Resources.level5_b;
            pics[2] = Properties.Resources.level5_c;
         

        }
        public Level2()
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




        //chang the background color based on what the player choosed when the level is load
        private void Level2_Load(object sender, EventArgs e)
        {
            if(lvl1 != null)
            {
                lvl1.Close();
            }
            
            main.Updatelevel(2);
           
             
            fillIMGS();

            foreach (PictureBox picture in tableLayoutPanel1.Controls)
            {
                picture.Enabled = false;
            }
            timer2.Start();
        }


        //close the level
       


        //enable the start button after the form closed
        private void Level2_FormClosed(object sender, FormClosedEventArgs e)
        {
            StartButton.Enabled = true;
        }

        //Timers block

        private void timer1_Tick(object sender, EventArgs e)
        {
            //updating duration evry second
            Duration++;
            main.UpdateDuration(Duration);
            //updating data to the main when the level is finished
            if (rightClicks == 3)
            {
                P1._score += this.score;
                P1._Maxlvl += 1;
                P1._Duration += this.Duration;
                timer1.Stop();
                Exit.Enabled = false;
                level3 lvl3 = new level3();
                lvl3.lvl2 = this;
                lvl3.main = this.main;
                lvl3.StartButton = this.StartButton;
                lvl3.Show();



            }





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


   

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            matching(sender as PictureBox);
        }

        private void Exit_Click(object sender, EventArgs e)
        {

            StartButton.Enabled = true;
            this.Close();
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

