using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fashion_Shop.data
{
    class ClassLogin : data.ClassConfig
    {
        public static String username { get; set; }
        public String password { get; set; }
        public static int userid { get; set; }
        public static int niveau { get; set; }
      

        public Boolean userLogin() {
            try
            {
                getConnection();
                if (createCommand())
                {
                   
                    if (con.State.ToString().ToLower().Equals("closed"))
                        con.Open();

                    String sql = "select *from tutilisateur where username='" + username + "' and password like '" + password + "'";
                    cm.CommandText = sql;

                    SqlDataReader reader = cm.ExecuteReader();
                    if (reader.Read())
                    {
                        username = reader.GetString(2);
                        userid = reader.GetInt16(1);
                        niveau = reader.GetInt16(3);
                        return true;
                    }
                    else
                    {
                        return false;
                    }



                }
                else {
                    MessageBox.Show("Impossible de creer la command");
                }
            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
            }
                
            return false;

        }
        public void setInfos(String usernam, String passwor) {
            username = usernam;
            password = passwor;
            
        
        }
    }
}
