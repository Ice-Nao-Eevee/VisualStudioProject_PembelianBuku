using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pembelian_Buku
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonkembali_Click(object sender, EventArgs e)
        {
            // jika benar, buka Form1
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void lbview_Enter(object sender, EventArgs e)
        {

        }

        private void txthargabuku_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbbuku_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pilih = cmbbuku.SelectedIndex;

            switch (pilih)
            {
                case 0:
                    txthargabuku.Text = "Rp80.000";
                    lbview.Text = "Novel karya Leila S. Chudori yang mengisahkan perjuangan mahasiswa era Reformasi.";
                    break;

                case 1:
                    txthargabuku.Text = "Rp100.000";
                    lbview.Text = "Novel karya Eka Kurniawan yang penuh drama sejarah dan mitos.";
                    break;

                case 2:
                    txthargabuku.Text = "Rp152.150";
                    lbview.Text = "Novel Dee Lestari bertema fantasi yang berfokus pada indra penciuman.";
                    break;

                case 3:
                    txthargabuku.Text = "Rp75.650";
                    lbview.Text = "Karya Andrea Hirata yang mengangkat kehidupan sederhana penuh ironi.";
                    break;

                case 4:
                    txthargabuku.Text = "Rp115.200";
                    lbview.Text = "Memoar Tara Westover tentang perjuangan mendapatkan pendidikan.";
                    break;

                default:
                    txthargabuku.Text = "";
                    lbview.Text = "Pilih buku untuk melihat penjelasan.";
                    break;
            }
        }

        private void txtmembayar_TextChanged(object sender, EventArgs e)
        {
            // Kalau textbox masih kosong, langsung return biar gak error
            if (string.IsNullOrWhiteSpace(txtmembayar.Text))
            {
                txtkembalian.Text = "";
                return;
            }

            try
            {
                // Ambil harga buku, buang "Rp" dan titiknya biar bisa dihitung
                string hargaString = txthargabuku.Text.Replace("Rp", "").Replace(".", "").Trim();
                int hargaBuku = int.Parse(hargaString);

                // Ambil uang yang dimasukkan user
                int uangDibayar = int.Parse(txtmembayar.Text);

                // Hitung kembalian
                int kembalian = uangDibayar - hargaBuku;

                // Kalau kembalian < 0, berarti uang kurang
                if (kembalian < 0)
                {
                    txtkembalian.Text = "Uang kurang " + Math.Abs(kembalian).ToString("N0");
                }
                else
                {
                    txtkembalian.Text = kembalian.ToString("N0");
                }
            }
            catch
            {
                // Kalau user masukin huruf, kasih pesan error sederhana
                txtkembalian.Text = "Input tidak valid";
            }
        }

        private void btnselesai_Click(object sender, EventArgs e)
        {

        }

        private void btnselesai_Click_1(object sender, EventArgs e)
        {
            if (cmbbuku.SelectedItem == null)
            {
                MessageBox.Show("Silakan pilih buku terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtmembayar.Text))
            {
                MessageBox.Show("Bayar terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ambil harga buku (hapus Rp dan titik biar bisa dihitung)
            string hargaString = txthargabuku.Text.Replace("Rp", "").Replace(".", "").Trim();
            int hargaBuku = int.Parse(hargaString);

            int uangDibayar = int.Parse(txtmembayar.Text);

            if (uangDibayar < hargaBuku)
            {
                MessageBox.Show("Uang tidak cukup untuk membeli buku ini!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kalau semua valid, tampilkan struk
            string pesan = "Pembelian Sukses!\n" +
                           "Buku: " + cmbbuku.SelectedItem.ToString() + "\n" +
                           "Harga: " + txthargabuku.Text + "\n" +
                           "Bayar: Rp" + txtmembayar.Text + "\n" +
                           "Kembalian: Rp" + txtkembalian.Text;

            MessageBox.Show(pesan, "Struk Pembelian", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
