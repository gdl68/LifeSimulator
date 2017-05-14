using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class StartMenu : Form
    {
        

        public StartMenu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            while (true)
            {
                if (tbName.ToString() != null && (rbM.Checked != false || rbW.Checked != false))
                {

                    Config cfg = new Config(tbName.ToString(), Convert.ToInt32(nudAge.Value), rbM.Checked ? "М" : rbW.Checked ? "Ж" : "");
                    Hide();
                    Form1 Form1 = new Form1(ref cfg);
                    Form1.ShowDialog();
                    break;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
