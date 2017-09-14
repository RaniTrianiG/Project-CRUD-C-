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
    public partial class FCrud : Form
    {
        public FCrud()
        {
            InitializeComponent();
        }

        MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=sharp;"); 
        private void btnLogin1_Click(object sender, EventArgs e)
        {
            FLogin fl = new FLogin();
            //fl.Show();
            fl.ShowDialog();
        }

        private void showData()
        {
            conn.Close();
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM data", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "data");
            dataGridFCrud.DataSource = ds;
            dataGridFCrud.DataMember = "data";
        }

        private void FCrud_Load(object sender, EventArgs e)
        {
            showData(); //ini fungi buat nampilin ke datagrid kan? fungsi ini dipanggil lagi setelah FormSimpan ditutup
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormSimpan fs = new FormSimpan();
            //fs.Show(); //kalau show cuma ditampilin aja tapi ga ditungguin
            fs.ShowDialog(); // kalau ini ditungguin sampe formnya ditutup baru lanjut ke codingan dibawahnya
            //dibawah sini codingan setelah FormSimpan ditutup, berarti disini codingan buat refresh datagrid
            showData(); //coba ya
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {

            // kasih notifikasi pake MessageBox.Show(), tapi messageboxnya codingnya dimasukin kedalem if() coba sok bntr
            if (MessageBox.Show("Yakin seyakin yakinnya :v", "Yakin?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes) { // disini dikasih messagebox buat nanay ke user, artinya ga ada arti ketang :v. udah ditanya disini
                // ini setelah si user jawab
                //kalau klik Yes
                Application.Exit();
                
            }
        }
    }
}
