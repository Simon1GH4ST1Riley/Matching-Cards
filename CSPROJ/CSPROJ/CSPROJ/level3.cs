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
    public partial class level3 : Form
    {
        int score;
        int Duration;
        int rightClicks;
        int wrongClicks;
        PictureBox FC , SC;
        private Player P1 = BackPoint.AllPlayers.GetChosenPlayer();
        public Button StartButton;
        public Main main;
        public Level2 lvl2;

        Image[] pics = new Image[4];
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
            pics[2] = Properties.Resources.level5_c;
            pics[3] = Properties.Resources.level5_d;
        }
        public level3()
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
        private void Level3_Load(object sender, EventArgs e)
        {
            if (lvl2 != null)
            {
                lvl2.Close();
            }
            main.Updatelevel(3);
            switch (P1._Color)
            {
                case COLOR.Red:
                    this.BackColor = Color.Red;
                    break;
                case COLOR.SeaGreen:
                    this.BackColor = Color.SeaGreen;
                    break;
                case COLOR.Yellow:
                    this.BackColor = Color.Yellow;
                    break;
                default:
                    this.BackgroundImage = Properties.Resources._135739235_epoxy_resin_petri_dish_art_macro_photo_abstract_background;
                    break;
            }
            fillIMGS();

            foreach (PictureBox picture in tableLayoutPanel1.Controls)
            {
                picture.Enabled = false;
            }
            timer2.Start();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            matching(sender as PictureBox);
        }
        private void Exit_button_Click(object sender, EventArgs e)
        {
          
            StartButton.Enabled = true;
            this.Close();
        }
        private void Level5_FormClosed(object sender, FormClosedEventArgs e)
        {
            StartButton.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //updating duration evry second
            Duration++;
            main.UpdateDuration(Duration);
            //updating data to the main when the level is finished
            if (rightClicks == 4)
            {
                P1._score += this.score;
                P1._Maxlvl += 1;
                P1._Duration += this.Duration;
                timer1.Stop();
                button1.Enabled = false;

                Level4 lvl4 = new Level4();
                lvl4.lvl3 = this;
                lvl4.main = this.main;
                lvl4.StartButton = this.StartButton;
                lvl4.Show();

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