using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CSPROJ
{
    public partial class Main : Form
    {
        
        Thread thread;
        private Player P1;
        private bool GDisCollapsed=false;
        private bool PDisCollapsed = false;
        private bool RDisCollapsed = false;
        public Main()
        {
            InitializeComponent();
        }
       
        public void UpdateScore(int Score)
        {
            this.textBox2.Text = Score.ToString();  
        }
        public void UpdateDuration(int Duration)
        {
            this.textBox3.Text = Duration.ToString();
        }
        public void Updatelevel(int level)
        {
            this.textBox4.Text = level.ToString();
        }
        public void UpdateNORC(int Norc) //updating NO. of right clicks
        {
            this.textBox5.Text = Norc.ToString();
        }
        public void UpdateNOWC(int Nowc) //updating NO. of wrong clicks
        {
            this.textBox6.Text = Nowc.ToString();
        }
        private void Game_Click(object sender, EventArgs e) 
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (BackPoint.AllPlayers.GetCount() == 0)
            {
                this.Close();
                thread = new Thread(OpenCreateProfileform);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else 
            {
                P1=BackPoint.AllPlayers.GetChosenPlayer();
                if (P1 != null)
                { this.textBox1.Text = P1._Name; 
         
                           
                   
                    this.textBox2.Text = P1._score.ToString();
                    this.textBox3.Text = P1._Duration.ToString();
                    this.textBox4.Text = P1._Maxlvl.ToString();

                 }
                else { this.textBox1.Text = ""; }
                this.textBox2.Text = "0"; 
                this.textBox3.Text = "0";
                this.textBox4.Text = "0";
                this.textBox5.Text = "0";
                this.textBox6.Text = "0";
                
            }
           
            

        }

        private void GameButton(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void End_Game(object sender, EventArgs e)
        {
            if (P1 != null)
            { P1.DontChoose(); }

            this.Close();
            thread = new Thread(OpenMainForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void New_Game(object sender, EventArgs e)
        {
            if (P1 != null)
            { P1.DontChoose(); }
           
            this.Close();
            thread = new Thread(OpennewGameForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!GDisCollapsed)
            {
                GameDD.Height += 10;
                if (GameDD.Size == GameDD.MaximumSize)
                {
                    timer1.Stop();
                    GDisCollapsed = true;
                }
            }
            else
             {
                GameDD.Height -= 10;
                if (GameDD.Size == GameDD.MinimumSize)
                {
                    timer1.Stop();
                    GDisCollapsed = false;
                }
            }
        }

        private void Profile_Button(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void Profile_Current(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenCurrentProfile);
             thread.SetApartmentState(ApartmentState.STA);
             thread.Start();
           

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (!PDisCollapsed)
            {
                ProfileDD.Height += 10;
                if (ProfileDD.Size == ProfileDD.MaximumSize)
                {
                    timer2.Stop();
                    PDisCollapsed = true;
                }
            }
            else
            {
                ProfileDD.Height -= 10;
                if (ProfileDD.Size == ProfileDD.MinimumSize)
                {
                    timer2.Stop();
                    PDisCollapsed = false;
                }
            }
        }

        private void ProfileDD_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ReportButton(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void Report_Statistics(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenStatisticsForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void Report_History(object sender, EventArgs e)
        {
           this.Close();
            thread = new Thread(OpenHistoryForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (!RDisCollapsed)
            {
                ReportDD.Height += 10;
                if (ReportDD.Size == ReportDD.MaximumSize)
                {
                    timer3.Stop();
                    RDisCollapsed = true;
                }
            }
            else
            {
                ReportDD.Height -= 10;
                if (ReportDD.Size == ReportDD.MinimumSize)
                {
                    timer3.Stop();
                    RDisCollapsed = false;
                }
            }
        }

        private void ExitButton(object sender, EventArgs e)
        { 

            Application.Exit();
        }

        private void Profile_New(object sender, EventArgs e)
        {   
            this.Close();
            thread = new Thread(OpenCreateProfileform);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (P1 != null)
            {
                switch (P1._Maxlvl + 1)
                {
                    case 1:
                        

                        level1 lvl1 = new level1();
                        lvl1.main = this;
                        lvl1.StartButton = this.StartButton;
                        lvl1.Show();
                        this.StartButton.Enabled = false;


                        break;

                    case 2:
                        
                        Level2 lvl_2 = new Level2();
                        lvl_2.main = this;
                        lvl_2.StartButton = this.StartButton;
                        lvl_2.Show();
                        this.StartButton.Enabled = false;


                        break;
                    case 3:
                        
                        level3 lvl_3 = new level3();
                        lvl_3.main = this;
                        lvl_3.StartButton = this.StartButton;
                        lvl_3.Show();
                        this.StartButton.Enabled = false;


                        break;
                    case 4:
                        
                        Level4 lvl_4 = new Level4();
                        lvl_4.main = this;
                        lvl_4.StartButton = this.StartButton;
                        lvl_4.Show();
                        this.StartButton.Enabled = false;


                        break;
                    case 5:
                        
                        Level5 lvl_5 = new Level5();
                        lvl_5.main = this;
                        lvl_5.StartButton = this.StartButton;
                        lvl_5.Show();
                        this.StartButton.Enabled = false;


                        break;




                }
            }

        }
        //Thread Functions
        public void OpennewGameForm(object obj)
        {
            Application.Run(new NewGame());
        }

        public void OpenCreateProfileform(object obj)
        {
            Application.Run(new CreateProfile());
        }
        public void OpenCurrentProfile(object obj)
        {
            Application.Run(new CurrentProfile());
        }
        public void OpenMainForm(object obj)
        {


            Application.Run(new Main());
        }
        public void OpenStatisticsForm(object obj)
        {


            Application.Run(new Statistics());
        }

       
         public void OpenHistoryForm(object obj)
{


    Application.Run(new History());
}


    }
}
