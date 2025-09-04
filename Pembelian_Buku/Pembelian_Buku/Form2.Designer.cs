namespace Pembelian_Buku
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonkembali = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            cmbbuku = new ComboBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            txthargabuku = new TextBox();
            lbview = new GroupBox();
            groupBox4 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            txtkembalian = new TextBox();
            txtmembayar = new TextBox();
            btnselesai = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // buttonkembali
            // 
            buttonkembali.Location = new Point(12, 394);
            buttonkembali.Name = "buttonkembali";
            buttonkembali.Size = new Size(150, 44);
            buttonkembali.TabIndex = 0;
            buttonkembali.Text = "Kembali";
            buttonkembali.UseVisualStyleBackColor = true;
            buttonkembali.Click += buttonkembali_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbbuku);
            groupBox1.Location = new Point(34, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(727, 76);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 26);
            label1.Name = "label1";
            label1.Size = new Size(131, 31);
            label1.TabIndex = 4;
            label1.Text = "Pilih Buku:";
            // 
            // cmbbuku
            // 
            cmbbuku.FormattingEnabled = true;
            cmbbuku.Items.AddRange(new object[] { "Laut Bercerita – Leila S. Chudori", "Cantik Itu Luka – Eka Kurniawan", "Aroma Karsa – Dee Lestari", "Orang-Orang Biasa – Andrea Hirata", "Educated (Terdidik) – Tara Westover (memoar terjemahan)" });
            cmbbuku.Location = new Point(258, 26);
            cmbbuku.Name = "cmbbuku";
            cmbbuku.Size = new Size(450, 28);
            cmbbuku.TabIndex = 3;
            cmbbuku.SelectedIndexChanged += cmbbuku_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txthargabuku);
            groupBox2.Location = new Point(429, 127);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(332, 67);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Harga Buku";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(43, 28);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 7;
            label4.Text = "Harga Buku:";
            // 
            // txthargabuku
            // 
            txthargabuku.Location = new Point(154, 26);
            txthargabuku.Name = "txthargabuku";
            txthargabuku.Size = new Size(159, 27);
            txthargabuku.TabIndex = 0;
            txthargabuku.TextChanged += txthargabuku_TextChanged;
            // 
            // lbview
            // 
            lbview.Location = new Point(34, 127);
            lbview.Name = "lbview";
            lbview.Size = new Size(365, 208);
            lbview.TabIndex = 4;
            lbview.TabStop = false;
            lbview.Text = "Deskripsi Buku";
            lbview.Enter += lbview_Enter;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(txtkembalian);
            groupBox4.Controls.Add(txtmembayar);
            groupBox4.Location = new Point(429, 200);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(332, 135);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Detail Pembayaran";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 86);
            label3.Name = "label3";
            label3.Size = new Size(152, 25);
            label3.TabIndex = 6;
            label3.Text = "Uang Kembalian:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 28);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 5;
            label2.Text = "Membayar:";
            // 
            // txtkembalian
            // 
            txtkembalian.Location = new Point(154, 84);
            txtkembalian.Name = "txtkembalian";
            txtkembalian.Size = new Size(159, 27);
            txtkembalian.TabIndex = 1;
            // 
            // txtmembayar
            // 
            txtmembayar.Location = new Point(154, 26);
            txtmembayar.Name = "txtmembayar";
            txtmembayar.Size = new Size(159, 27);
            txtmembayar.TabIndex = 0;
            txtmembayar.TextChanged += txtmembayar_TextChanged;
            // 
            // btnselesai
            // 
            btnselesai.Location = new Point(623, 394);
            btnselesai.Name = "btnselesai";
            btnselesai.Size = new Size(165, 44);
            btnselesai.TabIndex = 5;
            btnselesai.Text = "Selesai";
            btnselesai.UseVisualStyleBackColor = true;
            btnselesai.Click += btnselesai_Click_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnselesai);
            Controls.Add(groupBox4);
            Controls.Add(lbview);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(buttonkembali);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonkembali;
        private GroupBox groupBox1;
        private Label label1;
        private ComboBox cmbbuku;
        private GroupBox groupBox2;
        private GroupBox lbview;
        private Label label4;
        private TextBox txthargabuku;
        private GroupBox groupBox4;
        private Label label3;
        private Label label2;
        private TextBox txtkembalian;
        private TextBox txtmembayar;
        private Button btnselesai;
    }
}