using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace Mohammed_Jacksi
{
    public partial class Processes : Form
    {
        public Processes()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new All_Processes().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int p_id = Convert.ToInt32(id.Text);
                Process p = Process.GetProcessById(p_id);
                p.Kill();
            }
            catch (Exception)
            {

                throw;
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://www.google.com/search?source=hp&ei=hphUXLL3JYyCjLsPtLeSqA0&q=" + Search.Text);
        }
    }
}
