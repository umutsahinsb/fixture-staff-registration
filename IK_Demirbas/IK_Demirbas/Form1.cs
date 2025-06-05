using System.Data.SqlClient;

namespace BID_Demirbas
{
    public partial class Form1 : Form
    {
        /* Bilgi deðiþikliðini saðlayabilmek için sürekli yeni instance oluþturmamak için 
         statik bir Login form kullanmamýz lazým! "public Form1" içindeki kullanýma dikkat et! */
        public Form1()
        {
            InitializeComponent();
        }

        private void itemListButton_Click(object sender, EventArgs e)
        {
            FormManager.ShowForm(FormManager.ItemInstance);
            this.Hide();
        }

        private void staffListButton_Click(object sender, EventArgs e)
        {
            FormManager.ShowForm(FormManager.StaffInstance);
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Anasayfa";
            string name = FormManager.LoginForm.staffNameHolder.Text;
            string role = FormManager.LoginForm.staffRoleHolder.Text;

            staffNameLabel.Text = name;
            staffRoleLabel.Text = role;

            if (role == "Dev" || role == "Yönetici")
            {
                addStaffButton.Visible = true;
                deleteStaffButton.Visible = true;
            }
            else
            {
                deleteStaffButton.Visible = false;
                addStaffButton.Visible = false;
            }
        }
        private void addStaffButton_Click(object sender, EventArgs e)
        {
            var f = new DevAddLoginStaff();
            f.Show();
        }

        private void deleteStaffButton_Click(object sender, EventArgs e)
        {
            var f = new DevDeleteStaff();
            f.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Program kapatýlacak. Emin misiniz?", "Dikkat", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }
    }
}
