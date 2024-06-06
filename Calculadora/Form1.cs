using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void capitalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MontoSimple montoSimple = new MontoSimple();
            montoSimple.Show();
        }

        private void capitalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CapitalSimple capitalSimple = new CapitalSimple();
            capitalSimple.Show();
        }

        private void tasaDeInteresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TasaSimple tasaSimple = new TasaSimple();
            tasaSimple.Show();
        }

        private void tiempoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            TiempoSimple tiempoSimple = new TiempoSimple();
            tiempoSimple.Show();
            this.Visible = false;
        }
    }
}
