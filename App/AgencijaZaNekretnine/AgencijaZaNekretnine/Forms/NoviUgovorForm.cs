using AgencijaZaNekretnine.Data.Controller;
using AgencijaZaNekretnine.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace AgencijaZaNekretnine.Forms
{
    public partial class NoviUgovorForm : Form
    {
        public NoviUgovorForm()
        {
            InitializeComponent();
            ucitajListuNekretnina();
        }

        private void SacuvajButton_Click(object sender, EventArgs e)
        {
            UgovorIznajmljivanje ui = new UgovorIznajmljivanje();
            ui.idUgovorIznajmljivanje = 1;
            ui.klijentJMB = JmbKlijentaTextBox.Text;
            ui.agentJMB = JmbAgentaTextBox.Text;
            ui.kirija = Double.Parse(KirijaTextBox.Text);
            ui.datum = DatumPicker.Value;
            ui.opis = TekstUgovoraTextBox.Text;
            ui.depozit = Double.Parse(DepozitTextBox.Text);
            ui.minimalanPeriodIznajmljivanja = int.Parse(MinimalanPeriodTextBox.Text);
            ui.idNekretnina = int.Parse(SifraNekretnineCb.SelectedItem.ToString());
            UgovorIznajmljivanjeController.Insert(ui);
            this.Close();
        }

        private void OtkaziButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucitajListuNekretnina()
        {
            var lista = NekretninaIznajmljivanjeController.ReadAll();
            foreach (var item in lista)
                SifraNekretnineCb.Items.Add(item.idNekretnina.ToString());
        }

        private void SifraNekretnineCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Int32.Parse(SifraNekretnineCb.SelectedItem.ToString());
            NekretninaIznajmljivanje ni = NekretninaIznajmljivanjeController.Read(id);
            Nekretnina n = NekretninaController.Read(id);
            SifraNekretnineTextBox.Text = id.ToString(); //ni.idNekretnina.ToString();
            BrPosteTextBox.Text = n.brPoste;
            AdresaTextBox.Text = n.adresa;
            JmbVlasnikaTextBox.Text = n.vlasnikJMB;
            KirijaTb.Text = ni.predlozenaKirija.ToString();
            SlobodnoOdTextBox.Text = ni.slobodnoOd.ToString();
        }

        private void applyTheme(object sender, EventArgs e)
        {
            var theme = ConfigurationManager.AppSettings["theme"];
            if (theme == "light")
                this.BackColor = Color.White;
            else if (theme == "dark")
            {
                this.BackColor = Color.DimGray;
                this.OtkaziButton.BackColor = Color.FromArgb(39, 39, 58);
                this.SacuvajButton.BackColor = Color.FromArgb(39, 39, 58);
                this.NekretnineGroupBox.BackColor = Color.FromArgb(39, 39, 58);
            }
            else this.BackColor = Color.CornflowerBlue;
        }
    }
}
