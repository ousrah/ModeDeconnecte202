using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModeDeconnecte202
{
    public partial class FrmConsultation2 : Form
    {
        BindingSource bsPatient;
        BindingSource bsConsultation;
        public FrmConsultation2()
        {
            InitializeComponent();
        }

        private void FrmConsultation2_Load(object sender, EventArgs e)
        {
            bsPatient = db.remplirListe("patient");
            comboBox1.DisplayMember = "nom";
            comboBox1.ValueMember = "id";
            comboBox1.DataSource = bsPatient;

            bsConsultation = db.remplirListeRelation("consultation", bsPatient, "id", "idPatient");
            listBox1.DisplayMember = "dateConsultation";
            listBox1.ValueMember = "id";
            listBox1.DataSource = bsConsultation;

            txtDC.DataBindings.Add("Text", bsConsultation, "dateConsultation");
            txtDescription.DataBindings.Add("Text", bsConsultation, "observation");


        }

        private void txtDC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dtpDC.Value = Convert.ToDateTime(txtDC.Text);
            }
            catch (Exception ex) { }
        }

        private void dtpDC_ValueChanged(object sender, EventArgs e)
        {
            txtDC.Text = dtpDC.Value.ToString();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            bsConsultation.AddNew();
            txtDC.Text = DateTime.Now.ToString();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            bsConsultation.EndEdit();
            db.MiseAJour("Consultation");
        }
    }
}
