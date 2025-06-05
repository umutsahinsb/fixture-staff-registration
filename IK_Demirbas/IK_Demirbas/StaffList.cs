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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BID_Demirbas
{
    public partial class StaffList : Form
    {
        public int count = 0;
        string connectionString = "Server=UMUT;Database=BID_Demirbas;Trusted_Connection=True;";

        public StaffList()
        {
            InitializeComponent();
            FormClosing += StaffList_FormClosing;
        }
        private void ButonIkonYukleme()
        {

            button2.ImageAlign = ContentAlignment.MiddleCenter;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
        }
        private void FirstList(List<string> list)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT DISTINCT * FROM Personel";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(reader["Personel_Birim"].ToString());
                    }
                    con.Close();
                }
            }
        }
        private void ComboUpdate(List<string> list)
        {
            departmentBox.BeginUpdate();
            departmentBox.DataSource = list;
            departmentBox.EndUpdate();
        }
        private void ListUpdate(List<string> list)
        {
            staffListBox.BeginUpdate();
            staffListBox.DataSource = list;
            staffListBox.EndUpdate();
        }
        private void deleteStaffButton_Click(object sender, EventArgs e)
        {
            if (staffListBox.Text.Length <= 0)
            {
                MessageBox.Show("Personel seçimi yapmadınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string staffName = staffListBox.GetItemText(staffListBox.SelectedItem);
                string staffDepart = departmentBox.Text;
                int err = 0;

                DialogResult dialogResult = MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?\n\n" + staffName +
                    "\t" + staffDepart, "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    if (err == 1) { }

                    else
                    {
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {

                            string queryUpdate = "UPDATE Bilgi_Sistemleri_Demirbas_Listesi " +
                                    "SET Kullanici = NULL, Kullanici_Bolum = NULL " +
                                    "WHERE Kullanici = @StaffName AND Kullanici_Bolum = @StaffDepart";

                            using (SqlCommand cmdUpdate = new SqlCommand(queryUpdate, con))
                            {

                                cmdUpdate.Parameters.AddWithValue("@StaffName", staffName);
                                cmdUpdate.Parameters.AddWithValue("@StaffDepart", staffDepart);

                                con.Open();
                                cmdUpdate.ExecuteNonQuery();
                                con.Close();

                                MessageBox.Show("Personele kaydedilen tüm ürünler boş duruma getirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }

                            string query = "DELETE FROM Personel WHERE Personel_Adi = @StaffName AND Personel_Birim = @StaffDepart";

                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {

                                cmd.Parameters.AddWithValue("@StaffName", staffName);
                                cmd.Parameters.AddWithValue("@StaffDepart", staffDepart);


                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();


                                MessageBox.Show("Personel kaydı silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                    }
                }
            }
        }
        private void addStaffButton_Click(object sender, EventArgs e)
        {
            FormManager.ShowForm(new AddStaff());
            this.Hide();
        }
        void StaffList_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Bu değer konmazsa SONSUZ LOOP'a sokuyor.
            if (count == 0)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    FormManager.ShowForm(FormManager.Form1Instance);
                    count = 1;
                    this.Hide();
                }
            }
        }
        private void StaffList_Load(object sender, EventArgs e)
        {

            {
                ButonIkonYukleme();
                this.Refresh();
                this.Text = "Personel Listesi";
                string f = FormManager.Form1Instance.staffNameLabel.Text;
                string h = FormManager.Form1Instance.staffRoleLabel.Text;
                inheritName.Text = f;
                inheritRole.Text = h;
                string role = FormManager.Form1Instance.staffRoleLabel.Text;
                if (role == "Personel")
                {
                    changeInfo.Visible = false;
                    deleteStaffButton.Visible = false;
                    addStaffButton.Visible = false;
                }
                List<string> list = new List<string>();
                FirstList(list);
                var uniqueItemsList = list.Distinct().ToList();
                ComboUpdate(uniqueItemsList);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            string index = departmentBox.GetItemText(departmentBox.SelectedItem);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT Personel_Adi FROM Personel WHERE Personel_Birim = @DEPARTMENT";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@DEPARTMENT", index);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(reader["Personel_Adi"].ToString());
                    }
                    con.Close();
                }
                ListUpdate(list);
            }
        }
        private void addItemToStaff_Click(object sender, EventArgs e)
        {
            if (staffListBox.Text.Length <= 0)
            {
                MessageBox.Show("Personel seçimi yapmadınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FormManager.ShowForm(FormManager.AddItemStaffInstance);
            }
        }
        private void changeInfo_Click(object sender, EventArgs e)
        {
            if (staffListBox.Text.Length <= 0)
            {
                MessageBox.Show("Personel seçimi yapmadınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FormManager.ShowForm(FormManager.ChangeStaffInfoInstance);
            }
        }
        private void deleteItemFromStaff_Click(object sender, EventArgs e)
        {
            if (staffListBox.Text.Length <= 0)
            {
                MessageBox.Show("Personel seçimi yapmadınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FormManager.ShowForm(FormManager.DeleteStaffInstance);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FormManager.ShowForm(FormManager.Form1Instance);
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MinimizeBox = true;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Program kapatılacak. Emin misiniz?", "Dikkat", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }

}