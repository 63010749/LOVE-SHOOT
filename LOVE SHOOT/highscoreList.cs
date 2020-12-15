using System;
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
    public partial class highscoreList : Form
    {
        public highscoreList()
        {
            InitializeComponent();
        }

        private void highscoreList_Load(object sender, EventArgs e)
        {
            Score1.Text = Convert.ToString(Properties.Settings.Default.Score1);
            Score2.Text = Convert.ToString(Properties.Settings.Default.Score2);
            Score3.Text = Convert.ToString(Properties.Settings.Default.Score3);
            Score4.Text = Convert.ToString(Properties.Settings.Default.Score4);
            Score5.Text = Convert.ToString(Properties.Settings.Default.Score5);

            Name1.Text = Convert.ToString(Properties.Settings.Default.Name1);
            Name2.Text = Convert.ToString(Properties.Settings.Default.Name2);
            Name3.Text = Convert.ToString(Properties.Settings.Default.Name3);
            Name4.Text = Convert.ToString(Properties.Settings.Default.Name4);
            Name5.Text = Convert.ToString(Properties.Settings.Default.Name5);

            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 option = new Form1();
            option.Show();
            Visible = false;
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
    }
}
