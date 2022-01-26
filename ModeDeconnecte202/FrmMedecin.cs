using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace ModeDeconnecte202
{
    public partial class FrmMedecin : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand com = new SqlCommand();
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        BindingSource bs = new BindingSource();
        public FrmMedecin()
        {
            InitializeComponent();
        }
        private void FrmMedecin_Load(object sender, EventArgs e)
        {
            //configuration de la chaine de connection
            //string cs = @"data source=.\sqlexpress2008;initial catalog=CabinetMedecin;user id=sa;password=P@ssw0rd";
            //string cs = @"data source=.\sqlexpress2008;initial catalog=CabinetMedecin;integrated security=true";
            string cs = ConfigurationManager.ConnectionStrings["cabinetMedecinConnectionString"].ConnectionString;
            cn.ConnectionString = cs;
            cn.Open();
            com.Connection = cn;
            com.CommandText = "select * from medecin";
            //remplissage de la data set
            da = new SqlDataAdapter(com);
            da.Fill(ds, "medecin");
            //configuration de la binding source
            bs.DataSource = ds;
            bs.DataMember = "medecin";
            //affichage de la liste box
            lstMedecins.DisplayMember = "nom";
            lstMedecins.ValueMember = "id";
            lstMedecins.DataSource = bs;
            //affichage des zones de texte
            lblId.DataBindings.Add("Text", bs, "id");
            txtnom.DataBindings.Add("Text", bs, "nom");
            txtnom.DataBindings.Add("Tag", bs, "id");
            txtprenom.DataBindings.Add("Text", bs, "prenom");
            //  MessageBox.Show("ça marche");
        }
        private void btnSuivant_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }
        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }
        private void btnChercher_Click(object sender, EventArgs e)
        {
            bs.Filter = "nom like '%" + txtChercher.Text + "%'";
        }
    }
}
