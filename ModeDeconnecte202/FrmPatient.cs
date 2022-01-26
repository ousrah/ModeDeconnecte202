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
        SqlConnection cn = new SqlConnection();
        DataSet ds = new DataSet();
        SqlCommand com ;
        SqlDataAdapter da;
        BindingSource bs = new BindingSource();
       SqlCommandBuilder cb;
        bool isSaved = true;
        public FrmPatient()
        {
            InitializeComponent();
        }
        private void FrmPatient_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["cabinetMedecinConnectionString"].ConnectionString;
            cn.Open();
//            com = new SqlCommand("select *, isnull(nom,'') + ' ' + isnull(prenom,' ') as nomComplet from patient",cn);
            com = new SqlCommand("select * from patient", cn);
            da = new SqlDataAdapter(com);
            cb = new SqlCommandBuilder(da);
            da.Fill(ds, "patient");
            bs.DataSource = ds;
            bs.DataMember = "patient";
        //    dataGridView1.DataSource = bs;
            lstPatients.DisplayMember = "nom";
            lstPatients.ValueMember = "id";
            lstPatients.DataSource = bs;
       //     comboBox1.DisplayMember = "nom";
       //     comboBox1.ValueMember = "id";
       //     comboBox1.DataSource = bs;
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
            bs.EndEdit();
            isSaved = false;
        }
        private void FrmPatient_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!isSaved)
                if (MessageBox.Show("Voulez vous enregistrer les modification?","Enregistrement",MessageBoxButtons.YesNo)==DialogResult.Yes)
                    da.Update(ds.Tables["patient"]);
        }
    }
}
