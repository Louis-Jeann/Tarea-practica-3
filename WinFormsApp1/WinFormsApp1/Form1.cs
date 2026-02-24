namespace WinFormsApp1
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

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // Limpia la lista antes de mostrar nueva tabla

            if (int.TryParse(textBox1.Text, out int numero))
            {
                for (int i = 1; i <= 10; i++)
                {
                    int resultado = numero * i;
                    listBox1.Items.Add(numero + " x " + i + " = " + resultado);
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un número válido");
            }
        }
    }
}
