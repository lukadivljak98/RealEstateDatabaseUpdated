using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace AgencijaZaNekretnine.Forms
{
    public partial class PodesavanjaForm : Form
    {
        public PodesavanjaForm()
        {
            InitializeComponent();
        }

        private void languageCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (languageCb.SelectedIndex)
            {
                case 0:
                    var changeLanguage = new ChangeLanguage();
                    changeLanguage.UpdateConfig("language", "sr");
                    break;
                case 1:
                    var changeLanguage2 = new ChangeLanguage();
                    changeLanguage2.UpdateConfig("language", "en"); 
                    break;
            }
            Application.Restart();
        }

        private void themeCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (themeCb.SelectedIndex)
            {
                case 0:
                    var changeLanguage = new ChangeLanguage();
                    changeLanguage.UpdateConfig("theme", "dark");
                    break;
                case 1:
                    var changeLanguage2 = new ChangeLanguage();
                    changeLanguage2.UpdateConfig("theme", "light");
                    break;
                case 2:
                    var changeLanguage3 = new ChangeLanguage();
                    changeLanguage3.UpdateConfig("theme", "colorful");
                    break;
            }
            Application.Restart();
        }

        private void applyTheme(object sender, EventArgs e)
        {
            var theme = ConfigurationManager.AppSettings["theme"];
            if (theme == "light")
                this.panel1.BackColor = Color.White;
            else if (theme == "dark")
            {
                this.panel1.BackColor = Color.DimGray;
                this.panel2.BackColor = Color.FromArgb(39, 39, 58);
                this.label1.BackColor = Color.FromArgb(39, 39, 58);
                this.label2.BackColor = Color.FromArgb(39, 39, 58);
                this.languageCb.BackColor = Color.FromArgb(39, 39, 58);
                this.themeCb.BackColor = Color.FromArgb(39, 39, 58);
            }
            else this.panel1.BackColor = Color.CornflowerBlue;
        }
    }
}
