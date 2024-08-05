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
    public partial class NewGame : Form
    {
        Thread thread;
        
        public void fillList()
        {
           
            String[] PlayersNames = BackPoint.AllPlayers.getAllNames();
            listBox1.DataSource = PlayersNames;
        }
        public NewGame()
        {
            InitializeComponent();
            
        }

        private void NewGame_Load(object sender, EventArgs e)
        {
            
            fillList();

        }

        private void StartButton(object sender, EventArgs e)
        {
            BackPoint.AllPlayers.GetPlayer(listBox1.SelectedIndex);
            thread = new Thread(OpenMainForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
           
           
        }

        private void NamesList(object sender, EventArgs e)
        {
            
             
        }
        //Thread Functions
        public void OpenMainForm(object obj)
        {
            
            
            Application.Run(new Main());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
