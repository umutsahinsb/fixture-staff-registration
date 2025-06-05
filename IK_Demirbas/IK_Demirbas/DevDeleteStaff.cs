using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BID_Demirbas
{
    public partial class DevDeleteStaff : Form
    {
        string connectionString = "Server=UMUT;Database=BID_Demirbas;Trusted_Connection=True;";
        public DevDeleteStaff()
        {
            InitializeComponent();
        }

        void KullaniciYukleme()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Kullanicilar";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        usernameCombo.Items.Add(reader["Kullanici_Adi"].ToString());
                    }
                }
            }
        }
        private void DevDeleteStaff_Load(object sender, EventArgs e)
        {
            KullaniciYukleme();
            this.Text = "Sistemden Personel Sil";
        }

        private void usernameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string username = usernameCombo.SelectedItem.ToString();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT Personel_İsimSoyisim, Personel_Rol FROM Kullanicilar " +
                    "WHERE Kullanici_Adi = @StaffUsername";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@StaffUsername", username);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        label1.Text = reader["Personel_İsimSoyisim"].ToString();
                        label2.Text = reader["Personel_Rol"].ToString();
                    }
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string username = usernameCombo.SelectedItem.ToString();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Kullanicilar " +
                    "WHERE Kullanici_Adi = @StaffUsername";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@StaffUsername", username);
                    con.Open();
                   DialogResult dialogResult = MessageBox.Show("Bu kullanıcıyı silmek istediğinize emin misiniz?",
                        "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kullanıcı silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    con.Close(); 
                }
            }
        }
    }
}
