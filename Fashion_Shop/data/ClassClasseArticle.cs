using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fashion_Shop.data
{
    class Article : data.ClassConfig
    {

        public int id { get; set; }
        public String designation { get; set; }
        public String pays { get; set; }
        public String ville { get; set; }
        public DateTime date { get; set; }
        public DateTime dates { get; set; }
        public float qten { get; set; }
        public float qtein { get; set; }

        public static Article objet;

        public static Article GetInstance() 
        {
            if (objet == null)
            {
                objet = new Article();
            }
            return objet;
        }

        public Boolean addArctile() 
        {
            try
            {

                if (createCommand())
                {
                    cm.CommandText = "addARTICLE";
                    cm.CommandType = CommandType.StoredProcedure;
                    setParametre(cm, "@CODE", DbType.Int64, 100000, id);
                    setParametre(cm, "@DESIGNATION", DbType.String, 30, designation);
                    setParametre(cm, "@PAYSPROV", DbType.String, 100, pays);
                    setParametre(cm, "@VILLEPROV", DbType.String, 100, ville);
                    setParametre(cm, "@DATEEN", DbType.DateTime, 100, date);
                    setParametre(cm, "@DATESORT", DbType.DateTime, 100, dates);
                    setParametre(cm, "@QTEEN", DbType.Double, 100, qten);
                    setParametre(cm, "@QTEIN", DbType.Double, 100, qtein);
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

        public Boolean delete(int id) 
        {
            try
            {

                if (createCommand())
                {
                    String sql = "Delete from " + ClassConstantes.Table.Table_Article + " where code=" + id;
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

        public void getArtcle(ComboBox combo) 
        {
            try
            {
                if (createCommand()) 
                {
                    String sql = "Select nom from " + ClassConstantes.Table.VName_Article + " Order By nom ASC";
                    cm.CommandText = sql;
                    dr = cm.ExecuteReader();

                    while (dr.Read()) 
                    {
                        combo.Items.Add(dr.GetValue(0));
                    }
                    
                }
            
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dr.Dispose();
                Dispose();
            }
        
        }
        public void getArtcleV(ComboBox combo)
        {
            try
            {
                if (createCommand())
                {
                    String sql = "Select * from " + ClassConstantes.Table.Table_Article + " Order By designation ASC";
                    cm.CommandText = sql;
                    dr = cm.ExecuteReader();

                    while (dr.Read())
                    {
                        combo.Items.Add(dr.GetValue(1));
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


        

    }
}
