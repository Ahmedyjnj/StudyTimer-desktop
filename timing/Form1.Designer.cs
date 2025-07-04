namespace timing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            mission_textBox1 = new TextBox();
            mission_textbox2 = new TextBox();
            mission_textBox3 = new TextBox();
            mission_textBox4 = new TextBox();
            mission_textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            date_label = new Label();
            hours_UpDown = new NumericUpDown();
            minutes_updown = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            button3 = new Button();
            timer_study = new System.Windows.Forms.Timer(components);
            label_timetaked = new Label();
            stop_music = new Button();
            button2 = new Button();
            openFileDialog1 = new OpenFileDialog();
            panel2 = new Panel();
            button6 = new Button();
            button4 = new Button();
            label8 = new Label();
            mission_textBox6 = new TextBox();
            button5 = new Button();
            mission_name = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer_now = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)hours_UpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minutes_updown).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // mission_textBox1
            // 
            mission_textBox1.BackColor = Color.White;
            mission_textBox1.Font = new Font("Tahoma", 10.8F);
            mission_textBox1.ForeColor = Color.Black;
            mission_textBox1.Location = new Point(117, 9);
            mission_textBox1.Name = "mission_textBox1";
            mission_textBox1.RightToLeft = RightToLeft.Yes;
            mission_textBox1.Size = new Size(279, 29);
            mission_textBox1.TabIndex = 5;
            mission_textBox1.TextChanged += mission_textBox1_TextChanged;
            // 
            // mission_textbox2
            // 
            mission_textbox2.BackColor = Color.White;
            mission_textbox2.Font = new Font("Tahoma", 10.8F);
            mission_textbox2.ForeColor = Color.Black;
            mission_textbox2.Location = new Point(117, 67);
            mission_textbox2.Name = "mission_textbox2";
            mission_textbox2.RightToLeft = RightToLeft.Yes;
            mission_textbox2.Size = new Size(279, 29);
            mission_textbox2.TabIndex = 6;
            mission_textbox2.Visible = false;
            mission_textbox2.TextChanged += mission_textbox2_TextChanged;
            // 
            // mission_textBox3
            // 
            mission_textBox3.BackColor = Color.White;
            mission_textBox3.Font = new Font("Tahoma", 10.8F);
            mission_textBox3.ForeColor = Color.Black;
            mission_textBox3.Location = new Point(117, 126);
            mission_textBox3.Name = "mission_textBox3";
            mission_textBox3.RightToLeft = RightToLeft.Yes;
            mission_textBox3.Size = new Size(279, 29);
            mission_textBox3.TabIndex = 7;
            mission_textBox3.Visible = false;
            mission_textBox3.TextChanged += mission_textBox3_TextChanged;
            // 
            // mission_textBox4
            // 
            mission_textBox4.BackColor = Color.White;
            mission_textBox4.Font = new Font("Tahoma", 10.8F);
            mission_textBox4.ForeColor = Color.Black;
            mission_textBox4.Location = new Point(117, 191);
            mission_textBox4.Name = "mission_textBox4";
            mission_textBox4.RightToLeft = RightToLeft.Yes;
            mission_textBox4.Size = new Size(279, 29);
            mission_textBox4.TabIndex = 8;
            mission_textBox4.Visible = false;
            mission_textBox4.TextChanged += mission_textBox4_TextChanged;
            // 
            // mission_textBox5
            // 
            mission_textBox5.BackColor = Color.White;
            mission_textBox5.Font = new Font("Tahoma", 10.8F);
            mission_textBox5.ForeColor = Color.Black;
            mission_textBox5.Location = new Point(117, 251);
            mission_textBox5.Name = "mission_textBox5";
            mission_textBox5.RightToLeft = RightToLeft.Yes;
            mission_textBox5.Size = new Size(279, 29);
            mission_textBox5.TabIndex = 9;
            mission_textBox5.Visible = false;
            mission_textBox5.TextChanged += mission_textBox5_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.Location = new Point(402, 9);
            label1.Name = "label1";
            label1.Size = new Size(57, 23);
            label1.TabIndex = 10;
            label1.Text = "مهمة 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(402, 67);
            label2.Name = "label2";
            label2.Size = new Size(57, 23);
            label2.TabIndex = 11;
            label2.Text = "مهمة2";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(402, 126);
            label3.Name = "label3";
            label3.Size = new Size(58, 23);
            label3.TabIndex = 12;
            label3.Text = "مهمة3";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(402, 192);
            label4.Name = "label4";
            label4.Size = new Size(55, 23);
            label4.TabIndex = 13;
            label4.Text = "مهمة4";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.Location = new Point(402, 251);
            label5.Name = "label5";
            label5.Size = new Size(57, 23);
            label5.TabIndex = 14;
            label5.Text = "مهمة5";
            label5.Visible = false;
            // 
            // date_label
            // 
            date_label.BackColor = Color.Black;
            date_label.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            date_label.ForeColor = Color.White;
            date_label.Location = new Point(195, 9);
            date_label.Name = "date_label";
            date_label.Size = new Size(405, 25);
            date_label.TabIndex = 15;
            date_label.Text = "label6";
            date_label.TextAlign = ContentAlignment.TopRight;
            // 
            // hours_UpDown
            // 
            hours_UpDown.BackColor = Color.White;
            hours_UpDown.Location = new Point(142, 41);
            hours_UpDown.Name = "hours_UpDown";
            hours_UpDown.Size = new Size(41, 27);
            hours_UpDown.TabIndex = 16;
            // 
            // minutes_updown
            // 
            minutes_updown.BackColor = Color.White;
            minutes_updown.Location = new Point(220, 41);
            minutes_updown.Name = "minutes_updown";
            minutes_updown.Size = new Size(41, 27);
            minutes_updown.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(199, 18);
            label6.Name = "label6";
            label6.Size = new Size(80, 25);
            label6.TabIndex = 18;
            label6.Text = "minutes";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(133, 18);
            label7.Name = "label7";
            label7.Size = new Size(59, 25);
            label7.TabIndex = 19;
            label7.Text = "hours";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(17, 78);
            button1.Name = "button1";
            button1.Size = new Size(101, 34);
            button1.TabIndex = 20;
            button1.Text = "( add time )";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Add_Time;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(minutes_updown);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(hours_UpDown);
            panel1.Location = new Point(12, 174);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 125);
            panel1.TabIndex = 21;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Location = new Point(199, 78);
            button3.Name = "button3";
            button3.Size = new Size(66, 34);
            button3.TabIndex = 21;
            button3.Text = "( End )";
            button3.UseVisualStyleBackColor = false;
            button3.Click += End_Click;
            // 
            // timer_study
            // 
            timer_study.Interval = 1000;
            timer_study.Tick += timer1_study;
            // 
            // label_timetaked
            // 
            label_timetaked.BackColor = Color.LightGray;
            label_timetaked.Font = new Font("Cambria Math", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_timetaked.Location = new Point(12, 58);
            label_timetaked.Name = "label_timetaked";
            label_timetaked.Size = new Size(376, 95);
            label_timetaked.TabIndex = 22;
            label_timetaked.Text = "Timer";
            // 
            // stop_music
            // 
            stop_music.Location = new Point(12, 352);
            stop_music.Name = "stop_music";
            stop_music.Size = new Size(108, 29);
            stop_music.TabIndex = 24;
            stop_music.Text = "Close sound";
            stop_music.UseVisualStyleBackColor = true;
            stop_music.Click += stop_music_Click;
            // 
            // button2
            // 
            button2.Location = new Point(159, 352);
            button2.Name = "button2";
            button2.Size = new Size(138, 29);
            button2.TabIndex = 25;
            button2.Text = "add sound";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Add_new_sound;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(mission_textBox6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(mission_textBox4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(mission_textBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(mission_textbox2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(mission_textBox3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(mission_textBox5);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(394, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(465, 363);
            panel2.TabIndex = 26;
            // 
            // button6
            // 
            button6.BackColor = Color.GreenYellow;
            button6.Location = new Point(9, 310);
            button6.Name = "button6";
            button6.Size = new Size(101, 29);
            button6.TabIndex = 28;
            button6.Text = "save in file";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 128);
            button4.Location = new Point(9, 56);
            button4.Name = "button4";
            button4.Size = new Size(101, 34);
            button4.TabIndex = 25;
            button4.Text = "delete Task ";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label8.Location = new Point(402, 309);
            label8.Name = "label8";
            label8.Size = new Size(57, 23);
            label8.TabIndex = 24;
            label8.Text = "مهمة6";
            label8.Visible = false;
            // 
            // mission_textBox6
            // 
            mission_textBox6.BackColor = Color.White;
            mission_textBox6.Font = new Font("Tahoma", 10.8F);
            mission_textBox6.ForeColor = Color.Black;
            mission_textBox6.Location = new Point(117, 309);
            mission_textBox6.Name = "mission_textBox6";
            mission_textBox6.RightToLeft = RightToLeft.Yes;
            mission_textBox6.Size = new Size(279, 29);
            mission_textBox6.TabIndex = 23;
            mission_textBox6.Visible = false;
            mission_textBox6.TextChanged += mission_textBox6_TextChanged;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(192, 192, 255);
            button5.Location = new Point(9, 9);
            button5.Name = "button5";
            button5.Size = new Size(101, 34);
            button5.TabIndex = 22;
            button5.Text = "( Add Task )";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // mission_name
            // 
            mission_name.AutoSize = true;
            mission_name.Location = new Point(12, 58);
            mission_name.Name = "mission_name";
            mission_name.Size = new Size(50, 20);
            mission_name.TabIndex = 27;
            mission_name.Text = "label8";
            // 
            // timer1
            // 
            timer1.Interval = 10;
            // 
            // timer2
            // 
            timer2.Interval = 10;
            // 
            // timer_now
            // 
            timer_now.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(871, 433);
            Controls.Add(mission_name);
            Controls.Add(panel2);
            Controls.Add(button2);
            Controls.Add(stop_music);
            Controls.Add(label_timetaked);
            Controls.Add(panel1);
            Controls.Add(date_label);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)hours_UpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)minutes_updown).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox mission_textBox1;
        private TextBox mission_textbox2;
        private TextBox mission_textBox3;
        private TextBox mission_textBox4;
        private TextBox mission_textBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label date_label;
        private NumericUpDown hours_UpDown;
        private NumericUpDown minutes_updown;
        private Label label6;
        private Label label7;
        private Button button1;
        private Panel panel1;
        private System.Windows.Forms.Timer timer_study;
        private Label label_timetaked;
        private Button stop_music;
        private Button button2;
        private OpenFileDialog openFileDialog1;
        private Panel panel2;
        private Label mission_name;
        private Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer_now;
        private Label label8;
        private TextBox mission_textBox6;
        private Button button5;
        private Button button4;
        private Button button6;
    }
}
