using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Mohammed_Jacksi
{
    public partial class Threads : Form
    {

        Thread thread1;
        Thread thread2;
        Thread thread3;

        public Threads()
        {
            InitializeComponent();
        }

        void first()
        {
            while (true)
            {
                Graphics g = progressBar1.CreateGraphics();
                Rectangle red = progressBar1.ClientRectangle;
                Rectangle yellow = progressBar1.ClientRectangle;
                Random rand = new Random();

                int num = rand.Next(yellow.Height);
                yellow.Height = num;
                g.FillRectangle(Brushes.Red, red);
                g.FillRectangle(Brushes.Yellow, yellow);
                Thread.Sleep(100);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (thread1 == null)
            {
                thread1 = new Thread(new ThreadStart(first));
                thread1.Start();
            }

        }

        void third()
        {
            while (true)
            {
                Graphics g = progressBar3.CreateGraphics();
                Rectangle red = progressBar3.ClientRectangle;
                Rectangle yellow = progressBar3.ClientRectangle;
                Random rand = new Random();

                int num = rand.Next(yellow.Height);
                yellow.Height = num;
                g.FillRectangle(Brushes.Red, red);
                g.FillRectangle(Brushes.Yellow, yellow);
                Thread.Sleep(100);
            }

        }


        void second()
        {
            while (true)
            {
                Graphics g = progressBar2.CreateGraphics();
                Rectangle red = progressBar2.ClientRectangle;
                Rectangle yellow = progressBar2.ClientRectangle;
                Random rand = new Random();

                int num = rand.Next(yellow.Height);
                yellow.Height = num;
                g.FillRectangle(Brushes.Red, red);
                g.FillRectangle(Brushes.Yellow, yellow);
                Thread.Sleep(100);
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (thread1 != null)
            {
                thread1.Abort();
                thread1 = null;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (thread2 == null)
            {
                thread2 = new Thread(new ThreadStart(second));
                thread2.Start();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (thread2 != null)
            {
                thread2.Abort();
                thread2 = null;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (thread3 == null)
            {
                thread3 = new Thread(new ThreadStart(third));
                thread3.Start();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (thread3 != null)
            {
                thread3.Abort();
                thread3 = null;
            }
        }
    }
}
