
namespace AgencijaZaNekretnine.Forms
{
    partial class PodesavanjaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PodesavanjaForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.themeCb = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.languageCb = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.themeCb);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.languageCb);
            this.panel2.Name = "panel2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // themeCb
            // 
            resources.ApplyResources(this.themeCb, "themeCb");
            this.themeCb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.themeCb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.themeCb.ForeColor = System.Drawing.Color.Black;
            this.themeCb.FormattingEnabled = true;
            this.themeCb.Items.AddRange(new object[] {
            resources.GetString("themeCb.Items"),
            resources.GetString("themeCb.Items1"),
            resources.GetString("themeCb.Items2")});
            this.themeCb.Name = "themeCb";
            this.themeCb.SelectedIndexChanged += new System.EventHandler(this.themeCb_SelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // languageCb
            // 
            resources.ApplyResources(this.languageCb, "languageCb");
            this.languageCb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.languageCb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.languageCb.ForeColor = System.Drawing.Color.Black;
            this.languageCb.FormattingEnabled = true;
            this.languageCb.Items.AddRange(new object[] {
            resources.GetString("languageCb.Items"),
            resources.GetString("languageCb.Items1")});
            this.languageCb.Name = "languageCb";
            this.languageCb.SelectedIndexChanged += new System.EventHandler(this.languageCb_SelectedIndexChanged);
            // 
            // PodesavanjaForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.panel1);
            this.Name = "PodesavanjaForm";
            this.Load += new System.EventHandler(this.applyTheme);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox languageCb;
        private System.Windows.Forms.CheckedListBox themeCb;
        private System.Windows.Forms.Panel panel2;
    }
}