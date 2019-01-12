using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HR_Localization
{
    public partial class Choose : Form
    {
        public FileInfo len;

        public Choose()
        {
            InitializeComponent();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            FileInfo lockf = new FileInfo(Application.StartupPath + @"\set.lock");
            StreamWriter sw = lockf.CreateText();
            sw.WriteLine(comboBox1.Text.Trim());
            sw.Flush();
            sw.Close();
            len = new FileInfo(Application.StartupPath + @"\" + comboBox1.Text.Trim() + ".cfg");
            if (len.Exists)
            {
                new Main().Show();
                this.Hide();
                len = null;
            }
            else
            {
                File_Load file = new File_Load(Application.StartupPath + @"\" + comboBox1.Text.Trim() + ".cfg");
                Value_Replace vr = new Value_Replace(file.GetValue("Choose.MessageBox.MissFileName"));
                DialogResult dr =  MessageBox.Show(vr.Handle(comboBox1.Text.Trim() + ".cfg"), file.GetValue("Choose.MessageBox.MissFileName.Title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dr.Equals(DialogResult.OK))
                {
                    lockf.Delete();
                    System.Environment.Exit(0);
                }
                len = null;
            }
        }

        private void Choose_Load(object sender, EventArgs e)
        {

        }
    }
}
