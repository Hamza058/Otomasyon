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
    public partial class frmSepet : Form
    {
        public frmSepet()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=HKILIC\\SQLEXPRESS;Initial Catalog=tlf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds = new DataSet();

        public void griddoldur()
        {
            da = new SqlDataAdapter("Select *From kayit", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "tlf");
            con.Close();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa gec = new FrmAnaSayfa();
            gec.Show();
            this.Hide();
        }

        private void frmSepet_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'tlfDataSet.kayit' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kayitTableAdapter.Fill(this.tlfDataSet.kayit);

            con.Open();
            da = new SqlDataAdapter("select * from kayit where Ad like '%" + FrmGiris.isim + "%'", con);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adres = richTextBox1.Text;
            if (adres != "")
            {
                con.Open();
                cmd = new SqlCommand("Select * from kayit where Eposta='" + FrmGiris.kullanici + "'", con);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if (FrmGiris.kullanici == dr["Eposta"].ToString())
                    {
                        con.Close();
                        con.Open();
                        cmd = new SqlCommand("update kayit set Adres='" + adres + "'where Eposta='" + FrmGiris.kullanici + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                con.Close();
                MessageBox.Show("Siparişiniz Alınmıştır");
                FrmAnaSayfa gec = new FrmAnaSayfa();
                gec.Show();
                this.Close();
            }
            else
                MessageBox.Show("Adresi Boş Bırakmayınız", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
