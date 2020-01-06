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
    public partial class OknoWyboru : Form
    {
        public OknoWyboru()
        {
            InitializeComponent();
        }

        private void Wyjdz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dalej_Click(object sender, EventArgs e)
        {
            if(((specjalnyDzien.Checked || Casual.Checked) && (Zimno.Checked || Cieplo.Checked)))
            {
                this.Hide();
                Glowny ss = new Glowny();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Nie zaznaczyleś potrzebnych opcji!");
            }
        }

        private void OknoWyboru_Load(object sender, EventArgs e)
        {

        }
    }
}
