using BattleShipGame.Models;
using System.Media;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
using Microsoft.VisualBasic.Devices;

namespace BattleShipGame
{
    public partial class Form1 : Form
    {

        System.Windows.Forms.Timer _gameTimer;
        System.Windows.Forms.Timer _enemyTimer;

        private bool _isSpacePressed = false;


        Bitmap explosion = new Bitmap("Resources/boom02.png");
        Ship ship = new Ship(0, 0, 0, 0);
        Image shipImage = Image.FromFile("Resources/ship01.png");


        private bool isStart = false;
        int score;
        private Bitmap backBuffer;
        public Graphics graphics;
        public Graphics eGraphics;
        private int curFrameColumn;
        private int curFrameRow;
        List<Enemy> _enemyList = new List<Enemy>();
        List<Bullet> _bulletList = new List<Bullet>();
        List<Exploding> _explosionList = new List<Exploding>();
        public Form1()
        {
            InitializeComponent();
            graphics = this.CreateGraphics();
            eGraphics = this.CreateGraphics();
            DoubleBuffered = true;



            _gameTimer = new Timer();
            _gameTimer.Enabled = true;
            _gameTimer.Interval = 50;
            _gameTimer.Tick += new EventHandler(_gametimer_Tick);


            _enemyTimer = new Timer();
            _enemyTimer.Enabled = true;
            _enemyTimer.Interval = 3000;
            _enemyTimer.Tick += new EventHandler(_enemyTimer_Tick);


            _gameTimer.Start();
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            backBuffer = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            score = 0;
        }
        private void mExplosion(Exploding ex)
        {
            Graphics g = Graphics.FromImage(backBuffer);
            g.Clear(Color.Empty);
            curFrameColumn = ex.indexE % 5;
            curFrameRow = ex.indexE / 5;
            if (!ex.isShip)
                g.DrawImage(explosion, new Rectangle(ex.x - ship.width / 2 - 25, ex.y - ship.height / 2 - 25, ship.width + 50, ship.height + 50), new Rectangle(curFrameColumn * 130, curFrameRow * 130, 130, 130), GraphicsUnit.Pixel);
            else
                g.DrawImage(explosion, new Rectangle(ex.x - 85, ex.y - 85, 200, 200), new Rectangle(curFrameColumn * 130, curFrameRow * 130, 130, 130), GraphicsUnit.Pixel);
            g.Dispose();
            ex.indexE++;

        }
        private void _gametimer_Tick(object sender, EventArgs e)
        {
            shipRun();
            if (!isStart)
            {
                ship.SetShip(this.Width / 2, this.Height - 100, shipImage.Width / 6, shipImage.Height / 6);
                graphics.DrawImage(shipImage, ship.p.X - ship.width / 2, ship.p.Y - ship.height / 2, ship.width, ship.height);
                isStart = true;
            }
            scoreBox.Text = score.ToString();
            EnemyCome();
            Refresh();
        }
        private void EnemyCome()
        {
            Rectangle shpRec = new Rectangle(ship.p.X - ship.width / 2 + 10, ship.p.Y - ship.height / 2 + 10, ship.width - 20, ship.height - 20);
            for (int i = 0; i < _enemyList.Count; i++)
            {
                Rectangle enRec = new Rectangle(_enemyList[i].p.X - _enemyList[i].width / 2, _enemyList[i].p.Y - _enemyList[i].height / 2, _enemyList[i].width, _enemyList[i].height);
                _enemyList[i].p.Y += _enemyList[i].speed;
                if (_enemyList[i].p.Y > this.Height + 20)
                {
                    _enemyList.RemoveAt(i);
                    i--;

                }
            }

            //    for (int j = 0; j < bullet_list.Count; j++)
            //    {
            //        Rectangle bulRec = new Rectangle(bullet_list[j].p.X - bullet_list[j].wi / 2, bullet_list[j].p.Y - bullet_list[j].he / 2 - 20, bullet_list[j].wi, bullet_list[j].he);
            //        if (enRec.IntersectsWith(bulRec))
            //        {
            //            enemi_list[i].HP -= bullet_list[j].dame;
            //            if (bullet_list[j].type != 4)
            //            {
            //                bullet_list.RemoveAt(j);
            //                j--;
            //            }
            //            Explosion ex = new Explosion(enemi_list[i].p.X, enemi_list[i].p.Y, enemi_list[i].wi);
            //            if (enemi_list[i].HP <= 0)
            //            {
            //                score += enemi_list[i].type * 10;

            //                enemi_list.RemoveAt(i);

            //                i--;

            //            }
            //            explosion_list.Add(ex);

            //        }
            //    }
            //    if (enRec.IntersectsWith(shpRec))
            //    {
            //        enemi_list.RemoveAt(i);
            //        i--;
            //        Explosion ex = new Explosion(ship.p.X, ship.p.Y, ship.wi);
            //        ex.isShip = true;
            //        explosion_list.Add(ex);
            //        ship.setShip(0, 0, 0, 0);
            //        game_timer.Interval = 300;
            //        loose();

            //    }
            //}

            //for (int i = 0; i < bullet_list.Count; i++)
            //{
            //    bullet_list[i].p.Y -= bullet_list[i].speed;
            //    if (bullet_list[i].p.Y < -20)
            //    {

            //        bullet_list.RemoveAt(i);
            //        i--;
            //    }
            //}
            
        }
        private void shipRun()
        {
            //double velocity = /*(speed: pixels per seconds)*/ 150 * /*(timer tick time in seconds)*/ 0.05;

            //if ()
            //{
            //    if (ship.p.Y - ship.he / 2 > 0)

            //        ship.p.Y -= (int)velocity;
            //}
            //if (Keyboard.IsKeyDown(Keys.Down))
            //{
            //    if (ship.p.Y + ship.he / 2 + 50 <= this.Height)
            //        ship.p.Y += (int)velocity;
            //}
            //if (Keyboard.IsKeyDown(Keys.Left))
            //{
            //    if (ship.p.X - ship.wi / 2 - 5 > 0)
            //        ship.p.X -= (int)velocity;
            //}
            //if (Keyboard.IsKeyDown(Keys.Right))
            //{
            //    if (ship.p.X + ship.wi / 2 + 20 <= this.Width)
            //        ship.p.X += (int)velocity;
            //}

        }

        private void _enemyTimer_Tick(object sender, EventArgs e)
        {
            Random rd = new Random();
            int x = rd.Next(50, this.Width - 50);
            Enemy enemy = new Enemy(x, 0);
            enemy.eImage = Image.FromFile("Resources/bullet.png");
            _enemyList.Add(enemy);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (!_gameTimer.Enabled)
                return;

            foreach (Enemy en in _enemyList)
            {
                e.Graphics.DrawImage(en.eImage, en.p.X - en.width / 2, en.p.Y - en.height / 2, en.width, en.height);

            }
            foreach (Bullet bullet in _bulletList)
            {
                e.Graphics.DrawImage(bullet.bImage, bullet.p.X - bullet.width / 2, bullet.p.Y - bullet.height / 2, bullet.width, bullet.height);
            }

            

        }
    }
}