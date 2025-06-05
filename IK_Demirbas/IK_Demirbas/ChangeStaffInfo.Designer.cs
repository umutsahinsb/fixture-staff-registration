namespace BID_Demirbas
{
    partial class ChangeStaffInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeStaffInfo));
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            staffNameLabel = new Label();
            button1 = new Button();
            staffDepartmentLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(285, 34);
            label1.Name = "label1";
            label1.Size = new Size(257, 25);
            label1.TabIndex = 0;
            label1.Text = "İşlem Yapılan Personel ve Birimi";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(285, 219);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(268, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(66, 221);
            label2.Name = "label2";
            label2.Size = new Size(133, 21);
            label2.TabIndex = 2;
            label2.Text = "Yeni İsim-Soyisim";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(119, 299);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 3;
            label3.Text = "Yeni Birim";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(285, 301);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(268, 23);
            comboBox1.TabIndex = 4;
            // 
            // staffNameLabel
            // 
            staffNameLabel.AutoSize = true;
            staffNameLabel.Font = new Font("Segoe UI", 11F);
            staffNameLabel.Location = new Point(347, 77);
            staffNameLabel.Name = "staffNameLabel";
            staffNameLabel.Size = new Size(80, 20);
            staffNameLabel.TabIndex = 5;
            staffNameLabel.Text = "StaffName";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(316, 394);
            button1.Name = "button1";
            button1.Size = new Size(185, 34);
            button1.TabIndex = 6;
            button1.Text = "Bilgileri Güncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // staffDepartmentLabel
            // 
            staffDepartmentLabel.AutoSize = true;
            staffDepartmentLabel.Font = new Font("Segoe UI", 11F);
            staffDepartmentLabel.Location = new Point(347, 113);
            staffDepartmentLabel.Name = "staffDepartmentLabel";
            staffDepartmentLabel.Size = new Size(120, 20);
            staffDepartmentLabel.TabIndex = 7;
            staffDepartmentLabel.Text = "StaffDepartment";
            // 
            // ChangeStaffInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 627);
            Controls.Add(staffDepartmentLabel);
            Controls.Add(button1);
            Controls.Add(staffNameLabel);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ChangeStaffInfo";
            Text = "ChangeStaffInfo";
            Load += ChangeStaffInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Label staffNameLabel;
        private Button button1;
        private Label staffDepartmentLabel;
    }
}