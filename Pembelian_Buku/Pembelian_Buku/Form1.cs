namespace Pembelian_Buku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // username dan password yang benar (bisa diatur sesukamu)
            string username = "naovee";
            string password = "12345";

            // cek apakah input sesuai
            if (textBox1.Text == username && textBox2.Text == password)
            {
                // jika benar, buka Form1
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                // jika salah, tampilkan pesan
                MessageBox.Show("Username atau Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
