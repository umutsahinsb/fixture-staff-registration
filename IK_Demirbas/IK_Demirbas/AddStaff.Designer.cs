namespace BID_Demirbas
{
    partial class AddStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStaff));
            label1 = new Label();
            label2 = new Label();
            addButton = new Button();
            staffNameSurnameText = new TextBox();
            newDepartmentText = new TextBox();
            departmentBox = new ComboBox();
            newDepartmentCheck = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(34, 89);
            label1.Name = "label1";
            label1.Size = new Size(195, 25);
            label1.TabIndex = 0;
            label1.Text = "Personel İsim - Soyisim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(173, 147);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 1;
            label2.Text = "Birimi";
            // 
            // addButton
            // 
            addButton.Location = new Point(173, 316);
            addButton.Name = "addButton";
            addButton.Size = new Size(116, 23);
            addButton.TabIndex = 2;
            addButton.Text = "Personel Ekle";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // staffNameSurnameText
            // 
            staffNameSurnameText.Location = new Point(288, 91);
            staffNameSurnameText.Name = "staffNameSurnameText";
            staffNameSurnameText.Size = new Size(228, 23);
            staffNameSurnameText.TabIndex = 3;
            // 
            // newDepartmentText
            // 
            newDepartmentText.Location = new Point(288, 150);
            newDepartmentText.Name = "newDepartmentText";
            newDepartmentText.Size = new Size(228, 23);
            newDepartmentText.TabIndex = 4;
            // 
            // departmentBox
            // 
            departmentBox.DropDownStyle = ComboBoxStyle.DropDownList;
            departmentBox.FormattingEnabled = true;
            departmentBox.Location = new Point(288, 149);
            departmentBox.Name = "departmentBox";
            departmentBox.Size = new Size(228, 23);
            departmentBox.TabIndex = 6;
            // 
            // newDepartmentCheck
            // 
            newDepartmentCheck.AutoSize = true;
            newDepartmentCheck.Font = new Font("Segoe UI", 12F);
            newDepartmentCheck.Location = new Point(173, 228);
            newDepartmentCheck.Name = "newDepartmentCheck";
            newDepartmentCheck.Size = new Size(141, 25);
            newDepartmentCheck.TabIndex = 7;
            newDepartmentCheck.Text = "Yeni Birim Kaydı";
            newDepartmentCheck.UseVisualStyleBackColor = true;
            newDepartmentCheck.CheckedChanged += newDepartmentCheck_CheckedChanged;
            // 
            // CloseButton
            // 
            button1.Location = new Point(480, 316);
            button1.Name = "CloseButton";
            button1.Size = new Size(219, 23);
            button1.TabIndex = 8;
            button1.Text = "Toplu Personel Ekle (Dosya Seç)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 541);
            Controls.Add(button1);
            Controls.Add(newDepartmentCheck);
            Controls.Add(departmentBox);
            Controls.Add(newDepartmentText);
            Controls.Add(staffNameSurnameText);
            Controls.Add(addButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddStaff";
            Text = "AddStaff";
            Load += AddStaff_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button addButton;
        private TextBox staffNameSurnameText;
        private TextBox newDepartmentText;
        private ComboBox departmentBox;
        private CheckBox newDepartmentCheck;
        private Button button1;
    }
}