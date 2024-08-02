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
    public partial class History : Form
    {
        Thread thread;
        Player[] plyers = BackPoint.AllPlayers.GetPlayers();
        Player chosePlyerInfo = null;
        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            FillList();



        }
        private void FillList()
        {
            String[] PlayersNames = BackPoint.AllPlayers.getAllNames();
            listBox1.DataSource = PlayersNames;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            chosePlyerInfo = plyers[listBox1.SelectedIndex];
            label1.Text = chosePlyerInfo._CreationDate.ToString();
            label2.Text = chosePlyerInfo._Duration.ToString();
            label3.Text = chosePlyerInfo._score.ToString();
            label4.Text = chosePlyerInfo._Maxlvl.ToString();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void OpenMainForm(object obj)
        {
            Application.Run(new Main());
        }
        private void History_FormClosed(object sender, FormClosedEventArgs e)
        {
            thread = new Thread(OpenMainForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
