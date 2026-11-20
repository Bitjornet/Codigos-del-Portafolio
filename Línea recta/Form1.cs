using System;
using System.Windows.Forms;

namespace Geoanalitica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Recta ObtenerRectaDesdeInterfaz()
        {
            float x1 = float.Parse(txtX1.Text);
            float y1 = float.Parse(txtY1.Text);
            float x2 = float.Parse(txtX2.Text);
            float y2 = float.Parse(txtY2.Text);

            Punto p1 = new Punto(x1, y1);
            Punto p2 = new Punto(x2, y2);

            return new Recta(p1, p2);
        }

        private void btnDistancia_Click(object sender, EventArgs e)
        {
            try
            {
                Recta recta = ObtenerRectaDesdeInterfaz();
                float d = recta.Distancia();

                lblDistancia.Text = "Distancia = " + d.ToString("0.00");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingresa números válidos en las coordenadas.", "Error de entrada");
            }
        }

        private void btnPuntoMedio_Click(object sender, EventArgs e)
        {
            try
            {
                Recta recta = ObtenerRectaDesdeInterfaz();
                Punto pm = recta.PuntoMedio();

                lblXM.Text = "XM = " + pm.X.ToString("0.00");
                lblYM.Text = "YM = " + pm.Y.ToString("0.00");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingresa números válidos en las coordenadas.", "Error de entrada");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnDistancia_Click_1(object sender, EventArgs e)
        {
            try
            {
                Recta recta = ObtenerRectaDesdeInterfaz();
                float d = recta.Distancia();

                lblDistancia.Text = " " + d.ToString("0.00");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingresa números válidos en las coordenadas.", "Error de entrada");
            }
        }

        private void btnPuntoMedio_Click_1(object sender, EventArgs e)
        {
            try
            {
                Recta recta = ObtenerRectaDesdeInterfaz();
                Punto pm = recta.PuntoMedio();

                lblXM.Text = "  " + pm.X.ToString("0.00");
                lblYM.Text = " " + pm.Y.ToString("0.00");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingresa números válidos en las coordenadas.", "Error de entrada");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}