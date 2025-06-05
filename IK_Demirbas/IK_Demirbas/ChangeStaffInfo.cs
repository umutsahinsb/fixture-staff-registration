using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BID_Demirbas
{
    public partial class ChangeStaffInfo : Form
    {
        public int count = 0;
        public ChangeStaffInfo()
        {
            InitializeComponent();
            FormClosing += ChangeStaffInfo_FormClosing;
        }
        string connectionString = "Server=UMUT;Database=BID_Demirbas;Trusted_Connection=True;";
        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["StaffList"];
        System.Windows.Forms.Form l = System.Windows.Forms.Application.OpenForms["StaffList"];

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
            comboBox1.BeginUpdate();
            comboBox1.DataSource = list;
            comboBox1.EndUpdate();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string oldName = staffNameLabel.Text.Trim();
            string oldDepart = staffDepartmentLabel.Text.Trim();

            string newName = textBox1.Text.Trim();
            string newDepart = comboBox1.Text.Trim();

            if (newName == "")
            {
                MessageBox.Show("İsim kısmı boş olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int err = 0;

                DialogResult dialogResult = MessageBox.Show("Bu kaydı değiştirmek istediğinize emin misiniz?\n\n" + oldName + "   " + oldDepart + "\n\n" + newName + "   " + newDepart, "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    if (err == 1) { }

                    else
                    {
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {

                            string queryUpdate = "UPDATE Bilgi_Sistemleri_Demirbas_Listesi " +
                                    "SET Kullanici = @NewStaffName, Kullanici_Bolum = @NewStaffDepart " +
                                    "WHERE Kullanici = @OldStaffName AND Kullanici_Bolum = @OldStaffDepart";

                            using (SqlCommand cmdUpdate = new SqlCommand(queryUpdate, con))
                            {
                                cmdUpdate.Parameters.AddWithValue("@OldStaffName", oldName);
                                cmdUpdate.Parameters.AddWithValue("@OldStaffDepart", oldDepart);
                                cmdUpdate.Parameters.AddWithValue("@NewStaffName", newName);
                                cmdUpdate.Parameters.AddWithValue("@NewStaffDepart", newDepart);

                                con.Open();
                                cmdUpdate.ExecuteNonQuery();
                                con.Close();

                                MessageBox.Show("Personele kaydedilen tüm ürünlerin kullanıcı " +
                                    "bilgisi otomatik düzenlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }

                            string query = "UPDATE Personel " +
                                "SET Personel_Adi = @NewStaffName, Personel_Birim = @NewStaffDepart " +
                                "WHERE Personel_Adi = @OldStaffName AND Personel_Birim = @OldStaffDepart";

                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {
                                cmd.Parameters.AddWithValue("@OldStaffName", oldName);
                                cmd.Parameters.AddWithValue("@OldStaffDepart", oldDepart);
                                cmd.Parameters.AddWithValue("@NewStaffName", newName);
                                cmd.Parameters.AddWithValue("@NewStaffDepart", newDepart);


                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();


                                MessageBox.Show("Personel kaydı düzenlendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                    }
                }
            }
        }
        void ChangeStaffInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Bu değer konmazsa SONSUZ LOOP'a sokuyor.
            if (count == 0)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                // Prompt user to save his data
                {
                    count = 1;
                    FormManager.StaffInstance.Update();
                    FormManager.StaffInstance.Refresh();
                    FormManager.ShowForm(FormManager.StaffInstance);
                    this.Hide();

                }
            }
            // Autosave and clear up ressources
        }
        private void ChangeStaffInfo_Load(object sender, EventArgs e)
        {
            this.Text = "Bilgi Değiştir";
            string text = FormManager.StaffInstance.staffListBox.Text;
            string textDepartment = FormManager.StaffInstance.departmentBox.SelectedItem.ToString();
            staffNameLabel.Text = text;
            staffDepartmentLabel.Text = textDepartment;

            List<string> list = new List<string>();
            FirstList(list);
            var uniqueItemsList = list.Distinct().ToList();
            ComboUpdate(uniqueItemsList);

        }
    }
}
