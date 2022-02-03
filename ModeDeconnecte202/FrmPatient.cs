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
    public partial class FrmPatient : Form
    {
       
        BindingSource bs;
    
        bool isSaved = true;
        public FrmPatient()
        {
            InitializeComponent();
        }
        private void FrmPatient_Load(object sender, EventArgs e)
        {
            bs = db.remplirListe("patient");
            lstPatients.DisplayMember = "nom";
            lstPatients.ValueMember = "id";
            lstPatients.DataSource = bs;
    
            txtnom.DataBindings.Add("Text", bs, "nom");
            txtprenom.DataBindings.Add("Text", bs, "prenom");
            txttel.DataBindings.Add("Text", bs, "telephone");
            txtemail.DataBindings.Add("Text", bs, "email");
        }
        private void btnChercher_Click(object sender, EventArgs e)
        {
            bs.Filter = "nom like '%" + txtChercher.Text + "%'";
        }
        private void btnSuivant_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }
        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            bs.AddNew();
        }
        private void btnValider_Click(object sender, EventArgs e)
        {
            int i = lstPatients.SelectedIndex;
            bs.EndEdit();
            db.MiseAJour("patient");
            lstPatients.SelectedIndex = i;
        }
        private void FrmPatient_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!isSaved)
                if (MessageBox.Show("Voulez vous enregistrer les modification?","Enregistrement",MessageBoxButtons.YesNo)==DialogResult.Yes)
                    db.MiseAJour("patient");
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("La suppression d'un patient entrainera la suppression de toutes les données connexion!!!, Etes vous cerain de la supprimer?","Suppression",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                db.ds.Relations["fk_consultation_patient"].ChildKeyConstraint.DeleteRule = Rule.Cascade;
               bs.RemoveCurrent();
               db.MiseAJour("consultation");
                db.MiseAJour("patient");
                db.ds.Relations["fk_consultation_patient"].ChildKeyConstraint.DeleteRule = Rule.None;


            }
        }
    }
}
