namespace ModeDeconnecte202
{
    partial class FrmConsultation
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
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnChercher = new System.Windows.Forms.Button();
            this.txtChercher = new System.Windows.Forms.TextBox();
            this.lstPatients = new System.Windows.Forms.ListBox();
            this.lstConsultations = new System.Windows.Forms.ListBox();
            this.dtpDateConsultation = new System.Windows.Forms.DateTimePicker();
            this.txtObservation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(291, 505);
            this.btnSuivant.Margin = new System.Windows.Forms.Padding(6);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(69, 44);
            this.btnSuivant.TabIndex = 22;
            this.btnSuivant.Text = ">";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(2, 505);
            this.btnPrecedent.Margin = new System.Windows.Forms.Padding(6);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(69, 44);
            this.btnPrecedent.TabIndex = 21;
            this.btnPrecedent.Text = "<";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // btnChercher
            // 
            this.btnChercher.Location = new System.Drawing.Point(248, 15);
            this.btnChercher.Margin = new System.Windows.Forms.Padding(6);
            this.btnChercher.Name = "btnChercher";
            this.btnChercher.Size = new System.Drawing.Size(112, 34);
            this.btnChercher.TabIndex = 20;
            this.btnChercher.Text = "Chercher";
            this.btnChercher.UseVisualStyleBackColor = true;
            this.btnChercher.Click += new System.EventHandler(this.btnChercher_Click);
            // 
            // txtChercher
            // 
            this.txtChercher.Location = new System.Drawing.Point(2, 15);
            this.txtChercher.Margin = new System.Windows.Forms.Padding(6);
            this.txtChercher.Name = "txtChercher";
            this.txtChercher.Size = new System.Drawing.Size(234, 28);
            this.txtChercher.TabIndex = 19;
            // 
            // lstPatients
            // 
            this.lstPatients.FormattingEnabled = true;
            this.lstPatients.ItemHeight = 22;
            this.lstPatients.Location = new System.Drawing.Point(2, 57);
            this.lstPatients.Margin = new System.Windows.Forms.Padding(8);
            this.lstPatients.Name = "lstPatients";
            this.lstPatients.Size = new System.Drawing.Size(358, 444);
            this.lstPatients.TabIndex = 18;
            // 
            // lstConsultations
            // 
            this.lstConsultations.FormattingEnabled = true;
            this.lstConsultations.ItemHeight = 22;
            this.lstConsultations.Location = new System.Drawing.Point(376, 57);
            this.lstConsultations.Margin = new System.Windows.Forms.Padding(8);
            this.lstConsultations.Name = "lstConsultations";
            this.lstConsultations.Size = new System.Drawing.Size(358, 444);
            this.lstConsultations.TabIndex = 23;
            // 
            // dtpDateConsultation
            // 
            this.dtpDateConsultation.Location = new System.Drawing.Point(786, 119);
            this.dtpDateConsultation.Name = "dtpDateConsultation";
            this.dtpDateConsultation.Size = new System.Drawing.Size(396, 28);
            this.dtpDateConsultation.TabIndex = 24;
            // 
            // txtObservation
            // 
            this.txtObservation.Location = new System.Drawing.Point(786, 181);
            this.txtObservation.Multiline = true;
            this.txtObservation.Name = "txtObservation";
            this.txtObservation.Size = new System.Drawing.Size(402, 223);
            this.txtObservation.TabIndex = 25;
            // 
            // FrmConsultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 568);
            this.Controls.Add(this.txtObservation);
            this.Controls.Add(this.dtpDateConsultation);
            this.Controls.Add(this.lstConsultations);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.btnPrecedent);
            this.Controls.Add(this.btnChercher);
            this.Controls.Add(this.txtChercher);
            this.Controls.Add(this.lstPatients);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmConsultation";
            this.Text = "FrmConsultation";
            this.Load += new System.EventHandler(this.FrmConsultation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnChercher;
        private System.Windows.Forms.TextBox txtChercher;
        private System.Windows.Forms.ListBox lstPatients;
        private System.Windows.Forms.ListBox lstConsultations;
        private System.Windows.Forms.DateTimePicker dtpDateConsultation;
        private System.Windows.Forms.TextBox txtObservation;
    }
}