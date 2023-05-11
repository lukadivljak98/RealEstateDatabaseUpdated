
namespace AgencijaZaNekretnine.Forms
{
    partial class NovaNekretninaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovaNekretninaForm));
            this.BrPosteLbl = new System.Windows.Forms.Label();
            this.AdresaLbl = new System.Windows.Forms.Label();
            this.VlasnikJmbLbl = new System.Windows.Forms.Label();
            this.PerdlozenaKirijaLbl = new System.Windows.Forms.Label();
            this.SlobodnoOdLbl = new System.Windows.Forms.Label();
            this.SlobodnoDoLbl = new System.Windows.Forms.Label();
            this.AdresaTextBox = new System.Windows.Forms.TextBox();
            this.VlasnikJmbTextBox = new System.Windows.Forms.TextBox();
            this.PredlozenaKirijaTextBox = new System.Windows.Forms.TextBox();
            this.SlobodnoOdPicker = new System.Windows.Forms.DateTimePicker();
            this.SlobodnoDoPicker = new System.Windows.Forms.DateTimePicker();
            this.OtkaziButton = new System.Windows.Forms.Button();
            this.SacuvajButton = new System.Windows.Forms.Button();
            this.BrPosteComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BrPosteLbl
            // 
            resources.ApplyResources(this.BrPosteLbl, "BrPosteLbl");
            this.BrPosteLbl.Name = "BrPosteLbl";
            // 
            // AdresaLbl
            // 
            resources.ApplyResources(this.AdresaLbl, "AdresaLbl");
            this.AdresaLbl.Name = "AdresaLbl";
            // 
            // VlasnikJmbLbl
            // 
            resources.ApplyResources(this.VlasnikJmbLbl, "VlasnikJmbLbl");
            this.VlasnikJmbLbl.Name = "VlasnikJmbLbl";
            // 
            // PerdlozenaKirijaLbl
            // 
            resources.ApplyResources(this.PerdlozenaKirijaLbl, "PerdlozenaKirijaLbl");
            this.PerdlozenaKirijaLbl.Name = "PerdlozenaKirijaLbl";
            // 
            // SlobodnoOdLbl
            // 
            resources.ApplyResources(this.SlobodnoOdLbl, "SlobodnoOdLbl");
            this.SlobodnoOdLbl.Name = "SlobodnoOdLbl";
            // 
            // SlobodnoDoLbl
            // 
            resources.ApplyResources(this.SlobodnoDoLbl, "SlobodnoDoLbl");
            this.SlobodnoDoLbl.Name = "SlobodnoDoLbl";
            // 
            // AdresaTextBox
            // 
            resources.ApplyResources(this.AdresaTextBox, "AdresaTextBox");
            this.AdresaTextBox.Name = "AdresaTextBox";
            // 
            // VlasnikJmbTextBox
            // 
            resources.ApplyResources(this.VlasnikJmbTextBox, "VlasnikJmbTextBox");
            this.VlasnikJmbTextBox.Name = "VlasnikJmbTextBox";
            // 
            // PredlozenaKirijaTextBox
            // 
            resources.ApplyResources(this.PredlozenaKirijaTextBox, "PredlozenaKirijaTextBox");
            this.PredlozenaKirijaTextBox.Name = "PredlozenaKirijaTextBox";
            // 
            // SlobodnoOdPicker
            // 
            resources.ApplyResources(this.SlobodnoOdPicker, "SlobodnoOdPicker");
            this.SlobodnoOdPicker.Name = "SlobodnoOdPicker";
            // 
            // SlobodnoDoPicker
            // 
            resources.ApplyResources(this.SlobodnoDoPicker, "SlobodnoDoPicker");
            this.SlobodnoDoPicker.Name = "SlobodnoDoPicker";
            // 
            // OtkaziButton
            // 
            resources.ApplyResources(this.OtkaziButton, "OtkaziButton");
            this.OtkaziButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.OtkaziButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.OtkaziButton.Name = "OtkaziButton";
            this.OtkaziButton.UseVisualStyleBackColor = false;
            this.OtkaziButton.Click += new System.EventHandler(this.OtkaziButton_Click);
            // 
            // SacuvajButton
            // 
            resources.ApplyResources(this.SacuvajButton, "SacuvajButton");
            this.SacuvajButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.SacuvajButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.SacuvajButton.Name = "SacuvajButton";
            this.SacuvajButton.UseVisualStyleBackColor = false;
            this.SacuvajButton.Click += new System.EventHandler(this.SacuvajButton_Click);
            // 
            // BrPosteComboBox
            // 
            resources.ApplyResources(this.BrPosteComboBox, "BrPosteComboBox");
            this.BrPosteComboBox.FormattingEnabled = true;
            this.BrPosteComboBox.Name = "BrPosteComboBox";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.BrPosteLbl);
            this.panel2.Controls.Add(this.AdresaLbl);
            this.panel2.Controls.Add(this.VlasnikJmbLbl);
            this.panel2.Controls.Add(this.PerdlozenaKirijaLbl);
            this.panel2.Controls.Add(this.SlobodnoDoLbl);
            this.panel2.Controls.Add(this.SlobodnoOdLbl);
            this.panel2.Name = "panel2";
            // 
            // NovaNekretninaForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BrPosteComboBox);
            this.Controls.Add(this.SacuvajButton);
            this.Controls.Add(this.OtkaziButton);
            this.Controls.Add(this.SlobodnoDoPicker);
            this.Controls.Add(this.SlobodnoOdPicker);
            this.Controls.Add(this.PredlozenaKirijaTextBox);
            this.Controls.Add(this.VlasnikJmbTextBox);
            this.Controls.Add(this.AdresaTextBox);
            this.Name = "NovaNekretninaForm";
            this.Load += new System.EventHandler(this.applyTheme);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label BrPosteLbl;
        private System.Windows.Forms.Label AdresaLbl;
        private System.Windows.Forms.Label VlasnikJmbLbl;
        private System.Windows.Forms.Label PerdlozenaKirijaLbl;
        private System.Windows.Forms.Label SlobodnoOdLbl;
        private System.Windows.Forms.Label SlobodnoDoLbl;
        private System.Windows.Forms.TextBox AdresaTextBox;
        private System.Windows.Forms.TextBox VlasnikJmbTextBox;
        private System.Windows.Forms.TextBox PredlozenaKirijaTextBox;
        private System.Windows.Forms.DateTimePicker SlobodnoOdPicker;
        private System.Windows.Forms.DateTimePicker SlobodnoDoPicker;
        private System.Windows.Forms.Button OtkaziButton;
        private System.Windows.Forms.Button SacuvajButton;
        private System.Windows.Forms.ComboBox BrPosteComboBox;
        private System.Windows.Forms.Panel panel2;
    }
}