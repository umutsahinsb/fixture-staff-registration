namespace BID_Demirbas
{
    partial class AddItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItem));
            dno = new TextBox();
            itemName = new TextBox();
            prop = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            addItemButton = new Button();
            browseButton = new Button();
            departmentCombo = new ComboBox();
            staffCombo = new ComboBox();
            itemMaterialCombo = new ComboBox();
            itemPropertiesCombo = new ComboBox();
            checkBox2 = new CheckBox();
            newMaterialCheck = new CheckBox();
            newPropertiesCheck = new CheckBox();
            SuspendLayout();
            // 
            // dno
            // 
            dno.Location = new Point(182, 23);
            dno.Name = "dno";
            dno.Size = new Size(358, 23);
            dno.TabIndex = 0;
            // 
            // itemName
            // 
            itemName.Location = new Point(182, 80);
            itemName.Name = "itemName";
            itemName.Size = new Size(358, 23);
            itemName.TabIndex = 1;
            // 
            // prop
            // 
            prop.Location = new Point(182, 145);
            prop.Name = "prop";
            prop.Size = new Size(358, 23);
            prop.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(41, 25);
            label1.Name = "label1";
            label1.Size = new Size(105, 21);
            label1.TabIndex = 5;
            label1.Text = "Demirbaş No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(43, 82);
            label2.Name = "label2";
            label2.Size = new Size(103, 21);
            label2.TabIndex = 6;
            label2.Text = "Malzeme Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(64, 147);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 7;
            label3.Text = "Özellikleri:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(26, 208);
            label4.Name = "label4";
            label4.Size = new Size(120, 21);
            label4.TabIndex = 8;
            label4.Text = "Kullanıcı Bölüm:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(75, 254);
            label5.Name = "label5";
            label5.Size = new Size(71, 21);
            label5.TabIndex = 9;
            label5.Text = "Kullanıcı:";
            // 
            // addItemButton
            // 
            addItemButton.Font = new Font("Segoe UI", 12F);
            addItemButton.Location = new Point(71, 419);
            addItemButton.Name = "addItemButton";
            addItemButton.Size = new Size(215, 36);
            addItemButton.TabIndex = 10;
            addItemButton.Text = "Demirbaş Ekle";
            addItemButton.UseVisualStyleBackColor = true;
            addItemButton.Click += addItemButton_Click;
            // 
            // browseButton
            // 
            browseButton.Font = new Font("Segoe UI", 12F);
            browseButton.Location = new Point(379, 419);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(215, 36);
            browseButton.TabIndex = 11;
            browseButton.Text = "Bilgisayardan Dosya Seç";
            browseButton.UseVisualStyleBackColor = true;
            browseButton.Click += browseButton_Click;
            // 
            // departmentCombo
            // 
            departmentCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            departmentCombo.FormattingEnabled = true;
            departmentCombo.Location = new Point(182, 206);
            departmentCombo.Name = "departmentCombo";
            departmentCombo.Size = new Size(358, 23);
            departmentCombo.TabIndex = 12;
            departmentCombo.SelectedIndexChanged += departmentCombo_SelectedIndexChanged;
            // 
            // staffCombo
            // 
            staffCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            staffCombo.FormattingEnabled = true;
            staffCombo.Location = new Point(182, 252);
            staffCombo.Name = "staffCombo";
            staffCombo.Size = new Size(358, 23);
            staffCombo.TabIndex = 13;
            // 
            // itemMaterialCombo
            // 
            itemMaterialCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            itemMaterialCombo.FormattingEnabled = true;
            itemMaterialCombo.Location = new Point(182, 80);
            itemMaterialCombo.Name = "itemMaterialCombo";
            itemMaterialCombo.Size = new Size(358, 23);
            itemMaterialCombo.TabIndex = 15;
            itemMaterialCombo.SelectedIndexChanged += itemMaterialCombo_SelectedIndexChanged;
            // 
            // itemPropertiesCombo
            // 
            itemPropertiesCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            itemPropertiesCombo.FormattingEnabled = true;
            itemPropertiesCombo.Location = new Point(182, 147);
            itemPropertiesCombo.Name = "itemPropertiesCombo";
            itemPropertiesCombo.Size = new Size(358, 23);
            itemPropertiesCombo.TabIndex = 16;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(665, 212);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(82, 19);
            checkBox2.TabIndex = 17;
            checkBox2.Text = "Depo ürün";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // newMaterialCheck
            // 
            newMaterialCheck.AutoSize = true;
            newMaterialCheck.Location = new Point(665, 82);
            newMaterialCheck.Name = "newMaterialCheck";
            newMaterialCheck.Size = new Size(99, 19);
            newMaterialCheck.TabIndex = 18;
            newMaterialCheck.Text = "Yeni Malzeme";
            newMaterialCheck.UseVisualStyleBackColor = true;
            newMaterialCheck.CheckedChanged += newMaterialCheck_CheckedChanged;
            // 
            // newPropertiesCheck
            // 
            newPropertiesCheck.AutoSize = true;
            newPropertiesCheck.Location = new Point(665, 147);
            newPropertiesCheck.Name = "newPropertiesCheck";
            newPropertiesCheck.Size = new Size(86, 19);
            newPropertiesCheck.TabIndex = 19;
            newPropertiesCheck.Text = "Yeni Özellik";
            newPropertiesCheck.UseVisualStyleBackColor = true;
            newPropertiesCheck.CheckedChanged += newPropertiesCheck_CheckedChanged;
            // 
            // AddItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 502);
            Controls.Add(newPropertiesCheck);
            Controls.Add(newMaterialCheck);
            Controls.Add(checkBox2);
            Controls.Add(itemPropertiesCombo);
            Controls.Add(itemMaterialCombo);
            Controls.Add(staffCombo);
            Controls.Add(departmentCombo);
            Controls.Add(browseButton);
            Controls.Add(addItemButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(prop);
            Controls.Add(itemName);
            Controls.Add(dno);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddItem";
            Text = "ItemAdd";
            Load += AddItem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox dno;
        private TextBox itemName;
        private TextBox prop;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button addItemButton;
        private Button browseButton;
        private ComboBox departmentCombo;
        private ComboBox staffCombo;
        private ComboBox itemMaterialCombo;
        private ComboBox itemPropertiesCombo;
        private CheckBox checkBox2;
        private CheckBox newMaterialCheck;
        private CheckBox newPropertiesCheck;
    }
}