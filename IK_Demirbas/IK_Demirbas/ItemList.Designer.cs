namespace BID_Demirbas
{
    partial class ItemList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemList));
            itemListBox = new ListBox();
            addItemButton = new Button();
            deleteItemButton = new Button();
            label1 = new Label();
            itemSearchButton = new Button();
            button1 = new Button();
            searchBar = new TextBox();
            filterItemCheck = new CheckBox();
            SuspendLayout();
            // 
            // itemListBox
            // 
            itemListBox.FormattingEnabled = true;
            itemListBox.ItemHeight = 15;
            itemListBox.Location = new Point(217, 66);
            itemListBox.Name = "itemListBox";
            itemListBox.Size = new Size(844, 574);
            itemListBox.TabIndex = 0;
            // 
            // addItemButton
            // 
            addItemButton.Font = new Font("Segoe UI", 12F);
            addItemButton.Image = (Image)resources.GetObject("addItemButton.Image");
            addItemButton.Location = new Point(14, 313);
            addItemButton.Name = "addItemButton";
            addItemButton.Size = new Size(144, 59);
            addItemButton.TabIndex = 1;
            addItemButton.Text = "Ekle";
            addItemButton.TextAlign = ContentAlignment.MiddleRight;
            addItemButton.UseVisualStyleBackColor = true;
            addItemButton.Click += addItemButton_Click;
            // 
            // deleteItemButton
            // 
            deleteItemButton.Font = new Font("Segoe UI", 12F);
            deleteItemButton.Location = new Point(14, 378);
            deleteItemButton.Name = "deleteItemButton";
            deleteItemButton.Size = new Size(144, 50);
            deleteItemButton.TabIndex = 2;
            deleteItemButton.Text = "Sil";
            deleteItemButton.UseVisualStyleBackColor = true;
            deleteItemButton.Click += deleteItemButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(361, 4);
            label1.Name = "label1";
            label1.Size = new Size(155, 15);
            label1.TabIndex = 3;
            label1.Text = "Tüm malzemeler listeleniyor";
            // 
            // itemSearchButton
            // 
            itemSearchButton.Font = new Font("Segoe UI", 12F);
            itemSearchButton.Location = new Point(14, 113);
            itemSearchButton.Name = "itemSearchButton";
            itemSearchButton.Size = new Size(144, 50);
            itemSearchButton.TabIndex = 4;
            itemSearchButton.Text = "Bul";
            itemSearchButton.UseVisualStyleBackColor = true;
            itemSearchButton.Click += itemSearchButton_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(14, 440);
            button1.Name = "button1";
            button1.Size = new Size(144, 50);
            button1.TabIndex = 5;
            button1.Text = "Listeyi Yenile";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // searchBar
            // 
            searchBar.Font = new Font("Segoe UI", 11F);
            searchBar.Location = new Point(14, 66);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(144, 27);
            searchBar.TabIndex = 6;
            // 
            // filterItemCheck
            // 
            filterItemCheck.Font = new Font("Segoe UI", 12F);
            filterItemCheck.Location = new Point(14, 182);
            filterItemCheck.Name = "filterItemCheck";
            filterItemCheck.Size = new Size(144, 95);
            filterItemCheck.TabIndex = 7;
            filterItemCheck.Text = "Kullanıcısı ve Birimi Olmayan Ürünleri Listele";
            filterItemCheck.UseVisualStyleBackColor = true;
            filterItemCheck.CheckedChanged += filterItemCheck_CheckedChanged;
            // 
            // ItemList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 700);
            Controls.Add(filterItemCheck);
            Controls.Add(searchBar);
            Controls.Add(button1);
            Controls.Add(itemSearchButton);
            Controls.Add(label1);
            Controls.Add(deleteItemButton);
            Controls.Add(addItemButton);
            Controls.Add(itemListBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ItemList";
            Text = "ItemList";
            Load += ItemList_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox itemListBox;
        private Button addItemButton;
        private Button deleteItemButton;
        private Label label1;
        private Button itemSearchButton;
        private Button button1;
        private TextBox searchBar;
        private CheckBox filterItemCheck;
    }
}