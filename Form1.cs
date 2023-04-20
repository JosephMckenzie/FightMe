//using static Form1;

using System;
using System.Xml.Schema;

namespace FightMe
{
    public partial class FightingGameMainForm : Form
    {
        public Player player1 = new(0, 0);
        public int floorHeight = (1800 / 5) * 4;
        public double gravity = 9.81;
        public System.Windows.Forms.Timer gameTimer = new();
        private int xVelocityMax = 30;
        private int xVelocityMin = -30;
        public bool grounded;
        private int jumps;

        public FightingGameMainForm()
        {

            InitializeComponent();
            Cool_image.Image = FightMe.Properties.Resources.pixil_frame_0;
            this.KeyPreview = true;
            gameTimer.Interval = 40;
            //int volval = volumeslider.Value;

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            this.BackgroundImage = new Bitmap(this.Width, this.Height);
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.DoubleBuffered = true;
            gameTimer.Tick += gameloop;
            Cool_image.Location = new Point(player1.X, player1.Y);
            punchbox.Hide();
            player1.punchbox = punchbox;
            punchbox.Location = new Point(player1.X + 200, player1.Y + 136);

            optionsbutt.Location = new Point(this.Width / 2 - optionsbutt.Width / 2, this.Height / 2 - optionsbutt.Height / 2);
            startbutt.Location = new Point(this.Width / 2 - startbutt.Width / 2, optionsbutt.Location.Y - exitbutt.Height);
            exitbutt.Location = new Point(this.Width / 2 - exitbutt.Width / 2, optionsbutt.Location.Y + exitbutt.Height);
            volumebutt.Location = new Point(this.Width / 2 - volumebutt.Width / 2, this.Height / 2 - volumebutt.Height / 2);
            videobutt.Location = new Point(this.Width / 2 - videobutt.Width / 2, volumebutt.Location.Y - videobutt.Height);
            controlsbutt.Location = new Point(this.Width / 2 - controlsbutt.Width / 2, volumebutt.Location.Y + volumebutt.Height);
            backbutt.Location = new Point(this.Width / 2 - backbutt.Width / 2);

            videobutt.Hide();
            volumebutt.Hide();
            controlsbutt.Hide();
            backbutt.Hide();
        }

        private void optionsbutt_Click(object sender, EventArgs e)
        {
            startbutt.Hide();
            optionsbutt.Hide();
            exitbutt.Hide();
            volumebutt.Show();
            videobutt.Show();
            controlsbutt.Show();
            backbutt.Show();

        }

        private void startbutt_Click(object sender, EventArgs e)
        {
            startbutt.Hide();
            optionsbutt.Hide();
            exitbutt.Hide();
            backbutt.Hide();
            Cool_image.Show();
            gameTimer.Start();



        }

        private void exitbutt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void volumebutt_Click(object sender, EventArgs e)
        {
            volumebutt.Hide();
            videobutt.Hide();
            controlsbutt.Hide();
            //volumeslider.Show();
            //volsli_txtbox.Show();
            // vol_device_dropbox.Show();
        }

        private void backbutt_Click(object sender, EventArgs e)
        {
            volumebutt.Hide();
            videobutt.Hide();
            controlsbutt.Hide();
            backbutt.Hide();
            //volumeslider.Hide();
            // volsli_txtbox.Hide();
            // vol_device_dropbox.Hide();
            // subtitles.Hide();
            startbutt.Show();
            optionsbutt.Show();
            exitbutt.Show();
        }

        private void videobutt_Click(object sender, EventArgs e)
        {
            volumebutt.Hide();
            videobutt.Hide();
            controlsbutt.Hide();
            // subtitles.Show();
        }

