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
            this.Hide();
        }

        private void capitalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CapitalSimple capitalSimple = new CapitalSimple();
            capitalSimple.Show();
            this.Hide();
        }

        private void tasaDeInteresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TasaSimple tasaSimple = new TasaSimple();
            tasaSimple.Show();
            this.Hide();
        }

        private void tiempoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            TiempoSimple tiempoSimple = new TiempoSimple();
            tiempoSimple.Show();
            this.Hide();
        }

        private void montoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MontoCompuesto montoCompuesto = new MontoCompuesto();
            montoCompuesto.Show();
            this.Hide();
        }

        private void capitalToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            CapitalCompuesto capitalCompuesto = new CapitalCompuesto();
            capitalCompuesto.Show();
            this.Hide();
        }

        private void tasaDeInteresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TasaCompuesto tasaCompuesto = new TasaCompuesto();
            tasaCompuesto.Show();
            this.Hide();
        }
    }
}
