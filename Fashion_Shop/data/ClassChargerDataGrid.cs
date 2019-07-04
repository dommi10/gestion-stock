using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections;

namespace Fashion_Shop.data
{
    class ClassChargerDataGrid : data.ClassConfig
    {
        public static ClassChargerDataGrid objet;

        public static ClassChargerDataGrid GetInstance ()
        {
            if(objet == null)
            {
                objet = new ClassChargerDataGrid();
            }
            return objet;
                
        }

        public DataTable chargerArticle()
        {
            Article art = new Article();
            DataTable dt = new DataTable();

            try
            {
                if (createCommand())
                {
                    String sql = "select *from " + ClassConstantes.Table.Table_Article+" ORDER BY CODE DESC";
                    cm.CommandText = sql;
                    dataAdapter = new SqlDataAdapter(cm);
                    dataAdapter.Fill(dt);

                    
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
            return dt;
        }
        public DataTable chargerFournisseur() 
        {
            Article art = new Article();
            DataTable dt = new DataTable();

            try
            {
                if (createCommand())
                {
                    String sql = "select *from " + ClassConstantes.Table.View_Fournissseur+" ORDER BY nom ASC";
                    cm.CommandText = sql;
                    dataAdapter = new SqlDataAdapter(cm);
                    dataAdapter.Fill(dt);


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
            return dt;
        
        }
        public DataTable chargerClient() 
        {

                DataTable dt = new DataTable();
                SqlDataAdapter da;

                try
                {
                    if (createCommand())
                    {
                        String sql = "select *from " + ClassConstantes.Table.View_Client +" ORDER BY nom DESC";
                        cm.CommandText = sql;
                        cm.ExecuteNonQuery();
                        da = new SqlDataAdapter(cm);
                        da.Fill(dt);
                        


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
                return dt;

            }
        
        
        public DataTable chargerSortie() 
        {
            DataTable dt = new DataTable();
            
            try
            {
                if (createCommand())
                {
                    String sql = "Select *from " + ClassConstantes.Table.View_sortie + " order by Date_ Desc";
                    cm.CommandText = sql;
                    cm.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter(cm);
                    da.Fill(dt);
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
            return dt;
        }
        public DataTable chargerEntree() 
        {
            try
            {
                if (createCommand())
                {
                    String sql = "select *from " + ClassConstantes.Table.View_Entree +" ORDER By Article";
                    cm.CommandText = sql;
                    dataAdapter = new SqlDataAdapter(cm);
                    dt = new DataTable();
                    dataAdapter.Fill(dt);
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                dt.Dispose();
                Dispose();
            }
            return dt;
        }
        public void chargerVente(DataGridView grid) 
        {
            try
            {
                if (createCommand())
                {
                    String sql = "select *from " + ClassConstantes.Table.View_vente;
                    cm.CommandText = sql;
                    dataAdapter = new SqlDataAdapter(cm);
                    dt = new DataTable();
                    dataAdapter.Fill(dt);
                    grid.DataSource = dataAdapter;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable chargerCommande() 
        {
            try
            {
                if (createCommand())
                {
                    String sql = "select *from " + ClassConstantes.Table.View_Commande;
                    cm.CommandText = sql;
                    dataAdapter = new SqlDataAdapter(cm);
                    dt = new DataTable();
                    dataAdapter.Fill(dt);
                    
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
            return dt;
        }
        public DataTable chargerCommande1()
        {
            try
            {
                if (createCommand())
                {
                    String sql = "select *from " + ClassConstantes.Table.View_Commande1;
                    cm.CommandText = sql;
                    dataAdapter = new SqlDataAdapter(cm);
                    dt = new DataTable();
                    dataAdapter.Fill(dt);

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
            return dt;
        }

        public void chargerLigneCommande(DataGridView grid) 
        {
            try
            {
                if (createCommand())
                {
                    String sql = "select *from " + ClassConstantes.Table.View_LigneC;
                    cm.CommandText = sql;
                    dataAdapter = new SqlDataAdapter(cm);
                    dt = new DataTable();
                    dataAdapter.Fill(dt);
                    grid.DataSource = dataAdapter;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DataTable chargerEmploye() 
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;

            try
            {
                if (createCommand())
                {
                    String sql = "select *from " + ClassConstantes.Table.View_Employe + " ORDER BY Nom ASC";
                    cm.CommandText = sql;
                    cm.ExecuteNonQuery();
                    da = new SqlDataAdapter(cm);
                    da.Fill(dt);



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
            return dt;
        }
        
        public DataTable chargerUtilisateur() 
        {
            try
            {
                if (createCommand())
                {
                    String sql = "select *from " + ClassConstantes.Table.View_users;
                    cm.CommandText = sql;
                    dataAdapter = new SqlDataAdapter(cm);
                    dt = new DataTable();
                    dataAdapter.Fill(dt);
                    
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
            return dt;
        }
    }
}
