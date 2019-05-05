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
    public partial class Memory : Form
    {
        void clear()
        {
            blocksTextBox.Text = "";
            processesTextBox.Text = "";
            blockText.Text = "";
            processText.Text = "";
        }
        public Memory()
        {
            InitializeComponent();
        }
        int[] getBlocks()
        {
            String myString = blocksTextBox.Text.Substring(0, blocksTextBox.Text.Length - 1);
            String[] priority = myString.Split('\n');

            int[] myint = Array.ConvertAll<string, int>(priority, int.Parse);
            return myint;
        }
        int[] getProcesses()
        {
            String myString = processesTextBox.Text.Substring(0, processesTextBox.Text.Length - 1);
            String[] priority = myString.Split('\n');

            int[] myint = Array.ConvertAll<string, int>(priority, int.Parse);
            return myint;
        }
        void firstFit()
        {
            
            int[] processes = getProcesses();
            int[] blockes = getBlocks();
            String[] allocation = new String[processes.Length];
            for (int i = 0; i < processes.Length; i++)
            {
                bool found = false;
                int process = processes[i];
                for (int j = 0; j < blockes.Length; j++)
                {
                    int block = blockes[j];

                    if (process <= block)
                    {
                        blockes[j] = block - process;
                        allocation[i] = (i + 1) + " - " + (j + 1);
                        found = true;
                        break;
                    }
                }
                if(!found)
                    allocation[i] = (i + 1) + " - Not Allocated";
            }

            String show = "";
            for (int i = 0; i < allocation.Length; i++)
            {
                    show += allocation[i] + "\n";
            }
            MessageBox.Show("P - Block\n" + show);
        }

        void bestFit()
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (firstFitRadioButton.Checked)
                firstFit();
            else if (bestFitRadioButton.Checked)
                bestFit();
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            blocksTextBox.AppendText(blockText.Text + "\r\n");
            blockText.Text = "";
            blockText.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            processesTextBox.AppendText(processText.Text + "\r\n");
            processText.Text = "";
            processText.Focus();
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void firstFitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            clear();
        }

        private void bistFitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            clear();
        }

        private void worstFitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            clear();
        }
    }
}
