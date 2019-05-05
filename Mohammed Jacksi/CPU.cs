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
    public partial class CPU : Form
    {
        void clear_textbox()
        {
            textBox1.Text = "";
            burst.Text = "";
            priority.Text = "";
            priorityTextBox.Text = "";
        }
        void hide_quantum()
        {
            label1.Visible = false;
            q.Visible = false;
        }
        void show_quantum()
        {
            label1.Visible = true;
            q.Visible = true;
        }
        void hide_priorty()
        {
            priorityTextBox.Visible = false;
            priority_label.Visible = false;
            priority.Visible = false;
        }
        void show_priorty()
        {
            priorityTextBox.Visible = true;
            priority_label.Visible = true;
            priority.Visible = true;
        }
        public CPU()
        {
            InitializeComponent();
            hide_quantum();
            hide_priorty();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            clear_textbox();
            show_quantum();
            hide_priorty();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            clear_textbox();
            hide_quantum();
            hide_priorty();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            clear_textbox();
            hide_quantum();
            hide_priorty();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            clear_textbox();
            hide_quantum();
            show_priorty();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(burst.Text);
            if (priorityRadioButton.Checked)
            {
                priorityTextBox.AppendText(priority.Text);
                priorityTextBox.AppendText("\r\n");
            }
            textBox1.AppendText("\r\n");
            priority.Text = "";
            burst.Text = "";
            burst.Focus();
        }

        int[] getBurstTime()
        {
            String myString = textBox1.Text.Substring(0,textBox1.Text.Length - 1);
            String[] burst_time = myString.Split('\n');
            
            int[] myint = Array.ConvertAll<string, int>(burst_time, int.Parse);
            return myint;
        }

        int[] getPriority()
        {
            String myString = priorityTextBox.Text.Substring(0, textBox1.Text.Length - 1);
            String[] priority = myString.Split('\n');

            int[] myint = Array.ConvertAll<string, int>(priority, int.Parse);
            return myint;
        }

        int[] getBurstTimeWithPriority()
        {
            int[] priority = getPriority();
            int[] burst_time = getBurstTime();
            Array.Sort(priority, burst_time);

            return burst_time;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (fcfsRadioButton.Checked) 
            {
                fcfs();
            } else if (sjfRadioButton.Checked)
            {
                sjf();
            } else if (priorityRadioButton.Checked)
            {
                prior();
            }
            else
            {
                rr();
            }
        }

        void fcfs()
        {
            int[] burst = getBurstTime();
            int[] wt = new int[burst.Length];
            // waiting time for first process is 0 
            wt[0] = 0;

            // calculating waiting time 
            for (int i = 1; i < burst.Length; i++)
                wt[i] = burst[i - 1] + wt[i - 1];
            int sum = wt.Sum();
            double awt = Convert.ToDouble(sum) / Convert.ToDouble(burst.Length);
            MessageBox.Show("FCFS AWT: " + awt);
        }

        void sjf()
        {
            int[] burst = getBurstTime();
            Array.Sort(burst);
            int[] wt = new int[burst.Length];
            // waiting time for first process is 0 
            wt[0] = 0;

            // calculating waiting time 
            for (int i = 1; i < burst.Length; i++)
                wt[i] = burst[i - 1] + wt[i - 1];
            int sum = wt.Sum();
            MessageBox.Show("len:" + burst.Length + ", sum:"+sum);
            double awt = Convert.ToDouble(sum) / Convert.ToDouble(burst.Length);
            MessageBox.Show("SJF AWT: " + awt);
        }

        void prior()
        {
            String s = "";
            int[] burst = getBurstTimeWithPriority();
            int[] wt = new int[burst.Length];
            // waiting time for first process is 0 
            wt[0] = 0;

            // calculating waiting time 
            for (int i = 1; i < burst.Length; i++)
                wt[i] = burst[i - 1] + wt[i - 1];

            int sum = wt.Sum();
            double awt = Convert.ToDouble(sum) / Convert.ToDouble(burst.Length);
            MessageBox.Show("FCFS AWT: " + awt);

        }

        void rr()
        {

        }
    }
}
