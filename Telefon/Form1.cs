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
    public partial class FrmGiris : Form
    {

        public FrmGiris()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public static string isim = "";
        public static string soyismi = "";
        public static string kullanici;
        public static string sifre;

        private void lblUyeOl_Click(object sender, EventArgs e)
        {
            FrmUyelik gec = new FrmUyelik();
            gec.Show();
            this.Hide();
        }

        private void lblSifreUnuttum_Click(object sender, EventArgs e)
        {
            FrmSifreUnt g = new FrmSifreUnt();
            g.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa gec1 = new FrmAnaSayfa();
            kullanici = txtEmail.Text;
            sifre = txtSifre.Text;

            if (txtEmail.Text == "admin" && txtSifre.Text == "admin")
            {
                FrmAdmin gec2 = new FrmAdmin();
                gec2.Show();
                this.Hide();
            }
            else
            {
                con = new SqlConnection("Data Source=HKILIC\\SQLEXPRESS;Initial Catalog=tlf;Integrated Security=True");
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM kayit where Eposta='" + kullanici + "' AND Sifre='" + sifre + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    isim = dr[0].ToString();
                    soyismi = dr[1].ToString();
                    MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
                    gec1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
                }
                con.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                txtSifre.UseSystemPasswordChar = false;
            else
                txtSifre.UseSystemPasswordChar = true;
        }
    }
}
