using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CSPROJ
{
    public partial class Statistics : Form
    {
        Thread thread;
        int[] Durations = BackPoint.AllPlayers.GetDuration();
        int[] Scores = BackPoint.AllPlayers.GetScores();
        int NOGs = BackPoint.AllPlayers.GetNOG();
        int NOP = BackPoint.AllPlayers.GetCount();

        public Statistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {

            label4.Text = NOGs.ToString();
            label6.Text = NOP.ToString();
            label8.Text = getHS().ToString();
            label10.Text = getLS().ToString();
            label12.Text = getMD().ToString();
            label14.Text = getHD().ToString();
            label16.Text = getTD().ToString();


        }
        private int getHS() {
            int x = 0;
            foreach (int n in Scores)
            {
                if (n >= x)
                {
                    x = n;
                }
            }

            return x;
                }
        private int getLS()
        {
            int x = Scores[0];
            foreach (int n in Scores)
            {
                if (n <= x)
                {
                    x = n;
                }
            }

            return x;
        }
       
        private int getMD()
        {
            int x = Durations[0];
            foreach (int n in Durations)
            {
                if (n <= x)
                {
                    x = n;
                }
            }

            return x;
        }
        private int getHD()
        {
            int x = Durations[0];
            foreach (int n in Durations)
            {
                if (n >= x)
                {
                    x = n;
                }
            }

            return x;
        }
        private int getTD()
        {
            int x = 0;
            foreach (int n in Durations)
            {
                x += n;
            }

            return x;
        }
        public void OpenMainForm(object obj)
        {
            Application.Run(new Main());
        }
        private void Statistics_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            thread = new Thread(OpenMainForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
