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
    public partial class Main : Form
    {
        FileInfo cfg;
        File_Load fl;
        Value_Replace vr;
        StreamReader flr;

        public Main()
        {
            InitializeComponent();
        }

        private void Rechoose_Click(object sender, EventArgs e)
        {

        }

        private void Main_Closing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            FileInfo loc = new FileInfo(Application.StartupPath + @"\set.lock");
            StreamReader sr = new StreamReader(loc.OpenRead());
            fl = new File_Load(Application.StartupPath + @"\" + sr.ReadLine() + ".cfg"); ;
            sr.Close();
            sr = null;
            this.Text = fl.GetValue("Main.Title") + ":";
            this.label1.Text = fl.GetValue("Main.Target") + ":";
            this.label2.Text = fl.GetValue("Main.Item") + ":";
            this.label3.Text = fl.GetValue("Main.Input") + ":";
            this.Commit.Text = fl.GetValue("Main.Confirm");
            this.Rechoose.Text = fl.GetValue("Main.Rechoose");
        }
    }
}
