using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Fashion_Shop.data
{
    class ClassCommande : data.ClassConfig
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public int quantite { get; set; }
        public String Etat { get; set; }
        public ListView ligne;
        int quanti;
        public static ClassCommande objet { get; set; }

        public static ClassCommande GetInstance() 
        {
            if (objet == null)
                objet = new ClassCommande();
            return objet;
        }

        public Boolean addCommand() 
        {
            bool p = false;
            try 
            {
                if (createCommand()) 
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "addCommand";
                    SqlParameter param = new SqlParameter("@idout", DbType.Int32);
                    
                    setParametre(cm, "@id", DbType.Int32, Int32.MaxValue, id);
                    setParametre(cm, "@dateLivraison", DbType.DateTime, 50, date);
                    setParametre(cm, "@etat", DbType.String, 30, Etat);
                    setParametre(cm, "@quantite", DbType.Int32, Int32.MaxValue, quantite);
                    param.Direction = ParameterDirection.Output;
                    cm.Parameters.Add(param);
                    cm.ExecuteNonQuery();
                    if(id == 0)
                        id = int.Parse(param.Value.ToString());
                    
                    ClassLigneCommande.GetInstance().commandeId = id;
                    ClassLigneCommande.GetInstance().ligne = ligne;
                    if(ClassLigneCommande.GetInstance().addLigne())
                        p = true;

                }
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
            finally 
            {
                Dispose();
            }
            return p;
        }

        public void addDetails() 
        {
            String[] row = null;
            try
            {

                if (createCommand())
                {

                    String sql = "select *from " + ClassConstantes.Table.View_LigneC + " where refComande =" + id;
                    cm.CommandText = sql;
                    dr = cm.ExecuteReader();
                    ligne.Items.Clear();
                    while (dr.Read())
                    {
                        row = new String[]{
                            
                            dr.GetValue(1).ToString(),
                            dr.GetValue(2).ToString(),
                            dr.GetValue(3).ToString(),
                            dr.GetValue(4).ToString(),
                            dr.GetValue(5).ToString(),
                            dr.GetValue(6).ToString(),
                            dr.GetValue(7).ToString(),
                            dr.GetValue(8).ToString()
                           
                        };

                        ligne.Items.Add(new ListViewItem(row));
                        
                    }

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                dr.Dispose();
                Dispose();
            }
        
        }
        public void addDetails1()
        {
            String[] row = null;
            try
            {

                if (createCommand())
                {

                    String sql = "select *from " + ClassConstantes.Table.View_LigneF + " where refComande =" + id;
                    cm.CommandText = sql;
                    dr = cm.ExecuteReader();
                    ligne.Items.Clear();
                    while (dr.Read())
                    {
                        row = new String[]{
                            
                            dr.GetValue(1).ToString(),
                            dr.GetValue(2).ToString(),
                            dr.GetValue(3).ToString(),
                            dr.GetValue(4).ToString(),
                            dr.GetValue(5).ToString(),
                            dr.GetValue(6).ToString(),
                            dr.GetValue(7).ToString(),
                            dr.GetValue(8).ToString()
                           
                        };

                        ligne.Items.Add(new ListViewItem(row));

                    }

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                dr.Dispose();
                Dispose();
            }

        }
        public Boolean deletQuantie()
        {
            bool p = false;
            getQuantite();
            try
            {
                if (createCommand())
                {
                    String sql = "Update " + ClassConstantes.Table.Table_Commande + " set quantite= " + (quanti - quantite) + " where commandeId=" + id;
                    cm.CommandText = sql;
                    cm.ExecuteNonQuery();
                    p = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Dispose();
            }
            return p;
        }
        public void getQuantite()
        {
            try
            {
                if (createCommand())
                {
                    String sql = "select quantite from " + ClassConstantes.Table.Table_Commande + " where commandeId=" + id;
                    cm.CommandText = sql;
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        quanti = int.Parse(dr.GetValue(0).ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Dispose();
            }
        }
        public Boolean delete()
        {
            bool p = false;
            try
            {
                if (createCommand())
                {
                    String sql = "Delete from " + ClassConstantes.Table.Table_Commande + " where commandeId=" + id;
                    cm.CommandText = sql;
                    cm.ExecuteNonQuery();
                    p = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Dispose();
            }
            return p;
        }
    }
}
