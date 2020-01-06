using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GARDEROBA
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Glowa biała_baseballowka = new Glowa(false, true, false, "C:\\Users\\sebak\\Desktop\\PROJEKD\\GARDEROBA\\GARDEROBA\\Properties\\Ubrania\\Damskie\\Głowa\\bialaB.jpg");
        }
    }
     public class Ubrania
    {
        public bool czyCiepło;
        public bool czyZimno;
        public bool czySpecjalnaOkazja;

        public Ubrania(bool czyCiepło, bool czyZimno, bool czySpecjalnaOkazja)
        {
            this.czyCiepło = czyCiepło;
            this.czyZimno = czyZimno;
            this.czySpecjalnaOkazja = czySpecjalnaOkazja;
        }
    }
     public class Glowa : Ubrania , IGarderoba
    {

        public string Image { get; set; }
        public Glowa(bool czyCiepło, bool czyZimno, bool czySpecjalnaOkazja, string Image) : base(czyCiepło, czyZimno, czySpecjalnaOkazja)
        {
            this.czyCiepło = czyCiepło;
            this.czyZimno = czyZimno;
            this.czySpecjalnaOkazja = czySpecjalnaOkazja;
            this.Image = Image;
        }
    }
    public class Góra : Ubrania, IGarderoba
    {
        public string Image { get; set; }
        public Góra(bool czyCiepło, bool czyZimno, bool czySpecjalnaOkazja, string Image) : base(czyCiepło, czyZimno, czySpecjalnaOkazja)
        {
            this.czyCiepło = czyCiepło;
            this.czyZimno = czyZimno;
            this.czySpecjalnaOkazja = czySpecjalnaOkazja;
            this.Image = Image;
        }
    }
    public class Dół : Ubrania, IGarderoba
    {
        public string Image { get; set; } 
        public Dół(bool czyCiepło, bool czyZimno, bool czySpecjalnaOkazja, string Image) : base(czyCiepło, czyZimno, czySpecjalnaOkazja)
        {
            this.czyCiepło = czyCiepło;
            this.czySpecjalnaOkazja = czySpecjalnaOkazja;
            this.Image = Image;
        }
    }
    public class Buty : Ubrania, IGarderoba
    {
        public string Image { get; set; }
        public Buty(bool czyCiepło, bool czyZimno, bool czySpecjalnaOkazja, string Image) : base(czyCiepło, czyZimno, czySpecjalnaOkazja)
        {
            this.czyCiepło = czyCiepło;
            this.czyZimno = czyZimno;
            this.czySpecjalnaOkazja = czySpecjalnaOkazja;
            this.Image = Image;
        }
    }
}
