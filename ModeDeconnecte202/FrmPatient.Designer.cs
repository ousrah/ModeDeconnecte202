namespace ModeDeconnecte202
{
    partial class FrmPatient
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
            this.lblId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnChercher = new System.Windows.Forms.Button();
            this.txtChercher = new System.Windows.Forms.TextBox();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.lstPatients = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(759, 77);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 24);
            this.lblId.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Code :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Prénom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nom :";
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(279, 425);
            this.btnSuivant.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(103, 48);
            this.btnSuivant.TabIndex = 17;
            this.btnSuivant.Text = ">";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(88, 426);
            this.btnPrecedent.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(103, 48);
            this.btnPrecedent.TabIndex = 16;
            this.btnPrecedent.Text = "<";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // btnChercher
            // 
            this.btnChercher.Location = new System.Drawing.Point(330, 12);
            this.btnChercher.Margin = new System.Windows.Forms.Padding(4);
            this.btnChercher.Name = "btnChercher";
            this.btnChercher.Size = new System.Drawing.Size(140, 47);
            this.btnChercher.TabIndex = 15;
            this.btnChercher.Text = "Chercher";
            this.btnChercher.UseVisualStyleBackColor = true;
            this.btnChercher.Click += new System.EventHandler(this.btnChercher_Click);
            // 
            // txtChercher
            // 
            this.txtChercher.Location = new System.Drawing.Point(16, 16);
            this.txtChercher.Margin = new System.Windows.Forms.Padding(4);
            this.txtChercher.Name = "txtChercher";
            this.txtChercher.Size = new System.Drawing.Size(304, 28);
            this.txtChercher.TabIndex = 14;
            // 
            // txtprenom
            // 
            this.txtprenom.Location = new System.Drawing.Point(764, 169);
            this.txtprenom.Margin = new System.Windows.Forms.Padding(4);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(249, 28);
            this.txtprenom.TabIndex = 13;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(764, 121);
            this.txtnom.Margin = new System.Windows.Forms.Padding(4);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(249, 28);
            this.txtnom.TabIndex = 12;
            // 
            // lstPatients
            // 
            this.lstPatients.FormattingEnabled = true;
            this.lstPatients.ItemHeight = 22;
            this.lstPatients.Location = new System.Drawing.Point(16, 77);
            this.lstPatients.Margin = new System.Windows.Forms.Padding(6);
            this.lstPatients.Name = "lstPatients";
            this.lstPatients.Size = new System.Drawing.Size(452, 334);
            this.lstPatients.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(534, 273);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "E-mail :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(534, 221);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "Téléphone  :";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(763, 269);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(249, 28);
            this.txtemail.TabIndex = 25;
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(763, 221);
            this.txttel.Margin = new System.Windows.Forms.Padding(4);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(249, 28);
            this.txttel.TabIndex = 24;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(551, 363);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(103, 48);
            this.btnAjouter.TabIndex = 28;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(620, 426);
            this.btnValider.Margin = new System.Windows.Forms.Padding(4);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(103, 48);
            this.btnValider.TabIndex = 29;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(883, 363);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(145, 48);
            this.btnSupprimer.TabIndex = 30;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // FrmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 536);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.btnPrecedent);
            this.Controls.Add(this.btnChercher);
            this.Controls.Add(this.txtChercher);
            this.Controls.Add(this.txtprenom);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.lstPatients);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPatient";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPatient_FormClosing);
            this.Load += new System.EventHandler(this.FrmPatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnChercher;
        private System.Windows.Forms.TextBox txtChercher;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.ListBox lstPatients;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnSupprimer;
    }
}