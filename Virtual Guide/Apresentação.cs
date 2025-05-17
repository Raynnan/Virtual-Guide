using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virtual_Guide
{
    public partial class Apresentação : Form
    {
        public Apresentação()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();

            sobre.ShowDialog();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            TelaPrincipal principal = new TelaPrincipal();

            principal.Show();

            this.Close();
        }
    }
}
