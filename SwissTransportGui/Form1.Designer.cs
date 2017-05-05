namespace SwissTransportGui
{
    partial class Form1
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
            this.Verbindungen = new System.Windows.Forms.ListBox();
            this.From = new System.Windows.Forms.ComboBox();
            this.To = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Suchen = new System.Windows.Forms.Button();
            this.Fahrplan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Verbindungen
            // 
            this.Verbindungen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Verbindungen.FormattingEnabled = true;
            this.Verbindungen.ItemHeight = 25;
            this.Verbindungen.Location = new System.Drawing.Point(43, 221);
            this.Verbindungen.Name = "Verbindungen";
            this.Verbindungen.Size = new System.Drawing.Size(1072, 504);
            this.Verbindungen.TabIndex = 2;
            // 
            // From
            // 
            this.From.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.From.FormattingEnabled = true;
            this.From.Location = new System.Drawing.Point(111, 42);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(654, 33);
            this.From.TabIndex = 3;
            this.From.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            this.From.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // To
            // 
            this.To.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.To.FormattingEnabled = true;
            this.To.Location = new System.Drawing.Point(111, 107);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(654, 33);
            this.To.TabIndex = 4;
            this.To.DropDown += new System.EventHandler(this.comboBox2_DropDown);
            this.To.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "To:";
            // 
            // Suchen
            // 
            this.Suchen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Suchen.Location = new System.Drawing.Point(821, 42);
            this.Suchen.Name = "Suchen";
            this.Suchen.Size = new System.Drawing.Size(167, 38);
            this.Suchen.TabIndex = 7;
            this.Suchen.Text = "Suchen";
            this.Suchen.UseVisualStyleBackColor = true;
            this.Suchen.Click += new System.EventHandler(this.Suchen_Click);
            // 
            // Fahrplan
            // 
            this.Fahrplan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Fahrplan.Location = new System.Drawing.Point(821, 98);
            this.Fahrplan.Name = "Fahrplan";
            this.Fahrplan.Size = new System.Drawing.Size(167, 48);
            this.Fahrplan.TabIndex = 8;
            this.Fahrplan.Text = "Fahrplan";
            this.Fahrplan.UseVisualStyleBackColor = true;
            this.Fahrplan.Click += new System.EventHandler(this.Fahrplan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1710, 923);
            this.Controls.Add(this.Fahrplan);
            this.Controls.Add(this.Suchen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.To);
            this.Controls.Add(this.From);
            this.Controls.Add(this.Verbindungen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox Verbindungen;
        private System.Windows.Forms.ComboBox From;
        private System.Windows.Forms.ComboBox To;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Suchen;
        private System.Windows.Forms.Button Fahrplan;
    }
}

