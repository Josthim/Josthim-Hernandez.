using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjDivisionEntreCero
{
    public partial class DivisionEntreCero : Form
    {
        public DivisionEntreCero()
        {
            InitializeComponent();
        }

        private void DivisionEntreCero_Load(object sender, EventArgs e)
        {
            lblResultado.Text = "";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                // Capturando los datos
                int numerador = int.Parse(txtNumerador.Text);
                int denominador = int.Parse(txtDenominador.Text);

                // Realizando calculo
                double resultado = numerador / denominador;

                // Imprimiendo el resultado
                lblResultado.Text = resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Debe escribir dos numeros",
                    "Formato de número inválido", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }
            catch(DivideByZeroException divideByZeroExceptioParameter)
            {
                MessageBox.Show(divideByZeroExceptioParameter.Message,
                    "Intento de division por cero", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
       
    }
}
