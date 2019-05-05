using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mohammed_Jacksi
{
    public partial class MohammedJacksi : Form
    {
        public MohammedJacksi()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (lastIsNumber()) label1.Text += "*";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            firstZero();
            label1.Text += "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label1.Text += ".";

        }

        private void button17_Click(object sender, EventArgs e)
        {
            string math = label1.Text;
            string value = new DataTable().Compute(math, null).ToString();
            label1.Text = value;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if(lastIsNumber())
                label1.Text += "+";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            firstZero();
            label1.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            firstZero();
            label1.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            firstZero();
            label1.Text += "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (lastIsNumber())
                label1.Text += "-";
            else
                label1.Text = label1.Text.Substring(label1.Text.Length - 1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            firstZero();
            label1.Text += "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            firstZero();
            label1.Text += "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            firstZero();
            label1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            firstZero();
            label1.Text += "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            firstZero();
            label1.Text += "8";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            firstZero();
            label1.Text += "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lastIsNumber()) label1.Text += "/";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length>0)
            {
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
            }
            if (label1.Text.Length <= 0)
            {
                label1.Text = "0";
            }
        }
        

        private void _0_Click(object sender, EventArgs e)
        {
            if (lastIsNumber()) label1.Text += "%";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        void firstZero()
        {
            if (label1.Text == "0")
                label1.Text = "";
        }

        bool lastIsNumber()
        {
            char a = label1.Text[label1.Text.Length - 1];
            return a>='0' && a<='9';
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Enabled = !textBox1.Enabled;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter) return;

            switch (textBox1.Text)
            {
                case "file":
                    Files file = new Files();
                    file.ShowDialog();
                    break;
                case "thread":
                    Threads threads = new Threads();
                    threads.ShowDialog();
                    break;
                case "cpu":
                    CPU cpu = new CPU();
                    cpu.ShowDialog();
                    break;
                case "process":
                    Processes processes = new Processes();
                    processes.ShowDialog();
                    break;
                case "memory":
                    break;
                default:
                    break;
            }
            textBox1.Text = "";
        }
    }
}
