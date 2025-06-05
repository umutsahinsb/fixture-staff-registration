using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using Microsoft.Vbe.Interop;
using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.AxHost;


namespace BID_Demirbas
{

    public partial class AddItem : Form
    {
        string connectionString = "Server=UMUT;Database=BID_Demirbas;Trusted_Connection=True;";
        public AddItem()
        {
            InitializeComponent();
        }
        void BirimYukleme(List<string> list)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Personel";
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
        void MalzemeYukleme(List<string> list)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Bilgi_Sistemleri_Demirbas_Listesi";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(reader["Demirbas_Malzeme_Adi"].ToString());
                    }
                    con.Close();
                }
            }
        }
        private void DepartmentUpdate(List<string> list)
        {
            departmentCombo.BeginUpdate();
            departmentCombo.DataSource = list;
            departmentCombo.EndUpdate();
        }
        private void StaffUpdate(List<string> list)
        {
            staffCombo.BeginUpdate();
            staffCombo.DataSource = list;
            staffCombo.EndUpdate();
        }
        private void PropertiesUpdate(List<string> list)
        {
            itemPropertiesCombo.BeginUpdate();
            itemPropertiesCombo.DataSource = list;
            itemPropertiesCombo.EndUpdate();
        }
        private void MaterialUpdate(List<string> list)
        {
            itemMaterialCombo.BeginUpdate();
            itemMaterialCombo.DataSource = list;
            itemMaterialCombo.EndUpdate();
        }
        private void DemirbasEkle(string d_no, string itemname, string properties, string staffunit, string staff)
        {
            int err = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // D_NO Kontrolü.
                // Eğer aynı D_NO girilmişse, sistem uyarı vermeli ki D_NO'lar çakışmasın veya program çökmesin.
                string readQuery = "SELECT D_NO FROM Bilgi_Sistemleri_Demirbas_Listesi";
                using (SqlCommand cmd = new SqlCommand(readQuery, con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader["D_NO"].Equals(d_no))
                        {
                            MessageBox.Show("Aynı D_NO'ya sahip başka bir ürün bulunmakta! Ürün eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            err = 1;
                        }
                    }
                    con.Close();
                }

                // Yukarıdaki kontrolden başarıyla geçilememişse herhangi bir işleme devam edilmeyecek, program boşta bitecek.
                if (err == 1) { }


                else
                {
                    string query = "INSERT INTO Bilgi_Sistemleri_Demirbas_Listesi (D_NO, Demirbas_Malzeme_Adi, Ozellikleri, Kullanici_Bolum, Kullanici) " +
                    "VALUES (@D_NO, @Demirbas_Malzeme_Adi, @Ozellikleri, @Kullanici_Bolum, @Kullanici)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {


                        cmd.Parameters.AddWithValue("@D_NO", d_no);
                        cmd.Parameters.AddWithValue("@Demirbas_Malzeme_Adi", itemname);
                        cmd.Parameters.AddWithValue("@Ozellikleri", properties);
                        cmd.Parameters.AddWithValue("@Kullanici_Bolum", staffunit);
                        cmd.Parameters.AddWithValue("@Kullanici", staff);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();



                        MessageBox.Show("Kayıt başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void addItemButton_Click(object sender, EventArgs e)
        {
            int err = 0;

            string d_no = dno.Text;
           
            if (newMaterialCheck.Checked && newPropertiesCheck.Checked == false)
            {
                string itemname = itemName.Text;
                string properties = itemPropertiesCombo.SelectedItem.ToString();
                string staffunit = departmentCombo.SelectedItem.ToString();
                string staff = staffCombo.SelectedItem.ToString();

                DemirbasEkle(d_no, itemname, properties, staffunit, staff);
            }
            if(newMaterialCheck.Checked == false && newPropertiesCheck.Checked)
            {
                string itemname = itemMaterialCombo.SelectedItem.ToString();
                string properties = prop.Text;
                string staffunit = departmentCombo.SelectedItem.ToString();
                string staff = staffCombo.SelectedItem.ToString();

                DemirbasEkle(d_no, itemname, properties, staffunit, staff);

               
            }
            if (newMaterialCheck.Checked == false && newPropertiesCheck.Checked == false)
            {
                string itemname = itemMaterialCombo.SelectedItem.ToString();
                string properties = itemPropertiesCombo.SelectedItem.ToString();
                string staffunit = departmentCombo.SelectedItem.ToString();
                string staff = staffCombo.SelectedItem.ToString();

                DemirbasEkle(d_no, itemname, properties, staffunit, staff);
            }
            if (newMaterialCheck.Checked && newPropertiesCheck.Checked)
            {
                string itemname = itemName.Text;
                string properties = prop.Text;
                string staffunit = departmentCombo.SelectedItem.ToString();
                string staff = staffCombo.SelectedItem.ToString();

                DemirbasEkle(d_no, itemname, properties, staffunit, staff);
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog.Title = "Bir CSV dosyası seçin";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Seçilen dosya yolunu al
                string csvFilePath = openFileDialog.FileName;

                // CSV dosyasını oku ve bir DataTable'a yükle
                DataTable dataTable = LoadCsvToDataTable(csvFilePath);

                // DataTable'ı SQL Server'a aktarma
                BulkInsertToDatabase(dataTable);
            }
        }

        private DataTable LoadCsvToDataTable(string filePath)
        {
            DataTable dataTable = new DataTable();
            int whileKiller = 0;

            // Sütunları DataTable'a ekleyin
            dataTable.Columns.Add("D_NO", typeof(string));
            dataTable.Columns.Add("Demirbaş_Malzeme_Adı", typeof(string));
            dataTable.Columns.Add("Özellikleri", typeof(string));
            dataTable.Columns.Add("Kullanıcı_Bölüm", typeof(string));
            dataTable.Columns.Add("Kullanıcı", typeof(string));
            dataTable.Columns.Add("column6", typeof(string));
            dataTable.Columns.Add("column7", typeof(string));

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                BadDataFound = null, // Kötü verileri atla
                MissingFieldFound = null, // Eksik sütun hatalarını atla
                Delimiter = ";"
            }))
            {
                // Başlıkları oku
                csv.Read();
                csv.ReadHeader();

                while (csv.Read())
                {
                    string dNoValue = csv.GetField<string>("D.NO");

                    if (whileKiller != 0)
                    {
                        continue;
                    }

                    // Eğer D.NO dolu değilse satırı atla
                    if (string.IsNullOrWhiteSpace(dNoValue))
                    {
                        DialogResult dialogresult =
                           MessageBox.Show("DNO'su olmayan veriler var ve eklenmeyecekler!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                        if (dialogresult == DialogResult.OK)
                        {
                            whileKiller = 1;
                            continue;
                        }
                    }

                    DataRow row = dataTable.NewRow();
                    row["D_NO"] = dNoValue;
                    row["Demirbaş_Malzeme_Adı"] = csv.GetField<string>("Demirbaş Malzeme Adı");
                    row["Özellikleri"] = csv.GetField<string>("Özellikleri");
                    row["Kullanıcı_Bölüm"] = csv.GetField<string>("Kullanıcı");
                    row["Kullanıcı"] = csv.GetField<string>("Kullanıcı Bölüm");
                    row["column6"] = csv.GetField<string>(""); // Boş sütunlar için
                    row["column7"] = csv.GetField<string>(""); // Boş sütunlar için

                    dataTable.Rows.Add(row);
                }
            }

            // DataTable'ın dolu olup olmadığını kontrol edin
            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show($"DataTable'da {dataTable.Rows.Count} satır yüklendi.");
            }
            else
            {
                MessageBox.Show("DataTable boş, CSV'den veri yüklenmedi.");
            }

            return dataTable;
        }

        private void BulkInsertToDatabase(DataTable dataTable)
        {

            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("DataTable boş, aktarılacak veri yok.");
                return;
            }

            // Veri tabanına bağlan ve SqlBulkCopy kullanarak veriyi aktar
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(con))
                {
                    bulkCopy.DestinationTableName = "dbo.Bilgi_Sistemleri_Demirbas_Listesi";

                    // Sütun eşleştirmelerini (ColumnMappings) manuel olarak yapın
                    bulkCopy.ColumnMappings.Add("D_NO", "D_NO");
                    bulkCopy.ColumnMappings.Add("Demirbaş_Malzeme_Adı", "Demirbas_Malzeme_Adi");
                    bulkCopy.ColumnMappings.Add("Özellikleri", "Ozellikleri");
                    bulkCopy.ColumnMappings.Add("Kullanıcı_Bölüm", "Kullanici_Bolum");
                    bulkCopy.ColumnMappings.Add("Kullanıcı", "Kullanici");
                    bulkCopy.ColumnMappings.Add("column6", "column6");
                    bulkCopy.ColumnMappings.Add("column7", "column7");

                    try
                    {
                        bulkCopy.WriteToServer(dataTable);
                        MessageBox.Show("Veri başarıyla aktarıldı!");
                    }
                    catch (Exception ex)
                    {
                        string hata = ex.Message;
                        if (hata == "Violation of PRIMARY KEY constraint 'PK_Bilgi_Sistemleri_Demirbas Listesi'. Cannot insert duplicate key in object 'dbo.Bilgi_Sistemleri_Demirbas_Listesi'. The duplicate key value is (B1234).\r\nThe statement has been terminated.")
                        {
                            MessageBox.Show($"Hata: Çakışan DNO'lar var!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show("Ekleme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Hata: ", ex.Message);
                        }

                    }
                }
            }
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            List<string> items = new List<string>();
            BirimYukleme(items);
            var uniqueItemsList = items.Distinct().ToList();
            DepartmentUpdate(uniqueItemsList);

            items.Clear();

            MalzemeYukleme(items);
            uniqueItemsList = items.Distinct().ToList();
            MaterialUpdate(uniqueItemsList);

            this.Text = "Demirbaş Ekle";
            itemMaterialCombo.Visible = true;
            itemPropertiesCombo.Visible = true;
        }


        private void itemMaterialCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string material = itemMaterialCombo.SelectedItem.ToString();
            List<string> list = new List<string>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT Ozellikleri FROM Bilgi_Sistemleri_Demirbas_Listesi WHERE Demirbas_Malzeme_Adi = @ItemMaterial";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ItemMaterial", material);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(reader["Ozellikleri"].ToString());
                    }
                    con.Close();
                }
                PropertiesUpdate(list);
            }
        }

        private void departmentCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string department = departmentCombo.SelectedItem.ToString();
            List<string> list = new List<string>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT Personel_Adi FROM Personel WHERE Personel_Birim = @StaffDepartment";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@StaffDepartment", department);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(reader["Personel_Adi"].ToString());
                    }
                    con.Close();
                }
                StaffUpdate(list);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                departmentCombo.SelectedIndex = 0;
                staffCombo.SelectedIndex = 1;
                departmentCombo.Enabled = false;
                staffCombo.Enabled = false;
            }
            else
            {
                departmentCombo.SelectedIndex = 0;
                staffCombo.SelectedIndex = 0;
                departmentCombo.Enabled = true;
                staffCombo.Enabled = true;
            }
        }

        private void newMaterialCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (newMaterialCheck.Checked)
            {
                itemMaterialCombo.Visible = false;
            }
            else
            {
                itemMaterialCombo.Visible = true;
            }
        }

        private void newPropertiesCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (newPropertiesCheck.Checked)
            {
                itemPropertiesCombo.Visible = false;
            }
            else
                { itemPropertiesCombo.Visible = true; }
        }
        
    }
}
