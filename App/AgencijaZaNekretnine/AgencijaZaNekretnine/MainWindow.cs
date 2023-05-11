using AgencijaZaNekretnine.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgencijaZaNekretnine
{
    public partial class MainWindow : Form
    {
        private Form activeForm;

        public MainWindow()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblMainTitle.Text = childForm.Text;
        }

        private void NovaNekretnineButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.NovaNekretninaForm(), sender);
        }

        private void OAgencijiButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.OAgencijiForm(), sender);
        }

        private void SveNekretnineButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.SveNekretnineForm(), sender);
        }

        private void NoviUgovorButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.NoviUgovorForm(), sender);
        }

        private void lblMainTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void controlBtn3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void controlBtn2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void controlBtn1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PodesavanjaBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.PodesavanjaForm(), sender);
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.HomeForm(), sender);
        }

        private void applyTheme(object sender, EventArgs e)
        {
        }
    }
}
