namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string palabra = textBox1.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(palabra))
            {
                MessageBox.Show("Ingrese una palabra jefe");
                return;
            }

            char[] arreglo = palabra.ToCharArray();
            Array.Reverse(arreglo);
            string invertida = new string(arreglo);

            if (palabra == invertida)
            {
                MessageBox.Show("Esa sí es Palíndroma");
            }
            else
            {
                MessageBox.Show("Te dije Palíndroma, no otra cosa ");
            }
        }
    }
}
