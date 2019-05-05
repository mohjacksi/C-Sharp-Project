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
    public partial class All_Processes : Form
    {
        public All_Processes()
        {
            InitializeComponent();
        }

        private void All_Processes_Load(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcesses();
            foreach (var item in processes)
            {
                dataGridView1.Rows.Add(item.Id,item.ProcessName);
            }
            
        }
    }
}
