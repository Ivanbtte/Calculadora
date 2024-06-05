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
    public partial class MontoSimple : Form
    {
        double interes;

        public MontoSimple()
        {
            InitializeComponent();
        }

        private void MontoSimple_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string tInteres = cmbInteres.Text;
            string tiempo = cmbTiempo.Text;

            switch (tInteres)
            {
                case "Diario":

                    switch (tInteres)
                    {
                        case "Días":
                            interes = Double.Parse(txtInteres.Text) / 100;
                            break;
                        case "Meses":
                            interes = (Double.Parse(txtInteres.Text) / 100)*30;
                            break;
                        case "Bimestres":
                            interes = (Double.Parse(txtInteres.Text) / 100)*60;
                            break;
                        case "Trimestres":
                            interes = (Double.Parse(txtInteres.Text) / 100)*900;
                            break;
                        case "Cuatrimestres":
                            interes = (Double.Parse(txtInteres.Text) / 100)*120;
                            break;
                        case "Semestres":
                            interes = (Double.Parse(txtInteres.Text) / 100)*180;
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
                    switch (tInteres)
                    {
                        case "Días":
                            interes = (Double.Parse(txtInteres.Text) / 100)/30;
                            break;
                        case "Meses":
                            interes = (Double.Parse(txtInteres.Text) / 100);
                            break;
                        case "Bimestres":
                            interes = (Double.Parse(txtInteres.Text) / 100)*2;
                            break;
                        case "Trimestres":
                            interes = (Double.Parse(txtInteres.Text) / 100)*3;
                            break;
                        case "Cuatrimestres":
                            interes = (Double.Parse(txtInteres.Text) / 100)*4;
                            break;
                        case "Semestres":
                            interes = (Double.Parse(txtInteres.Text) / 100)*6;
                            break;
                        case "Años":
                            interes = (Double.Parse(txtInteres.Text) / 100)*12;
                            break;
                        default:
                            Console.WriteLine("Opción no reconocida. Por favor, introduce una opción válida.");
                            break;
                    }
                    break;
                case "Bimestral":
                    switch (tInteres)
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
                    switch (tInteres)
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
                    switch (tInteres)
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
                    switch (tInteres)
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
                    switch (tInteres)
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
        }
    }
}
