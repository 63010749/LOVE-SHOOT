﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOVE_SHOOT
{
    public partial class option_page : Form
    {
        public option_page()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Form1.wplayer.controls.play();
            Form2.wplayer.controls.play();
            pictureBox2.Image = Properties.Resources.sound_on1;
            Form1.wplayer.settings.volume = trackBar1.Value;
            Form2.wplayer.settings.volume = trackBar1.Value;

            if (trackBar1.Value == 0)
            {
                pictureBox2.Image = Properties.Resources.sound_off1;
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.back_to_menu1;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\Tang\Desktop\program_fun\second_game\test_2\test_2\Resources\button_sound.wav");
            sound.Play();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.back_to_menu1;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Form1 option = new Form1();
            option.Show();
            Visible = false;
        }

        private void option_page_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = false;
        }
    }
}
