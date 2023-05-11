
namespace AgencijaZaNekretnine.Forms
{
    partial class OAgencijiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OAgencijiForm));
            this.NazivAgencijeLbl = new System.Windows.Forms.Label();
            this.NazivAgencijeTextBox = new System.Windows.Forms.TextBox();
            this.BrTelefonaLbl = new System.Windows.Forms.Label();
            this.BrTelefonaTextBox = new System.Windows.Forms.TextBox();
            this.AdresaLbl = new System.Windows.Forms.Label();
            this.AdresaTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NazivAgencijeLbl
            // 
            resources.ApplyResources(this.NazivAgencijeLbl, "NazivAgencijeLbl");
            this.NazivAgencijeLbl.Name = "NazivAgencijeLbl";
            // 
            // NazivAgencijeTextBox
            // 
            resources.ApplyResources(this.NazivAgencijeTextBox, "NazivAgencijeTextBox");
            this.NazivAgencijeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NazivAgencijeTextBox.Name = "NazivAgencijeTextBox";
            this.NazivAgencijeTextBox.ReadOnly = true;
            this.NazivAgencijeTextBox.TextChanged += new System.EventHandler(this.NazivAgencijeTextBox_TextChanged);
            // 
            // BrTelefonaLbl
            // 
            resources.ApplyResources(this.BrTelefonaLbl, "BrTelefonaLbl");
            this.BrTelefonaLbl.Name = "BrTelefonaLbl";
            // 
            // BrTelefonaTextBox
            // 
            resources.ApplyResources(this.BrTelefonaTextBox, "BrTelefonaTextBox");
            this.BrTelefonaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BrTelefonaTextBox.Name = "BrTelefonaTextBox";
            this.BrTelefonaTextBox.ReadOnly = true;
            // 
            // AdresaLbl
            // 
            resources.ApplyResources(this.AdresaLbl, "AdresaLbl");
            this.AdresaLbl.Name = "AdresaLbl";
            // 
            // AdresaTextBox
            // 
            resources.ApplyResources(this.AdresaTextBox, "AdresaTextBox");
            this.AdresaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdresaTextBox.Name = "AdresaTextBox";
            this.AdresaTextBox.ReadOnly = true;
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.NazivAgencijeLbl);
            this.panel2.Controls.Add(this.BrTelefonaLbl);
            this.panel2.Controls.Add(this.AdresaLbl);
            this.panel2.Name = "panel2";
            // 
            // OAgencijiForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.AdresaTextBox);
            this.Controls.Add(this.BrTelefonaTextBox);
            this.Controls.Add(this.NazivAgencijeTextBox);
            this.Name = "OAgencijiForm";
            this.Load += new System.EventHandler(this.OAgencijiForm_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NazivAgencijeLbl;
        private System.Windows.Forms.TextBox NazivAgencijeTextBox;
        private System.Windows.Forms.Label BrTelefonaLbl;
        private System.Windows.Forms.TextBox BrTelefonaTextBox;
        private System.Windows.Forms.Label AdresaLbl;
        private System.Windows.Forms.TextBox AdresaTextBox;
        private System.Windows.Forms.Panel panel2;
    }
}