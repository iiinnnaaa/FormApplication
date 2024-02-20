using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Random rd = new Random();
        bool InProgress = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void startMove(object sender)
        {
            if (!InProgress)
            {
                InProgress = true;
                Point newPoint = new Point(rd.Next(this.ClientSize.Width - pictureBox1.Width),
                    rd.Next(this.ClientSize.Height - pictureBox1.Height));
                while (InProgress)
                {
                    pictureBox1.Location = new Point(
                        Math.Abs(pictureBox1.Location.X - newPoint.X) < 5
                            ? newPoint.X
                            : pictureBox1.Location.X + (newPoint.X - pictureBox1.Location.X) / 10,
                        Math.Abs(pictureBox1.Location.Y - newPoint.Y) < 5
                            ? newPoint.Y
                            : pictureBox1.Location.Y + (newPoint.Y - pictureBox1.Location.Y) / 10);
                    Thread.Sleep(20);
                }
            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startMove(pictureBox1);
            startMove(pictureBox2);
            startMove(pictureBox3);
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InProgress = false;
        }

        {
            PictureBox pb = (sender as PictureBox);
            if (pb.InvokeRequired)
            {
                pb.Invoke(new MoveDelegate(Move), pb);
            }

            else

            {
                pb.Location new Point(pb.Location.X + rd.Next(3, 7), pb.Location.Y);
                if (pb.Location.X > this.Width - pb.Width - 20)

                {
                }

                InProgress false;

                MessageBox.Show(string.Format("(e)", pb.Tag));
            }
        }

        Random rd new Random();

        bool InProgress = false;

        private void startMove(object sender)
        {
            while (InProgress)

            {
                Move(sender);
                Thread.Sleep(20);
            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)

        {
            pictureBox1.Location = new Point(66, 168);

            pictureBox2.Location = new Point(66, 407);

            pictureBox3.Location = new Point(66, 287);


            InProgress true;

            Thread t1 = new Thread(startMove);

            t1.Start(pictureBox1);
        }
    }