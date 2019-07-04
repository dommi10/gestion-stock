using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Fashion_Shop.data
{
    class ClassUser:data.ClassConfig
    {
        public int idUser { get; set; }
        public  String Username {get;set;}
        public String sUsername { get; set; }
        public int sNiveau { get; set; }
        public  int niveau { get; set; }
        public String password { get; set; }

        public static ClassUser objet;

        public static ClassUser GetInstance() 
        {
             if (objet == null)
                objet = new ClassUser();
            return objet;
        }

        public String GetUser(){
            return sUsername;
        }

        public Boolean addUser() 
        {
            bool p = false;
            try 
            {
                if (createCommand()) 
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "addUser";
                    setParametre(cm, "@idUser", DbType.Int32, Int32.MaxValue, idUser);
                    setParametre(cm, "@username", DbType.String, 30, Username);
                    setParametre(cm, "@password", DbType.String, Int32.MaxValue, password);
                    setParametre(cm, "@niveau", DbType.Int16, 1, niveau);
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

        public Boolean login() 
        {
            bool p = false;
            try
            {
                if (createCommand())
                {
                    String sql = "select *from tutilisateur where username='" + Username + "' and passwords like '" + password+"'";
                    cm.CommandText = sql;
                    dr = cm.ExecuteReader();
                    if (dr.Read()) 
                    {
                        GetInstance().sUsername = dr["username"].ToString();
                        GetInstance().sNiveau = int.Parse(dr["niveau"].ToString());
                        p = true;
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
            return p;
        }
        public Boolean delete() 
        {
            bool p = false;
            try
            {
                if (createCommand())
                {
                    String sql = "delete from tutilisateur where utilisateurId=" + idUser;
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
