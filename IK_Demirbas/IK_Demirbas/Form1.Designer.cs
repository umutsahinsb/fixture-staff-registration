namespace BID_Demirbas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            itemListButton = new Button();
            staffListButton = new Button();
            label1 = new Label();
            staffNameLabel = new Label();
            roleLabel = new Label();
            staffRoleLabel = new Label();
            addStaffButton = new Button();
            deleteStaffButton = new Button();
            CloseButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // itemListButton
            // 
            itemListButton.Font = new Font("Segoe UI", 12F);
            itemListButton.Location = new Point(47, 445);
            itemListButton.Name = "itemListButton";
            itemListButton.Size = new Size(175, 45);
            itemListButton.TabIndex = 0;
            itemListButton.Text = "Ürün Listesi";
            itemListButton.UseVisualStyleBackColor = true;
            itemListButton.Click += itemListButton_Click;
            // 
            // staffListButton
            // 
            staffListButton.Font = new Font("Segoe UI", 12F);
            staffListButton.Location = new Point(514, 445);
            staffListButton.Name = "staffListButton";
            staffListButton.Size = new Size(175, 45);
            staffListButton.TabIndex = 1;
            staffListButton.Text = "Personel Listesi";
            staffListButton.UseVisualStyleBackColor = true;
            staffListButton.Click += staffListButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(43, 255);
            label1.Name = "label1";
            label1.Size = new Size(94, 21);
            label1.TabIndex = 2;
            label1.Text = "Hoşgeldiniz:";
            // 
            // staffNameLabel
            // 
            staffNameLabel.AutoSize = true;
            staffNameLabel.Font = new Font("Segoe UI", 12F);
            staffNameLabel.Location = new Point(140, 255);
            staffNameLabel.Name = "staffNameLabel";
            staffNameLabel.Size = new Size(82, 21);
            staffNameLabel.TabIndex = 3;
            staffNameLabel.Text = "staffName";
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Segoe UI", 12F);
            roleLabel.Location = new Point(47, 305);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(36, 21);
            roleLabel.TabIndex = 4;
            roleLabel.Text = "Rol:";
            roleLabel.Visible = false;
            // 
            // staffRoleLabel
            // 
            staffRoleLabel.AutoSize = true;
            staffRoleLabel.Font = new Font("Segoe UI", 12F);
            staffRoleLabel.Location = new Point(89, 305);
            staffRoleLabel.Name = "staffRoleLabel";
            staffRoleLabel.Size = new Size(71, 21);
            staffRoleLabel.TabIndex = 5;
            staffRoleLabel.Text = "staffRole";
            staffRoleLabel.Visible = false;
            // 
            // addStaffButton
            // 
            addStaffButton.Font = new Font("Segoe UI", 12F);
            addStaffButton.Location = new Point(514, 231);
            addStaffButton.Name = "addStaffButton";
            addStaffButton.Size = new Size(175, 45);
            addStaffButton.TabIndex = 7;
            addStaffButton.Text = "Sisteme Personel Ekle";
            addStaffButton.UseVisualStyleBackColor = true;
            addStaffButton.Click += addStaffButton_Click;
            // 
            // deleteStaffButton
            // 
            deleteStaffButton.Font = new Font("Segoe UI", 12F);
            deleteStaffButton.Location = new Point(514, 292);
            deleteStaffButton.Name = "deleteStaffButton";
            deleteStaffButton.Size = new Size(175, 45);
            deleteStaffButton.TabIndex = 8;
            deleteStaffButton.Text = "Sistemden Personel Sil";
            deleteStaffButton.UseVisualStyleBackColor = true;
            deleteStaffButton.Click += deleteStaffButton_Click;
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
            CloseButton.Location = new Point(702, 9);
            CloseButton.Margin = new Padding(0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(46, 27);
            CloseButton.TabIndex = 9;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 29);
            button1.Name = "button1";
            button1.Size = new Size(138, 28);
            button1.TabIndex = 10;
            button1.Text = "Tekrar Giriş Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 525);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(CloseButton);
            Controls.Add(deleteStaffButton);
            Controls.Add(addStaffButton);
            Controls.Add(staffRoleLabel);
            Controls.Add(roleLabel);
            Controls.Add(staffNameLabel);
            Controls.Add(label1);
            Controls.Add(staffListButton);
            Controls.Add(itemListButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Giriş Menüsü";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button itemListButton;
        private Button staffListButton;
        private Label label1;
        private Label roleLabel;
        private Button addStaffButton;
        private Button deleteStaffButton;
        public Label staffNameLabel;
        public Label staffRoleLabel;
        private Button CloseButton;
        private Button button1;
    }
}
