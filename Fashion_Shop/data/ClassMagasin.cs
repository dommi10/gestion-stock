using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Fashion_Shop.data
{
    class ClassMagasin:data.ClassConfig
    {
        public static ClassMagasin objet;


        public static ClassMagasin GetInstance() 
        {
            if (objet == null)
                objet = new ClassMagasin();
            return objet;
            
        }
        public int quantite { get; set; }
        public String NomArticle { get; set; }
        public int quantitealarm { get; set; }
        public Boolean addMagasin() 
        {
            bool p = false;
            try 
            {
                if (createCommand()) 
                {
                    cm.CommandType = System.Data.CommandType.StoredProcedure;
                    cm.CommandText = "addMagasin";
                    setParametre(cm, "@quantite", DbType.Int32, Int32.MaxValue, quantite);
                    setParametre(cm, "@quantitealarm", DbType.Int16, 100, 4);
                    setParametre(cm, "@nomarticle", DbType.String, 30, NomArticle);
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
        public Boolean delete() 
        {
            bool p = false;
            try 
            {
                if (createCommand()) 
                {
                   
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "deleteMagasin";
                    setParametre(cm, "@nomArticle", DbType.String, 30, @NomArticle);
                    setParametre(cm, "@quantite", DbType.Int32, Int32.MaxValue, @quantite);
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

        public int getQuantite() 
        {
            int quant = 0;
           
            try
            {
                if (createCommand()) 
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "magasinQuantite";
                    setParametre(cm, "@nom", DbType.String, 30, NomArticle);
                    SqlParameter pam = new SqlParameter("@quantite", SqlDbType.Int);
                    pam.Direction = ParameterDirection.Output;
                    cm.Parameters.Add(pam);
                    cm.ExecuteNonQuery();
                    quant =int.Parse(pam.Value.ToString());
                    
                    
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
            return quant;
        }
        public Boolean deleteQuant() 
        {
            bool p = false;
            try
            {
                if (createCommand())
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "deleteQuantite";
                    setParametre(cm, "@nom", DbType.String, 30, NomArticle);
                    setParametre(cm, "@quantite", DbType.Int32, Int32.MaxValue, quantite);
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
