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
    public partial class PeriodoAnticipada : Form
    {
        double periodo;
        double interes;

        public PeriodoAnticipada()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            txtAnualidad.Clear();
            cmbInteres.SelectedIndex = 0;
            txtInteres.Clear();
            txtMonto.Clear();
        }

        private bool ValidarCampos()
        {
            // Verificar todos los TextBox, excepto txtMonto
            foreach (Control control in this.Controls)
            {
                if (control is TextBox && control != txtTiempo)
                {
                    TextBox textBox = control as TextBox;
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        MessageBox.Show("Todos los campos deben estar llenos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                else if (control is ComboBox)
                {
                    ComboBox comboBox = control as ComboBox;
                    if (comboBox.SelectedIndex == -1)
                    {
                        MessageBox.Show("Todos los campos deben estar llenos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }

            return true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Verificar los campos antes de proceder
            if (!ValidarCampos())
            {
                return;
            }
            interes = Convert.ToDouble(txtInteres.Text) / 100;
            periodo = Math.Log(((Convert.ToDouble(txtMonto.Text) * interes) / (Convert.ToDouble(txtAnualidad.Text))*(1+interes)) + 1) / Math.Log(1 + interes);
            txtTiempo.Text = periodo.ToString("F2") + " Periodos";
            limpiar();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 menuu = new Form1();
            menuu.Show();
        }
    }
}
