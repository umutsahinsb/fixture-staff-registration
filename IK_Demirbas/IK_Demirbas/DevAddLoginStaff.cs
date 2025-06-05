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

namespace BID_Demirbas
{
    public partial class DevAddLoginStaff : Form
    {
        string connectionString = "Server=UMUT;Database=BID_Demirbas;Trusted_Connection=True;";
        public DevAddLoginStaff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameText.Text;
            string name = staffNameText.Text;
            string password = staffPasswordText.Text;
            int err = 0;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Kullanicilar VALUES (@StaffUsername, @StaffPassword, @StaffName, @StaffRole)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    string readQuery = "SELECT Kullanici_Adi, Kullanici_Sifre FROM Kullanicilar";
                    using (SqlCommand secCmd = new SqlCommand(readQuery, con))
                    {
                        con.Open();
                        SqlDataReader reader = secCmd.ExecuteReader();
                        while (reader.Read())
                        {
                            if (reader["Kullanici_Adi"].Equals(username) && reader["Kullanici_Sifre"].Equals(password))
                            {
                                MessageBox.Show("Aynı kullanıcı ad - şifre kombinas" +
                                    "yonuna sahip kullanıcı bulunmakta! Kullanıcı eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                err = 1;
                            }
                        }
                        con.Close();
                    }
                    if (err != 0) { }
                    else
                    {

                        cmd.Parameters.AddWithValue("@StaffUsername", username);
                        cmd.Parameters.AddWithValue("@StaffPassword", password);
                        cmd.Parameters.AddWithValue("@StaffName", name);
                        cmd.Parameters.AddWithValue("@StaffRole", comboBox1.SelectedItem.ToString());

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Personel ekleme başarılı.", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                }
            }
        }

        private void DevAddLoginStaff_Load(object sender, EventArgs e)
        {
            this.Text = "Sisteme Kullanıcı Ekle";
        }
    }
}
