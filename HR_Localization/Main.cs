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
        StreamWriter flw;
        static int NORMAL = 0;
        static int WRRING = 1;
        static int ERROR = 2;

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
            string l = sr.ReadLine();
            fl = new File_Load(Application.StartupPath + @"\" + l + ".cfg");
            Log("文件已加载",Main.NORMAL);
            flr = fl.GetFileReader();
            Log("选择语言:" + l,Main.NORMAL);
            sr.Close();
            flw = fl.GetFileWriter();
            Log("写入流开启", Main.NORMAL);

            this.Text = fl.GetValue("Main.Title") + ":";
            this.label1.Text = fl.GetValue("Main.Target") + ":";
            this.label2.Text = fl.GetValue("Main.Item") + ":";
            this.label3.Text = fl.GetValue("Main.Input") + ":";
            this.Commit.Text = fl.GetValue("Main.Confirm");
            this.Rechoose.Text = fl.GetValue("Main.Rechoose");
            Log("启动正常", Main.NORMAL);
            LoadItem();
            Log("读取完成", Main.NORMAL);
            flr.BaseStream.Seek(0, SeekOrigin.Begin);

        }

        public void Log(string label,int level)
        {
            if(level == Main.NORMAL)
            {
                this.Logbox.AppendText("[INFO]:" + label + "\n");
            }
            if (level == Main.WRRING)
            {
                this.Logbox.AppendText("[WRRING]:" + label + "\n");
            }
            if(level == Main.ERROR)
            {
                this.Logbox.AppendText("[ERROR]:" + label + "\n");
            }
        }

        public void LoadItem()
        {
            string result;
            flr.BaseStream.Seek(0, SeekOrigin.Begin);
            while((result = flr.ReadLine()) != null)
            {
                string[] a = result.Split('=');
                this.ItemSel.Items.Add(a[0]);
                this.ItemBox.Items.Add(result);
            }
        }

        private void ItemBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string result;
            try
            {
                result = this.ItemBox.SelectedItem.ToString();
            }catch(Exception ea)
            {
                return;
            }
            string[] a = result.Split('=');
            this.ItemSel.Text = a[0];
            this.Inputbox.Text = a[1];
        }

        private void ItemSel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = this.ItemSel.Text;
            string a = fl.GetValue(select);
            fl.Reset_Stream();
            this.Inputbox.Text = a;
        }
    }
}
