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
    public partial class MontoVencida : Form
    {

        double interes;
        double monto;
        string tInteres;

        public MontoVencida()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            txtAnualidad.Clear();
            cmbInteres.SelectedIndex = 0;
            txtInteres.Clear();
            txtTiempo.Clear();
            cmbTiempo.SelectedIndex = 0;
        }

        private bool ValidarCampos()
        {
            // Verificar todos los TextBox, excepto txtMonto
            foreach (Control control in this.Controls)
            {
                if (control is TextBox && control != txtMonto)
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

        private void MontoVencida_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Verificar los campos antes de proceder
            if (!ValidarCampos())
            {
                return;
            }
            tInteres = cmbInteres.Text;
            string tiempo = cmbTiempo.Text;

            switch (tInteres)
            {
                case "Diario":

                    switch (tiempo)
                    {
                        case "Diario":
                            interes = Double.Parse(txtInteres.Text) / 100;
                            break;
                        case "Mensual":
                            interes = (Double.Parse(txtInteres.Text) / 100) * 30;
                            break;
                        case "Bimestral":
                            interes = (Double.Parse(txtInteres.Text) / 100) * 60;
                            break;
                        case "Trimestral":
                            interes = (Double.Parse(txtInteres.Text) / 100) * 900;
                            break;
                        case "Cuatrimestral":
                            interes = (Double.Parse(txtInteres.Text) / 100) * 120;
                            break;
                        case "Semestral":
                            interes = (Double.Parse(txtInteres.Text) / 100) * 180;
                            break;
                        case "Anual":
                            interes = (Double.Parse(txtInteres.Text) / 100) * 360;
                            break;
                        default:
                            Console.WriteLine("Opción no reconocida. Por favor, introduce una opción válida.");
                            break;
                    }

                    break;
                case "Mensual":
                    switch (tiempo)
                    {
                        case "Diario":
                            interes = (Double.Parse(txtInteres.Text) / 100) / 30;
                            break;
                        case "Mensual":
                            interes = (Double.Parse(txtInteres.Text) / 100);
                            break;
                        case "Bimestral":
                            interes = (Double.Parse(txtInteres.Text) / 100) * 2;
                            break;
                        case "Trimestral":
                            interes = (Double.Parse(txtInteres.Text) / 100) * 3;
                            break;
                        case "Cuatrimestral":
                            interes = (Double.Parse(txtInteres.Text) / 100) * 4;
                            break;
                        case "Semestral":
                            interes = (Double.Parse(txtInteres.Text) / 100) * 6;
                            break;
                        case "Anual":
                            interes = (Double.Parse(txtInteres.Text) / 100) * 12;
                            break;
                        default:
                            Console.WriteLine("Opción no reconocida. Por favor, introduce una opción válida.");
                            break;
                    }
                    break;
                case "Bimestral":
                    switch (tiempo)
                    {
                        case "Diario":
                            interes = (Double.Parse(txtInteres.Text) / 100) / 60;
                            break;
                        case "Mensual":
                            interes = (Double.Parse(txtInteres.Text) / 100) / 2;
                            break;
                        case "Bimestral":
                            interes = (Double.Parse(txtInteres.Text) / 100);
                            break;
                        case "Trimestral":
                            interes = ((Double.Parse(txtInteres.Text) / 100) / 2) * 3;
                            break;
                        case "Cuatrimestral":
                            interes = (Double.Parse(txtInteres.Text) / 100) * 2;
                            break;
                        case "Semestral":
                            interes = (Double.Parse(txtInteres.Text) / 100) * 3;
                            break;
                        case "Anual":
                            interes = (Double.Parse(txtInteres.Text) / 100) * 6;
                            break;
                        default:
                            Console.WriteLine("Opción no reconocida. Por favor, introduce una opción válida.");
                            break;
                    }
                    break;
                case "Trimestral":
                    switch (tiempo)
                    {
                        case "Diario":
                            interes = (Double.Parse(txtInteres.Text) / 100) / 90;
                            break;
                        case "Mensual":
                            interes = (Double.Parse(txtInteres.Text) / 100) / 3;
                            break;
                        case "Bimestral":
                            interes = ((Double.Parse(txtInteres.Text) / 100) / 3) * 2;
                            break;
                        case "Trimestral":
                            interes = (Double.Parse(txtInteres.Text) / 100);
                            break;
                        case "Cuatrimestral":
                            interes = ((Double.Parse(txtInteres.Text) / 100) / 3) * 4;
                            break;
                        case "Semestral":
                            interes = (Double.Parse(txtInteres.Text) / 100) * 2;
                            break;
                        case "Anual":
                            interes = (Double.Parse(txtInteres.Text) / 100) * 4;
                            break;
                        default:
                            Console.WriteLine("Opción no reconocida. Por favor, introduce una opción válida.");
                            break;
                    }
                    break;
                case "Cuatrimestral":
                    switch (tiempo)
                    {
                        case "Diario":
                            interes = (Double.Parse(txtInteres.Text) / 100) / 120;
                            break;
                        case "Mensual":
                            interes = (Double.Parse(txtInteres.Text) / 100) / 4;
                            break;
                        case "Bimestral":
                            interes = (Double.Parse(txtInteres.Text) / 100) / 2;
                            break;
                        case "Trimestral":
                            interes = ((Double.Parse(txtInteres.Text) / 100) / 4) * 3;
                            break;
                        case "Cuatrimestral":
                            interes = (Double.Parse(txtInteres.Text) / 100);
                            break;
                        case "Semestral":
                            interes = ((Double.Parse(txtInteres.Text) / 100) / 4) * 6;
                            break;
                        case "Anual":
                            interes = (Double.Parse(txtInteres.Text) / 100) * 3;
                            break;
                        default:
                            Console.WriteLine("Opción no reconocida. Por favor, introduce una opción válida.");
                            break;
                    }
                    break;
                case "Semestral":
                    switch (tiempo)
                    {
                        case "Diario":
                            interes = (Double.Parse(txtInteres.Text) / 100) / 180;
                            break;
                        case "Mensual":
                            interes = (Double.Parse(txtInteres.Text) / 100) / 6;
                            break;
                        case "Bimestral":
                            interes = ((Double.Parse(txtInteres.Text) / 100) / 6) * 2;
                            break;
                        case "Trimestral":
                            interes = (Double.Parse(txtInteres.Text) / 100) / 2;
                            break;
                        case "Cuatrimestral":
                            interes = ((Double.Parse(txtInteres.Text) / 100) / 6) * 4;
                            break;
                        case "Semestral":
                            interes = (Double.Parse(txtInteres.Text) / 100);
                            break;
                        case "Anual":
                            interes = (Double.Parse(txtInteres.Text) / 100) * 2;
                            break;
                        default:
                            Console.WriteLine("Opción no reconocida. Por favor, introduce una opción válida.");
                            break;
                    }
                    break;
                case "Anual":
                    switch (tiempo)
                    {
                        case "Diario":
                            interes = (Double.Parse(txtInteres.Text) / 100) / 360;
                            break;
                        case "Mensual":
                            interes = (Double.Parse(txtInteres.Text) / 100) / 12;
                            break;
                        case "Bimestral":
                            interes = (Double.Parse(txtInteres.Text) / 100) / 6;
                            break;
                        case "Trimestral":
                            interes = (Double.Parse(txtInteres.Text) / 100) / 4;
                            break;
                        case "Cuatrimestral":
                            interes = (Double.Parse(txtInteres.Text) / 100) / 3;
                            break;
                        case "Semestral":
                            interes = (Double.Parse(txtInteres.Text) / 100) / 2;
                            break;
                        case "Anual":
                            interes = (Double.Parse(txtInteres.Text) / 100);
                            break;
                        default:
                            Console.WriteLine("Opción no reconocida. Por favor, introduce una opción válida.");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Opción no reconocida. Por favor, introduce una opción válida.");
                    break;
            }

            monto = Convert.ToDouble(txtAnualidad.Text)*((Math.Pow((1+interes), Convert.ToDouble(txtTiempo.Text)) -1)/interes);
            txtMonto.Text = monto.ToString("F2");
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
