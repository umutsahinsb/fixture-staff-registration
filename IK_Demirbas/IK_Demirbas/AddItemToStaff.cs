using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BID_Demirbas
{
    public partial class AddItemToStaff : Form
    {
        string connectionString = "Server=UMUT;Database=BID_Demirbas;Trusted_Connection=True;";
        public int count = 0;

        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["StaffList"];
        System.Windows.Forms.Form l = System.Windows.Forms.Application.OpenForms["StaffList"];
        public AddItemToStaff()
        {
            InitializeComponent();
            FormClosing += AddItemToStaff_FormClosing;
        }
        void AddItemToStaff_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Bu değer konmazsa SONSUZ LOOP'a sokuyor.
            if (count == 0)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                // Prompt user to save his data
                {
                    count = 1;
                    FormManager.StaffInstance.Show();
                    this.Close();

                }
            }
            // Autosave and clear up ressources
        }
        void ListeSifirlama(List<string> list)
        {
            listBox1.BeginUpdate();
            listBox1.DataSource = list;
            listBox1.EndUpdate();
        }

        List<string> ListeyeAt(List<string> lt)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Bilgi_Sistemleri_Demirbas_Listesi WHERE Kullanici_Bolum = 'Bilgi Sistemleri Dairesi Başkanlığı' " +
                    "AND Kullanici = 'Bilgi Sistemleri Depo'";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        lt.Add(reader["D_NO"].ToString() + "\t" + reader["Demirbas_Malzeme_Adi"].ToString() + "\t\t + " +
                            reader["Ozellikleri"].ToString());
                    }
                    con.Close();
                }
            }
            return lt;
        }

        List<string> searchedItem(List<string> list)
        {
            string text = textBox1.Text;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string queryFiltered = "SELECT * FROM Bilgi_Sistemleri_Demirbas_Listesi " +
                   "WHERE Kullanici_Bolum = 'Bilgi Sistemleri Dairesi Başkanlığı' AND Kullanici = 'Bilgi Sistemleri Depo' AND (CHARINDEX(@TEXT, D_NO) > 0 " +
                   "OR CHARINDEX(@TEXT, Demirbas_Malzeme_Adi) > 0 " +
                   "OR CHARINDEX(@TEXT, Ozellikleri) > 0)";
                using (SqlCommand cmd = new SqlCommand(queryFiltered, con))
                {
                    cmd.Parameters.AddWithValue("@TEXT", text);

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(reader["D_NO"] + "\t" + reader["Demirbas_Malzeme_Adi"].ToString() + "\t\t" + reader["Ozellikleri"].ToString());
                    }
                    con.Close();
                    ListeSifirlama(list);
                }
            }
            return list;
        }

        void ItemEkle()
        {
            string name = staffName.Text;
            string departmentName = staffDepartmentLabel.Text;
            string itemName = listBox1.SelectedItem.ToString();
            string dno = itemName.Split(new string[] { "\t" }, StringSplitOptions.None)[0];

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                string queryUpdate = "UPDATE Bilgi_Sistemleri_Demirbas_Listesi " +
                        "SET Kullanici = @StaffName, Kullanici_Bolum = @StaffDepart " +
                        "WHERE D_NO = @DNO";

                using (SqlCommand cmdUpdate = new SqlCommand(queryUpdate, con))
                {
                    cmdUpdate.Parameters.AddWithValue("@StaffName", name);
                    cmdUpdate.Parameters.AddWithValue("@StaffDepart", departmentName);
                    cmdUpdate.Parameters.AddWithValue("@DNO", dno);

                    con.Open();
                    cmdUpdate.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Personelin demirbaş kaydı başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            this.Hide();
        }

        private void AddItemToStaff_Load(object sender, EventArgs e)
        {
            this.Text = "Personel Demirbaş Bilgisi";
            string text = FormManager.StaffInstance.staffListBox.Text;
            string departmentName = FormManager.StaffInstance.departmentBox.Text;
            staffName.Text = text;
            staffDepartmentLabel.Text = departmentName;

            List<string> filterCheck = new List<string>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Bilgi_Sistemleri_Demirbas_Listesi WHERE Kullanici_Bolum = 'Bilgi Sistemleri Dairesi Başkanlığı' " +
                    "AND Kullanici = 'Bilgi Sistemleri Depo'";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        filterCheck.Add(reader["D_NO"] + "\t" + reader["Demirbas_Malzeme_Adi"].ToString() + "\t\t" + reader["Ozellikleri"].ToString());
                    }
                    con.Close();
                    ListeSifirlama(filterCheck);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            List<string> list = new List<string>();
            List<string> filteredList = new List<string>();
            List<string> searched = new List<string>();

            if (textBox1.Text == "")
            {
                ListeyeAt(list);
                ListeSifirlama(list);
            }
            else
            {
                searchedItem(searched);
            }
        }

        private void addItemToStaffButton_Click(object sender, EventArgs e)
        {
            ItemEkle();
        }
    }
}
