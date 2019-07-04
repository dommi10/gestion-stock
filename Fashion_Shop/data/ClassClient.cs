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
    class ClassClient : data.ClassConfig
    {
        public long clientId { get; set; }
        public String clientName { get; set; }
        public Char clientSexe { get; set; }
        public String clientAddress { get; set; }
        public String clientNumber { get; set; }
        public static ClassClient objet;

        public static ClassClient GetInstance() 
        {
            if (objet == null)
                objet = new ClassClient();
            return objet;
        }

        public Boolean addClient() 
        {
            try 
            {
                if (createCommand()) 
                {
                    cm.CommandText = "addClient";
                    cm.CommandType = CommandType.StoredProcedure;
                   
                        //setParametre(cm, "@id", DbType.Int64, 1000000, clientId);
                        setParametre(cm, "@nom", DbType.String, 30, clientName);
                        setParametre(cm, "@sexe", DbType.String, 1, clientSexe);
                        setParametre(cm, "@addresse", DbType.String, 100, clientAddress);
                        setParametre(cm, "@telephone", DbType.String, 30, clientNumber);
                        cm.ExecuteNonQuery();
                        return true;
                    
                    
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return false;
        
        }

        public Boolean delete(int id) 
        {
            try
             {
                if (createCommand()) 
                {
                    String sql = "Delete from "+ClassConstantes.Table.Table_Client+" where clientId = "+id;
                    cm.CommandText = sql;
                    cm.ExecuteNonQuery();
                        return true;
                    
                    
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return false;
        
        }

        public void GetClient(ComboBox combo) 
        {
            try
            {
                if (createCommand()) 
                {
                    String sql = "Select * from " + ClassConstantes.Table.VName_Client;
                    cm.CommandText = sql;
                    dr = cm.ExecuteReader();
                    while (dr.Read()) 
                    {
                        combo.Items.Add(dr.GetValue(0).ToString());
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

     


    }
}
