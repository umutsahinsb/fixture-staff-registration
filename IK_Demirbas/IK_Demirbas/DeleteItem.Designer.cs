namespace BID_Demirbas
{
    partial class DeleteItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteItem));
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            textBox1 = new TextBox();
            secondItemLabel = new Label();
            secondItemText = new TextBox();
            secondItemCheck = new CheckBox();
            SuspendLayout();
            // 
            // CloseButton
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(442, 302);
            button1.Name = "CloseButton";
            button1.Size = new Size(183, 39);
            button1.TabIndex = 0;
            button1.Text = "Ürünü Sil";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(77, 94);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 1;
            label1.Text = "Ürünün D.No'sunu Girin";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(151, 302);
            button2.Name = "button2";
            button2.Size = new Size(192, 39);
            button2.TabIndex = 2;
            button2.Text = "Ürün Bağlantısını Kopart";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(314, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 29);
            textBox1.TabIndex = 3;
            // 
            // secondItemLabel
            // 
            secondItemLabel.AutoSize = true;
            secondItemLabel.Font = new Font("Segoe UI", 11F);
            secondItemLabel.Location = new Point(77, 177);
            secondItemLabel.Name = "secondItemLabel";
            secondItemLabel.Size = new Size(200, 20);
            secondItemLabel.TabIndex = 4;
            secondItemLabel.Text = "İkinci Ürünün D.No'sunu Girin";
            // 
            // secondItemText
            // 
            secondItemText.Font = new Font("Segoe UI", 12F);
            secondItemText.Location = new Point(314, 168);
            secondItemText.Name = "secondItemText";
            secondItemText.Size = new Size(202, 29);
            secondItemText.TabIndex = 5;
            // 
            // secondItemCheck
            // 
            secondItemCheck.AutoSize = true;
            secondItemCheck.BackColor = SystemColors.Control;
            secondItemCheck.Font = new Font("Segoe UI", 11F);
            secondItemCheck.Location = new Point(77, 249);
            secondItemCheck.Name = "secondItemCheck";
            secondItemCheck.Size = new Size(154, 24);
            secondItemCheck.TabIndex = 6;
            secondItemCheck.Text = "Aralık Belirteceğim";
            secondItemCheck.UseVisualStyleBackColor = false;
            secondItemCheck.CheckedChanged += secondItemCheck_CheckedChanged;
            // 
            // DeleteItem
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(771, 555);
            Controls.Add(secondItemCheck);
            Controls.Add(secondItemText);
            Controls.Add(secondItemLabel);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DeleteItem";
            Text = "ItemDelete";
            Load += DeleteItem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private TextBox textBox1;
        private Label secondItemLabel;
        private TextBox secondItemText;
        private CheckBox secondItemCheck;
    }
}