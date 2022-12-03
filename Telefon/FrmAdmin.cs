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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=HKILIC\\SQLEXPRESS;Initial Catalog=tlf;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds;

        public void griddoldur()
        {
            da = new SqlDataAdapter("Select *From kayit", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "kayit");
            dataGridView1.DataSource = ds.Tables["Hali"];
            con.Close();
        }


        private void pictureBox16_Click(object sender, EventArgs e)
        {
            FrmGiris gec = new FrmGiris();
            gec.Show();
            this.Close();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'tlfDataSet2.kayit' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kayitTableAdapter.Fill(this.tlfDataSet2.kayit);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter("Select * from kayit where Eposta like'%" + textBox1.Text + "%'", con);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            DialogResult durum;
            try
            {
                durum = MessageBox.Show("kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == durum)
                {
                    SqlCommand SİL = new SqlCommand("delete from kayit where Eposta='" + textBox1.Text + "'", con);
                    SİL.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("İŞLEM BAŞARILIDIR!");
                    textBox1.Clear();
                    griddoldur();
                }
            }
            catch (Exception HATA)
            {
                MessageBox.Show("İŞLEM HATASI = " + HATA.Message);
            }

        }
    }
}
