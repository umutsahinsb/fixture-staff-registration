using System.Data.SqlClient;

namespace BID_Demirbas
{
    public partial class Form1 : Form
    {
        /* Bilgi de�i�ikli�ini sa�layabilmek i�in s�rekli yeni instance olu�turmamak i�in 
         statik bir Login form kullanmam�z laz�m! "public Form1" i�indeki kullan�ma dikkat et! */
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

            if (role == "Dev" || role == "Y�netici")
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
            DialogResult dialogResult = MessageBox.Show("Program kapat�lacak. Emin misiniz?", "Dikkat", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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
