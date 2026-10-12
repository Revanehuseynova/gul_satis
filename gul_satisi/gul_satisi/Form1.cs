namespace gul_satisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
        double toplamGelir = 0;

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || maskedTextBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Xanalar boş ola bilməz!");
                return;
            }

            double count = Convert.ToDouble(maskedTextBox1.Text);
            double price = Convert.ToDouble(textBox2.Text);

            if (count <= 0 || price <= 0)
            {
                MessageBox.Show("Say və qiymət sıfırdan kiçik və ya sıfır ola bilməz!");
                return;
            }

            double result = count * price;

            dataGridView1.Rows.Add(textBox1.Text, count.ToString(), price.ToString(), result.ToString("F2"));

            toplamGelir = toplamGelir + result;
            label5.Text = toplamGelir.ToString("F2");

            textBox1.Text = "";
            maskedTextBox1.Text = "";
            textBox2.Text = "";
        }

      
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Çıxış edilsinmi?", "Diqqət", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}