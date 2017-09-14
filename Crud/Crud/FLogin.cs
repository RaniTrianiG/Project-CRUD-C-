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
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=sharp;");

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Masukkan password!");
            }
            else {
                try {
                    MySqlCommand cmd = new MySqlCommand("Select uname from user where uname ='" + txtUsername.Text + "' and pwd=sha2('" + txtPassword.Text + "',224)", conn);
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows == true)
                    {
                        reader.Read();
                        MessageBox.Show("Login Sukses!");
                        this.Hide();
                        frmCrud fc = new frmCrud();
                        fc.ShowDialog();
                    }
                    else {
                        MessageBox.Show("Login Gagal!");
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FLogin_Load(object sender, EventArgs e) // nih yang ini
        {
            // bentar, kamu tau ini tempat dijalanin pas apa?
            //tau ga?
            /**
             * engga
             * codingan disini kan dijalaninnya waktu formnya mau tampil, kenapa kamu ngoding disini?
             * oh, berarti harusnya di form yang sebelum FLogin gtu?
             * nih
             * saya contohin satu yah buat yang tambah aja
             **/
        }
    }
}
