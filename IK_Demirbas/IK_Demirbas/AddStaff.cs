using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BID_Demirbas
{
    public partial class AddStaff : Form
    {
        string connectionString = "Server=UMUT;Database=BID_Demirbas;Trusted_Connection=True;";
        public int count = 0;
        public AddStaff()
        {
            InitializeComponent();
            FormClosing += AddStaff_FormClosing;
        }
        private DataTable LoadCsvToDataTable(string filePath)
        {
            DataTable dataTable = new DataTable();
            int whileKiller = 0;

            // Sütunları DataTable'a ekleyin
            dataTable.Columns.Add("P_ID", typeof(string));
            dataTable.Columns.Add("Personel_Adı", typeof(string));
            dataTable.Columns.Add("Personel_Birim", typeof(string));

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
                    string dNoValue = csv.GetField<string>("Kullanıcı");

                    if (whileKiller != 0)
                    {
                        continue;
                    }

                    // Eğer D.NO dolu değilse satırı atla
                    if (string.IsNullOrWhiteSpace(dNoValue))
                    {
                        DialogResult dialogresult =
                           MessageBox.Show("İsimsiz veriler var ve eklenmeyecekler!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                        if (dialogresult == DialogResult.OK)
                        {
                            whileKiller = 1;
                            continue;
                        }
                    }

                    DataRow row = dataTable.NewRow();
                    row["Personel_Adı"] = csv.GetField<string>("Kullanıcı Bölüm");
                    row["Personel_Birim"] = csv.GetField<string>("Kullanıcı");
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
                    bulkCopy.DestinationTableName = "dbo.Personel";

                    // Sütun eşleştirmelerini (ColumnMappings) manuel olarak yapın
                    bulkCopy.ColumnMappings.Add("Personel_Adı", "Personel_Adi");
                    bulkCopy.ColumnMappings.Add("Personel_Birim", "Personel_Birim");

                    DataView view = new DataView(dataTable);
                    DataTable distinctValues = view.ToTable(true, "Personel_Adı", "Personel_Birim");

                    try
                    {
                        bulkCopy.WriteToServer(distinctValues);
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
        void AddStaff_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Bu değer konmazsa SONSUZ LOOP'a sokuyor.
            if (count == 0)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                // Prompt user to save his data
                {
                    count = 1;
                    FormManager.ShowForm(FormManager.StaffInstance);
                    this.Close();

                }
            }
            // Autosave and clear up ressources
        }
        private void AddStaff_Load(object sender, EventArgs e)
        {
            this.Text = "Personel Ekle";
            newDepartmentText.Visible = false;
            
            List<string> list = new List<string>();
            FirstList(list);
            var uniqueItemsList = list.Distinct().ToList();
            ComboUpdate(uniqueItemsList);
        }

        private void newDepartmentCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (newDepartmentCheck.Checked)
            {
                newDepartmentText.Visible = true;
                departmentBox.Visible = false;

            }
            else
            {
                newDepartmentText.Visible = false;
                departmentBox.Visible = true;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int index = departmentBox.Text.Length;
            string name = staffNameSurnameText.Text;
            string depart = departmentBox.Text;
            string departText = newDepartmentText.Text;


            if (staffNameSurnameText.Text.Length == 0)
            {
                MessageBox.Show("Personel adı boş olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (index == 0 && newDepartmentText.Text.Length == 0)
            {
                MessageBox.Show("Personel birimi boş olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (newDepartmentCheck.Checked)
            {
                newDepartmentText.Visible = true;

                using (SqlConnection con = new SqlConnection(connectionString))
                {

                    string query = "INSERT INTO Personel (Personel_Adi, Personel_Birim) " +
                       "VALUES (@personelAdi, @personelBirim)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {

                        cmd.Parameters.AddWithValue("@personelAdi", name);
                        cmd.Parameters.AddWithValue("@personelBirim", departText);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Personel kaydı başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            else
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {

                    string query = "INSERT INTO Personel (Personel_Adi, Personel_Birim) " +
                       "VALUES (@personelAdi, @personelBirim)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {

                        cmd.Parameters.AddWithValue("@personelAdi", name);
                        cmd.Parameters.AddWithValue("@personelBirim", depart);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Personel kaydı başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
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
                this.Close();
            }
        }
    }
}
