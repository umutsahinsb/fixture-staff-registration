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
using System.Xml.Linq;

namespace BID_Demirbas
{
    public partial class Login : Form
    {
        string connectionString = "Server=UMUT;Database=BID_Demirbas;Trusted_Connection=True;";
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string name = usernameText.Text;
            string password = passwordText.Text;
            bool success = false;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT Personel_Rol FROM Kullanicilar WHERE Kullanici_Adi = @StaffName AND Kullanici_Sifre = @StaffPassword";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@StaffName", name);
                    cmd.Parameters.AddWithValue("@StaffPassword", password);

                    con.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        staffRoleHolder.Text = result.ToString();
                        success = true;
                    }
                    con.Close();

                }
                string secondQuery = "SELECT Personel_İsimSoyisim FROM Kullanicilar WHERE Kullanici_Adi = @StaffName2 AND Kullanici_Sifre = @StaffPassword2";
                using (SqlCommand secondCmd = new SqlCommand(secondQuery, con))
                {
                    secondCmd.Parameters.AddWithValue("@StaffName2", name);
                    secondCmd.Parameters.AddWithValue("@StaffPassword2", password);

                    con.Open();
                    object resultName = secondCmd.ExecuteScalar();


                    if (resultName != null)
                    {
                        staffNameHolder.Text = resultName.ToString();

                    }
                    else
                    {
                        MessageBox.Show("İsim alınamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
                if (success)
                {
                    /* Bir önceki ekrana dönüş butonu kullanıp, bilgilerin değişikliğini sağlayabilmek için yeni Form bu şekilde yaratılacak. */
                    FormManager.ShowForm(FormManager.Form1Instance);
                    this.Hide();
                }
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
