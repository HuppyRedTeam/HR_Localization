﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace HR_Localization
{
    public partial class Main : Form
    {
        FileInfo cfg;
        File_Load fl;
        StreamReader flr;
        StreamWriter flw;
        static int NORMAL = 0;
        static int WRRING = 1;
        static int ERROR = 2;

        public Main()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            this.Commit.Enabled = false;
        }

        private void Rechoose_Click(object sender, EventArgs e)
        {
            FileInfo loc = new FileInfo(Application.StartupPath + @"\set.lock");
            loc.Delete();
            this.Dispose();
            Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
            
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
            fl = new File_Load(Application.StartupPath + @"\" + l + ".cfg",File_Load.Open);
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
            new Thread(new ThreadStart(RefreshButton)).Start();
            fl.CloseStream();
            fl = null;
        }

        public void RefreshButton()
        {
            while (true)
            {
                if ((this.Choose_Leng.Text != "") && (this.ItemSel.Text != "") && (this.Inputbox.Text != ""))
                {
                    this.Commit.Enabled = true;
                }
                Thread.Sleep(500);
            }
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
            fl = new File_Load(Application.StartupPath + @"\" + this.Choose_Leng.Text + ".cfg", File_Load.Open);
            string a = fl.GetValue(select);
            fl.Reset_Stream();
            this.Inputbox.Text = a;
            fl.CloseStream();
            fl = null;
        }

        private void Commit_Click(object sender, EventArgs e)
        {
            if (fl != null)
            {
                fl.CloseStream();
                fl = null;
            }
            fl = new File_Load(Application.StartupPath + @"\zh_CN.cfg",File_Load.Clear);
            flr = fl.GetFileReader();
            flw = fl.GetFileWriter();
            Processing p = new Processing();
            p.Show();
            ProgressBar pb = p.GetProgress();
            Label status = p.GetStatus();
            int line = 0;
            while (flr.ReadLine() != null)
            {
                line++;
            }
            string r;
            string[] result = new string[line+1];
            int i = 0;
            fl.Reset_Stream();
            while (i<result.Length)
            {
                r = flr.ReadLine();
                if(pb.Value < 20)
                {
                    pb.Value = i;
                }
                result[i] = r;
                i++;
                status.Text = "正在读取第：" + i + "行";
            }
            pb.Value = 25;
            status.Text = "开始写入";
            StreamReader sr = fl.GetFileReader();
            StreamWriter sw = fl.GetFileWriter();
            status.Text = "已创建写入流";
            pb.Value = 45;
            for (int a = 0; a < result.Length-1; a++ )
            {
                if(pb.Value < 75)
                {
                    pb.Value = 45 + a;
                }
                string re = result[a];
                string[] rea = re.Split('=');
                string input = this.ItemSel.Text + "=" + this.Inputbox.Text;
                Log(rea[0], Main.NORMAL);
                if (rea[0].Equals(this.ItemSel.Text))
                {
                    Log(rea[0], Main.NORMAL);
                    sw.WriteLine(input);
                    sw.Flush();
                }
                else
                {
                    sw.WriteLine(result[a]);
                    sw.Flush();
                }

                status.Text = "正在写入第：" + a + "行";
            }
            status.Text = "已完成所有操作";
            pb.Value = 100;
            MessageBox.Show("已完成更新", "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            p.Dispose();
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            while((r = sr.ReadLine()) != null)
            {
                this.ItemBox.Items.Clear();
                this.ItemBox.Items.Add(r);
            }
            fl.CloseStream();
            fl = null;
        }
    }
}
