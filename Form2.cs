using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace OtoparkTakip
{
    public partial class Form2 : Form
    {

        string connectionString = @"Data Source=DESKTOP-Q6O3070;Initial Catalog=OtoparkTakip;Integrated Security=True;TrustServerCertificate=True";

        DateTime girisTarihi;
        string bulunanPlaka = "";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ListeleCikanAraclar();

        }

        private void btnAracBul_Click(object sender, EventArgs e)
        {
            lblMesaj.Text = "";
            bulunanPlaka = txtPlakaAra.Text.Trim();

            if (string.IsNullOrEmpty(bulunanPlaka))
            {
                lblMesaj.ForeColor = System.Drawing.Color.Red;
                lblMesaj.Text = "Lütfen plaka giriniz!";
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT GirisTarihi FROM Araclar WHERE Plaka = @plaka AND Durum = 1";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@plaka", bulunanPlaka);

                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        girisTarihi = Convert.ToDateTime(result);
                        lblGirisTarihi.Text = "Giriş Tarihi: " + girisTarihi.ToString();
                        lblCikisTarihi.Text = "Çıkış Tarihi: " + DateTime.Now.ToString();
                        HesaplaUcretVeSure();
                    }
                    else
                    {
                        lblMesaj.ForeColor = System.Drawing.Color.Red;
                        lblMesaj.Text = "Aktif araç bulunamadı!";
                        TemizleBilgi();
                    }
                }
                catch (Exception ex)
                {
                    lblMesaj.ForeColor = System.Drawing.Color.Red;
                    lblMesaj.Text = "Hata: " + ex.Message;
                }
            }
        }

        private void HesaplaUcretVeSure()
        {
            DateTime cikisTarihi = DateTime.Now;
            lblCikisTarihi.Text = "Çıkış Tarihi: " + cikisTarihi.ToString();

            TimeSpan sure = cikisTarihi - girisTarihi;
            lblSure.Text = "Süre: " + sure.TotalHours.ToString("0.00") + " saat";

            double saat = Math.Ceiling(sure.TotalHours);
            if (saat < 1) saat = 1; // Minimum 1 saat ücret alınır

            double ucret = saat * 20; // Saatlik ücret 20 TL
            lblUcret.Text = "Ücret: " + ucret.ToString("C2");
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(bulunanPlaka))
            {
                lblMesaj.ForeColor = System.Drawing.Color.Red;
                lblMesaj.Text = "Önce araç bulunmalıdır!";
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string updateQuery = "UPDATE Araclar SET Durum = 0, CikisTarihi = @cikisTarihi WHERE Plaka = @plaka AND Durum = 1";
                SqlCommand cmd = new SqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@plaka", bulunanPlaka);
                cmd.Parameters.AddWithValue("@cikisTarihi", DateTime.Now);

                try
                {
                    conn.Open();
                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        lblMesaj.ForeColor = System.Drawing.Color.Green;
                        lblMesaj.Text = "Araç çıkışı başarıyla yapıldı!";
                        TemizleBilgi();
                        ListeleCikanAraclar();
                    }
                    else
                    {
                        lblMesaj.ForeColor = System.Drawing.Color.Red;
                        lblMesaj.Text = "Araç çıkışı yapılamadı!";
                    }
                }
                catch (Exception ex)
                {
                    lblMesaj.ForeColor = System.Drawing.Color.Red;
                    lblMesaj.Text = "Hata: " + ex.Message;
                }
            }
        }

        private void TemizleBilgi()
        {
            lblGirisTarihi.Text = "Giriş Tarihi: -";
            lblCikisTarihi.Text = "Çıkış Tarihi: -";
            lblSure.Text = "Süre: -";
            lblUcret.Text = "Ücret: -";
            txtPlakaAra.Clear();
            bulunanPlaka = "";
        }

        private void ListeleCikanAraclar()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Plaka, GirisTarihi, CikisTarihi FROM Araclar WHERE Durum = 0 ORDER BY CikisTarihi DESC";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();

                try
                {
                    da.Fill(dt);
                    dataGridViewCikanAraclar.DataSource = dt;
                }
                catch (Exception ex)
                {
                    lblMesaj.ForeColor = System.Drawing.Color.Red;
                    lblMesaj.Text = "Listeleme hatası: " + ex.Message;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
            this.Close();
        }
    }
}