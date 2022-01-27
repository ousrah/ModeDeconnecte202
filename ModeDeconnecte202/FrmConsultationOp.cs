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
    public partial class FrmConsultationOp : Form
    {
        public FrmConsultationOp()
        {
            InitializeComponent();
        }

        private BindingSource bsPatient;
        private BindingSource bsConsultation;

        private void FrmConsultationOp_Load(object sender, EventArgs e)
        {

            bsPatient = db.remplirListe("select * from patient", "patient");
            bsConsultation = db.remplirListeRelation("select * from consultation", "consultation", bsPatient, "id", "idpatient");

            listBox1.DisplayMember = "nom";
            listBox1.ValueMember = "id";
            listBox1.DataSource = bsPatient;

            dataGridView1.DataSource = bsConsultation;

            textBox1.DataBindings.Add("text", bsPatient, "nom");
            textBox2.DataBindings.Add("text", bsPatient, "prenom");
            textBox3.DataBindings.Add("text", bsPatient, "telephone");
            textBox4.DataBindings.Add("text", bsPatient, "email");

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            bsPatient.AddNew();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            bsPatient.EndEdit();
            db.miseAJour("patient");

        }
    }
}
