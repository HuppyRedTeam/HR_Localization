namespace HR_Localization
{
    partial class Main
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("aaaa");
            this.label1 = new System.Windows.Forms.Label();
            this.Choose_Leng = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Commit = new System.Windows.Forms.Button();
            this.Rechoose = new System.Windows.Forms.Button();
            this.Logbox = new System.Windows.Forms.RichTextBox();
            this.Inputbox = new System.Windows.Forms.TextBox();
            this.ItemBox = new System.Windows.Forms.ListView();
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main.Target";
            // 
            // Choose_Leng
            // 
            this.Choose_Leng.FormattingEnabled = true;
            this.Choose_Leng.Items.AddRange(new object[] {
            "zh_CN",
            "jp",
            "eng"});
            this.Choose_Leng.Location = new System.Drawing.Point(124, 22);
            this.Choose_Leng.Name = "Choose_Leng";
            this.Choose_Leng.Size = new System.Drawing.Size(140, 23);
            this.Choose_Leng.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Main.Item";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(124, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Main.Input";
            // 
            // Commit
            // 
            this.Commit.Location = new System.Drawing.Point(7, 144);
            this.Commit.Name = "Commit";
            this.Commit.Size = new System.Drawing.Size(84, 22);
            this.Commit.TabIndex = 5;
            this.Commit.Text = "Main.Commit";
            this.Commit.UseVisualStyleBackColor = true;
            // 
            // Rechoose
            // 
            this.Rechoose.Location = new System.Drawing.Point(124, 144);
            this.Rechoose.Name = "Rechoose";
            this.Rechoose.Size = new System.Drawing.Size(96, 22);
            this.Rechoose.TabIndex = 6;
            this.Rechoose.Text = "Main.Rechoose";
            this.Rechoose.UseVisualStyleBackColor = true;
            this.Rechoose.Click += new System.EventHandler(this.Rechoose_Click);
            // 
            // Logbox
            // 
            this.Logbox.Location = new System.Drawing.Point(10, 198);
            this.Logbox.Name = "Logbox";
            this.Logbox.Size = new System.Drawing.Size(299, 340);
            this.Logbox.TabIndex = 8;
            this.Logbox.Text = "";
            // 
            // Inputbox
            // 
            this.Inputbox.Location = new System.Drawing.Point(124, 98);
            this.Inputbox.Name = "Inputbox";
            this.Inputbox.Size = new System.Drawing.Size(185, 25);
            this.Inputbox.TabIndex = 9;
            // 
            // ItemBox
            // 
            this.ItemBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Item,
            this.Data});
            this.ItemBox.GridLines = true;
            this.ItemBox.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.ItemBox.LabelWrap = false;
            this.ItemBox.Location = new System.Drawing.Point(345, 9);
            this.ItemBox.Name = "ItemBox";
            this.ItemBox.Size = new System.Drawing.Size(525, 528);
            this.ItemBox.TabIndex = 10;
            this.ItemBox.UseCompatibleStateImageBehavior = false;
            // 
            // Item
            // 
            this.Item.Text = "项目";
            // 
            // Data
            // 
            this.Data.Text = "数据";
            this.Data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.ItemBox);
            this.Controls.Add(this.Inputbox);
            this.Controls.Add(this.Logbox);
            this.Controls.Add(this.Rechoose);
            this.Controls.Add(this.Commit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Choose_Leng);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Main.Title";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Closing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Choose_Leng;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Commit;
        private System.Windows.Forms.Button Rechoose;
        private System.Windows.Forms.RichTextBox Logbox;
        private System.Windows.Forms.TextBox Inputbox;
        private System.Windows.Forms.ListView ItemBox;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ColumnHeader Data;
    }
}