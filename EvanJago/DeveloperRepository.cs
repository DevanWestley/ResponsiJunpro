using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace EvanJago
{
    internal class DeveloperRepository : Developer
    {
        private const string conn = "Host=localhost;Port=5432;Username=postgres;Password=usti;Database=EvanJago";
        private static NpgsqlConnection connection;
        private static NpgsqlCommand cmd;
        private static DataTable dt;

        private DataGridView dgvData;
        private DataGridViewRow row;

        public DataGridViewRow Row { set { row = value; } }

        public DeveloperRepository(DataGridView _dgvData)
        {
            dgvData = _dgvData;
        }

        // Insert
        public void Insert(TextBox tbNama, ComboBox cbProyek, ComboBox cbStatus, TextBox tbFitur,TextBox tbBug)
        {
            connection = new NpgsqlConnection(conn);
            try
            {
                connection.Open();
                string sql = @"SELECT * FROM emp_insert(:_nama, :_proyek, :_status, :_fitur, :_bug)";
                cmd = new NpgsqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("_nama", tbNama.Text);
                cmd.Parameters.AddWithValue("_proyek", cbProyek.Text);
                cmd.Parameters.AddWithValue("_status", cbStatus.Text);
                cmd.Parameters.AddWithValue("_fitur", tbFitur.Text);
                cmd.Parameters.AddWithValue("_bug", tbBug.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data berhasil ditambahkan");
                    connection.Close();
                    tbNama.Text = null;
                    cbProyek.Text = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
            finally { connection.Close(); }
        }

        // Edit
        public void Edit(TextBox tbNama, ComboBox cbProyek, ComboBox cbStatus, TextBox tbFitur, TextBox tbBug)
        {
            connection = new NpgsqlConnection(conn);
            if (row == null)
            {
                MessageBox.Show("Mohon pilih baris data yang ingin diubah");
            }

            try
            {
                connection.Open();
                string sql = @"SELECT * FROM emp_update(:_id, :_nama, :_proyek, :_status, :_fitur, :_bug)";
                cmd = new NpgsqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("_id", row.Cells["_id_dev"].Value.ToString());
                cmd.Parameters.AddWithValue("_nama", tbNama.Text);
                cmd.Parameters.AddWithValue("_proyek", cbProyek.Text);
                cmd.Parameters.AddWithValue("_status", cbStatus.Text);
                cmd.Parameters.AddWithValue("_fitur", tbFitur.Text);
                cmd.Parameters.AddWithValue("_bug", tbBug.Text);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data berhasil diubah");
                    connection.Close();
                    tbNama.Text = null;
                    cbProyek.Text = null;
                    row = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
            finally { connection.Close(); }
        }

        // Delete
        public void Delete(TextBox tbNama, ComboBox cbProyek, ComboBox cbStatus, TextBox tbFitur, TextBox tbBug)
        {
            connection = new NpgsqlConnection(conn);
            if (row == null)
            {
                MessageBox.Show("Mohon pilih baris data yang ingin dihapus");
            }

            try
            {
                connection.Open();
                string sql = @"select * from emp_delete(:_id)";
                cmd = new NpgsqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("_id", row.Cells["_id_dev"].Value.ToString());

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data berhasil dihapus");
                    connection.Close();
                    tbNama.Text = null;
                    cbProyek.Text = null;
                    row = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
            finally { connection.Close(); }
        }
    }
}
