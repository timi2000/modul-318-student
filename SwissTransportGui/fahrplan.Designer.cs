namespace SwissTransportGui
{
    partial class fahrplan
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
            this.Abfahrtsort = new System.Windows.Forms.Label();
            this.AbfahrtsOrtWählen = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Abfahrtstafel = new System.Windows.Forms.ListBox();
            this.VerbindungenSuchen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Abfahrtsort
            // 
            this.Abfahrtsort.AutoSize = true;
            this.Abfahrtsort.Location = new System.Drawing.Point(12, 63);
            this.Abfahrtsort.Name = "Abfahrtsort";
            this.Abfahrtsort.Size = new System.Drawing.Size(123, 25);
            this.Abfahrtsort.TabIndex = 0;
            this.Abfahrtsort.Text = "Abfahrtsort:";
            // 
            // AbfahrtsOrtWählen
            // 
            this.AbfahrtsOrtWählen.FormattingEnabled = true;
            this.AbfahrtsOrtWählen.Location = new System.Drawing.Point(151, 60);
            this.AbfahrtsOrtWählen.Name = "AbfahrtsOrtWählen";
            this.AbfahrtsOrtWählen.Size = new System.Drawing.Size(539, 33);
            this.AbfahrtsOrtWählen.TabIndex = 1;
            this.AbfahrtsOrtWählen.DropDown += new System.EventHandler(this.AbfahrtsOrtWählen_DropDown);
            // 
            // Abfahrtstafel
            // 
            this.Abfahrtstafel.FormattingEnabled = true;
            this.Abfahrtstafel.ItemHeight = 25;
            this.Abfahrtstafel.Location = new System.Drawing.Point(151, 170);
            this.Abfahrtstafel.Name = "Abfahrtstafel";
            this.Abfahrtstafel.Size = new System.Drawing.Size(794, 504);
            this.Abfahrtstafel.TabIndex = 2;
            this.Abfahrtstafel.SelectedIndexChanged += new System.EventHandler(this.Abfahrtstafel_SelectedIndexChanged);
            // 
            // VerbindungenSuchen
            // 
            this.VerbindungenSuchen.Location = new System.Drawing.Point(765, 45);
            this.VerbindungenSuchen.Name = "VerbindungenSuchen";
            this.VerbindungenSuchen.Size = new System.Drawing.Size(211, 61);
            this.VerbindungenSuchen.TabIndex = 3;
            this.VerbindungenSuchen.Text = "Verbindungen Suchen";
            this.VerbindungenSuchen.UseVisualStyleBackColor = true;
            this.VerbindungenSuchen.Click += new System.EventHandler(this.VerbindungenSuchen_Click);
            // 
            // fahrplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 765);
            this.Controls.Add(this.VerbindungenSuchen);
            this.Controls.Add(this.Abfahrtstafel);
            this.Controls.Add(this.AbfahrtsOrtWählen);
            this.Controls.Add(this.Abfahrtsort);
            this.Name = "fahrplan";
            this.Text = "fahrplan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Abfahrtsort;
        private System.Windows.Forms.ComboBox AbfahrtsOrtWählen;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox Abfahrtstafel;
        private System.Windows.Forms.Button VerbindungenSuchen;
    }
}