using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace ModeDeconnecte202
{

    static class db
    {
        public static SqlConnection cn = new SqlConnection();
        public static DataSet ds = new DataSet();



        public static SqlCommand com = new SqlCommand();
        public static SqlDataAdapter da = new SqlDataAdapter();
        public static SqlCommandBuilder cb = new SqlCommandBuilder();

        public static void ouvrirConnection()
        {
            if (cn.State != ConnectionState.Open)
            {
                string cs = ConfigurationManager.ConnectionStrings["cabinetMedecinConnectionString"].ConnectionString;
                cn.ConnectionString = cs;
                cn.Open();
            }
        }

        public static void creerTable(string table)
        {

            creerTable("select * from " + table, table);
        }

        public static void creerTable(string req, string table)
        {
            ouvrirConnection();
            com.Connection = cn;
            com.CommandText = req;
            da.SelectCommand = com;
            if (ds.Tables.Contains(table))
            {
                ds.EnforceConstraints = false;
                ds.Tables[table].Clear();
            }
            da.Fill(ds, table);
            ds.EnforceConstraints = true;
        }


        public static void creerRelation(string tableP, string tableF, string pk, string fk)
        {
            ouvrirConnection();
            string nomRelation = "fk_" + tableF + "_" + tableP;
            DataColumn colPK = ds.Tables[tableP].Columns[pk];
            DataColumn colFK = ds.Tables[tableF].Columns[fk];
            DataRelation r = new DataRelation(nomRelation, colPK, colFK);

            if (!ds.Relations.Contains(nomRelation))
                ds.Relations.Add(r);


        }


        public static BindingSource remplirListe(string table)
        {
            return remplirListe("select * from " + table, table);
        }
            public static BindingSource remplirListe(string req, string table)
        {
            ouvrirConnection();
            com.Connection = cn;
            com.CommandText = req;
            da.SelectCommand = com;
            if (ds.Tables.Contains(table))
            { 
                ds.EnforceConstraints = false;
                ds.Tables[table].Clear();
               
            }

            da.Fill(ds, table);
            ds.EnforceConstraints = true;

            BindingSource bs = new BindingSource();

            bs.DataSource = ds;
            bs.DataMember = table;
            return bs;
        }

        public static BindingSource remplirListeRelation( string table, BindingSource bsPk, string pk, string fk)
        {
            return remplirListeRelation("select * from " + table, table, bsPk, pk, fk);
        }
            public static BindingSource remplirListeRelation(string req, string table, BindingSource bsPk, string pk, string fk)
        {
            ouvrirConnection();
            com.Connection = cn;
            com.CommandText = req;
            da.SelectCommand = com;

            if (ds.Tables.Contains(table))
            {
                ds.EnforceConstraints = false;
                ds.Tables[table].Clear();
            }

            da.Fill(ds, table);
            ds.EnforceConstraints = true;

            string nomRelation = "fk_" + table + "_" + bsPk.DataMember;
            DataColumn colPK = ds.Tables[bsPk.DataMember].Columns[pk];
            DataColumn colFK = ds.Tables[table].Columns[fk];
            DataRelation r = new DataRelation(nomRelation, colPK, colFK);

          //  r.ChildKeyConstraint.DeleteRule = Rule.Cascade;
          //  r.ChildKeyConstraint.UpdateRule = Rule.Cascade;


            if (! ds.Relations.Contains(nomRelation))
            ds.Relations.Add(r);

            BindingSource bs = new BindingSource();

            bs.DataSource = bsPk;
            bs.DataMember = nomRelation;
            return bs;


        }
        public static void executer(string req)
        {
            ouvrirConnection();
            com = new SqlCommand(req, cn);
            com.ExecuteNonQuery();
        }

        public static void MiseAJour(string table)
        {
            ouvrirConnection();
            com = new SqlCommand("select * from " + table,cn);
            da = new SqlDataAdapter(com);
            cb = new SqlCommandBuilder(da);
            da.Update(ds.Tables[table]);
            creerTable(table);
            

        }


    }
}
