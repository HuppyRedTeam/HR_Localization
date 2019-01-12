using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HR_Localization
{
    class File_Load
    {
        public FileInfo fl;
        public StreamReader sr;
        public StreamWriter wr;
        public FileStream fs;

        public File_Load(string path)
        {
            fl = new FileInfo(path);
            try
            {
                fs = fl.Open(FileMode.Open);
                sr = new StreamReader(fs);
                wr = new StreamWriter(fs);

            }
            catch (IOException e)
            {
                MessageBox.Show("Can't find file: " + e.ToString());
                System.Environment.Exit(0);
            }
        }

        public string GetValue(string value)
        {
            string result;
            while((result = sr.ReadLine()) != null){
                string[] con = result.Split('=');
                if (con[0].ToLower().Equals(value.ToLower()))
                {
                    return con[1];
                }
            }
            return "Error";

        }

        public void Reset_Stream()
        {
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            wr.BaseStream.Seek(0, SeekOrigin.Begin);
        }

        public StreamReader GetFileReader()
        {
            return this.sr;
        }

        public StreamWriter GetFileWriter()
        {
            return this.wr;
        }

        public void CloseStream()
        {
            this.fs.Close();
        }
    }
}