        void gameloop(object sender, EventArgs e)
        {
            punchbox.Location = new Point(player1.X + 200, player1.Y + 136);

            grav();
            if (player1.moving_left)
            {
                MoveLeft();
            }
            if (player1.moving_right)
            {
                MoveRight();
            }
            if (!player1.moving_left && !player1.moving_right && player1.Xvelocity < 0)
            {
                player1.Xvelocity = 0;

            }
            if (!player1.moving_right && !player1.moving_left && player1.Xvelocity > 0)
            {
                player1.Xvelocity = 0;
            }
            if (player1.X < 0)
            {
                player1.X = 0;
                player1.Xvelocity = 0;
            }
            if (player1.X >= this.Width)
            {
                player1.X = this.Width;
                player1.Xvelocity = 0;
            }
            player1.handleFrameTick();

        }
        void keydown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.D)
            {
                player1.moving_right = true;
            }

            if (e.KeyCode == Keys.A)
            {
                player1.moving_left = true;
            }

        }
        void keyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                player1.moving_right = false;
            }
            if (e.KeyCode == Keys.A)
            {
                player1.moving_left = false;
            }
        }


        void keypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                Application.Exit();
            }
            if (jumps == 1 && e.KeyChar == 119)
            {
                jump();
            }
            if (e.KeyChar == 117 && player1.punchdelaying == false)
            {
                player1.punch();
            }
        }

        void grav()
        {
            player1.grounded = player1.Y + player1.height >= this.Height - floorHeight;
            if (!player1.grounded) player1.Yvelocity += (int)gravity;
            System.Threading.Thread.Sleep(1000 / 60);
            if (player1.Y == floorHeight)
            {
                player1.grounded = true;
            }

            else
            {
                player1.grounded = false;
                jumps = 0;
            }

            if (!player1.grounded)
            {
                player1.Yvelocity += gravity;
                Cool_image.Location = new Point(player1.X, player1.Y);
            }
            if (player1.Y + Cool_image.Height + player1.Yvelocity >= floorHeight)
            {
                player1.Yvelocity = 0;
                player1.grounded = true;
                player1.Y += (int)Math.Round(player1.Yvelocity);
            }


            player1.Y += (int)Math.Round(player1.Yvelocity);
            if (player1.grounded)
            {
                player1.Yvelocity = 0;
                if (jumps < 1)
                {
                    jumps = 1;
                }

            }
            if (player1.Y <= 0)
            {
                player1.Y = 0;
                player1.Yvelocity = 0;
            }
        }

        public void MoveLeft()
        {
            player1.Xvelocity -= 5;
            player1.X += (int)Math.Round(player1.Xvelocity);
            if (player1.Xvelocity <= xVelocityMin)
            {
                player1.Xvelocity = xVelocityMin;
            }
        }

        public void MoveRight()
        {
            {
                player1.Xvelocity += 5;
                player1.X += (int)Math.Round(player1.Xvelocity);
                if (player1.Xvelocity >= xVelocityMax)
                {
                    player1.Xvelocity = xVelocityMax;
                }
            }
        }

        public void jump()
        {
            grounded = false;
            player1.Yvelocity -= 110;
            if (player1.Yvelocity >= 110)
            {
                player1.Yvelocity = 110;
            }
        }

        public class Player
        {
            public int X;
            public int Y;
            public double Xvelocity;
            public double Yvelocity;
            public int height;
            public bool moving_right;
            public bool moving_left;
            public bool grounded;
            public bool punching;
            public int punchtimer;
            public PictureBox punchbox;
            public bool punchdelaying;
            public int punchdelayer;

            public Player(int X, int Y)
            {
                this.X = X;
                this.Y = Y;
                punching = false;
                Xvelocity = 0;
                Yvelocity = 0;
                height = 400;
                grounded = false;
                moving_left = false;
                moving_right = false;
            }

            public void punch()
            {
                punchtimer = 5;
                punching = true;
                punchbox.Show();
                punchdelayer = 10;
                punchdelaying = true;

            }

            public void handleFrameTick()
            {
                if (punchtimer > 0)
                {
                    punchtimer--;
                }
                if (punchdelayer > 0)
                {
                    punchdelayer--;
                }

                if (punchtimer == 0)
                {
                    punchbox.Hide();
                    punching = false;

                }
                if (punchdelayer == 0)
                {
                    punchdelaying = false;
                }

            }
        }
    }
}