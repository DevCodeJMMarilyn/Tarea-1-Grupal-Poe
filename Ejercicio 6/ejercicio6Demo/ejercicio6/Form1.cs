namespace ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    MessageBox.Show("Por favor, ingrese todos los valores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double velocidadInicial;
                double velocidadFinal;
                double tiempo;

                if (!double.TryParse(textBox1.Text, out velocidadInicial) || !double.TryParse(textBox2.Text, out velocidadFinal) || !double.TryParse(textBox3.Text, out tiempo))
                {
                    MessageBox.Show("Por favor, ingrese valores numéricos válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (tiempo <= 0)
                {
                    MessageBox.Show("El tiempo debe ser mayor que cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                AceleracionCalculator aceleracion = new AceleracionCalculator(velocidadInicial, velocidadFinal, tiempo);
                double Aceleracion = aceleracion.CalcularAceleracion();

                label1.Text = $"La aceleracion es: {Aceleracion:F2} m/s^2";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
