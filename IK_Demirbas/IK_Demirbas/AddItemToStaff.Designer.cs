namespace BID_Demirbas
{
    partial class AddItemToStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItemToStaff));
            staffName = new Label();
            label1 = new Label();
            label2 = new Label();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            addItemToStaffButton = new Button();
            staffDepartmentLabel = new Label();
            SuspendLayout();
            // 
            // staffName
            // 
            staffName.Font = new Font("Segoe UI", 12F);
            staffName.Location = new Point(15, 98);
            staffName.Name = "staffName";
            staffName.Size = new Size(185, 87);
            staffName.TabIndex = 0;
            staffName.Text = "Umut Şahin";
            staffName.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(196, 65);
            label1.TabIndex = 1;
            label1.Text = "İşlem Yapılan Personel / Birimi";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(472, 33);
            label2.Name = "label2";
            label2.Size = new Size(152, 21);
            label2.TabIndex = 2;
            label2.Text = "Boşta Duran Ürünler";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(221, 77);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(736, 469);
            listBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 381);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 23);
            textBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(69, 321);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 5;
            label3.Text = "Ürün Ara";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13F);
            button1.Location = new Point(37, 438);
            button1.Name = "button1";
            button1.Size = new Size(152, 43);
            button1.TabIndex = 6;
            button1.Text = "Ara";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // addItemToStaffButton
            // 
            addItemToStaffButton.Font = new Font("Segoe UI", 13F);
            addItemToStaffButton.Location = new Point(963, 264);
            addItemToStaffButton.Name = "addItemToStaffButton";
            addItemToStaffButton.Size = new Size(153, 52);
            addItemToStaffButton.TabIndex = 7;
            addItemToStaffButton.Text = "Ürünü Ekle";
            addItemToStaffButton.UseVisualStyleBackColor = true;
            addItemToStaffButton.Click += addItemToStaffButton_Click;
            // 
            // staffDepartmentLabel
            // 
            staffDepartmentLabel.Font = new Font("Segoe UI", 11F);
            staffDepartmentLabel.Location = new Point(31, 185);
            staffDepartmentLabel.Name = "staffDepartmentLabel";
            staffDepartmentLabel.Size = new Size(168, 101);
            staffDepartmentLabel.TabIndex = 8;
            staffDepartmentLabel.Text = "StaffDepartment";
            staffDepartmentLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // AddItemToStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 639);
            Controls.Add(staffDepartmentLabel);
            Controls.Add(addItemToStaffButton);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(staffName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddItemToStaff";
            Text = "AddItemToStaff";
            Load += AddItemToStaff_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label staffName;
        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private TextBox textBox1;
        private Label label3;
        private Button button1;
        private Button addItemToStaffButton;
        private Label staffDepartmentLabel;
    }
}