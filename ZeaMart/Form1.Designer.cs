namespace ZeaMart
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            datagridv = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbx_nama = new TextBox();
            tbx_harga = new TextBox();
            tbx_jenis = new TextBox();
            tbx_stok = new TextBox();
            title = new Label();
            search_label = new Label();
            tbx_search = new TextBox();
            tbxkodeedit = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            tbx_namaedit = new TextBox();
            tbx_hargaedit = new TextBox();
            tbx_jenisedit = new TextBox();
            tbx_stokedit = new TextBox();
            buttontambah = new Button();
            buttonubah = new Button();
            ((System.ComponentModel.ISupportInitialize)datagridv).BeginInit();
            SuspendLayout();
            // 
            // datagridv
            // 
            datagridv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridv.Location = new Point(17, 448);
            datagridv.Margin = new Padding(4, 5, 4, 5);
            datagridv.Name = "datagridv";
            datagridv.RowHeadersWidth = 62;
            datagridv.Size = new Size(1123, 387);
            datagridv.TabIndex = 0;
            datagridv.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 147);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 1;
            label1.Text = "Nama Barang";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 220);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 2;
            label2.Text = "Harga barang";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 293);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 3;
            label3.Text = "Jenis Barang";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 367);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(107, 25);
            label4.TabIndex = 4;
            label4.Text = "Stok Barang";
            // 
            // tbx_nama
            // 
            tbx_nama.Location = new Point(17, 177);
            tbx_nama.Margin = new Padding(4, 5, 4, 5);
            tbx_nama.Name = "tbx_nama";
            tbx_nama.Size = new Size(295, 31);
            tbx_nama.TabIndex = 5;
            // 
            // tbx_harga
            // 
            tbx_harga.Location = new Point(17, 250);
            tbx_harga.Margin = new Padding(4, 5, 4, 5);
            tbx_harga.Name = "tbx_harga";
            tbx_harga.Size = new Size(295, 31);
            tbx_harga.TabIndex = 6;
            // 
            // tbx_jenis
            // 
            tbx_jenis.Location = new Point(17, 323);
            tbx_jenis.Margin = new Padding(4, 5, 4, 5);
            tbx_jenis.Name = "tbx_jenis";
            tbx_jenis.Size = new Size(295, 31);
            tbx_jenis.TabIndex = 7;
            // 
            // tbx_stok
            // 
            tbx_stok.Location = new Point(17, 397);
            tbx_stok.Margin = new Padding(4, 5, 4, 5);
            tbx_stok.Name = "tbx_stok";
            tbx_stok.Size = new Size(295, 31);
            tbx_stok.TabIndex = 8;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            title.Location = new Point(346, 15);
            title.Margin = new Padding(4, 0, 4, 0);
            title.Name = "title";
            title.Size = new Size(353, 45);
            title.TabIndex = 9;
            title.Text = "ZeaMart Second Store";
            // 
            // search_label
            // 
            search_label.AutoSize = true;
            search_label.BackColor = Color.FromArgb(128, 128, 255);
            search_label.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            search_label.ForeColor = Color.White;
            search_label.Location = new Point(17, 83);
            search_label.Margin = new Padding(4, 0, 4, 0);
            search_label.Name = "search_label";
            search_label.Size = new Size(101, 40);
            search_label.TabIndex = 10;
            search_label.Text = "Search";
            // 
            // tbx_search
            // 
            tbx_search.Location = new Point(146, 83);
            tbx_search.Margin = new Padding(4, 5, 4, 5);
            tbx_search.Multiline = true;
            tbx_search.Name = "tbx_search";
            tbx_search.Size = new Size(590, 39);
            tbx_search.TabIndex = 11;
            tbx_search.TextChanged += tbx_search_TextChanged;
            // 
            // tbxkodeedit
            // 
            tbxkodeedit.Location = new Point(773, 105);
            tbxkodeedit.Margin = new Padding(4, 5, 4, 5);
            tbxkodeedit.Name = "tbxkodeedit";
            tbxkodeedit.Size = new Size(295, 31);
            tbxkodeedit.TabIndex = 12;
            tbxkodeedit.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(773, 75);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(113, 25);
            label5.TabIndex = 13;
            label5.Text = "Kode Barang";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(773, 148);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(119, 25);
            label6.TabIndex = 14;
            label6.Text = "Nama Barang";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(773, 222);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(120, 25);
            label7.TabIndex = 15;
            label7.Text = "Harga Barang";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(773, 295);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(109, 25);
            label8.TabIndex = 16;
            label8.Text = "Jenis Barang";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(773, 365);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(107, 25);
            label9.TabIndex = 17;
            label9.Text = "Stok Barang";
            // 
            // tbx_namaedit
            // 
            tbx_namaedit.Location = new Point(773, 178);
            tbx_namaedit.Margin = new Padding(4, 5, 4, 5);
            tbx_namaedit.Name = "tbx_namaedit";
            tbx_namaedit.Size = new Size(295, 31);
            tbx_namaedit.TabIndex = 18;
            // 
            // tbx_hargaedit
            // 
            tbx_hargaedit.Location = new Point(773, 252);
            tbx_hargaedit.Margin = new Padding(4, 5, 4, 5);
            tbx_hargaedit.Name = "tbx_hargaedit";
            tbx_hargaedit.Size = new Size(295, 31);
            tbx_hargaedit.TabIndex = 19;
            // 
            // tbx_jenisedit
            // 
            tbx_jenisedit.Location = new Point(773, 325);
            tbx_jenisedit.Margin = new Padding(4, 5, 4, 5);
            tbx_jenisedit.Name = "tbx_jenisedit";
            tbx_jenisedit.Size = new Size(295, 31);
            tbx_jenisedit.TabIndex = 20;
            // 
            // tbx_stokedit
            // 
            tbx_stokedit.Location = new Point(773, 395);
            tbx_stokedit.Margin = new Padding(4, 5, 4, 5);
            tbx_stokedit.Name = "tbx_stokedit";
            tbx_stokedit.Size = new Size(295, 31);
            tbx_stokedit.TabIndex = 21;
            // 
            // buttontambah
            // 
            buttontambah.Location = new Point(323, 368);
            buttontambah.Margin = new Padding(4, 5, 4, 5);
            buttontambah.Name = "buttontambah";
            buttontambah.Size = new Size(171, 67);
            buttontambah.TabIndex = 22;
            buttontambah.Text = "Tambah";
            buttontambah.UseVisualStyleBackColor = true;
            buttontambah.Click += buttontambah_Click;
            // 
            // buttonubah
            // 
            buttonubah.Location = new Point(593, 367);
            buttonubah.Margin = new Padding(4, 5, 4, 5);
            buttonubah.Name = "buttonubah";
            buttonubah.Size = new Size(171, 67);
            buttonubah.TabIndex = 23;
            buttonubah.Text = "Ubah";
            buttonubah.UseVisualStyleBackColor = true;
            buttonubah.Click += buttonubah_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 855);
            Controls.Add(buttonubah);
            Controls.Add(buttontambah);
            Controls.Add(tbx_stokedit);
            Controls.Add(tbx_jenisedit);
            Controls.Add(tbx_hargaedit);
            Controls.Add(tbx_namaedit);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tbxkodeedit);
            Controls.Add(tbx_search);
            Controls.Add(search_label);
            Controls.Add(title);
            Controls.Add(tbx_stok);
            Controls.Add(tbx_jenis);
            Controls.Add(tbx_harga);
            Controls.Add(tbx_nama);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(datagridv);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)datagridv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView datagridv;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbx_nama;
        private TextBox tbx_harga;
        private TextBox tbx_jenis;
        private TextBox tbx_stok;
        private Label title;
        private Label search_label;
        private TextBox tbx_search;
        private TextBox tbxkodeedit;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox tbx_namaedit;
        private TextBox tbx_hargaedit;
        private TextBox tbx_jenisedit;
        private TextBox tbx_stokedit;
        private Button buttontambah;
        private Button buttonubah;
    }
}