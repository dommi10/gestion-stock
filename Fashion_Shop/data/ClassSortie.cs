using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Fashion_Shop.data
{
    class ClassSortie : data.ClassConfig
    {
        public int sortieId { get; set; }
        public int quantite { get; set; }
        public DateTime date { get; set; }
        public String nomUtilisateur { get; set; }
        public ListView listview { get; set; }
        public int total;
        String username = null;
        int quanti;
       public decimal pri;
        public Boolean addSortie() 
        {
            bool p = false;
            try
            {
                if (createCommand()) 
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "addSortie";
                    SqlParameter param = new SqlParameter("@idout", SqlDbType.Int);
                    param.Direction = ParameterDirection.Output;
                    cm.Parameters.Add(param);
                    setParametre(cm, "@id", DbType.Int32, Int32.MaxValue, sortieId);
                    setParametre(cm, "@quantite", DbType.Int32, Int32.MaxValue, quantite);
                    setParametre(cm, "@dateSortie", DbType.DateTime, 50, date);
                    setParametre(cm, "@nomUtilisateur", DbType.String, 50, nomUtilisateur);
                    cm.ExecuteNonQuery();
                    sortieId = int.Parse(param.Value.ToString());
                    ClassVente.GetInstance().sortieId = sortieId;
                    ClassVente.GetInstance().listview = listview;
                    if(ClassVente.GetInstance().addVente())
                            p = true;
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally 
            {
                Dispose();
            }
            return p;
        }


        public void detailSortie() 
        {
            total = 0;
            pri = 0;
            String[] row=null;
            try
            {
               
                if (createCommand()) 
                {
                   
                    String sql = "select *from " + ClassConstantes.Table.View_vente + " where refSortie =" + sortieId+" ";
                    cm.CommandText = sql;
                    dr = cm.ExecuteReader();
                    username = getUtilisateur();
                    listview.Items.Clear();
                    while (dr.Read()) 
                    {
                        row = new String[]{
                            
                            dr.GetValue(1).ToString(),
                            dr.GetValue(2).ToString(),
                            dr.GetValue(3).ToString(),
                            dr.GetValue(4).ToString(),
                            dr.GetValue(7).ToString(),
                            dr.GetValue(5).ToString(),
                            dr.GetValue(6).ToString(),
                            username
                        };
                        
                        listview.Items.Add(new ListViewItem(row));
                        total += 1;
                        pri = pri + (Decimal.Parse(dr.GetValue(4).ToString()) * int.Parse(dr.GetValue(3).ToString()));
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
        public String getUtilisateur() 
        {
            SqlDataReader data;
            String user = String.Empty;
            try
            {
                if (createCommand()) 
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "getUser";
                    setParametre(cm, "@sortieid", DbType.Int32, Int32.MaxValue, sortieId);
                    data = cm.ExecuteReader();
                    while (data.Read()) 
                    {
                        user = data[0].ToString();
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
            return user;
        }
        public Boolean deletQuantie() 
        {
            bool p = false;
            getQuantite();
            try
            {
                if (createCommand()) 
                {
                    String sql = "Update " + ClassConstantes.Table.Table_sortie + " set quantiteSortie= " +( quanti - quantite)+" where sortieId="+sortieId;
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
                    String sql = "select quantiteSortie from " + ClassConstantes.Table.Table_sortie + " where sortieId=" + sortieId;
                    cm.CommandText = sql;
                    dr = cm.ExecuteReader();
                    while (dr.Read()) 
                    {
                        quanti =int.Parse(dr.GetValue(0).ToString());
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
                updateQuantite();
                if (createCommand()) 
                {
                    String sql = "Delete from " + ClassConstantes.Table.Table_sortie + " where sortieId=" + sortieId;
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
        public void updateQuantite() 
        {
            try
            {
                foreach (ListViewItem item in listview.Items)
                    {
                        ClassVente.GetInstance().VenteId = int.Parse(item.SubItems[0].Text);
                        ClassVente.GetInstance().quantite = int.Parse(item.SubItems[2].Text);
                        ClassVente.GetInstance().delete();
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
    }
}
