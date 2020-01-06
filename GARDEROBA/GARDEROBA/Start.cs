using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GARDEROBA
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dalej_Click(object sender, EventArgs e)
        {
            this.Close();
            OknoWyboru ss = new OknoWyboru();
            ss.Show();
        }
    }
}
