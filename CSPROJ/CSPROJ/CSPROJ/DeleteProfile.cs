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
    public partial class DeleteProfile : Form
    {
        Thread thread;
        Player P1 = BackPoint.AllPlayers.GetChosenPlayer();
        public DeleteProfile()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {  
            FillList();

        }
        private void FillList()
        {
            String[] PlayersNames = BackPoint.AllPlayers.getAllNames();
            listBox1.DataSource = PlayersNames;
        }



        private void CloseCurrentinfo(object sender, EventArgs e)
        {
            BackPoint.AllPlayers.DeletePlayer(listBox1.SelectedIndex);
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
