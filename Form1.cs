using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BetaMart
{
    public partial class Form1 : Form
    {

        MySqlConnection connection = new MySqlConnection("server = localhost; uid = root; database = barang");
        DataTable dataTable = new DataTable();

        public Form1()
        {
            InitializeComponent();

            tb_namaEdit.Enabled = false;
            tb_hargaEdit.Enabled = false;
            tb_id.Enabled = false;
            btn_save.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillDataBarang();
        }

        public DataTable getDataBarang()
        {
            dataTable.Reset();
            dataTable = new DataTable();
            using (MySqlCommand command = new MySqlCommand("SELECT * FROM data_barang", connection))
            {
                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();
                dataTable.Load(reader);
            }
            return dataTable;
        }

        public void fillDataBarang()
        {
            dgv_dataBarang.DataSource = getDataBarang();

            DataGridViewButtonColumn colEditBarang = new DataGridViewButtonColumn();
            colEditBarang.UseColumnTextForButtonValue = true;
            colEditBarang.Text = "Edit";
            colEditBarang.Name = "";
            dgv_dataBarang.Columns.Add(colEditBarang);

            DataGridViewButtonColumn colDeleteBarang = new DataGridViewButtonColumn();
            colDeleteBarang.UseColumnTextForButtonValue = true;
            colDeleteBarang.Text = "Delete";
            colDeleteBarang.Name = "";
            dgv_dataBarang.Columns.Add(colDeleteBarang);

            connection.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            connection.Open();

            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO data_barang(nama, harga) VALUE(@nama, @harga)";
                cmd.Parameters.AddWithValue("@nama", tb_nama.Text);
                cmd.Parameters.AddWithValue("@harga", tb_harga.Text);
                cmd.ExecuteNonQuery();
                connection.Close();
                dgv_dataBarang.Columns.Clear();
                dataTable.Clear();
                fillDataBarang();
            }
            catch (Exception ex)
            {

            }
        }

        private void dgv_dataBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                int id = Convert.ToInt32(dgv_dataBarang.CurrentCell.RowIndex.ToString());
                ///tb_id.Text = dgv_dataBarang.Rows[id].Cells[0].Value.ToString();
                tb_namaEdit.Text = dgv_dataBarang.Rows[id].Cells[0].Value.ToString();
                tb_hargaEdit.Text = dgv_dataBarang.Rows[id].Cells[1].Value.ToString();

                tb_namaEdit.Enabled = true;
                tb_hargaEdit.Enabled = true;
                btn_save.Enabled = true;
            }

            if (e.ColumnIndex == 4)
            {
                int id = Convert.ToInt32(dgv_dataBarang.CurrentCell.RowIndex.ToString());

                MySqlCommand cmd;
                connection.Open();

                try
                {
                    cmd = connection.CreateCommand();
                    cmd.CommandText = "DELETE FROM data_barang WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", dgv_dataBarang.Rows[id].Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    dgv_dataBarang.Columns.Clear();
                    dataTable.Clear();
                    fillDataBarang();
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            connection.Open();

            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "UPDATE data_barang SET nama = @nama, harga = @harga WHERE id = @id";
                cmd.Parameters.AddWithValue("@nama", tb_id.Text);
                cmd.Parameters.AddWithValue("@nama", tb_namaEdit.Text);
                cmd.Parameters.AddWithValue("@harga", tb_hargaEdit.Text);
                cmd.ExecuteNonQuery();
                connection.Close();
                dgv_dataBarang.Columns.Clear();
                dataTable.Clear();
                fillDataBarang();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
