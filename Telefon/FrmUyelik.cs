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
    public partial class FrmUyelik : Form
    {

        SqlConnection con = new SqlConnection("Data Source=HKILIC\\SQLEXPRESS;Initial Catalog=tlf;Integrated Security=True");
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        public FrmUyelik()
        {
            InitializeComponent();
        }

        public void griddoldur()
        {
            da = new SqlDataAdapter("Select *From kayit", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "tlf");
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtSoyad.Text == "" || txtEposta.Text == "" || txtSifre.Text == "" || txtSifreTekrar.Text == "")
                MessageBox.Show("Lütfen Tüm Bilgileri Doldurun", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (txtSifre.Text == txtSifreTekrar.Text)
                {

                    con.Open();
                    string ekle;
                    ekle = "insert into kayit(Ad,Soyad,Eposta,Sifre)" + "values ('" + txtAd.Text + "','" + txtSoyad.Text + "','" + txtEposta.Text + "','" + txtSifre.Text + "')";
                    cmd = new SqlCommand(ekle, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    griddoldur();

                    MessageBox.Show("Kaydınız Başarılı Bir Şekilde Oluşturulmuştur");
                    FrmGiris gec = new FrmGiris();
                    gec.Show();
                    this.Close();
                }
                else
                    MessageBox.Show("Şifreleriniz Uyuşmuyor");
            }            
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
                txtSifreTekrar.UseSystemPasswordChar = false;
            else
                txtSifreTekrar.UseSystemPasswordChar = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmGiris gec = new FrmGiris();
            gec.Show();
            this.Close();
        }
    }
}
