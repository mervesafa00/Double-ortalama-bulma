namespace Double_ortalama_bulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double not1, not2, not3, ortalama;
            not1 = Convert.ToDouble(textBox1.Text);
            not2 = Convert.ToDouble(textBox2.Text);
            not3 = Convert.ToDouble(textBox3.Text);
            ortalama = (not1 + not2 + not3) / 3;
            label1.Text = ortalama.ToString();
        }
    }
}
