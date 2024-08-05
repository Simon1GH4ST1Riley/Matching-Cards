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
    public partial class CurrentProfile : Form
    {
        Thread thread;
        Player P1 = BackPoint.AllPlayers.GetChosenPlayer();
        public CurrentProfile()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   if (P1 == null)
            {
                return;
            }
            textBox1.Text = P1._Name;
            
            if (P1._Gender == GENDER.Male)
            {
                radioButton1.PerformClick();
            }
            else 
            {
                radioButton2.PerformClick();
            }
         
            listBox1.SetSelected(P1._Age-4,true);


        }

     

        private void CloseCurrentinfo(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenMainForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        //Thread Functions
        public void OpenMainForm(object obj)
        {
            Application.Run(new Main());
        }
    }
}
