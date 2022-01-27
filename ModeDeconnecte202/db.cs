using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace ModeDeconnecte202
{
    static class db
    {
        static SqlConnection cn = new SqlConnection();
        static DataSet ds = new DataSet();

        static SqlCommand com = new SqlCommand();
        static SqlDataAdapter da = new SqlDataAdapter();

        static SqlCommandBuilder cb = new SqlCommandBuilder();
        public static void OuvrirConnection()
        {
            if (cn.State != ConnectionState.Open)
            {
                cn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["cabinetMedecinConnectionString"].ConnectionString;
                cn.Open();
            }
        }
        public static void FermerConnection()
        {
            if (cn.State != ConnectionState.Closed)
                cn.Close();
        }
        public static BindingSource remplirListe(string req, string table)
        {
            OuvrirConnection();
            com.CommandText = req;
            com.Connection = cn;
            da.SelectCommand = com;

            /*   foreach(DataTable t in ds.Tables)
                      {
                          t.Constraints.Clear();
                      }
            */
          
            ds.EnforceConstraints = false;
            if (ds.Tables.Contains(table))
                ds.Tables[table].Clear();
            da.Fill(ds, table);
            ds.EnforceConstraints = true;

            BindingSource bs = new BindingSource();
            bs.DataSource = ds;
            bs.DataMember = table;
            return bs;

        }

        public static BindingSource remplirListeRelation(string req, string table, BindingSource bsPk, string pk, string fk)
        {
            OuvrirConnection();
            com.CommandText = req;
            com.Connection = cn;
            da.SelectCommand = com;
            ds.EnforceConstraints = false;
            if (ds.Tables.Contains(table))
                          ds.Tables[table].Clear();
            da.Fill(ds, table);
            ds.EnforceConstraints = true;
            string relation = "rel_" + table + "_" + bsPk.DataMember;
            DataColumn colPK = ds.Tables[bsPk.DataMember].Columns[pk];
            DataColumn colFK = ds.Tables[table].Columns[fk];
            DataRelation rel = new DataRelation(relation, colPK, colFK);

            if (!ds.Relations.Contains(relation))
                ds.Relations.Add(rel);

            BindingSource bs = new BindingSource();
            bs.DataSource = bsPk;
            bs.DataMember = relation;
            return bs;

        }

        public static void miseAJour(string table)
        {
            OuvrirConnection();
            com.CommandText = "select * from " + table;
            com.Connection = cn;
            da.SelectCommand = com;
            cb.DataAdapter = da;
            da.Update(ds.Tables[table]);

        }


    }
}
