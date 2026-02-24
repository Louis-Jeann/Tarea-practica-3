namespace WinFormsApp6
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
                if (numero <= 0)
                {
                    MessageBox.Show("Ingrese un número mayor a 0");
                    return;
                }

                int suma = 0;

                for (int i = 1; i < numero; i++)
                {
                    if (numero % i == 0)
                    {
                        suma += i;
                    }
                }

                if (suma == numero)
                {
                    MessageBox.Show("Es un número perfecto");
                }
                else
                {
                    MessageBox.Show("No es un número perfecto");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número válido");
            }
        }
    }
}
