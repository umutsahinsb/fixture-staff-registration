using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Word = Microsoft.Office.Interop.Word;


namespace BID_Demirbas
{
    public partial class DeleteItemFromStaff : Form
    {
        string connectionString = "Server=UMUT;Database=BID_Demirbas;Trusted_Connection=True;";
        public int count = 0;

        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["StaffList"];
        System.Windows.Forms.Form l = System.Windows.Forms.Application.OpenForms["StaffList"];
        public DeleteItemFromStaff()
        {
            InitializeComponent();
            FormClosing += DeleteItemFromStaff_FormClosing;
        }
        void DeleteItemFromStaff_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Bu değer konmazsa SONSUZ LOOP'a sokuyor.
            if (count == 0)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                // Prompt user to save his data
                {
                    count = 1;
                    FormManager.ShowForm(FormManager.StaffInstance);
                    this.Hide();

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
        string ResponsibleNumber()
        {
            string name = nameLabel.Text;
            string department = departmentLabel.Text;
            string personelID = " ";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT Personel_ID FROM Personel "
                    + "WHERE Personel_Adi = @StaffName AND Personel_Birim = @Department";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@StaffName", name);
                    cmd.Parameters.AddWithValue("@Department", department);

                    con.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        personelID = result.ToString();
                    }

                    con.Close();
                }
            }
            return personelID;
        }
        string StaffNumber()
        {
            string name = FormManager.Form1Instance.staffNameLabel.Text;
            string staffID = "";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT Personel_ID FROM Personel " +
                    "WHERE Personel_Adi = @StaffName AND Personel_Birim = 'Bilgi Sistemleri Dairesi Başkanlığı'";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@StaffName", name);

                    con.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        staffID = result.ToString();
                    }

                    con.Close();
                }
            }
            return staffID;
        }
        void MalzemeFonksiyon(List<string> list, string staff, string staffDepartment)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Bilgi_Sistemleri_Demirbas_Listesi " +
                    "WHERE Kullanici = @StaffName AND Kullanici_Bolum = @StaffDepartment";


                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    cmd.Parameters.AddWithValue("@StaffName", staff);
                    cmd.Parameters.AddWithValue("@StaffDepartment", staffDepartment);

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(reader["D_NO"] + "\t" + reader["Demirbas_Malzeme_Adi"].ToString() + "\t" + reader["Ozellikleri"].ToString());
                    }
                    con.Close();
                    ListeSifirlama(list);
                }

            }
        }
        void PDFKayitAl()
        {
            string responsibleID = ResponsibleNumber();
            string staffID = StaffNumber();

            string date = DateTime.Now.ToString("dd/MM/yyyy").Replace('.', '/');

            Word.Application wordApp = new Word.Application();
            wordApp.Visible = false; // Initially set to false while editing

            // Open the document
            string docPath = @"E:\C#\IK_Demirbas\Test Dosyaları\main documents\deneme1.docx";
            Word.Document document = wordApp.Documents.Open(docPath);

            // Fill in the placeholders in the text
            for (int f = 0; f < 6; f++)
            {
                Word.Range range = document.Content;
                range.Find.Execute("......p Başkanlığı", ReplaceWith: departmentLabel.Text);
                range.Find.Execute("......n", ReplaceWith: responsibleID);
                range.Find.Execute("......t", ReplaceWith: nameLabel.Text);
                range.Find.Execute("......2n", ReplaceWith: "1");
                range.Find.Execute("......2t", ReplaceWith: "Bilgi Sistemleri Depo");
                range.Find.Execute("----//----", ReplaceWith: date);
            }

            // Modify the table
            Word.Table table = document.Tables[1]; // Select the first table in the document

            // Clear existing rows if necessary (preserving header row)
            int existingRowCount = table.Rows.Count;
            for (int i = existingRowCount; i >= 2; i--) // Start from 2 to keep the header row
            {
                table.Rows[i].Delete();
            }

            // Add items from the ListBox to the table
            int rowIndex = 2; // Start from the second row because the first is a header
            foreach (string item in listBox1.Items)
            {
                char[] delimiter = new char[] { '\t' };
                string[] itemarr = item.Split(delimiter);

                table.Rows.Add(); // Add a new row
                table.Cell(rowIndex, 1).Range.Text = itemarr[0]; // NO
                table.Cell(rowIndex, 2).Range.Text = itemarr[1]; // ADI
                table.Cell(rowIndex, 3).Range.Text = "1"; // MIKTAR (Example fixed value)
                table.Cell(rowIndex, 4).Range.Text = itemarr[2]; // OZELLIKLER (Example fixed value)
                rowIndex++;
            }

            // Belgeyi kaydet ve kapat
            document.SaveAs2(@"E:\C#\IK_Demirbas\Test Dosyaları\Kullanıcı Verileri\" + nameLabel.Text + " - Kayıt.docx");
            document.Close();

            var appWord = new Word.Application();
            if (appWord.Documents != null)
            {
                //yourDoc is your word document
                var wordDocument = appWord.Documents.Open(@"E:\C#\IK_Demirbas\Test Dosyaları\Kullanıcı Verileri\" + nameLabel.Text + " - Kayıt.docx");
                string pdfDocName = @"E:\C#\IK_Demirbas\Test Dosyaları\Kullanıcı Verileri\" + nameLabel.Text + " - Kayıt.pdf";
                if (wordDocument != null)
                {
                    wordDocument.ExportAsFixedFormat(pdfDocName,
                    WdExportFormat.wdExportFormatPDF);
                    wordDocument.Close();
                }

                // PDF, oluşturulup kaydedildikten sonra otomatik olarak açılacak.
                DialogResult dialogResult = MessageBox.Show("Belge kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                    var p = new Process();
                    p.StartInfo = new ProcessStartInfo(@"E:\C#\IK_Demirbas\Test Dosyaları\Kullanıcı Verileri\" + nameLabel.Text + " - Kayıt.pdf")
                    {
                        UseShellExecute = true
                    };
                    p.Start();
                }
            }
            wordApp.Quit();
        }
        void WordKayitAl()
        {
            string responsibleID = ResponsibleNumber();
            string staffID = StaffNumber();

            string date = DateTime.Now.ToString("dd/MM/yyyy").Replace('.', '/');

            Word.Application wordApp = new Word.Application();
            wordApp.Visible = false; // Initially set to false while editing

            // Open the document
            string docPath = @"E:\C#\IK_Demirbas\Test Dosyaları\main documents\deneme1.docx";
            Word.Document document = wordApp.Documents.Open(docPath);

            // Fill in the placeholders in the text
            for (int f = 0; f < 6; f++)
            {
                Word.Range range = document.Content;
                range.Find.Execute("......p Başkanlığı", ReplaceWith: departmentLabel.Text);
                range.Find.Execute("......n", ReplaceWith: responsibleID);
                range.Find.Execute("......t", ReplaceWith: nameLabel.Text);
                range.Find.Execute("......2n", ReplaceWith: "1");
                range.Find.Execute("......2t", ReplaceWith: "Bilgi Sistemleri Depo");
                range.Find.Execute("----//----", ReplaceWith: date);
            }

            // Modify the table
            Word.Table table = document.Tables[1]; // Select the first table in the document

            // Clear existing rows if necessary (preserving header row)
            int existingRowCount = table.Rows.Count;
            for (int i = existingRowCount; i >= 2; i--) // Start from 2 to keep the header row
            {
                table.Rows[i].Delete();
            }

            // Add items from the ListBox to the table
            int rowIndex = 2; // Start from the second row because the first is a header
            foreach (string item in listBox1.Items)
            {
                char[] delimiter = new char[] { '\t' };
                string[] itemarr = item.Split(delimiter);

                table.Rows.Add(); // Add a new row
                table.Cell(rowIndex, 1).Range.Text = itemarr[0]; // NO
                table.Cell(rowIndex, 2).Range.Text = itemarr[1]; // ADI
                table.Cell(rowIndex, 3).Range.Text = "1"; // MIKTAR (Example fixed value)
                table.Cell(rowIndex, 4).Range.Text = itemarr[2]; // OZELLIKLER (Example fixed value)
                rowIndex++;
            }

            // Belgeyi kaydet ve kapat
            document.SaveAs2(@"E:\C#\IK_Demirbas\Test Dosyaları\Kullanıcı Verileri\" + nameLabel.Text + " - Kayıt.docx");
            document.Close();

            var appWord = new Word.Application();
            if (appWord.Documents != null)
            {
                //yourDoc is your word document
                var wordDocument = appWord.Documents.Open(@"E:\C#\IK_Demirbas\Test Dosyaları\Kullanıcı Verileri\" + nameLabel.Text + " - Kayıt.docx");
                string pdfDocName = @"E:\C#\IK_Demirbas\Test Dosyaları\Kullanıcı Verileri\" + nameLabel.Text + " - Kayıt.pdf";
                if (wordDocument != null)
                {
                    wordDocument.ExportAsFixedFormat(pdfDocName,
                    WdExportFormat.wdExportFormatPDF);
                    wordDocument.Close();
                }

                // PDF, oluşturulup kaydedildikten sonra otomatik olarak açılacak.
                DialogResult dialogResult = MessageBox.Show("Belge kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                    var p = new Process();
                    p.StartInfo = new ProcessStartInfo(@"E:\C#\IK_Demirbas\Test Dosyaları\Kullanıcı Verileri\" + nameLabel.Text + " - Kayıt.docx")
                    {
                        UseShellExecute = true
                    };
                    p.Start();


                }

            }
            wordApp.Quit();
        }
        private void DeleteItemFromStaff_Load(object sender, EventArgs e)
        {
            this.Text = "Personel Demirbaş Bilgisi";
            nameLabel.Text = FormManager.StaffInstance.staffListBox.Text.Trim();
            departmentLabel.Text = FormManager.StaffInstance.departmentBox.Text.Trim();
            List<string> birimList = new List<string>();

            string staff = nameLabel.Text;
            string staffDepartment = departmentLabel.Text;
            List<string> list = new List<string>();

            MalzemeFonksiyon(list, staff, staffDepartment);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string staff = nameLabel.Text;
            string staffDepartment = departmentLabel.Text;
            List<string> list = new List<string>();

            string itemName = listBox1.SelectedItem.ToString();
            string dno = itemName.Split(new string[] { "\t" }, StringSplitOptions.None)[0];

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE Bilgi_Sistemleri_Demirbas_Listesi " +
                    "SET Kullanici = 'Bilgi İşlemleri Depo', Kullanici_Bolum = 'Bilgi İşlemleri Dairesi Başkanlığı' " +
                    "WHERE D_NO = @DNO";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@DNO", dno);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Seçili ürünün " +
                                "personel/birim bağlantısı kesildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                MalzemeFonksiyon(list, staff, staffDepartment);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string staff = nameLabel.Text;
            string staffDepartment = departmentLabel.Text;
            List<string> list = new List<string>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE Bilgi_Sistemleri_Demirbas_Listesi " +
                    "SET Kullanici = NULL, Kullanici_Bolum = NULL " +
                    "WHERE Kullanici = @StaffName AND Kullanici_Bolum = @StaffDepartment";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@StaffName", staff);
                    cmd.Parameters.AddWithValue("@StaffDepartment", staffDepartment);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Personele ait tüm demirbaşlar kaldırıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                MalzemeFonksiyon(list, staff, staffDepartment);
            }
            this.Hide();
        }
        private void wordOutputButton_Click(object sender, EventArgs e)
        {
            WordKayitAl();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            PDFKayitAl();

        }
    }
}
