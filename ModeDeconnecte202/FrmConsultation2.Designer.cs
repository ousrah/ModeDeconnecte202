
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
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(37, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(383, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(37, 116);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(383, 356);
            this.listBox1.TabIndex = 1;
            // 
            // dtpDC
            // 
            this.dtpDC.Location = new System.Drawing.Point(476, 142);
            this.dtpDC.Name = "dtpDC";
            this.dtpDC.Size = new System.Drawing.Size(394, 22);
            this.dtpDC.TabIndex = 2;
            this.dtpDC.ValueChanged += new System.EventHandler(this.dtpDC_ValueChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(476, 181);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(394, 188);
            this.txtDescription.TabIndex = 3;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(487, 400);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(557, 449);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 5;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(647, 70);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(100, 22);
            this.txtDC.TabIndex = 6;
            this.txtDC.TextChanged += new System.EventHandler(this.txtDC_TextChanged);
            // 
            // FrmConsultation2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 638);
            this.Controls.Add(this.txtDC);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.dtpDC);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "FrmConsultation2";
            this.Text = "FrmConsultation2";
            this.Load += new System.EventHandler(this.FrmConsultation2_Load);
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
    }
}