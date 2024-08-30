using System;
using System.Windows.Forms;

namespace SumarDosNumerosNuevo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            // Declarar las variables para los n�meros y el resultado
            int n1, n2, s;

            // Intentar convertir el texto de los TextBox en n�meros enteros
            if (int.TryParse(txtn1.Text, out n1) && int.TryParse(txtn2.Text, out n2))
            {
                // Sumar los dos n�meros
                s = n1 + n2;

                // Mostrar el resultado en un Label
                lblresult.Text = $"Resultado: {s}";
            }
            else
            {
                // Mostrar un mensaje de error si los valores no son v�lidos
                lblresult.Text = "Por favor, ingresa n�meros v�lidos.";
            }
        }
    }
}
