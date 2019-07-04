using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fashion_Shop.data
{
    class ClassFournisseur : data.ClassConfig
    {
        public int fournisseurId { get; set; }
        public String fournisseurName { get; set; }
        public String fournisseurPost { get; set; }
        public string fournisseurAddress { get; set; }
        public string fournisseurNumber { get; set; }

        public static ClassFournisseur objet;

        public static ClassFournisseur GetInstance() 
        {
            if (objet == null) 
            {
                objet = new ClassFournisseur();
            }
            return objet;
        
        
        }


        public Boolean addFournisseur() 
        {
            try
            {
                if (createCommand())
                {
                    cm.CommandText = "addFourn";
                    cm.CommandType = CommandType.StoredProcedure;

                    setParametre(cm, "@id", DbType.Int64, 1000000, fournisseurId);
                    setParametre(cm, "@nom", DbType.String, 30, fournisseurName);
                    setParametre(cm, "@postnom", DbType.String, 30, fournisseurPost);
                    setParametre(cm, "@addresse", DbType.String, 100, fournisseurAddress);
                    setParametre(cm, "@telephone", DbType.String, 30, fournisseurNumber);
                    cm.ExecuteNonQuery();
                    return true;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally 
            {
                cm.Dispose();
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }

            return false;
        }

        public Boolean getFournisseur(ComboBox combo) 
        {
            try
            {
                if (createCommand())
                {
                    String sql = "Select *from " + ClassConstantes.Table.VName_Fournisseur;
                    cm.CommandText = sql;
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        combo.Items.Add(dr.GetString(0));

                    }
                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cm.Dispose();
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return false;
        }

        public Boolean deleteFournisseur(int id) 
        {
            try
            {
                if (createCommand())
                {
                    String sql = "Delete from " + ClassConstantes.Table.Table_Fournisseur + " where fournisseurId=" + id;
                    cm.CommandText = sql;

                    cm.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally 
            {
                cm.Dispose();
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }

            return false;
        
        }
    }
}
