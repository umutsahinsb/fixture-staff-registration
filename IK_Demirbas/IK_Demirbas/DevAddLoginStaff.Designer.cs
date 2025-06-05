namespace BID_Demirbas
{
    partial class DevAddLoginStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevAddLoginStaff));
            label1 = new Label();
            label2 = new Label();
            staffNameText = new TextBox();
            staffPasswordText = new TextBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            button1 = new Button();
            usernameText = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(50, 143);
            label1.Name = "label1";
            label1.Size = new Size(166, 21);
            label1.TabIndex = 0;
            label1.Text = "Personel İsim-Soyisim:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(171, 223);
            label2.Name = "label2";
            label2.Size = new Size(45, 21);
            label2.TabIndex = 1;
            label2.Text = "Şifre:";
            // 
            // staffNameText
            // 
            staffNameText.Location = new Point(245, 141);
            staffNameText.Name = "staffNameText";
            staffNameText.Size = new Size(173, 23);
            staffNameText.TabIndex = 1;
            // 
            // staffPasswordText
            // 
            staffPasswordText.Location = new Point(245, 221);
            staffPasswordText.Name = "staffPasswordText";
            staffPasswordText.Size = new Size(173, 23);
            staffPasswordText.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Dev", "Yönetici", "Personel" });
            comboBox1.Location = new Point(245, 284);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(173, 23);
            comboBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(180, 284);
            label3.Name = "label3";
            label3.Size = new Size(36, 21);
            label3.TabIndex = 5;
            label3.Text = "Rol:";
            // 
            // CloseButton
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(245, 338);
            button1.Name = "CloseButton";
            button1.Size = new Size(173, 33);
            button1.TabIndex = 6;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // usernameText
            // 
            usernameText.Location = new Point(245, 183);
            usernameText.Name = "usernameText";
            usernameText.Size = new Size(173, 23);
            usernameText.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(118, 185);
            label4.Name = "label4";
            label4.Size = new Size(98, 21);
            label4.TabIndex = 7;
            label4.Text = "Kullanıcı Adı:";
            // 
            // DevAddLoginStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 614);
            Controls.Add(usernameText);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(staffPasswordText);
            Controls.Add(staffNameText);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DevAddLoginStaff";
            Text = "DevAddLoginStaff";
            Load += DevAddLoginStaff_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox staffNameText;
        private TextBox staffPasswordText;
        private ComboBox comboBox1;
        private Label label3;
        private Button button1;
        private TextBox usernameText;
        private Label label4;
    }
}