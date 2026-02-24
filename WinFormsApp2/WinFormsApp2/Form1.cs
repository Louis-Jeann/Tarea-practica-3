namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        int tiempoTotalSegundos = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int minutos) &&
    int.TryParse(textBox2.Text, out int segundos))
            {
                tiempoTotalSegundos = (minutos * 60) + segundos;

                if (tiempoTotalSegundos > 0)
                {
                    TIEMPO.Start();
                }
                else
                {
                    MessageBox.Show("Ingrese un tiempo mayor que 0");
                }
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos válidos");
            }
        }

        private void TIEMPO_Tick(object sender, EventArgs e)
        {
            if (tiempoTotalSegundos > 0)
            {
                tiempoTotalSegundos--;

                int minutos = tiempoTotalSegundos / 60;
                int segundos = tiempoTotalSegundos % 60;

                label1.Text = minutos.ToString("00") + ":" + segundos.ToString("00");
            }
            else
            {
                TIEMPO.Stop();
                MessageBox.Show("¡El tiempo se ha agotado!");
                label1.Text = "00:00";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
