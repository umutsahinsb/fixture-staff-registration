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
using System.Net;
using System.Diagnostics.Eventing.Reader;

namespace BID_Demirbas
{
    public partial class DeleteItem : Form
    {
        string connectionString = "Server=UMUT;Database=BID_Demirbas;Trusted_Connection=True;";
        public DeleteItem()
        {
            InitializeComponent();
        }

        int dnoKontrol(string d_no, ref int err)
        {
            List<string> list = new List<string>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string readQuery = "SELECT D_NO FROM Bilgi_Sistemleri_Demirbas_Listesi";
                using (SqlCommand cmd = new SqlCommand(readQuery, con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {

                        list.Add(reader["D_NO"].ToString());
                    }

                    if (!list.Contains(d_no))
                    {
                        MessageBox.Show("Bu D_NO'ya sahip bir ürün bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        err = 1;
                    }
                    else
                    {
                    }
                    con.Close();
                    return err;
                }
            }

        }

        void BaglantiKoparma(string dno)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE Bilgi_Sistemleri_Demirbas_Listesi SET Kullanıcı_Bölüm = NULL, Kullanıcı = NULL WHERE D_NO = @DNO";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    cmd.Parameters.AddWithValue("@DNO", dno);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Kayıtlı ürünün" +
                        " kullanıcı bölüm ve kullanıcısı kaldırıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dno = textBox1.Text;
            string dno2 = secondItemText.Text;
            int err = 0;

            DialogResult dialogResult = MessageBox.Show("Bu ürünü silmek istediğinize emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {

                dnoKontrol(dno, ref err);
                if (err == 1) { }
                else
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        if (secondItemCheck.Checked)
                        {
                            string queryBetween = "DELETE FROM Bilgi_Sistemleri_Demirbas_Listesi WHERE D_NO BETWEEN @DNO AND @DNO2";

                            using (SqlCommand cmd = new SqlCommand(queryBetween, con))
                            {

                                cmd.Parameters.AddWithValue("@DNO", dno);
                                cmd.Parameters.AddWithValue("@DNO2", dno2);

                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();

                                MessageBox.Show("Belirtilen aralıktaki kayıtlar silindi.", "Başarılı", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else 
                        { 
                            string query = "DELETE FROM Bilgi_Sistemleri_Demirbas_Listesi WHERE D_NO = @DNO";
                          
                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {

                                cmd.Parameters.AddWithValue("@DNO", dno);

                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();

                                MessageBox.Show("Kayıt silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dno = textBox1.Text;

            BaglantiKoparma(dno);
        }

        private void secondItemCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (secondItemCheck.Checked)
            {
                secondItemLabel.Visible = true;
                secondItemText.Visible = true;
            }
            else
            {
                secondItemLabel.Visible = false;
                secondItemText.Visible = false;
            }
        }

        private void DeleteItem_Load(object sender, EventArgs e)
        {
            this.Text = "Demirbaş Sil";
            secondItemLabel.Visible = false;
            secondItemText.Visible = false;
        }
    }
}
