using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace ModeDeconnecte202
{
    //pour enlever les lignes vides
    /*
     ^(?([^\r\n])\s)*\r?$\r?\n
    */

    public partial class FrmConsultation : Form
    {
        SqlConnection cn = new SqlConnection();
        DataSet ds = new DataSet();

        SqlCommand comP;
        SqlDataAdapter daP;
        BindingSource bsP = new BindingSource();

        SqlCommand comC;
        SqlDataAdapter daC;
        BindingSource bsC = new BindingSource();

        SqlCommandBuilder cb;
        public FrmConsultation()
        {
            InitializeComponent();
        }
        private void FrmConsultation_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["cabinetMedecinConnectionString"].ConnectionString;
            cn.Open();
            //Gestion des patients
            comP = new SqlCommand("select * from patient", cn);
            daP = new SqlDataAdapter(comP);
            //           cb = new SqlCommandBuilder(da);
            daP.Fill(ds, "patient");
            bsP.DataSource = ds;
            bsP.DataMember = "patient";
            lstPatients.DisplayMember = "nom";
            lstPatients.ValueMember = "id";
            lstPatients.DataSource = bsP;

            //Gestion des Consultations
            comC = new SqlCommand("select * from consultation order by dateConsultation desc", cn);
            daC = new SqlDataAdapter(comC);
            cb = new SqlCommandBuilder(daC);
            daC.Fill(ds, "consultation");


            DataColumn idPatient = ds.Tables["patient"].Columns["id"];
            DataColumn idPatientConsultation = ds.Tables["consultation"].Columns["idPatient"];
            DataRelation rel_consultation_patient = new DataRelation("fk_consultation_patient", idPatient, idPatientConsultation);
            ds.Relations.Add(rel_consultation_patient);



            bsC.DataSource = bsP;
            bsC.DataMember = "fk_consultation_patient";

            lstConsultations.DisplayMember = "dateConsultation";
            lstConsultations.ValueMember = "id";
            lstConsultations.DataSource = bsC;

            txtDC.DataBindings.Add("Text", bsC, "dateConsultation");
            txtObservation.DataBindings.Add("Text", bsC, "observation");






        }
        private void btnChercher_Click(object sender, EventArgs e)
        {
            bsP.Filter = "nom like '%" + txtChercher.Text + "%'";
        }
        private void btnSuivant_Click(object sender, EventArgs e)
        {
            bsP.MoveNext();
        }
        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            bsP.MovePrevious();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            bsC.AddNew();
            txtDC.Text = DateTime.Now.ToString();

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            bsC.EndEdit();
            daC.Update(ds.Tables["consultation"]);
        }

        private void txtDC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dtpDateConsultation.Value = Convert.ToDateTime(txtDC.Text);
            }
            catch (Exception ex) { }
        }

        private void dtpDateConsultation_ValueChanged(object sender, EventArgs e)
        {
            txtDC.Text = dtpDateConsultation.Value.ToString();
        }
    }
}
