using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class CapitalSimple : Form
    {

        double interes;
        double capital;
        string tInteres;
        int tiempoReal;

        public CapitalSimple()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            txtMonto.Clear();
            cmbInteres.SelectedIndex = 0;
            rdbReal.Checked = false;
            rdbEstimado.Checked = false;
            txtInteres.Clear();
            txtTiempo.Clear();
            cmbTiempo.SelectedIndex = 0;
        }

        private bool ValidarCampos()
        {
            // Verificar todos los TextBox, excepto txtMonto
            foreach (Control control in this.Controls)
            {
                if (control is TextBox && control != txtCapital)
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

            if (!rdbReal.Checked && !rdbEstimado.Checked)
            {
                MessageBox.Show("Debe seleccionar una opción (Real o Estimado).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            if (rdbEstimado.Checked)
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
                            case "Días":
                                interes = Double.Parse(txtInteres.Text) / 100;
                                break;
                            case "Meses":
                                interes = (Double.Parse(txtInteres.Text) / 100) * 30;
                                break;
                            case "Bimestres":
                                interes = (Double.Parse(txtInteres.Text) / 100) * 60;
                                break;
                            case "Trimestres":
                                interes = (Double.Parse(txtInteres.Text) / 100) * 900;
                                break;
                            case "Cuatrimestres":
                                interes = (Double.Parse(txtInteres.Text) / 100) * 120;
                                break;
                            case "Semestres":
                                interes = (Double.Parse(txtInteres.Text) / 100) * 180;
                                break;
                            case "Años":
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
                            case "Días":
                                interes = (Double.Parse(txtInteres.Text) / 100) / 30;
                                break;
                            case "Meses":
                                interes = (Double.Parse(txtInteres.Text) / 100);
                                break;
                            case "Bimestres":
                                interes = (Double.Parse(txtInteres.Text) / 100) * 2;
                                break;
                            case "Trimestres":
                                interes = (Double.Parse(txtInteres.Text) / 100) * 3;
                                break;
                            case "Cuatrimestres":
                                interes = (Double.Parse(txtInteres.Text) / 100) * 4;
                                break;
                            case "Semestres":
                                interes = (Double.Parse(txtInteres.Text) / 100) * 6;
                                break;
                            case "Años":
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
                            case "Días":
                                interes = (Double.Parse(txtInteres.Text) / 100) / 60;
                                break;
                            case "Meses":
                                interes = (Double.Parse(txtInteres.Text) / 100) / 2;
                                break;
                            case "Bimestres":
                                interes = (Double.Parse(txtInteres.Text) / 100);
                                break;
                            case "Trimestres":
                                interes = ((Double.Parse(txtInteres.Text) / 100) / 2) * 3;
                                break;
                            case "Cuatrimestres":
                                interes = (Double.Parse(txtInteres.Text) / 100) * 2;
                                break;
                            case "Semestres":
                                interes = (Double.Parse(txtInteres.Text) / 100) * 3;
                                break;
                            case "Años":
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
                            case "Días":
                                interes = (Double.Parse(txtInteres.Text) / 100) / 90;
                                break;
                            case "Meses":
                                interes = (Double.Parse(txtInteres.Text) / 100) / 3;
                                break;
                            case "Bimestres":
                                interes = ((Double.Parse(txtInteres.Text) / 100) / 3) * 2;
                                break;
                            case "Trimestres":
                                interes = (Double.Parse(txtInteres.Text) / 100);
                                break;
                            case "Cuatrimestres":
                                interes = ((Double.Parse(txtInteres.Text) / 100) / 3) * 4;
                                break;
                            case "Semestres":
                                interes = (Double.Parse(txtInteres.Text) / 100) * 2;
                                break;
                            case "Años":
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
                            case "Días":
                                interes = (Double.Parse(txtInteres.Text) / 100) / 120;
                                break;
                            case "Meses":
                                interes = (Double.Parse(txtInteres.Text) / 100) / 4;
                                break;
                            case "Bimestres":
                                interes = (Double.Parse(txtInteres.Text) / 100) / 2;
                                break;
                            case "Trimestres":
                                interes = ((Double.Parse(txtInteres.Text) / 100) / 4) * 3;
                                break;
                            case "Cuatrimestres":
                                interes = (Double.Parse(txtInteres.Text) / 100);
                                break;
                            case "Semestres":
                                interes = ((Double.Parse(txtInteres.Text) / 100) / 4) * 6;
                                break;
                            case "Años":
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
                            case "Días":
                                interes = (Double.Parse(txtInteres.Text) / 100) / 180;
                                break;
                            case "Meses":
                                interes = (Double.Parse(txtInteres.Text) / 100) / 6;
                                break;
                            case "Bimestres":
                                interes = ((Double.Parse(txtInteres.Text) / 100) / 6) * 2;
                                break;
                            case "Trimestres":
                                interes = (Double.Parse(txtInteres.Text) / 100) / 2;
                                break;
                            case "Cuatrimestres":
                                interes = ((Double.Parse(txtInteres.Text) / 100) / 6) * 4;
                                break;
                            case "Semestres":
                                interes = (Double.Parse(txtInteres.Text) / 100);
                                break;
                            case "Años":
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
                            case "Días":
                                interes = (Double.Parse(txtInteres.Text) / 100) / 360;
                                break;
                            case "Meses":
                                interes = (Double.Parse(txtInteres.Text) / 100) / 12;
                                break;
                            case "Bimestres":
                                interes = (Double.Parse(txtInteres.Text) / 100) / 6;
                                break;
                            case "Trimestres":
                                interes = (Double.Parse(txtInteres.Text) / 100) / 4;
                                break;
                            case "Cuatrimestres":
                                interes = (Double.Parse(txtInteres.Text) / 100) / 3;
                                break;
                            case "Semestres":
                                interes = (Double.Parse(txtInteres.Text) / 100) / 2;
                                break;
                            case "Años":
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

                capital = Convert.ToInt32(txtMonto.Text) / (1 + (interes * Convert.ToInt32(txtTiempo.Text)));
                txtCapital.Text = "" + capital;
            }
            else if (rdbReal.Checked)
            {
                tInteres = cmbInteres.Text;
                DateTime fechaInicio = dtpInicio.Value;
                DateTime fechaFin = dtpFin.Value;
                tiempoReal = (fechaFin - fechaInicio).Days;

                switch (tInteres)
                {
                    case "Diario":
                        interes = Double.Parse(txtInteres.Text);
                        break;
                    case "Mensual":
                        interes = ((Double.Parse(txtInteres.Text) / 100) * 12) / 365;
                        break;
                    case "Bimestral":
                        interes = ((Double.Parse(txtInteres.Text) / 100) * 6) / 365;
                        break;
                    case "Trimestral":
                        interes = ((Double.Parse(txtInteres.Text) / 100) * 4) / 365;
                        break;
                    case "Cuatrimestral":
                        interes = ((Double.Parse(txtInteres.Text) / 100) * 3) / 365;
                        break;
                    case "Semestral":
                        interes = ((Double.Parse(txtInteres.Text) / 100) * 2) / 365;
                        break;
                    case "Anual":
                        interes = ((Double.Parse(txtInteres.Text) / 100) * 1) / 365;
                        break;
                    default:
                        Console.WriteLine("Opción no reconocida. Por favor, introduce una opción válida.");
                        break;
                }

                capital = Convert.ToInt32(txtMonto.Text) / (1 + (interes * tiempoReal));
                txtCapital.Text = "" + capital;
            }

            limpiar();
        }

        private void rdbEstimado_CheckedChanged(object sender, EventArgs e)
        {
            cmbTiempo.Visible = true;
            txtTiempo.Visible = true;
            cmbTiempo.Enabled = true;
            txtTiempo.Enabled = true;
            dtpInicio.Visible = false;
            dtpFin.Visible = false;
            dtpInicio.Enabled = false;
            dtpFin.Enabled = false;
            lblInicio.Visible = false;
            lblFin.Visible = false;
        }

        private void rdbReal_CheckedChanged(object sender, EventArgs e)
        {
            cmbTiempo.Visible = false;
            txtTiempo.Visible = false;
            cmbTiempo.Enabled = false;
            txtTiempo.Enabled = false;
            dtpInicio.Visible = true;
            dtpFin.Visible = true;
            dtpInicio.Enabled = true;
            dtpFin.Enabled = true;
            lblInicio.Visible = true;
            lblFin.Visible = true;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 menuu = new Form1();
            menuu.Show();
        }
    }
}
