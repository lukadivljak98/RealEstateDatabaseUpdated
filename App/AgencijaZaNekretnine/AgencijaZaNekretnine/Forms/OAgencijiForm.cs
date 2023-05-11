using AgencijaZaNekretnine.Data.Controller;
using AgencijaZaNekretnine.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgencijaZaNekretnine.Forms
{
    public partial class OAgencijiForm : Form
    {
        public OAgencijiForm()
        {
            InitializeComponent();
        }

        private void OAgencijiForm_Load(object sender, EventArgs e)
        {
            Agencija a = AgencijaController.Read(1);
            NazivAgencijeTextBox.Text = a.naziv;
            BrTelefonaTextBox.Text = a.brTelefona;
            AdresaTextBox.Text = a.adresa;
            var theme = ConfigurationManager.AppSettings["theme"];
            if (theme == "light")
                this.BackColor = Color.White;
            else if (theme == "dark")
                this.BackColor = Color.DimGray;
            else this.BackColor = Color.CornflowerBlue;
        }

        private void NazivAgencijeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
