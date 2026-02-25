namespace WinFormsApp8
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

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(texto))
            {
                MessageBox.Show("Ingrese una oración");
                return;
            }

            string[] palabras = texto.Split(new char[] { ' ' },
                                             StringSplitOptions.RemoveEmptyEntries);

            int cantidad = palabras.Length;

            label1.Text = "Cantidad de palabras: " + cantidad;
        }
    }
}
