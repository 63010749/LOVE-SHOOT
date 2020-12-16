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
    public partial class Form2 : Form
    {
        int NewScore;
        int[] Swap = new int[5];

        string NewName;
        string[] Swap1 = new string[5];

        bool goLeft, goRight, goUp, goDown, gameOver;
        string facing = "up";
        int playerHealth = 100;
        int speed = 30;
        int ammo = 10;
        int zombieSpeed = 4;
        Random randNum = new Random();
        int choose;
        int score;
        List<PictureBox> zombiesList = new List<PictureBox>();
        List<PictureBox> hpallList = new List<PictureBox>();
        List<PictureBox> ammoallList = new List<PictureBox>();
        

        public Form2()
        {
            InitializeComponent();
            wplayer.URL = (@"C:\Users\Tang\Desktop\program_fun\LOVE SHOOT\LOVE SHOOT\Resources\background_sound.wav");
            wplayer.controls.play();
            axWindowsMediaPlayer1.Hide();
            panel1.Hide();
            panel2.Hide();
           
            RestartGame();
        }
        public static WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        private void MainTimerEvent(object sender, EventArgs e)
        {
            if (playerHealth > 1)
            {
                healthBar.Value = playerHealth;
                if (playerHealth > 1 && playerHealth < 30)
                {
                    pictureBox3.Image = Properties.Resources.B_Face3;
                }
                if (playerHealth > 29 && playerHealth < 60)
                {
                    pictureBox3.Image = Properties.Resources.B_Face2;
                }
                if (playerHealth > 59 && playerHealth < 101)
                {
                    pictureBox3.Image = Properties.Resources.B_Face1;
                }

                
            }

            else
            {
               
                panel1.Show();
                gameOver = true;
                wplayer.controls.stop();
                player.Image = Properties.Resources.Dead;
                GameTimer.Stop();
                
                
               
                
            }

            txtAmmo.Text = " " + ammo;
            txtScore.Text = " " + score;


            if (goLeft == true && player.Left > 0)
            {
                player.Left -= speed;
            }

            if (goRight == true && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += speed;
            }

            if (goUp == true && player.Top > 90)
            {
                player.Top -= speed;
            }

            if (goDown == true && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += speed;
            }



            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "ammo")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        ammo += 5;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "zombie")
                {
                    
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        if (score <= 20)
                        {
                            playerHealth -= 1;
                        }
                        if(score>= 20 && score <= 40)
                        {
                            playerHealth -= 3;
                        }
                        if (score >= 40 && score <= 70)
                        {
                            playerHealth -= 5;
                        }
                        if (score >= 70 && score <= 100)
                        {
                            playerHealth -= 10;
                        }
                        if (score >= 100)
                        {
                            playerHealth -= 15;
                        }

                    }
                    if (x.Left > player.Left)
                    {
                        x.Left -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zlef1;
                    }
                    if (x.Left < player.Left)
                    {
                        x.Left += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zright1;
                    }
                    if (x.Top > player.Top)
                    {
                        x.Top -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zup1;
                    }
                    if (x.Top < player.Top)
                    {
                        x.Top += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zdown1;
                    }

                    foreach (Control j in this.Controls)
                    {
                        if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "zombie")
                        {
                            if (x.Bounds.IntersectsWith(j.Bounds))
                            {
                                score++;
                                if (score % 10 == 0 && score != 0)
                                {
                                    DropHp();
                                }
                                this.Controls.Remove(j);
                                ((PictureBox)j).Dispose();
                                this.Controls.Remove(x);
                                ((PictureBox)x).Dispose();
                                zombiesList.Remove((PictureBox)x);
                                MakeZombies();
                            }
                        }
                    }
                }
                if (x is PictureBox && (string)x.Tag == "hp")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\Tang\Desktop\program_fun\LOVE SHOOT\LOVE SHOOT\sound\hp_sound.wav");
                        sound.Play();
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        if (playerHealth < 90)
                        {
                            playerHealth += 10;
                        }
                        else if (playerHealth >= 90 && playerHealth <100)
                        {
                            int prehealth = 100 - playerHealth;
                            playerHealth += prehealth;
                        }
                    }
                }

            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (gameOver == true)
            {
                return;
            }

            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                facing = "left";
                player.Image = Properties.Resources.Left1;
                choose = 2;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                facing = "right";
                player.Image = Properties.Resources.right1;
                choose = 2;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                facing = "up";
                player.Image = Properties.Resources.up1;
                choose = 1;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                facing = "down";
                player.Image = Properties.Resources.down1;
                choose = 1;
            }
        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }

            if (e.KeyCode == Keys.Space && ammo > 0 && gameOver == false)
            {
                ammo--;
                ShootBullet(facing);
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\Tang\Desktop\program_fun\LOVE SHOOT\LOVE SHOOT\sound\shoot_sound.wav");
                sound.Play();

                if (ammo < 1)
                {
                    DropAmmo();
                }

            }
        }

        private void ShootBullet(string direction)
        {
            Bullet shootBullet = new Bullet();
            shootBullet.direction = direction;
            shootBullet.bulletLeft = player.Left + (player.Width / 2);
            shootBullet.bulletTop = player.Top + (player.Height / 2);
            if (choose == 1)
            {
                shootBullet.MakeBullet(this);
            }
            if (choose == 2)
            {
                shootBullet.MakeBullet1(this);
            }

        }

        
        private void Form2_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = false;
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = false;
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                NewScore = score;
                NewName = textBox1.Text;


                if (NewScore > Convert.ToInt32(Score1.Text)) //If NewScore Is Higher Than #1
                {
                    Swap1[1] = Convert.ToString(Name1.Text);      //Swap[1] = Old Score1.Text
                    Name1.Text = Convert.ToString(NewName);    //Score1.Text = NewScore
                    Swap1[2] = Convert.ToString(Name2.Text);  //Swap[2] Old Score2.Text
                    Name2.Text = Convert.ToString(Swap1[1]); //Score2.Text = Prev Score1.Text
                    Swap1[3] = Convert.ToString(Name3.Text);  //Swap[3] = Old Score3.Text
                    Name3.Text = Convert.ToString(Swap1[2]); //score3.Text = Prev Score2.Text
                    Swap1[4] = Convert.ToString(Name4.Text);  //Swap[4] = Old Score4.Text
                    Name4.Text = Convert.ToString(Swap1[3]); //Score4.Text = Prev Score3.Text
                    Name5.Text = Convert.ToString(Swap1[4]); //Score5.Text = Prev Score4.Text

                    Swap[1] = Convert.ToInt32(Score1.Text);      //Swap[1] = Old Score1.Text
                    Score1.Text = Convert.ToString(NewScore);    //Score1.Text = NewScore
                    Swap[2] = Convert.ToInt32(Score2.Text);  //Swap[2] Old Score2.Text
                    Score2.Text = Convert.ToString(Swap[1]); //Score2.Text = Prev Score1.Text
                    Swap[3] = Convert.ToInt32(Score3.Text);  //Swap[3] = Old Score3.Text
                    Score3.Text = Convert.ToString(Swap[2]); //score3.Text = Prev Score2.Text
                    Swap[4] = Convert.ToInt32(Score4.Text);  //Swap[4] = Old Score4.Text
                    Score4.Text = Convert.ToString(Swap[3]); //Score4.Text = Prev Score3.Text
                    Score5.Text = Convert.ToString(Swap[4]); //Score5.Text = Prev Score4.Text
                }
                else

                    if (NewScore > Convert.ToInt32(Score2.Text)) //If NewScore Is Higher Than #2
                {
                    Swap1[1] = Convert.ToString(Name2.Text);   //Swap[1] = Old Score2.Text
                    Name2.Text = Convert.ToString(NewName); //Score2.Text = NewScore
                    Swap1[2] = Convert.ToString(Name3.Text);   //Swap[2] = Old Score3.Text
                    Name3.Text = Convert.ToString(Swap1[1]);  //score3.Text = Old Score2.Text
                    Swap1[3] = Convert.ToString(Name4.Text);  //Swap[3] = Old Score4.Text
                    Name4.Text = Convert.ToString(Swap1[2]);  //Score4.Text = Old Score3.Text
                    Name5.Text = Convert.ToString(Swap1[3]);  //Score5.Text = Old Score4.Text

                    Swap[1] = Convert.ToInt32(Score2.Text);   //Swap[1] = Old Score2.Text
                    Score2.Text = Convert.ToString(NewScore); //Score2.Text = NewScore
                    Swap[2] = Convert.ToInt32(Score3.Text);   //Swap[2] = Old Score3.Text
                    Score3.Text = Convert.ToString(Swap[1]);  //score3.Text = Old Score2.Text
                    Swap[3] = Convert.ToInt32(Score4.Text);  //Swap[3] = Old Score4.Text
                    Score4.Text = Convert.ToString(Swap[2]);  //Score4.Text = Old Score3.Text
                    Score5.Text = Convert.ToString(Swap[3]);  //Score5.Text = Old Score4.Text


                }
                else
                        if (NewScore > Convert.ToInt32(Score3.Text)) //If NewScore Is Higher Than #3
                {
                    Swap1[1] = Convert.ToString(Name3.Text);   //Swap[1] = Old Score3.Text
                    Name3.Text = Convert.ToString(NewName); //Score3.Text = NewScore
                    Swap1[2] = Convert.ToString(Name4.Text);   //Swap[2] = Old Score4.Text
                    Name4.Text = Convert.ToString(Swap1[1]);  //Score4.Text = Old Score3.Text
                    Name5.Text = Convert.ToString(Swap1[2]);  //Score5.Text = Old Score4.Text

                    Swap[1] = Convert.ToInt32(Score3.Text);   //Swap[1] = Old Score3.Text
                    Score3.Text = Convert.ToString(NewScore); //Score3.Text = NewScore
                    Swap[2] = Convert.ToInt32(Score4.Text);   //Swap[2] = Old Score4.Text
                    Score4.Text = Convert.ToString(Swap[1]);  //Score4.Text = Old Score3.Text
                    Score5.Text = Convert.ToString(Swap[2]);  //Score5.Text = Old Score4.Text
                }
                else
                            if (NewScore > Convert.ToInt32(Score4.Text)) //If NewScore Is Higher Than #4
                {
                    Swap1[1] = Convert.ToString(Name4.Text);   //Swap[1] = Old Score4.Text
                    Name4.Text = Convert.ToString(NewName); //Score4.Text = NewScore
                    Name5.Text = Convert.ToString(Swap1[1]);  //Score5.Text = Prev Score4.Text

                    Swap[1] = Convert.ToInt32(Score4.Text);   //Swap[1] = Old Score4.Text
                    Score4.Text = Convert.ToString(NewScore); //Score4.Text = NewScore
                    Score5.Text = Convert.ToString(Swap[1]);  //Score5.Text = Prev Score4.Text
                }
                else
                                if (NewScore > Convert.ToInt32(Score5.Text)) //If NewScore Is Higher Than #5
                {
                    Swap1[1] = Convert.ToString(Name5.Text);
                    Name5.Text = Convert.ToString(NewName); //Score5.Text = NewScore

                    Swap[1] = Convert.ToInt32(Score5.Text);
                    Score5.Text = Convert.ToString(NewScore); //Score5.Text = NewScore
                }

                //Saves The HighScores
                Properties.Settings.Default.Score1 = Score1.Text;
                Properties.Settings.Default.Score2 = Score2.Text;
                Properties.Settings.Default.Score3 = Score3.Text;
                Properties.Settings.Default.Score4 = Score4.Text;
                Properties.Settings.Default.Score5 = Score5.Text;

                Properties.Settings.Default.Name1 = Name1.Text;
                Properties.Settings.Default.Name2 = Name2.Text;
                Properties.Settings.Default.Name3 = Name3.Text;
                Properties.Settings.Default.Name4 = Name4.Text;
                Properties.Settings.Default.Name5 = Name5.Text;

                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
            }

            over option = new over();
            option.Show();
            Visible = false;

        }

        private void MakeZombies()
        {
            // when this function is called it will make zombies in the game

            PictureBox zombie = new PictureBox(); // create a new picture box called zombie
            
            zombie.Tag = "zombie"; // add a tag to it called zombie
            zombie.Image = Properties.Resources.zdown1; // the default picture for the zombie is zdown
            zombie.BackColor = Color.FromArgb(0, 0, 0, 0);
            zombie.Left = randNum.Next(0, 900); // generate a number between 0 and 900 and assignment that to the new zombies left 
            zombie.Top = randNum.Next(0, 800); // generate a number between 0 and 800 and assignment that to the new zombies top
            zombie.SizeMode = PictureBoxSizeMode.AutoSize; // set auto size for the new picture box
            zombiesList.Add(zombie);
            this.Controls.Add(zombie); // add the picture box to the screen
            player.BringToFront(); // bring the player to the front
        }

        private void DropHp()
        {
            PictureBox hp = new PictureBox(); // create a new instance of the picture box
            hp.BackColor = Color.FromArgb(0, 0, 0, 0);
            hp.Tag = "hp"; // set the tag to hp
            hp.Image = Properties.Resources.Hp_Image1; // assignment the ammo image to the picture box
            hp.Left = randNum.Next(10, this.ClientSize.Width - hp.Width); // set the location to a random left
            hp.Top = randNum.Next(40, this.ClientSize.Height - hp.Height); // set the location to a random top
            hp.SizeMode = PictureBoxSizeMode.AutoSize; // set the size to auto size
            hpallList.Add(hp);
            this.Controls.Add(hp); // add the ammo picture box to the screen
            hp.BringToFront(); // bring it to front
            player.BringToFront(); // bring the player t
        }

        private void DropAmmo()
        {

            // this function will make a ammo image for this game

            PictureBox ammo = new PictureBox(); // create a new instance of the picture box
            ammo.BackColor = Color.FromArgb(0, 0, 0, 0);
            ammo.Image = Properties.Resources.Ammo_Image1; // assignment the ammo image to the picture box
            ammo.SizeMode = PictureBoxSizeMode.AutoSize; // set the size to auto size
            ammo.Left = randNum.Next(10, this.ClientSize.Width - ammo.Width); // set the location to a random left
            ammo.Top = randNum.Next(40, this.ClientSize.Height - ammo.Height); // set the location to a random top
            ammo.Tag = "ammo"; // set the tag to ammo
            ammoallList.Add(ammo);
            this.Controls.Add(ammo); // add the ammo picture box to the screen
            ammo.BringToFront(); // bring it to front
            player.BringToFront(); // bring the player to front
        }

        private void RestartGame()
        {

            player.Image = Properties.Resources.up1;

            foreach (PictureBox i in zombiesList)
            {
                this.Controls.Remove(i);
            }
            foreach (PictureBox h in hpallList)
            {
                this.Controls.Remove(h);
            }

            foreach (PictureBox p in ammoallList)
            {
                this.Controls.Remove(p);
            }

            zombiesList.Clear();
            hpallList.Clear();
            ammoallList.Clear();

            for (int i = 0; i < 3; i++)
            {
                MakeZombies();
            }

            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;
            gameOver = false;

            playerHealth = 100;
            score = 0;
            ammo = 10;

            GameTimer.Start();

        }

    }
}
