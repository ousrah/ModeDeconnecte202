
namespace ModeDeconnecte202
{
    partial class FrmConsultation2
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dtpDC = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.lstMedicaments = new System.Windows.Forms.ComboBox();
            this.txtObsMedicament = new System.Windows.Forms.TextBox();
            this.btnAjoutMedicament = new System.Windows.Forms.Button();
            this.dgvOrdonance = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdonance)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(23, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(383, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(23, 67);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(383, 356);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dtpDC
            // 
            this.dtpDC.Location = new System.Drawing.Point(23, 450);
            this.dtpDC.Name = "dtpDC";
            this.dtpDC.Size = new System.Drawing.Size(394, 22);
            this.dtpDC.TabIndex = 2;
            this.dtpDC.ValueChanged += new System.EventHandler(this.dtpDC_ValueChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(23, 478);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(394, 126);
            this.txtDescription.TabIndex = 3;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(23, 610);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(74, 650);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 5;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(211, 540);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(100, 22);
            this.txtDC.TabIndex = 6;
            this.txtDC.TextChanged += new System.EventHandler(this.txtDC_TextChanged);
            // 
            // lstMedicaments
            // 
            this.lstMedicaments.FormattingEnabled = true;
            this.lstMedicaments.Location = new System.Drawing.Point(455, 448);
            this.lstMedicaments.Name = "lstMedicaments";
            this.lstMedicaments.Size = new System.Drawing.Size(383, 24);
            this.lstMedicaments.TabIndex = 7;
            // 
            // txtObsMedicament
            // 
            this.txtObsMedicament.Location = new System.Drawing.Point(844, 448);
            this.txtObsMedicament.Multiline = true;
            this.txtObsMedicament.Name = "txtObsMedicament";
            this.txtObsMedicament.Size = new System.Drawing.Size(394, 66);
            this.txtObsMedicament.TabIndex = 8;
            // 
            // btnAjoutMedicament
            // 
            this.btnAjoutMedicament.Location = new System.Drawing.Point(1012, 520);
            this.btnAjoutMedicament.Name = "btnAjoutMedicament";
            this.btnAjoutMedicament.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutMedicament.TabIndex = 9;
            this.btnAjoutMedicament.Text = "Ajouter";
            this.btnAjoutMedicament.UseVisualStyleBackColor = true;
            this.btnAjoutMedicament.Click += new System.EventHandler(this.btnAjoutMedicament_Click);
            // 
            // dgvOrdonance
            // 
            this.dgvOrdonance.AllowUserToAddRows = false;
            this.dgvOrdonance.AllowUserToDeleteRows = false;
            this.dgvOrdonance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdonance.Location = new System.Drawing.Point(455, 67);
            this.dgvOrdonance.Name = "dgvOrdonance";
            this.dgvOrdonance.ReadOnly = true;
            this.dgvOrdonance.RowHeadersWidth = 51;
            this.dgvOrdonance.RowTemplate.Height = 24;
            this.dgvOrdonance.Size = new System.Drawing.Size(772, 356);
            this.dgvOrdonance.TabIndex = 10;
            // 
            // FrmConsultation2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 694);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.dgvOrdonance);
            this.Controls.Add(this.btnAjoutMedicament);
            this.Controls.Add(this.txtObsMedicament);
            this.Controls.Add(this.lstMedicaments);
            this.Controls.Add(this.txtDC);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dtpDC);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "FrmConsultation2";
            this.Text = "FrmConsultation2";
            this.Load += new System.EventHandler(this.FrmConsultation2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdonance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DateTimePicker dtpDC;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.ComboBox lstMedicaments;
        private System.Windows.Forms.TextBox txtObsMedicament;
        private System.Windows.Forms.Button btnAjoutMedicament;
        private System.Windows.Forms.DataGridView dgvOrdonance;
    }
}