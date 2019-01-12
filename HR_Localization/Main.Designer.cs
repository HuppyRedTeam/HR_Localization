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
            this.label1 = new System.Windows.Forms.Label();
            this.Choose_Leng = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ItemSel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Commit = new System.Windows.Forms.Button();
            this.Rechoose = new System.Windows.Forms.Button();
            this.Logbox = new System.Windows.Forms.RichTextBox();
            this.Inputbox = new System.Windows.Forms.TextBox();
            this.ItemBox = new System.Windows.Forms.ListBox();
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
            // ItemSel
            // 
            this.ItemSel.FormattingEnabled = true;
            this.ItemSel.Location = new System.Drawing.Point(124, 57);
            this.ItemSel.Name = "ItemSel";
            this.ItemSel.Size = new System.Drawing.Size(140, 23);
            this.ItemSel.TabIndex = 3;
            this.ItemSel.SelectedIndexChanged += new System.EventHandler(this.ItemSel_SelectedIndexChanged);
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
            this.Logbox.Size = new System.Drawing.Size(314, 340);
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
            this.ItemBox.FormattingEnabled = true;
            this.ItemBox.ItemHeight = 15;
            this.ItemBox.Location = new System.Drawing.Point(349, 21);
            this.ItemBox.Name = "ItemBox";
            this.ItemBox.Size = new System.Drawing.Size(521, 529);
            this.ItemBox.TabIndex = 10;
            this.ItemBox.SelectedIndexChanged += new System.EventHandler(this.ItemBox_SelectedIndexChanged);
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
            this.Controls.Add(this.ItemSel);
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
        private System.Windows.Forms.ComboBox ItemSel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Commit;
        private System.Windows.Forms.Button Rechoose;
        private System.Windows.Forms.RichTextBox Logbox;
        private System.Windows.Forms.TextBox Inputbox;
        private System.Windows.Forms.ListBox ItemBox;
    }
}