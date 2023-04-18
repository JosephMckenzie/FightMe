//using static Form1;

namespace FightMe
{
    public partial class FightingGameMainForm : Form
    {
        public Player player1 = new(0, 0);
        public int floorHeight = 500;
        public double gravity = 0.9;
        public System.Windows.Forms.Timer gameTimer = new();



        public FightingGameMainForm()
        {

            InitializeComponent();
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


            /*optionsbutt.Location = new Point(this.Width / 2 - optionsbutt.Width / 2, this.Height / 2 - optionsbutt.Height / 2);
            startbutt.Location = new Point(this.Width / 2 - startbutt.Width / 2, optionsbutt.Location.Y - exitbutt.Height);
            exitbutt.Location = new Point(this.Width / 2 - exitbutt.Width / 2, optionsbutt.Location.Y + exitbutt.Height);
            volumebutt.Location = new Point(this.Width / 2 - volumebutt.Width / 2, this.Height / 2 - volumebutt.Height / 2);
            videobutt.Location = new Point(this.Width / 2 - videobutt.Width / 2, volumebutt.Location.Y - videobutt.Height);
            controlsbutt.Location = new Point(this.Width / 2 - controlsbutt.Width / 2, volumebutt.Location.Y + volumebutt.Height);*/
            backbutt.Location = new Point(this.Width / 2 - backbutt.Width / 2);
           
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

            grav();
            //XMovePlayer();
        }


        void timertick(object sender, EventArgs e)
        {

        }
        //void keyup(object sender, KeyPressEventArgs e)
        void keypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                Application.Exit();
            }
            /* Cool_image.Location = new Point(player1.X, player1.Y);
             if (e.KeyChar == 100)
             {
                 player1.moving_right = true;
                 this.Text = player1.moving_right.ToString();

             }*/
        }

        void grav()
        {
            player1.grounded = player1.Y + player1.height >= this.Height - floorHeight;
            if (!player1.grounded) player1.Yvelocity += (int)gravity;
            System.Threading.Thread.Sleep(1000 / 60);
            if (player1.moving_right)
            {
                player1.Xvelocity += 2;
            }
            else
            {
                player1.Xvelocity = 0;
            }

            if (player1.Y == floorHeight)
            {
                player1.grounded = true;
            }

            else
            {
                player1.grounded = false;
            }

            if (!player1.grounded)
            {
                player1.Yvelocity += gravity;
                Cool_image.Location = new Point(player1.X, player1.Y);
            }
            if (player1.Y + Cool_image.Height + player1.Yvelocity >= floorHeight)
            {
                player1.Y = floorHeight;
                player1.grounded = true;
            }

            player1.X += (int)Math.Round(player1.Xvelocity);
            player1.Y += (int)Math.Round(player1.Yvelocity);
            if (player1.grounded)
            {
                player1.Y = this.Height - floorHeight - Cool_image.Height - 1;
                player1.Yvelocity = 0;
            }
        }
        /* void XMovePlayer()
         {
             MoveLeft();
             MoveRight();

             player1.X += (int)math.round(player1.Xvelocity);
             if (!player1.Xvelocity > 10)
             {
                 player1.Xvelocity = 10;
             }
             Cool_image.Location = new (player1.X, player1.Y);
         }*/

        public void MoveLeft(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 65)
            {
                player1.moving_left = true;
                player1.Xvelocity -= 10;
            }
            else
            {
                player1.moving_left = false;
            }
        }
        public void MoveRight(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 68)
            {
                player1.moving_right = true;
                player1.Xvelocity += 10;
            }
            else
            {
                player1.moving_right = false;
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

            public Player(int X, int Y)
            {
                this.X = X;
                this.Y = Y;
                Xvelocity = 0;
                Yvelocity = 0;
                height = 50;
                grounded = false;
                moving_left = false;
                moving_right = false;
            }

        }



    }
}