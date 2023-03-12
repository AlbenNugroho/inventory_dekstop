using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ZeaMart
{
    public partial class Form1 : Form
    {
        MySqlConnection sambungankoneksi = Koneksidb.getKonektionn();
        DataTable datatabel = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            isidatatabel();
        }

        public void isidatatabel()
        {
            //menampilkan datatable ke datagridview
            datagridv.DataSource = Getdatabarangbekas();

            DataGridViewButtonColumn colEdit = new DataGridViewButtonColumn();
            colEdit.UseColumnTextForButtonValue = true;
            colEdit.Text = "Edit";
            colEdit.Name = "";
            datagridv.Columns.Add(colEdit);

            DataGridViewButtonColumn colDelete = new DataGridViewButtonColumn();
            colDelete.UseColumnTextForButtonValue = true;
            colDelete.Text = "Hapus";
            colDelete.Name = "";
            datagridv.Columns.Add(colDelete);
        }

        public DataTable Getdatabarangbekas()
        {
            //membaca data di localhost
            datatabel.Reset();
            datatabel = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM data_barangbekas", sambungankoneksi))
            {
                sambungankoneksi.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                datatabel.Load(reader);
            }
            return datatabel;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                int id = Convert.ToInt32(datagridv.CurrentCell.RowIndex.ToString());
                tbxkodeedit.Text = datagridv.Rows[id].Cells[0].Value.ToString();
                tbx_namaedit.Text = datagridv.Rows[id].Cells[1].Value.ToString();
                tbx_hargaedit.Text = datagridv.Rows[id].Cells[2].Value.ToString();
                tbx_jenisedit.Text = datagridv.Rows[id].Cells[3].Value.ToString();
                tbx_stokedit.Text = datagridv.Rows[id].Cells[4].Value.ToString();

                tbx_namaedit.Enabled = true;
                tbx_hargaedit.Enabled = true;
                tbx_jenisedit.Enabled = true;
                tbx_stokedit.Enabled = true;
            }

            if (e.ColumnIndex == 6)
            {
                int id = Convert.ToInt32(datagridv.CurrentCell.RowIndex.ToString());

                MySqlCommand cmd;
                try
                {
                    cmd = sambungankoneksi.CreateCommand();
                    cmd.CommandText = "DELETE FROM data_barangbekas WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", datagridv.Rows[id].Cells[0].Value.ToString());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil dihapus");
                    resetIncrement();
                    sambungankoneksi.Close();

                    datagridv.Columns.Clear();
                    datatabel.Clear();
                    isidatatabel();
                }
                catch (Exception)
                {
                    MessageBox.Show("Gagal hapus buku");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void resetIncrement()
        {
            MySqlScript querysql = new MySqlScript(sambungankoneksi, "SET @id := 0; UPDATE data_barangbekas SET id = @id := (@id+1); " + "ALTER TABLE data_barangbekas AUTO_INCREMENT = 1;");
            querysql.Execute();
        }

        private void buttontambah_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            try
            {
                resetIncrement();
                cmd = sambungankoneksi.CreateCommand();
                cmd.CommandText = "INSERT INTO data_barangbekas(nama, harga, jenis, stok) VALUE (@nama, @harga, @jenis, @stok)";
                cmd.Parameters.AddWithValue("@nama", tbx_nama.Text);
                cmd.Parameters.AddWithValue("@harga", tbx_harga.Text);
                cmd.Parameters.AddWithValue("@jenis", tbx_jenis.Text);
                cmd.Parameters.AddWithValue("@stok", tbx_stok.Text);
                cmd.ExecuteNonQuery();

                sambungankoneksi.Close();
                datagridv.Columns.Clear();
                datatabel.Clear();
                isidatatabel();


            }
            catch (Exception)
            {
                MessageBox.Show("Gagal menambah data");
            }
        }

        private void tbx_search_TextChanged(object sender, EventArgs e)
        {
            searchdatabarangbekas(tbx_search.Text);
        }

        public void searchdatabarangbekas(string ValueToFind)
        {
            string searchQuery = "SELECT * FROM data_barangbekas WHERE CONCAT(nama) LIKE '%" + ValueToFind + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, sambungankoneksi);
            DataTable tablesearch = new DataTable();
            adapter.Fill(tablesearch);
            datagridv.DataSource = tablesearch;
        }

        private void buttonubah_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;

            try
            {
                resetIncrement();

                cmd = sambungankoneksi.CreateCommand();
                cmd.CommandText = "UPDATE data_barangbekas SET nama = @nama, harga = @harga, jenis = @jenis, stok = @stok WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", tbxkodeedit.Text);
                cmd.Parameters.AddWithValue("@nama", tbx_namaedit.Text);
                cmd.Parameters.AddWithValue("@harga", tbx_hargaedit.Text);
                cmd.Parameters.AddWithValue("@jenis", tbx_jenisedit.Text);
                cmd.Parameters.AddWithValue("@stok", tbx_stokedit.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diubah");
                sambungankoneksi.Close();

                datagridv.Columns.Clear();
                datatabel.Clear();
                isidatatabel();
            }
            catch (Exception)
            {
                MessageBox.Show("Data gagal diubah");
            }
        }
    }
}