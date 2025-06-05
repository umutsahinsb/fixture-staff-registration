namespace BID_Demirbas
{
    partial class DevDeleteStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevDeleteStaff));
            deleteButton = new Button();
            usernameCombo = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Segoe UI", 12F);
            deleteButton.Location = new Point(262, 483);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(190, 44);
            deleteButton.TabIndex = 0;
            deleteButton.Text = "Sil";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // usernameCombo
            // 
            usernameCombo.FormattingEnabled = true;
            usernameCombo.Location = new Point(300, 226);
            usernameCombo.Name = "usernameCombo";
            usernameCombo.Size = new Size(190, 23);
            usernameCombo.TabIndex = 1;
            usernameCombo.SelectedIndexChanged += usernameCombo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(332, 370);
            label1.Name = "label1";
            label1.Size = new Size(16, 21);
            label1.TabIndex = 2;
            label1.Text = "-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(332, 417);
            label2.Name = "label2";
            label2.Size = new Size(16, 21);
            label2.TabIndex = 3;
            label2.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(89, 224);
            label3.Name = "label3";
            label3.Size = new Size(183, 25);
            label3.TabIndex = 4;
            label3.Text = "Silinecek Kullanıcı Adı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(300, 310);
            label4.Name = "label4";
            label4.Size = new Size(90, 21);
            label4.TabIndex = 5;
            label4.Text = "Kullanıcının";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(229, 370);
            label5.Name = "label5";
            label5.Size = new Size(97, 21);
            label5.TabIndex = 6;
            label5.Text = "Adı - Soyadı:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(281, 417);
            label6.Name = "label6";
            label6.Size = new Size(45, 21);
            label6.TabIndex = 7;
            label6.Text = "Rolü:";
            // 
            // DevDeleteStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 653);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(usernameCombo);
            Controls.Add(deleteButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DevDeleteStaff";
            Text = "DevDeleteStaff";
            Load += DevDeleteStaff_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button deleteButton;
        private ComboBox usernameCombo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}