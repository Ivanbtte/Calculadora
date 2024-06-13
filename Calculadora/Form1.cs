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

        private void tiempoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TiempoCompuesto tiempoCompuesto = new TiempoCompuesto();
            tiempoCompuesto.Show();
            this.Hide();
        }

        private void montoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MontoVencida montoVencida = new MontoVencida();
            montoVencida.Show();
            this.Hide();
        }

        private void anualidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnualidadVencidaA anualidadVencidaA = new AnualidadVencidaA();
            anualidadVencidaA.Show();
            this.Hide();
        }

        private void periodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PeriodosVencida periodosVencida = new PeriodosVencida();
            periodosVencida.Show();
            this.Hide();
        }

        private void valorPresenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void anualidadToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void periodosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void montoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MontoAnticipada montoAnticipada = new MontoAnticipada();
            montoAnticipada.Show();
            this.Hide();
        }

        private void anualidadToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AnualidadAnticipadaA anualidadAnticipadaA = new AnualidadAnticipadaA();
            anualidadAnticipadaA.Show();
            this.Hide();
        }

        private void periodosToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            PeriodoAnticipada periodoAnticipada = new PeriodoAnticipada();
            periodoAnticipada.Show();
            this.Hide();
        }
    }
}
