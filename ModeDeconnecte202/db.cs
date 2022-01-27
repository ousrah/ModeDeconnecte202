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
            
            if (ds.Tables.Contains(table))
                ds.Tables[table].Clear();

            da.Fill(ds, table);

            BindingSource bs = new BindingSource();
            bs.DataSource = ds;
            bs.DataMember = table;
            return bs;

        }



    }
}
