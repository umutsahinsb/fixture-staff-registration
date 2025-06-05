namespace BID_Demirbas
{
    partial class StaffList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffList));
            staffListBox = new ListBox();
            addStaffButton = new Button();
            deleteStaffButton = new Button();
            departmentBox = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            addItemToStaff = new Button();
            deleteItemFromStaff = new Button();
            changeInfo = new Button();
            inheritName = new Label();
            inheritRole = new Label();
            button2 = new Button();
            CloseButton = new Button();
            SuspendLayout();
            // 
            // staffListBox
            // 
            staffListBox.FormattingEnabled = true;
            staffListBox.ItemHeight = 15;
            staffListBox.Location = new Point(352, 49);
            staffListBox.Name = "staffListBox";
            staffListBox.Size = new Size(273, 334);
            staffListBox.TabIndex = 0;
            // 
            // addStaffButton
            // 
            addStaffButton.Font = new Font("Segoe UI", 12F);
            addStaffButton.Location = new Point(29, 412);
            addStaffButton.Name = "addStaffButton";
            addStaffButton.Size = new Size(166, 51);
            addStaffButton.TabIndex = 1;
            addStaffButton.Text = "Yeni Personel Kaydı";
            addStaffButton.UseVisualStyleBackColor = true;
            addStaffButton.Click += addStaffButton_Click;
            // 
            // deleteStaffButton
            // 
            deleteStaffButton.Font = new Font("Segoe UI", 12F);
            deleteStaffButton.Location = new Point(678, 412);
            deleteStaffButton.Name = "deleteStaffButton";
            deleteStaffButton.Size = new Size(158, 51);
            deleteStaffButton.TabIndex = 2;
            deleteStaffButton.Text = "Personeli Sil";
            deleteStaffButton.UseVisualStyleBackColor = true;
            deleteStaffButton.Click += deleteStaffButton_Click;
            // 
            // departmentBox
            // 
            departmentBox.DropDownStyle = ComboBoxStyle.DropDownList;
            departmentBox.FormattingEnabled = true;
            departmentBox.ItemHeight = 15;
            departmentBox.Location = new Point(29, 205);
            departmentBox.MaxLength = 255;
            departmentBox.Name = "departmentBox";
            departmentBox.Size = new Size(247, 23);
            departmentBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(29, 157);
            label1.Name = "label1";
            label1.Size = new Size(234, 20);
            label1.TabIndex = 4;
            label1.Text = "Görüntülenecek Departmanı Seçin";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13F);
            button1.Location = new Point(29, 267);
            button1.Name = "button1";
            button1.Size = new Size(143, 43);
            button1.TabIndex = 5;
            button1.Text = "Görüntüle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(678, 91);
            label2.Name = "label2";
            label2.Size = new Size(158, 25);
            label2.TabIndex = 6;
            label2.Text = "Seçili Personel İçin:";
            // 
            // addItemToStaff
            // 
            addItemToStaff.Font = new Font("Segoe UI", 12F);
            addItemToStaff.Location = new Point(678, 224);
            addItemToStaff.Name = "addItemToStaff";
            addItemToStaff.Size = new Size(158, 51);
            addItemToStaff.TabIndex = 7;
            addItemToStaff.Text = "Demirbaş Kaydı Oluştur";
            addItemToStaff.UseVisualStyleBackColor = true;
            addItemToStaff.Click += addItemToStaff_Click;
            // 
            // deleteItemFromStaff
            // 
            deleteItemFromStaff.Font = new Font("Segoe UI", 12F);
            deleteItemFromStaff.Location = new Point(678, 141);
            deleteItemFromStaff.Name = "deleteItemFromStaff";
            deleteItemFromStaff.Size = new Size(158, 51);
            deleteItemFromStaff.TabIndex = 8;
            deleteItemFromStaff.Text = "Kayıt Bilgilerine Bak";
            deleteItemFromStaff.UseVisualStyleBackColor = true;
            deleteItemFromStaff.Click += deleteItemFromStaff_Click;
            // 
            // changeInfo
            // 
            changeInfo.Font = new Font("Segoe UI", 12F);
            changeInfo.Location = new Point(678, 332);
            changeInfo.Name = "changeInfo";
            changeInfo.Size = new Size(158, 51);
            changeInfo.TabIndex = 9;
            changeInfo.Text = "Bilgisini Değiştir";
            changeInfo.UseVisualStyleBackColor = true;
            changeInfo.Click += changeInfo_Click;
            // 
            // inheritName
            // 
            inheritName.AutoSize = true;
            inheritName.Location = new Point(96, 482);
            inheritName.Name = "inheritName";
            inheritName.Size = new Size(73, 15);
            inheritName.TabIndex = 10;
            inheritName.Text = "InheritName";
            inheritName.Visible = false;
            // 
            // inheritRole
            // 
            inheritRole.AutoSize = true;
            inheritRole.Location = new Point(319, 482);
            inheritRole.Name = "inheritRole";
            inheritRole.Size = new Size(64, 15);
            inheritRole.TabIndex = 11;
            inheritRole.Text = "InheritRole";
            inheritRole.Visible = false;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(29, 49);
            button2.Name = "button2";
            button2.Size = new Size(140, 42);
            button2.TabIndex = 12;
            button2.Text = "       Anasayfa";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Red;
            CloseButton.BackgroundImageLayout = ImageLayout.None;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CloseButton.ForeColor = Color.Cyan;
            CloseButton.Location = new Point(836, 9);
            CloseButton.Margin = new Padding(0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(46, 27);
            CloseButton.TabIndex = 13;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // StaffList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 596);
            ControlBox = false;
            Controls.Add(CloseButton);
            Controls.Add(button2);
            Controls.Add(inheritRole);
            Controls.Add(inheritName);
            Controls.Add(changeInfo);
            Controls.Add(deleteItemFromStaff);
            Controls.Add(addItemToStaff);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(departmentBox);
            Controls.Add(deleteStaffButton);
            Controls.Add(addStaffButton);
            Controls.Add(staffListBox);
            Name = "StaffList";
            Text = "StaffList";
            Load += StaffList_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button addStaffButton;
        private Button deleteStaffButton;
        private Label label1;
        private Button button1;
        private Label label2;
        private Button addItemToStaff;
        private Button deleteItemFromStaff;
        public ListBox staffListBox;
        private Button changeInfo;
        public ComboBox departmentBox;
        private Label inheritRole;
        public Label inheritName;
        private Button button2;
        private Button CloseButton;
    }
}