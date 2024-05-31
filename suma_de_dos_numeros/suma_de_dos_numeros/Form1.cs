namespace suma_de_dos_numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double N1, N2, R;
            N1 = double.Parse(textBox1.Text);
            N2 = double.Parse(textBox2.Text);
            R = N1 + N2;
            textBox3.Text = R.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
