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
        BindingSource bsMedicament;
        BindingSource bsMPC = new BindingSource();
        BindingSource bsOrdonance;
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


            bsMedicament = db.remplirListe("medicament");
            lstMedicaments.DisplayMember = "nom";
            lstMedicaments.ValueMember = "id";
            lstMedicaments.DataSource = bsMedicament;


            bsConsultation = db.remplirListeRelation("consultation", bsPatient, "id", "idPatient");
            listBox1.DisplayMember = "dateConsultation";
            listBox1.ValueMember = "id";
            listBox1.DataSource = bsConsultation;

            txtDC.DataBindings.Add("Text", bsConsultation, "dateConsultation");
            txtDescription.DataBindings.Add("Text", bsConsultation, "observation");

    bsOrdonance = db.remplirListe("ordonance");
   lstMedicaments.DataBindings.Add("SelectedValue", bsOrdonance, "idMedicament");
            txtObsMedicament.DataBindings.Add("Text", bsOrdonance, "observation");



            string req = "select m.nom, o.observation, o.idConsultation, m.id   from ordonance o inner join medicament m on o.idMedicament = m.id";
            db.creerTable(req, "MedicamentsParConsultation");
            db.creerRelation("consultation", "MedicamentsParConsultation", "id", "idConsultation");
             
            bsMPC.DataSource = bsConsultation;
            bsMPC.DataMember = "fk_MedicamentsParConsultation_consultation";
            dgvOrdonance.DataSource = bsMPC;
            filtrer();
            dgvOrdonance.Columns[1].Width = 300;
            dgvOrdonance.Columns[2].Visible = false;
            dgvOrdonance.Columns[3].Visible = false;
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
            

            int i = listBox1.SelectedIndex;
            bsConsultation.EndEdit();
            db.MiseAJour("Consultation");
            listBox1.SelectedIndex = i;
        }



        private void filtrer()
        {
            string m = "";

            foreach(DataGridViewRow r in dgvOrdonance.Rows)
            {
                m += r.Cells[3].Value.ToString() + ",";

            }
            if (m != "")
                bsMedicament.Filter = "id not in (" + m + ")";
          else
            bsMedicament.Filter = "";

        }


        private void btnAjoutMedicament_Click(object sender, EventArgs e)
        {
            string req = "insert into ordonance values("+listBox1.SelectedValue.ToString()+","+lstMedicaments.SelectedValue.ToString()+",'"+ txtObsMedicament.Text.Replace("'","''")+"')";
            db.executer(req);
             req = "select m.nom, o.observation, o.idConsultation, m.id  from ordonance o inner join medicament m on o.idMedicament = m.id";
            db.creerTable(req, "MedicamentsParConsultation");

            filtrer();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrer();
        }
    }
}
