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

        public File_Load(string path)
        {
            fl = new FileInfo(path);
            try
            {
                sr = new StreamReader(fl.Open(FileMode.Open));

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

        public StreamReader GetFileReader()
        {
            return this.sr;
        }

        public StreamWriter GetFileWriter()
        {
            return this.wr;
        }
    }
}
