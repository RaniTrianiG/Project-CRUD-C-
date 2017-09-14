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
    public partial class frmCrud : Form
    {
        public frmCrud()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=sharp;");

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtNama.Text == "" || txtNoHP.Text == "" || txtNoTelp.Text == "" || txtEmail.Text == "" || txtAlamat.Text == "")
            {
                MessageBox.Show("Silahkan isi form dengan benar!");
            }
            else
            {
                try {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO data(`id`, `nama`, `no_telp`, `no_hp`, `email`, `alamat`, `tgl_lahir`) VALUES ( '" + txtId.Text +"', '"+ txtNama.Text + "', '"+ txtNoTelp.Text + "', '"+ txtNoHP.Text + "', '"+ txtEmail.Text + "', '"+ txtAlamat.Text + "', '"+ DTglLahir.Value.ToString("yyyy-MM-dd") +"')", conn);
                    conn.Close();
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine(cmd.CommandText);

                    MessageBox.Show("Data Berhasil Dimasukkan", "Sukses");
                    showData();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);   
                }
            }
        }

        private void btnPerbarui_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" | txtNama.Text == "" || txtNoHP.Text == "" || txtNoTelp.Text == "" || txtEmail.Text == "" || txtAlamat.Text == "") {
                MessageBox.Show("Data belum lengkap!", "Validasi");
            } else {
                try {
                    MySqlCommand cmd = new MySqlCommand("update data set nama='" + txtNama.Text + "', no_telp='" + txtNoHP.Text + "', email='" + txtAlamat.Text + "', tgl_lahir='" + DTglLahir.Value.ToString("yyyy-MM-dd") + "' where id='" + txtId.Text + "'", conn); //nanti dijelasin, kalo bener itu juga codingannya
                    conn.Close();
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil diperbarui","Perbarui");
                    showData();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
            showData();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try {
                MySqlCommand cmd = new MySqlCommand("delete from data where id='" + txtId.Text + "';", conn);
                conn.Close();
                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data berhasil dihapus","Hapus");
                showData();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            showData();
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtNama.Clear();
            txtNoHP.Clear();
            txtNoTelp.Clear();
            DTglLahir.Value = DateTime.Today; // kembaliin ke tanggal hari ini
            txtEmail.Clear();
            txtAlamat.Clear();
        }
        
        private void showData()
        {
            conn.Close();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM data", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "data");
            dataGridUtama.DataSource = ds;
            dataGridUtama.DataMember = "data";
        }

        private void frmCrud_Load(object sender, EventArgs e)
        {
            showData();

            Console.WriteLine(DTglLahir.Value.ToString("yyyy-MM-dd"));
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            if(txtId.Text == string.Empty)
            {
            
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("SELECT nama, no_telp, no_hp, email, alamat, tgl_lahir FROM data WHERE id=@id LIMIT 1", conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", txtId.Text);
                conn.Close();
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)// kalau ada datanya
                {
                    
                    // buka data readernya
                    dr.Read();
                    
                    txtNama.Text = dr.GetValue(0).ToString();
                    txtNoTelp.Text = dr.GetValue(1).ToString();
                    txtNoHP.Text = dr.GetValue(2).ToString();
                    txtEmail.Text = dr.GetValue(3).ToString();
                    txtAlamat.Text = dr.GetValue(4).ToString();
                    //txtTglLahir.Text = dr.GetValue(5).ToString(); // formatnya beda bukan string lagi, tapi Date
                    DTglLahir.Value = dr.GetDateTime(5); 
                    
                    // jangan lupa ditutup, bisi masuk angin, eh jail tangan teh :v eh geraa
                    dr.Close();
                }
                else
                {
                    Console.WriteLine("Empty row");
                    btnBersihkan.PerformClick();

                     }

            }
        }

        private void dataGridUtama_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string v;
            v = dataGridUtama.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtId.Text = v;
            btnCari.PerformClick();
            //Console.WriteLine(v);
        }

        private void dataGridUtama_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
