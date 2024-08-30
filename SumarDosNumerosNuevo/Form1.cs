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
            // Declarar las variables para los números y el resultado
            int n1, n2, s;

            // Intentar convertir el texto de los TextBox en números enteros
            if (int.TryParse(txtn1.Text, out n1) && int.TryParse(txtn2.Text, out n2))
            {
                // Sumar los dos números
                s = n1 + n2;

                // Mostrar el resultado en un Label
                lblresult.Text = $"Resultado: {s}";
            }
            else
            {
                // Mostrar un mensaje de error si los valores no son válidos
                lblresult.Text = "Por favor, ingresa números válidos.";
            }
        }
    }
}
