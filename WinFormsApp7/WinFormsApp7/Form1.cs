namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool EsPrimo(int numero)
        {
            if (numero <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }

            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (int.TryParse(textBox1.Text, out int inicio) &&
                int.TryParse(textBox2.Text, out int fin))
            {
                if (inicio > fin)
                {
                    MessageBox.Show("El valor Inicio no puede ser mayor que Fin");
                    return;
                }

                for (int numero = inicio; numero <= fin; numero++)
                {
                    if (EsPrimo(numero))
                    {

                        listBox1.Items.Add(numero);
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos válidos");
            }


        }
    }
}
