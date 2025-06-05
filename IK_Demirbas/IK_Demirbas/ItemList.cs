using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Net.Mime.MediaTypeNames;

namespace BID_Demirbas
{
    public partial class ItemList : Form
    {
        string connectionString = "Server=UMUT;Database=BID_Demirbas;Trusted_Connection=True;";
        public int count = 0;
        public ItemList()
        {
            InitializeComponent();
            FormClosing += ItemList_FormClosing;
        }
        void ItemList_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Bu değer konmazsa SONSUZ LOOP'a sokuyor.
            if (count == 0)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                // Prompt user to save his data
                {
                    count = 1;
                    FormManager.ShowForm(FormManager.Form1Instance);
                    this.Close();

                }
            }
            // Autosave and clear up ressources
        }
        void ListeSifirlama(List<string> list)
        {
            itemListBox.BeginUpdate();
            itemListBox.DataSource = list;
            itemListBox.EndUpdate();
        }
        List<string> ListeyeAt(List<string> lt)
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
                        lt.Add(reader["D_NO"].ToString() + "\t" + reader["Demirbas_Malzeme_Adi"].ToString() + "\t\t + " +
                            reader["Ozellikleri"].ToString());
                    }
                    con.Close();
                }
            }
            return lt;
        }
        List<string> filterCheckedList(List<string> list)
        {
            string text = searchBar.Text;

            if (filterItemCheck.Checked)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string queryFiltered = "SELECT * FROM Bilgi_Sistemleri_Demirbas_Listesi " +
                    "WHERE Kullanici_Bolum IS NULL AND Kullanici IS NULL AND (CHARINDEX(@TEXT, D_NO) > 0 " +
                    "OR CHARINDEX(@TEXT, Demirbas_Malzeme_Adi) > 0 " +
                    "OR CHARINDEX(@TEXT, Ozellikleri) > 0)";
                    using (SqlCommand cmdFiltered = new SqlCommand(queryFiltered, con))
                    {
                        cmdFiltered.Parameters.AddWithValue("@TEXT", text);

                        con.Open();
                        SqlDataReader reader = cmdFiltered.ExecuteReader();
                        while (reader.Read())
                        {
                            list.Add(reader["D_NO"] + "\t" + reader["Demirbas_Malzeme_Adi"].ToString() + "\t\t" + reader["Ozellikleri"].ToString());
                        }
                        con.Close();
                        ListeSifirlama(list);
                    }
                }
            }
            return list;
        }
        List<string> searchedItem(List<string> list) 
        {
            string text = searchBar.Text;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Bilgi_Sistemleri_Demirbas_Listesi " +
                    "WHERE CHARINDEX(@TEXT, D_NO) > 0 " +
                    "OR CHARINDEX(@TEXT, Demirbas_Malzeme_Adi) > 0 " +
                    "OR CHARINDEX(@TEXT, Ozellikleri) > 0";
                using (SqlCommand cmd = new SqlCommand(query, con))
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
        private void addItemButton_Click(object sender, EventArgs e)
        {
            FormManager.ShowForm(FormManager.AddItemInstance);
        }
        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            FormManager.ShowForm(FormManager.DeleteItemInstance);
        }
        private void ItemList_Load(object sender, EventArgs e)
        {
            this.Text = "Ürün Listesi";
            List<string> list = new List<string>();
            ListeyeAt(list);
            ListeSifirlama(list);
            addItemButton.ImageAlign = ContentAlignment.MiddleCenter;
            addItemButton.TextImageRelation = TextImageRelation.ImageBeforeText;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            ListeyeAt(list);
            ListeSifirlama(list);
        }
        private void itemSearchButton_Click(object sender, EventArgs e)
        {
            string text = searchBar.Text;
            List<string> list = new List<string>();
            List<string> filteredList = new List<string>();
            List<string> searched = new List<string>();

            if (searchBar.Text == "")
            {
                ListeyeAt(list);
                ListeSifirlama(list);
            }
            else
            {
                if (filterItemCheck.Checked)
                {
                    filterCheckedList(filteredList);
                }
                else
                {
                    searchedItem(searched);
                }
            }
        }
        private void filterItemCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (filterItemCheck.Checked)
            {
                List<string> filterCheck = new List<string>();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Bilgi_Sistemleri_Demirbas_Listesi WHERE Kullanici_Bolum IS NULL AND Kullanici IS NULL";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {

                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            filterCheck.Add(reader["D_NO"] + "\t\t" + reader["Demirbas_Malzeme_Adi"].ToString() + "\t\t" + reader["Ozellikleri"].ToString());
                        }
                        con.Close();
                        ListeSifirlama(filterCheck);
                    }
                }
            }
            else
            {
                List<string> list = new List<string>();
                ListeyeAt(list);
                ListeSifirlama(list);
            }
        }
    }
}
