using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HR_Localization
{
    public partial class Processing : Form
    {
        public Processing()
        {
            InitializeComponent();
        }

        private void Processing_Load(object sender, EventArgs e)
        {

        }

        public ProgressBar GetProgress()
        {
            return this.progressBar1;
        }

        public Label GetStatus()
        {
            return this.label1;
        }
    }
}
