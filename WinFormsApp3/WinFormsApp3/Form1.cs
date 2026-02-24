namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Metros");
            comboBox1.Items.Add("Centímetros");
            comboBox1.Items.Add("Pulgadas");

            comboBox2.Items.Add("Metros");
            comboBox2.Items.Add("Centímetros");
            comboBox2.Items.Add("Pulgadas");

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double valor))
            {
                double valorEnMetros = 0;
                double resultado = 0;

                // Convertir todo primero a metros
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "Metros":
                        valorEnMetros = valor;
                        break;
                    case "Centímetros":
                        valorEnMetros = valor / 100;
                        break;
                    case "Pulgadas":
                        valorEnMetros = valor * 0.0254;
                        break;
                }

                // Convertir de metros a la unidad destino
                switch (comboBox2.SelectedItem.ToString())
                {
                    case "Metros":
                        resultado = valorEnMetros;
                        break;
                    case "Centímetros":
                        resultado = valorEnMetros * 100;
                        break;
                    case "Pulgadas":
                        resultado = valorEnMetros / 0.0254;
                        break;
                }

                label1.Text = "Resultado: " + resultado.ToString("F4");
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido");
            }
        }
    }
}
