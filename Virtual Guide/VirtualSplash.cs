using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virtual_Guide
{
    public partial class VirtualSplash : Form
    {
        public VirtualSplash()
        {
            InitializeComponent();
        }

        int x = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            x += 2;
            if (x <= this.Width)
            {
                label2.Size = new System.Drawing.Size(x, 3);
                //label3.Text = (x/3).ToString()+"%";
            }
            else
            {
                this.Close();
            }
        }
    }
}
