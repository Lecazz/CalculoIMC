namespace CalculoIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Pega o peso do campo de peso
            decimal peso = numPeso.Value;

            decimal altura = numAltura.Value;

            decimal imc = peso / (altura * altura);

            // Coloca o resultado na legenda
            lblResultado.Text = imc.ToString("N2");
        }

        private void numPeso_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}