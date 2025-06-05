namespace BID_Demirbas
{
    partial class DeleteItemFromStaff
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
            listBox1 = new ListBox();
            label1 = new Label();
            nameLabel = new Label();
            departmentLabel = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            wordOutputButton = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(211, 92);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(727, 544);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(257, 25);
            label1.TabIndex = 1;
            label1.Text = "İşlem Yapılan Personel ve Birimi";
            // 
            // nameLabel
            // 
            nameLabel.Font = new Font("Segoe UI", 12F);
            nameLabel.Location = new Point(12, 92);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(184, 63);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "StaffName";
            // 
            // departmentLabel
            // 
            departmentLabel.Font = new Font("Segoe UI", 12F);
            departmentLabel.Location = new Point(12, 117);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.RightToLeft = RightToLeft.No;
            departmentLabel.Size = new Size(184, 123);
            departmentLabel.TabIndex = 3;
            departmentLabel.Text = "StaffDepartment";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(430, 49);
            label4.Name = "label4";
            label4.Size = new Size(277, 15);
            label4.TabIndex = 4;
            label4.Text = "Personel üzerine kayıtlı tüm demirbaşlar listeleniyor";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13F);
            button1.Location = new Point(12, 243);
            button1.Name = "button1";
            button1.Size = new Size(193, 66);
            button1.TabIndex = 5;
            button1.Text = "Seçili Demirbaşın Personel Kaydını Sil";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13F);
            button2.Location = new Point(12, 324);
            button2.Name = "button2";
            button2.Size = new Size(193, 86);
            button2.TabIndex = 6;
            button2.Text = "Personele Ait Tüm Demirbaş Kayıtlarını Sil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // wordOutputButton
            // 
            wordOutputButton.Font = new Font("Segoe UI", 13F);
            wordOutputButton.Location = new Point(12, 464);
            wordOutputButton.Name = "wordOutputButton";
            wordOutputButton.Size = new Size(193, 64);
            wordOutputButton.TabIndex = 7;
            wordOutputButton.Text = "Demirbaşların Kaydını Al (Word)";
            wordOutputButton.UseVisualStyleBackColor = true;
            wordOutputButton.Click += wordOutputButton_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 13F);
            button3.Location = new Point(12, 534);
            button3.Name = "button3";
            button3.Size = new Size(193, 64);
            button3.TabIndex = 8;
            button3.Text = "Demirbaşların Kaydını Al (PDF)";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // DeleteItemFromStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 662);
            Controls.Add(button3);
            Controls.Add(wordOutputButton);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(departmentLabel);
            Controls.Add(nameLabel);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "DeleteItemFromStaff";
            Text = "DeleteItemFromStaff";
            Load += DeleteItemFromStaff_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label nameLabel;
        private Label departmentLabel;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button wordOutputButton;
        private Button button3;
    }
}