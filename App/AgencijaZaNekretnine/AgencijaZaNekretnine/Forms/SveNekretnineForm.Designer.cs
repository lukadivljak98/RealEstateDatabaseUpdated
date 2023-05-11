
namespace AgencijaZaNekretnine.Forms
{
    partial class SveNekretnineForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SveNekretnineForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.NekretnineDataGridView = new System.Windows.Forms.DataGridView();
            this.IdNekretnineColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrPosteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdresaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VlasnikJmbColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PredlozenaKirijaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SlobodnoOdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SlobodnoDoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JeIznajmljenaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.NekretnineDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NekretnineDataGridView
            // 
            resources.ApplyResources(this.NekretnineDataGridView, "NekretnineDataGridView");
            this.NekretnineDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.NekretnineDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NekretnineDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NekretnineDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.NekretnineDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NekretnineDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdNekretnineColumn,
            this.BrPosteColumn,
            this.AdresaColumn,
            this.VlasnikJmbColumn,
            this.PredlozenaKirijaColumn,
            this.SlobodnoOdColumn,
            this.SlobodnoDoColumn,
            this.JeIznajmljenaColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.NekretnineDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.NekretnineDataGridView.Name = "NekretnineDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NekretnineDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.NekretnineDataGridView.RowHeadersVisible = false;
            this.NekretnineDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NekretnineDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.NekretnineDataGridView.RowTemplate.DividerHeight = 5;
            this.NekretnineDataGridView.RowTemplate.Height = 200;
            this.NekretnineDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // IdNekretnineColumn
            // 
            this.IdNekretnineColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.IdNekretnineColumn, "IdNekretnineColumn");
            this.IdNekretnineColumn.Name = "IdNekretnineColumn";
            // 
            // BrPosteColumn
            // 
            this.BrPosteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.BrPosteColumn, "BrPosteColumn");
            this.BrPosteColumn.Name = "BrPosteColumn";
            // 
            // AdresaColumn
            // 
            this.AdresaColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.AdresaColumn, "AdresaColumn");
            this.AdresaColumn.Name = "AdresaColumn";
            // 
            // VlasnikJmbColumn
            // 
            this.VlasnikJmbColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.VlasnikJmbColumn, "VlasnikJmbColumn");
            this.VlasnikJmbColumn.Name = "VlasnikJmbColumn";
            // 
            // PredlozenaKirijaColumn
            // 
            this.PredlozenaKirijaColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.PredlozenaKirijaColumn, "PredlozenaKirijaColumn");
            this.PredlozenaKirijaColumn.Name = "PredlozenaKirijaColumn";
            // 
            // SlobodnoOdColumn
            // 
            this.SlobodnoOdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.SlobodnoOdColumn, "SlobodnoOdColumn");
            this.SlobodnoOdColumn.Name = "SlobodnoOdColumn";
            // 
            // SlobodnoDoColumn
            // 
            this.SlobodnoDoColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.SlobodnoDoColumn, "SlobodnoDoColumn");
            this.SlobodnoDoColumn.Name = "SlobodnoDoColumn";
            // 
            // JeIznajmljenaColumn
            // 
            this.JeIznajmljenaColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.JeIznajmljenaColumn, "JeIznajmljenaColumn");
            this.JeIznajmljenaColumn.Name = "JeIznajmljenaColumn";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.NekretnineDataGridView);
            this.panel1.Name = "panel1";
            // 
            // SveNekretnineForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.panel1);
            this.Name = "SveNekretnineForm";
            this.Load += new System.EventHandler(this.SveNekretnineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NekretnineDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView NekretnineDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdNekretnineColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrPosteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdresaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VlasnikJmbColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PredlozenaKirijaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlobodnoOdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlobodnoDoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn JeIznajmljenaColumn;
    }
}