using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
namespace timing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



        }
        private System.Windows.Forms.Timer timenow1 = new System.Windows.Forms.Timer();


        private void timer1_Tick(object sender, EventArgs e)
        {


            date_label.Text = DateTime.Now.ToString("dddd  |  MM dd yyyy  |  'ÓÇÚÉ'   hh : mm : ss");

        }
        WMPLib.WindowsMediaPlayer wmp1;

        public void Form1_Load(object sender, EventArgs e)
        {
            wmp1 = new WMPLib.WindowsMediaPlayer();
            wmp1.URL = @"bomb-explosion.mp3";
            wmp1.controls.stop();
            timer_now.Start();
            textBoxes = new TextBox[]
             {
            mission_textBox1,
            mission_textbox2,
            mission_textBox3,
            mission_textBox4,
            mission_textBox5,
            mission_textBox6
                };

        }

        #region CheckMission

        //private void mission1_check_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (mission1_check.Checked == true)
        //    {
        //        mission_textBox1.Enabled = true;
        //    }
        //    else
        //    {
        //        mission_textBox1.Enabled = false;
        //    }





        //}

        //private void mission2_check_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (mission2_check.Checked == true)
        //    {
        //        mission_textbox2.Enabled = true;
        //    }
        //    else
        //    {
        //        mission_textbox2.Enabled = false;
        //    }

        //}

        //private void mission3_check_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (mission3_check.Checked == true)
        //    {
        //        mission_textBox3.Enabled = true;
        //    }
        //    else
        //    {
        //        mission_textBox3.Enabled = false;
        //    }

        //}

        //private void mission4_check_CheckedChanged(object sender, EventArgs e)
        //{

        //    if (mission4_check.Checked == true)
        //    {
        //        mission_textBox4.Enabled = true;
        //    }
        //    else
        //    {
        //        mission_textBox4.Enabled = false;
        //    }
        //}

        //private void mission5_check_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (mission5_check.Checked == true)
        //    {
        //        mission_textBox5.Enabled = true;
        //    }
        //    else
        //    {
        //        mission_textBox5.Enabled = false;
        //    }

        //}

        #endregion


        TextBox[] textBoxes;

        public int study_hours = 0;
        public int study_minutes = 0;

        public int Seconds = 60;

        public string Sound_Url;

        #region timers
        private void timer1_study(object sender, EventArgs e)
        {


            if (study_hours > 0 || study_minutes > 0)
            {


                Seconds -= 1;
                // Print the current time
                label_timetaked.Text = $"Current time: {study_hours} hours, {study_minutes - 1} minutes {Seconds}seconds";

                // Wait for 1 second to simulate real-time countdown
                if (Seconds == 0)
                {


                    // Subtract 1 minute
                    study_minutes--;
                    Seconds = 60;
                    // Check if minutes have gone below 0
                    if (study_minutes < 1 && study_hours > 0)
                    {
                        study_minutes = 60; // Reset minutes
                        study_hours--; // Subtract 1 hour
                    }
                }

            }
            else
            {

                label_timetaked.Text = $"Timer:{00} hours,{00} minutes{00}seconds";




                wmp1.controls.play();


                Reset_time();




            }






        }








        #endregion

        string[] missions = new string[6];
        int the_current_mission = 0;


        private void Add_Time(object sender, EventArgs e)
        {
            wmp1.controls.stop();

            if (the_current_mission == 5)
            {
                MessageBox.Show("Missions End", "problem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }





            runing_time();






        }



        public void runing_time()
        {
            study_hours = Convert.ToInt32(hours_UpDown.Value);
            study_minutes = Convert.ToInt32(minutes_updown.Value);



            if (the_current_mission < 5 && textBoxes[the_current_mission + 1].Text != "")
            {
                the_current_mission++;
            }
            else
            {
                the_current_mission = 0;
            }
            mission_name.Text = missions[the_current_mission];

            timer_study.Start();

        }



        private void stop_music_Click(object sender, EventArgs e)
        {
            wmp1.controls.stop();
        }

        private void Add_new_sound(object sender, EventArgs e)
        {


            openFileDialog1.ShowDialog();
            Sound_Url = openFileDialog1.FileName;
            if (Sound_Url != null && Sound_Url != "openFileDialog1")
            {
                wmp1.URL = Sound_Url;

            }
        }




        private void End_Click(object sender, EventArgs e)
        {


            Reset_time();
        }





        public void Reset_time()
        {
            study_hours = 0;
            study_minutes = 0;
            timer_study.Stop();



        }




        int visible_button = 1;
        private void button5_Click(object sender, EventArgs e)
        {
            if (visible_button == 1)
            {
                mission_textbox2.Visible = true;
                label2.Visible = true;
                visible_button++;
            }
            else if (visible_button == 2)
            {
                mission_textBox3.Visible = true;
                label3.Visible = true;
                visible_button++;
            }
            else if (visible_button == 3)
            {
                mission_textBox4.Visible = true;
                label4.Visible = true;
                visible_button++;
            }
            else if (visible_button == 4)
            {
                mission_textBox5.Visible = true;
                label5.Visible = true;
                visible_button++;
            }
            else if (visible_button == 5)
            {
                if (mission_textBox6.Visible)
                {
                    MessageBox.Show("You have already added 6 missions", "problem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                mission_textBox6.Visible = true;
                label8.Visible = true;

            }

        }



        private void button4_Click(object sender, EventArgs e)
        {
            if (visible_button == 5)
            {
                mission_textBox6.Visible = false;
                label8.Visible = false;
                mission_textBox6.Text = "";
                visible_button--;
                mission_textBox6_TextChanged(sender, e);

            }
            else if (visible_button == 4)
            {
                mission_textBox5.Visible = false;
                label5.Visible = false;
                mission_textBox5.Text = "";
                visible_button--;

                mission_textBox5_TextChanged(sender, e);
            }
            else if (visible_button == 3)
            {
                mission_textBox4.Visible = false;
                label4.Visible = false;
                mission_textBox4.Text = "";
                visible_button--;

                mission_textBox4_TextChanged(sender, e);
            }
            else if (visible_button == 2)
            {
                mission_textBox3.Visible = false;
                label3.Visible = false;
                mission_textBox3.Text = "";
                visible_button--;
                mission_textBox3_TextChanged(sender, e);
            }
            else if (visible_button == 1)
            {
                if (mission_textbox2.Visible == false)
                {
                    MessageBox.Show("You have already removed 6 missions", "problem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                mission_textbox2.Visible = false;
                label2.Visible = false;
                mission_textbox2.Text = "";

                mission_textbox2_TextChanged(sender, e);
            }



        }

        private void mission_textBox1_TextChanged(object sender, EventArgs e)
        {

            if (mission_textBox1.Enabled && mission_textBox1.Text != "")
            {
                missions[0] = mission_textBox1.Text;



            }
            else
            {
                missions[0] = null;
            }

        }

        private void mission_textbox2_TextChanged(object sender, EventArgs e)
        {
            if (mission_textbox2.Enabled && mission_textbox2.Text != "")
            {
                missions[1] = mission_textbox2.Text;



            }
            else
            {
                missions[1] = null;
            }
        }

        private void mission_textBox3_TextChanged(object sender, EventArgs e)
        {
            if (mission_textBox3.Enabled && mission_textBox3.Text != "")
            {
                missions[2] = mission_textBox3.Text;



            }
            else
            {
                missions[2] = null;
            }
        }

        private void mission_textBox4_TextChanged(object sender, EventArgs e)
        {
            if (mission_textBox4.Enabled && mission_textBox4.Text != "")
            {
                missions[3] = mission_textBox4.Text;



            }
            else
            {
                missions[3] = null;
            }
        }

        private void mission_textBox5_TextChanged(object sender, EventArgs e)
        {
            if (mission_textBox5.Enabled && mission_textBox5.Text != "")
            {
                missions[4] = mission_textBox5.Text;



            }
            else
            {
                missions[4] = null;
            }
        }

        private void mission_textBox6_TextChanged(object sender, EventArgs e)
        {
            if (mission_textBox6.Enabled && mission_textBox6.Text != "")
            {
                missions[5] = mission_textBox6.Text;



            }
            else
            {
                missions[5] = null;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            string text_url = openFileDialog1.FileName;
            if (text_url != null && Sound_Url != "openFileDialog1")
            {
               FileStream file = new FileStream(text_url, FileMode.Append, FileAccess.Write);
                StreamWriter writer = new StreamWriter(file);

                writer.WriteLine(date_label.Text);
                if (mission_textBox1.Text != "")
                {
                    writer.WriteLine("Mission 1: " + mission_textBox1.Text);
                }
                else if (mission_textbox2.Text!="")
                {
                    writer.WriteLine( "Mission 2: " + mission_textbox2.Text);
                }
                else if (mission_textBox3.Text != "")
                {
                    writer.WriteLine("Mission 3: " + mission_textBox3.Text);
                }
                else if (mission_textBox4.Text != "")
                {
                    writer.WriteLine("Mission 4: " + mission_textBox4.Text);
                }
                else if (mission_textBox5.Text != "")
                {
                    writer.WriteLine("Mission 5: " + mission_textBox5.Text);
                }
                else if (mission_textBox6.Text != "")
                {
                    writer.WriteLine("Mission 6: " + mission_textBox6.Text);
                }


                writer.WriteLine("--------------------------------------");

                writer.Close();
                file.Close();

            }
        }
    }
}
