namespace lol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                if (label1.Text == string.Empty)
                {
                    label1.Text = $"Se presiono la tecla {GetArrowDirection(e.KeyCode)}";
                }
                else
                {
                    label1.Text = string.Empty;
                    label1.Text = $"Se presiono la tecla {GetArrowDirection(e.KeyCode)}";
                }
            }
            else
            {
                MessageBox.Show("No se presiono una tecla de flecha de direccion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetArrowDirection(Keys keyCode)
        {
            switch (keyCode) 
            {
                case Keys.Up:
                    return "Arriba";
                case Keys.Down:
                    return "Abajo";
                case Keys.Left:
                    return "Izquierda";
                case Keys.Right:
                    return "Derecha";
                default:
                    return string.Empty;
            }
        }

    }
}
