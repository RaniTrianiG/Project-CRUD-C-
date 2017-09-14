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

namespace Crud
{
    public partial class FormSimpan : Form
    {
        public FormSimpan()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=sharp;");

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtNama.Text == "" || txtNoHP.Text == "" || txtNoTelp.Text == "" || txtEmail.Text == "" || txtAlamat.Text == "" ) {
                MessageBox.Show("Data berhasil dimasukkan", "Sukses!");
            }
            else {
                try {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO data(`id`, `nama`, `no_telp`, `no_hp`, `email`, `alamat`, `tgl_lahir`) VALUES ( '" + txtId.Text + "', '" + txtNama.Text + "', '" + txtNoTelp.Text + "', '" + txtNoHP.Text + "', '" + txtEmail.Text + "', '" + txtAlamat.Text + "', '" + picker.Value.ToString("yyyy-MM-dd") + "')", conn);
                    conn.Close();
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine(cmd.CommandText);

                    MessageBox.Show("Data Berhasil Dimasukkan", "Sukses");
                    bersih();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void bersih() {
            txtId.Clear();
            txtNama.Clear();
            txtNoHP.Clear();
            txtNoTelp.Clear();
            txtEmail.Clear();
            txtAlamat.Clear();
        }
        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtNama.Clear();
            txtNoHP.Clear();
            txtNoTelp.Clear();
            txtEmail.Clear();
            txtAlamat.Clear();
        }
    }
}
