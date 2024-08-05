using System;
using System.Windows.Forms;
using System.Threading;

namespace CSPROJ
{ 
    public partial class CreateProfile : Form
    {

        Thread thread;
        int Age;
        String name;
        GENDER Gen;
        public CreateProfile()
        {
            InitializeComponent();
        }

       

        private void NameEnterd(object sender, EventArgs e)
        {   
                name = textBox1.Text;
           
        }

        private void SaveButton(object sender, EventArgs e)
        { if (name == null || name == "")
            {

                this.Close();
                thread = new Thread(OpenMainForm);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();

            }
            else
            {
                Player player = new Player(Age, name, Gen);

                BackPoint.AllPlayers.AddtoDict(player);
                this.Close();
                thread = new Thread(OpenMainForm);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            
        }

       
        private void GenderChoiceMale(object sender, EventArgs e)
        {
            Gen = GENDER.Male;
        }

        private void GenderChoiceFemale(object sender, EventArgs e)
        {
            Gen = GENDER.Female;
        }

        private void SelectedAge(object sender, EventArgs e)
        {
            Age=int.Parse((String)listBox1.SelectedItem);
        }

   

        private void CreateProfile_Load(object sender, EventArgs e)
        {

        }
        //Thread Functions
        public void OpenMainForm(object obj)
        {
            Application.Run(new Main());
        }
        
    }
 
}
