using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Telefon
{
    public partial class FrmSifreUnt : Form
    {
        public FrmSifreUnt()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=HKILIC\\SQLEXPRESS;Initial Catalog=tlf;Integrated Security=True");
        SqlCommand cmd;
        DataSet ds = new DataSet();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmGiris gec = new FrmGiris();
            gec.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMail.Text != "" || txtSifre.Text != "" || txtSifre2.Text != "")
            {
                if (txtSifre.Text == txtSifre2.Text)
                {
                    con.Open();
                    cmd = new SqlCommand("update kayit set Sifre='" + txtSifre.Text + "'where Eposta='" + txtMail.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Şifreniz Değiştirilmiştir");
                    FrmGiris gec = new FrmGiris();
                    gec.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Şifreler eşleşmiyor", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Boş Bırakmayınız", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                txtSifre.UseSystemPasswordChar = false;
            else
                txtSifre.UseSystemPasswordChar = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                txtSifre2.UseSystemPasswordChar = false;
            else
                txtSifre2.UseSystemPasswordChar = true;
        }
    }
}
