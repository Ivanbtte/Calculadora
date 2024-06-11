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
    public partial class TasaSimple : Form
    {
        double tiempo;
        public TasaSimple()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            txtCapital.Clear();
            txtMonto.Clear();
            txtTiempo.Clear();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 menuu = new Form1();
            menuu.Show();
        }
        private bool ValidarCampos()
        {
            // Verificar todos los TextBox, excepto txtMonto
            foreach (Control control in this.Controls)
            {
                if (control is TextBox && control != txtInteres)
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
            tiempo = ((Convert.ToDouble(txtMonto.Text) / Convert.ToDouble(txtCapital.Text) - 1)) / Convert.ToDouble(txtTiempo.Text);
            txtInteres.Text = tiempo.ToString("F2") + "% de interes " + cmbInteres.Text;
            limpiar();
        }
    }
}
