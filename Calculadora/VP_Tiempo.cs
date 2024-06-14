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

    public partial class VP_Tiempo : Form
    {
        double periodo;
        double interes;
        private void limpiar()
        {
            txtAnualidad.Clear();
            cmbInteres.SelectedIndex = 0;
            txtInteres.Clear();
            txtVP.Clear();
            
        }

        private bool ValidarCampos()
        {
            // Verificar todos los TextBox, excepto txtMonto
            foreach (Control control in this.Controls)
            {
                if (control is TextBox && control != txtPeriodo)
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
        public VP_Tiempo()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 menuu = new Form1();
            menuu.Show();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Verificar los campos antes de proceder
            if (!ValidarCampos())
            {
                return;
            }
            double tasaIngresada = Convert.ToDouble(txtInteres.Text) / 100;
            string tInteres = cmbInteres.Text;
            switch (tInteres)
            {
                case "Diario":
                    interes = tasaIngresada;
                    break;
                case "Mensual":
                    interes = tasaIngresada / 12;
                    break;
                case "Bimestral":
                    interes = tasaIngresada / 6;
                    break;
                case "Trimestral":
                    interes = tasaIngresada / 4;
                    break;
                case "Cuatrimestral":
                    interes = tasaIngresada / 3;
                    break;
                case "Semestral":
                    interes = tasaIngresada / 2;
                    break;
                case "Anual":
                    interes = tasaIngresada;
                    break;
                default:
                    Console.WriteLine("Opción no reconocida. Por favor, introduce una opción válida.");
                    return;
            }
           
            periodo = -Math.Log((-(Convert.ToDouble(txtVP.Text) * interes) / Convert.ToDouble(txtAnualidad.Text)) + 1) / Math.Log(1 + interes);
            txtPeriodo.Text = periodo.ToString("F2") + " Periodos";
            limpiar();
        }
    }
}
