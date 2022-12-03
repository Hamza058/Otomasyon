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
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=HKILIC\\SQLEXPRESS;Initial Catalog=tlf;Integrated Security=True");
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        public static string ad;
        public static string renk;
        public static string fiyat;

        public void griddoldur()
        {
            da = new SqlDataAdapter("Select *From kayit", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "tlf");
            con.Close();
        }

        

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {           
            timer1.Start();
            lblProf.Text = FrmGiris.isim + " " + FrmGiris.soyismi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ad = lblAd1.Text;
            renk = comboBox1.Text;
            fiyat = lblFyt1.Text;
            con.Open();
            cmd = new SqlCommand("update kayit set Tlf_ad='" + ad + "',Tlf_renk='" + renk + "',Tlf_fyt='" + fiyat + "'where Eposta='" + FrmGiris.kullanici + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ad = lblAd2.Text;
            renk = comboBox2.Text;
            fiyat = lblFyt2.Text;
            con.Open();
            cmd = new SqlCommand("update kayit set Tlf_ad='" + ad + "',Tlf_renk='" + renk + "',Tlf_fyt='" + fiyat + "'where Eposta='" + FrmGiris.kullanici + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ad = lblAd3.Text;
            renk = comboBox3.Text;
            fiyat = lblFyt3.Text;
            con.Open();
            cmd = new SqlCommand("update kayit set Tlf_ad='" + ad + "',Tlf_renk='" + renk + "',Tlf_fyt='" + fiyat + "'where Eposta='" + FrmGiris.kullanici + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ad = llbAd4.Text;
            renk = comboBox4.Text;
            fiyat = lblFyt4.Text;
            con.Open();
            cmd = new SqlCommand("update kayit set Tlf_ad='" + ad + "',Tlf_renk='" + renk + "',Tlf_fyt='" + fiyat + "'where Eposta='" + FrmGiris.kullanici + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ad = lblAd5.Text;
            renk = comboBox5.Text;
            fiyat = lblFyt5.Text;
            con.Open();
            cmd = new SqlCommand("update kayit set Tlf_ad='" + ad + "',Tlf_renk='" + renk + "',Tlf_fyt='" + fiyat + "'where Eposta='" + FrmGiris.kullanici + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ad = lblAd16.Text;
            renk = comboBox6.Text;
            fiyat = lblFyt6.Text;
            con.Open();
            cmd = new SqlCommand("update kayit set Tlf_ad='" + ad + "',Tlf_renk='" + renk + "',Tlf_fyt='" + fiyat + "'where Eposta='" + FrmGiris.kullanici + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ad = lblAd7.Text;
            renk = comboBox7.Text;
            fiyat = lblFyt7.Text;
            con.Open();
            cmd = new SqlCommand("update kayit set Tlf_ad='" + ad + "',Tlf_renk='" + renk + "',Tlf_fyt='" + fiyat + "'where Eposta='" + FrmGiris.kullanici + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ad = lblAd8.Text;
            renk = comboBox8.Text;
            fiyat = lblFyt8.Text;
            con.Open();
            cmd = new SqlCommand("update kayit set Tlf_ad='" + ad + "',Tlf_renk='" + renk + "',Tlf_fyt='" + fiyat + "'where Eposta='" + FrmGiris.kullanici + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ad = lblAd9.Text;
            renk = comboBox9.Text;
            fiyat = lblFyt9.Text;
            con.Open();
            cmd = new SqlCommand("update kayit set Tlf_ad='" + ad + "',Tlf_renk='" + renk + "',Tlf_fyt='" + fiyat + "'where Eposta='" + FrmGiris.kullanici + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ad = lblAd10.Text;
            renk = comboBox10.Text;
            fiyat = lblFyt10.Text;
            con.Open();
            cmd = new SqlCommand("update kayit set Tlf_ad='" + ad + "',Tlf_renk='" + renk + "',Tlf_fyt='" + fiyat + "'where Eposta='" + FrmGiris.kullanici + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ad = lblAd11.Text;
            renk = comboBox11.Text;
            fiyat = lblFyt11.Text;
            con.Open();
            cmd = new SqlCommand("update kayit set Tlf_ad='" + ad + "',Tlf_renk='" + renk + "',Tlf_fyt='" + fiyat + "'where Eposta='" + FrmGiris.kullanici + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ad = lblAd12.Text;
            renk = comboBox12.Text;
            fiyat = lblFyt12.Text;
            con.Open();
            cmd = new SqlCommand("update kayit set Tlf_ad='" + ad + "',Tlf_renk='" + renk + "',Tlf_fyt='" + fiyat + "'where Eposta='" + FrmGiris.kullanici + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            FrmGiris gec = new FrmGiris();
            gec.Show();
            this.Close();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            frmSepet gec = new frmSepet();
            gec.Show();
            this.Hide();
        }

        private void label66_Click(object sender, EventArgs e)
        {
            frmSepet gec = new frmSepet();
            gec.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ad = lblAd13.Text;
            renk = comboBox14.Text;
            fiyat = lblFyt13.Text;
            if (comboBox14.Text == "")
                MessageBox.Show("Lütfen Renk Seçiniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                con.Open();
                cmd = new SqlCommand("update kayit set Tlf_ad='" + ad + "',Tlf_renk='" + renk + "',Tlf_fyt='" + fiyat + "'where Eposta='" + FrmGiris.kullanici + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                griddoldur();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ad = lblAd14.Text;
            renk = comboBox15.Text;
            fiyat = lblFyt14.Text;
            if (comboBox15.Text == "")
                MessageBox.Show("Lütfen Renk Seçiniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                con.Open();
                cmd = new SqlCommand("update kayit set Tlf_ad='" + ad + "',Tlf_renk='" + renk + "',Tlf_fyt='" + fiyat + "'where Eposta='" + FrmGiris.kullanici + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                griddoldur();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ad = lblAd15.Text;
            renk = comboBox16.Text;
            fiyat = lblFyt15.Text;
            if (comboBox16.Text == "")
                MessageBox.Show("Lütfen Renk Seçiniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                con.Open();
                cmd = new SqlCommand("update kayit set Tlf_ad='" + ad + "',Tlf_renk='" + renk + "',Tlf_fyt='" + fiyat + "'where Eposta='" + FrmGiris.kullanici + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                griddoldur();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ad = lblAd16.Text;
            renk = comboBox17.Text;
            fiyat = lblFyt16.Text;
            if (comboBox17.Text == "")
                MessageBox.Show("Lütfen Renk Seçiniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                con.Open();
                cmd = new SqlCommand("update kayit set Tlf_ad='" + ad + "',Tlf_renk='" + renk + "',Tlf_fyt='" + fiyat + "'where Eposta='" + FrmGiris.kullanici + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                griddoldur();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ad = lblAd17.Text;
            renk = comboBox18.Text;
            fiyat = lblFyt17.Text;
            if (comboBox18.Text == "")
                MessageBox.Show("Lütfen Renk Seçiniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                con.Open();
                cmd = new SqlCommand("update kayit set Tlf_ad='" + ad + "',Tlf_renk='" + renk + "',Tlf_fyt='" + fiyat + "'where Eposta='" + FrmGiris.kullanici + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                griddoldur();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            ad = lblAd18.Text;
            renk = comboBox19.Text;
            fiyat = lblFyt18.Text;
            if (comboBox19.Text == "")
                MessageBox.Show("Lütfen Renk Seçiniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                con.Open();
                cmd = new SqlCommand("update kayit set Tlf_ad='" + ad + "',Tlf_renk='" + renk + "',Tlf_fyt='" + fiyat + "'where Eposta='" + FrmGiris.kullanici + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                griddoldur();
            }
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            pnlIphone.Visible = false;
            pnlHua.Visible = false;
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            pnlIphone.Visible = true;
            pnlHua.Visible = false;
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            pnlHua.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox23.Location = new Point(pictureBox23.Location.X - 1, pictureBox23.Location.Y);
            label76.Location = new Point(label76.Location.X - 1, label76.Location.Y);
            if (label76.Location.X == -150)
            {
                pictureBox23.Location = new Point(390, 12);
                label76.Location = new Point(450, 30);
            }
        }
    }
}
