namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(maskedTextBox1.Text, out int numero))
            {
                if (numero <= 1)
                {
                    MessageBox.Show("No es primo");
                    return;
                }

                bool esPrimo = true;

                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }

                if (esPrimo)
                {
                    MessageBox.Show("Es primo");
                }
                else
                {
                    MessageBox.Show("No es primo");
                }
            }
            else
            {
                MessageBox.Show("Ingresa Aquí un numero Primo: ");
            }
        }
    }
}
