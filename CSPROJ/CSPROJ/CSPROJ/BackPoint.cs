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

    public partial class BackPoint : Form
    {

        public BackPoint()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public static PlayersDict AllPlayers = new PlayersDict();

    }
    
    
    public class PlayersDict
    {
        private Dictionary<int, Player> Players = new Dictionary<int, Player>();
        public void AddtoDict(Player newplayer) {
            Players.Add(Players.Count, newplayer);
        }
        public int[] GetScores()
        { int[] scores = new int[GetCount()];
            int i = 0;

            var q = from Player in Players
                    select Player;
            foreach (KeyValuePair<int, Player> P in q)
            {
              scores[i]=P.Value._score;
                i++;
            }
            return scores;
        }
        public int[] GetDuration()
        {
            int[] Duration = new int[GetCount()];
            int i = 0;

            var q = from Player in Players
                    select Player;
            foreach (KeyValuePair<int, Player> P in q)
            {
                Duration[i] = P.Value._Duration;
                i++;
            }
            return Duration;
        }
        public int GetNOG()
        { 

            int NOG = 0; ; 
            

            var q = from Player in Players
                    select Player;
            foreach (KeyValuePair<int, Player> P in q)
            {
                NOG += P.Value._Maxlvl;
            }
            return NOG;
        }
        public void GetPlayer(int key)
        { if (key == -1)
            {
                return;
            }
            Player p = Players.Values.ElementAt(key);
            p.Choose();


        }
        public int GetCount()
        {
            return Players.Count;
        }
        public string[] getAllNames()
        { int i = 0;
            String[] names = new string[GetCount()];
            foreach (KeyValuePair<int, Player> a in Players)
            {
                names[i] = Players.ElementAt(i).Value._Name;
                i++;
            }
            return names;
        }
        public Player GetChosenPlayer()
        {
            foreach (KeyValuePair<int, Player> a in Players)
            {
                if (a.Value.Chosen())
                {
                    return a.Value;
                    
                }
            }
            return null;
        }
        public Player[]  GetPlayers()
        {
            int i = 0;
            Player[] players = new Player[GetCount()];
            foreach (Player a in Players.Values)
            {
                players[i] = a;
                i++;
            }

            return players;

        }


    }

    public class Player
    {
        private int Maxlvl;
        private int Duration;
        private DateTime Creationdate;
        private int score;
        private int Age;
        private String Name;
        private COLOR Color;
        private GENDER Gender;
        private List<String> Movments;
        private bool isChosen;
       public List<String> _Movments { get { return Movments; } set { Movments = value;} }
        public int _Duration { get { return this.Duration; } set { this.Duration = value; } }
        public int _Maxlvl { get { return this.Maxlvl; }set { this.Maxlvl = value; } }
        public int _Age { get { return this.Age; } }
        public String _Name { get { return this.Name; } }
        public COLOR _Color { get { return this.Color; } set { this.Color = value; } }
        public GENDER _Gender { get { return this.Gender; } }
        public DateTime _CreationDate { get { return this.Creationdate; } }
        public int _score { set { this.score = value; } get { return this.score; } }
        public Player(int Age, String Name, COLOR Color, GENDER Gender)
        {
            this.Color = Color;
            this.Age = Age;
            this.Name = Name;
            this.Gender = Gender;
            this.isChosen = false;
            this.score = 0;
            this.Maxlvl = 0;
            this.Duration = 0;
            this.Movments = new List<string> ();
            this.Creationdate = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day);
        }
        public void Choose()
        {
            isChosen = true;
        }
        public void DontChoose()
        {
            isChosen = false;
        }
        public bool Chosen()
        {
            return isChosen;
        }

      


    }

    public enum GENDER
    {
        Male,
        Female
    }
   public enum COLOR
    {
        Yellow,
        Red,
        SeaGreen

    }
   
   
}
