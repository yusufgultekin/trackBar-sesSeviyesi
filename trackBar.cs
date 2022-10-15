using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int ses = trackBar1.Value;
            if (ses>=11)
            {
                label1.Text = "Ses yuksek";
                label1.ForeColor = Color.Red;
            }
            else if(ses==0)
            {
                label1.Text = "Ses yok";
                label1.ForeColor = Color.Black;
            }
            else
            {
                label1.Text = "Ses normal";
                label1.ForeColor = Color.Green;
            }
            
        }
    }
}
