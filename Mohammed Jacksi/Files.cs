using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Mohammed_Jacksi
{
    public partial class Files : Form
    {
        public Files()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sPath = path.Text;
            if(!File.Exists(sPath)){
                File.Create(sPath);
            }
            else
            {
                MessageBox.Show("The file already is exist!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String sPath = path.Text;
            if (!File.Exists(sPath))
            {
                MessageBox.Show("The file not exist, can't be deleted!");
            }
            else
            {
                File.Delete(sPath);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String sPath = path.Text;
            if (!File.Exists(sPath))
            {
                MessageBox.Show("The file not exist, can't be read!");
            }
            else
            {
                String t = File.ReadAllText(sPath);
                text.Text = t;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String sPath = path.Text;
            if (!File.Exists(sPath))
            {
                File.Create(sPath);
            }
            File.WriteAllText(sPath,text.Text);
        }
    }
}
