namespace CSPROJ
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Gamebutton = new System.Windows.Forms.Button();
            this.GameDD = new System.Windows.Forms.Panel();
            this.Game_EndButton = new System.Windows.Forms.Button();
            this.Game_NewButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ProfileDD = new System.Windows.Forms.Panel();
            this.Profile_NewButton = new System.Windows.Forms.Button();
            this.Profile_CurrentButton = new System.Windows.Forms.Button();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.ReportDD = new System.Windows.Forms.Panel();
            this.Report = new System.Windows.Forms.Button();
            this.GameDD.SuspendLayout();
            this.ProfileDD.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ReportDD.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gamebutton
            // 
            this.Gamebutton.BackColor = System.Drawing.Color.Teal;
            this.Gamebutton.Font = new System.Drawing.Font("Broadway", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Gamebutton.ForeColor = System.Drawing.Color.Black;
            this.Gamebutton.Location = new System.Drawing.Point(2, 0);
            this.Gamebutton.Margin = new System.Windows.Forms.Padding(4);
            this.Gamebutton.MinimumSize = new System.Drawing.Size(164, 68);
            this.Gamebutton.Name = "Gamebutton";
            this.Gamebutton.Size = new System.Drawing.Size(164, 68);
            this.Gamebutton.TabIndex = 0;
            this.Gamebutton.Text = "Game";
            this.Gamebutton.UseVisualStyleBackColor = false;
            this.Gamebutton.Click += new System.EventHandler(this.GameButton);
            // 
            // GameDD
            // 
            this.GameDD.Controls.Add(this.Game_EndButton);
            this.GameDD.Controls.Add(this.Gamebutton);
            this.GameDD.Controls.Add(this.Game_NewButton);
            this.GameDD.Location = new System.Drawing.Point(8, 1);
            this.GameDD.Margin = new System.Windows.Forms.Padding(4);
            this.GameDD.MaximumSize = new System.Drawing.Size(167, 139);
            this.GameDD.MinimumSize = new System.Drawing.Size(167, 71);
            this.GameDD.Name = "GameDD";
            this.GameDD.Size = new System.Drawing.Size(167, 71);
            this.GameDD.TabIndex = 1;
            this.GameDD.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Game_EndButton
            // 
            this.Game_EndButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Game_EndButton.Font = new System.Drawing.Font("Broadway", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Game_EndButton.ForeColor = System.Drawing.Color.Black;
            this.Game_EndButton.Location = new System.Drawing.Point(-1, 103);
            this.Game_EndButton.Margin = new System.Windows.Forms.Padding(4);
            this.Game_EndButton.MaximumSize = new System.Drawing.Size(164, 36);
            this.Game_EndButton.MinimumSize = new System.Drawing.Size(164, 12);
            this.Game_EndButton.Name = "Game_EndButton";
            this.Game_EndButton.Size = new System.Drawing.Size(164, 36);
            this.Game_EndButton.TabIndex = 3;
            this.Game_EndButton.Text = "End";
            this.Game_EndButton.UseVisualStyleBackColor = false;
            this.Game_EndButton.Click += new System.EventHandler(this.End_Game);
            // 
            // Game_NewButton
            // 
            this.Game_NewButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Game_NewButton.Font = new System.Drawing.Font("Broadway", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Game_NewButton.ForeColor = System.Drawing.Color.Black;
            this.Game_NewButton.Location = new System.Drawing.Point(-1, 68);
            this.Game_NewButton.Margin = new System.Windows.Forms.Padding(4);
            this.Game_NewButton.Name = "Game_NewButton";
            this.Game_NewButton.Size = new System.Drawing.Size(164, 36);
            this.Game_NewButton.TabIndex = 2;
            this.Game_NewButton.Text = "New";
            this.Game_NewButton.UseVisualStyleBackColor = false;
            this.Game_NewButton.Click += new System.EventHandler(this.New_Game);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ProfileDD
            // 
            this.ProfileDD.Controls.Add(this.Profile_NewButton);
            this.ProfileDD.Controls.Add(this.Profile_CurrentButton);
            this.ProfileDD.Controls.Add(this.ProfileButton);
            this.ProfileDD.Location = new System.Drawing.Point(183, 1);
            this.ProfileDD.Margin = new System.Windows.Forms.Padding(4);
            this.ProfileDD.MaximumSize = new System.Drawing.Size(167, 139);
            this.ProfileDD.MinimumSize = new System.Drawing.Size(167, 71);
            this.ProfileDD.Name = "ProfileDD";
            this.ProfileDD.Size = new System.Drawing.Size(167, 71);
            this.ProfileDD.TabIndex = 4;
            this.ProfileDD.Paint += new System.Windows.Forms.PaintEventHandler(this.ProfileDD_Paint);
            // 
            // Profile_NewButton
            // 
            this.Profile_NewButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Profile_NewButton.Font = new System.Drawing.Font("Broadway", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Profile_NewButton.ForeColor = System.Drawing.Color.Black;
            this.Profile_NewButton.Location = new System.Drawing.Point(0, 103);
            this.Profile_NewButton.Margin = new System.Windows.Forms.Padding(4);
            this.Profile_NewButton.MaximumSize = new System.Drawing.Size(164, 36);
            this.Profile_NewButton.MinimumSize = new System.Drawing.Size(164, 12);
            this.Profile_NewButton.Name = "Profile_NewButton";
            this.Profile_NewButton.Size = new System.Drawing.Size(164, 36);
            this.Profile_NewButton.TabIndex = 3;
            this.Profile_NewButton.Text = "New";
            this.Profile_NewButton.UseVisualStyleBackColor = false;
            this.Profile_NewButton.Click += new System.EventHandler(this.Profile_New);
            // 
            // Profile_CurrentButton
            // 
            this.Profile_CurrentButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Profile_CurrentButton.Font = new System.Drawing.Font("Broadway", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Profile_CurrentButton.ForeColor = System.Drawing.Color.Black;
            this.Profile_CurrentButton.Location = new System.Drawing.Point(-1, 68);
            this.Profile_CurrentButton.Margin = new System.Windows.Forms.Padding(4);
            this.Profile_CurrentButton.Name = "Profile_CurrentButton";
            this.Profile_CurrentButton.Size = new System.Drawing.Size(164, 36);
            this.Profile_CurrentButton.TabIndex = 2;
            this.Profile_CurrentButton.Text = "Delete";
            this.Profile_CurrentButton.UseVisualStyleBackColor = false;
            this.Profile_CurrentButton.Click += new System.EventHandler(this.Profile_Current);
            // 
            // ProfileButton
            // 
            this.ProfileButton.BackColor = System.Drawing.Color.Teal;
            this.ProfileButton.Font = new System.Drawing.Font("Broadway", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ProfileButton.ForeColor = System.Drawing.Color.Black;
            this.ProfileButton.Location = new System.Drawing.Point(1, 0);
            this.ProfileButton.Margin = new System.Windows.Forms.Padding(4);
            this.ProfileButton.MinimumSize = new System.Drawing.Size(164, 68);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(164, 68);
            this.ProfileButton.TabIndex = 0;
            this.ProfileButton.Text = "Profile";
            this.ProfileButton.UseVisualStyleBackColor = false;
            this.ProfileButton.Click += new System.EventHandler(this.Profile_Button);
            // 
            // timer2
            // 
            this.timer2.Interval = 5;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.Font = new System.Drawing.Font("Broadway", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(-1, 103);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.MaximumSize = new System.Drawing.Size(164, 36);
            this.button1.MinimumSize = new System.Drawing.Size(164, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "History";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Report_History);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button2.Font = new System.Drawing.Font("Broadway", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(-1, 68);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Statistics";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Report_Statistics);
            // 
            // timer3
            // 
            this.timer3.Interval = 5;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.Font = new System.Drawing.Font("Broadway", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(698, 3);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.MinimumSize = new System.Drawing.Size(164, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 68);
            this.button3.TabIndex = 4;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.ExitButton);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 219);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(855, 127);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(704, 75);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(132, 22);
            this.textBox6.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Broadway", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(532, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "#ofWrongclicks:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(394, 76);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(132, 22);
            this.textBox5.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Broadway", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(227, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "#ofRightclicks:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Broadway", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(4, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Level:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(90, 76);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 22);
            this.textBox4.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(704, 28);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 22);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Broadway", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(535, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Duration:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(395, 28);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Broadway", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(230, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Score:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 28);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(4, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Teal;
            this.StartButton.Font = new System.Drawing.Font("Broadway", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.Color.Black;
            this.StartButton.Location = new System.Drawing.Point(529, 3);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4);
            this.StartButton.MinimumSize = new System.Drawing.Size(164, 68);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(164, 68);
            this.StartButton.TabIndex = 7;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ReportDD
            // 
            this.ReportDD.Controls.Add(this.button1);
            this.ReportDD.Controls.Add(this.button2);
            this.ReportDD.Controls.Add(this.Report);
            this.ReportDD.Location = new System.Drawing.Point(356, 1);
            this.ReportDD.Margin = new System.Windows.Forms.Padding(4);
            this.ReportDD.MaximumSize = new System.Drawing.Size(167, 139);
            this.ReportDD.MinimumSize = new System.Drawing.Size(167, 71);
            this.ReportDD.Name = "ReportDD";
            this.ReportDD.Size = new System.Drawing.Size(167, 71);
            this.ReportDD.TabIndex = 5;
            // 
            // Report
            // 
            this.Report.BackColor = System.Drawing.Color.Teal;
            this.Report.Font = new System.Drawing.Font("Broadway", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Report.ForeColor = System.Drawing.Color.Black;
            this.Report.Location = new System.Drawing.Point(-1, 0);
            this.Report.Margin = new System.Windows.Forms.Padding(4);
            this.Report.MinimumSize = new System.Drawing.Size(164, 68);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(164, 68);
            this.Report.TabIndex = 0;
            this.Report.Text = "Report";
            this.Report.UseVisualStyleBackColor = false;
            this.Report.Click += new System.EventHandler(this.ReportButton);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BackgroundImage = global::CSPROJ.Properties.Resources._default;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(869, 433);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ReportDD);
            this.Controls.Add(this.ProfileDD);
            this.Controls.Add(this.GameDD);
            this.Controls.Add(this.StartButton);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matching Cards";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GameDD.ResumeLayout(false);
            this.ProfileDD.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ReportDD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Gamebutton;
        private System.Windows.Forms.Panel GameDD;
        private System.Windows.Forms.Button Game_EndButton;
        private System.Windows.Forms.Button Game_NewButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel ProfileDD;
        private System.Windows.Forms.Button Profile_NewButton;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Button Profile_CurrentButton;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Panel ReportDD;
        private System.Windows.Forms.Button Report;
    }
}

