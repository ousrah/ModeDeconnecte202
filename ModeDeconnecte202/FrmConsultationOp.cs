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
        private void FrmConsultationOp_Load(object sender, EventArgs e)
        {
            listBox1.DisplayMember = "nom";
            listBox1.ValueMember = "id";
            bsPatient = db.remplirListe("select * from patient", "patient");

            listBox1.DataSource = bsPatient;
            listBox2.DisplayMember = "nom";
            listBox2.ValueMember = "id";
            listBox2.DataSource = db.remplirListe("select * from medecin", "medecin");

            comboBox1.DisplayMember = "nom";
            comboBox1.ValueMember = "id";
            comboBox1.DataSource = db.remplirListe("select * from medicament", "medicament");

            dataGridView1.DataSource = bsPatient;

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
