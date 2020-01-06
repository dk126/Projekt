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
    public partial class Dodawanie : Form
    {
        public Dodawanie()
        {
            InitializeComponent();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if(radioButtonAddNakrycieG.Checked && (checkBoxCiepło.Checked || checkBoxZimno.Checked) && !(string.IsNullOrWhiteSpace(textBoxLokalizacja.Text)) && radioButtonNaSO.Checked) 
            {
                if(checkBoxZimno.Checked && !(checkBoxCiepło.Checked))
                {
                    Ubrania noweNG = new Glowa(false, true, true, textBoxLokalizacja.Text);
                }
                //i tutaj pozostałe 1500 ifów z różnymi warunkami
            }
        }
    }
}
