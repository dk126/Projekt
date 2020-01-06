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
    public partial class Glowny : Form
    {
        List<Image> lista_zdjec_glowa;
        List<Image> lista_zdjec_gora;
        List<Image> lista_zdjec_legs;
        List<Image> lista_zdjec_shoes;
        public Glowny()
        {
            InitializeComponent();
        }

        private void wyjdz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void PutOnHead_Click(object sender, EventArgs e)
        {
            if(lista_zdjec_glowa == null)
            {
                MessageBox.Show("Ładowanie dostępnych nakryć głowy");
                lista_zdjec_glowa = new List<Image>();
                
                lista_zdjec_glowa.Add(Image.FromFile(@"C:\Users\sebak\Desktop\PROJEKD\GARDEROBA\GARDEROBA\Properties\Ubrania\Damskie\Głowa\bialaB.jpg "));
                lista_zdjec_glowa.Add(Image.FromFile(@"C:\Users\sebak\Desktop\PROJEKD\GARDEROBA\GARDEROBA\Properties\Ubrania\Damskie\Głowa\czarnyK.jpg "));
                lista_zdjec_glowa.Add(Image.FromFile(@"C:\Users\sebak\Desktop\PROJEKD\GARDEROBA\GARDEROBA\Properties\Ubrania\Damskie\Głowa\rozowaZ.jpg "));

            }
        }

        private void TakeOffHead_Click(object sender, EventArgs e)
        {
            lista_zdjec_glowa = null;
        }

        private void PutOnBody_Click(object sender, EventArgs e)
        {
            if(lista_zdjec_gora == null)
            {
                MessageBox.Show("Ładowanie dostępnych ubrań górnej cześci ciała");
                lista_zdjec_gora = new List<Image>();
                lista_zdjec_gora.Add(Image.FromFile(@"C:\Users\sebak\Desktop\PROJEKD\GARDEROBA\GARDEROBA\Properties\Ubrania\Damskie\Góra\BluzkaWK.jpg"));
                lista_zdjec_gora.Add(Image.FromFile(@"C:\Users\sebak\Desktop\PROJEKD\GARDEROBA\GARDEROBA\Properties\Ubrania\Damskie\Góra\BluzkaWS.jpg"));
                lista_zdjec_gora.Add(Image.FromFile(@"C:\Users\sebak\Desktop\PROJEKD\GARDEROBA\GARDEROBA\Properties\Ubrania\Damskie\Góra\SukienkaWK.jpg"));
                lista_zdjec_gora.Add(Image.FromFile(@"C:\Users\sebak\Desktop\PROJEKD\GARDEROBA\GARDEROBA\Properties\Ubrania\Damskie\Góra"));
                //reszta do dodania
            }
        }

        private void buttonDodajNowe_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dodawanie ss = new Dodawanie();
            ss.Show();
        }
        
    }
}
