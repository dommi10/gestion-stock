using Fashion_Shop.design;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fashion_Shop.data
{
    class ClassConfig
    {
        public SqlConnection con;
        public SqlCommand cm;
        public SqlDataReader dr;
        public DataTable dt;
        public SqlDataAdapter dataAdapter;
      
        public static String DefaultPath = "GESTION_STOCK_SOFT";
        public String cheminBD;
 
       
        public Boolean getConnection() {
            String server = File.ReadAllText(ClassConstantes.Table.servername).Trim();
            String dbname = File.ReadAllText(ClassConstantes.Table.dbname).Trim();
            String username = File.ReadAllText(ClassConstantes.Table.username).Trim();
            String password = File.ReadAllText(ClassConstantes.Table.pasword).Trim();
            if (server != null && dbname != null && username != null)
            {
                cheminBD ="Server=" + server + ";Database=" + dbname + ";User ID=" + username + ";pwd=" + password;
                con = new SqlConnection(cheminBD);
                con.Open();
                return true;
            }
            else {
                
                MessageBox.Show("Veiller configurer le serveur!");
                return false;
            
            }
        }

        public Boolean createCommand() {
            
            if (getConnection()) 
            {
                cm = con.CreateCommand();
               
                return true;
            }
          return false;
        
        }

        public SqlConnection getChaine() 
        {
            getConnection();
            return con;
        }
        public Boolean createStoredCommand(String command)
        {
            if (cheminBD != null)
            {
                con = new SqlConnection(cheminBD);
                cm = new SqlCommand(command,con);
                return true;
            }
            return false;
        
        }

        public Boolean setConfiguration(String servername,String database, String username, String pass) 
        {

            try
            {

                cheminBD = "Server=" + servername.Trim() + ";Database=" + database.Trim() + ";User ID=" + username.Trim() + ";pwd=" + pass.Trim();
                con = new SqlConnection(cheminBD);
                con.Open();
                createInitialDirectory();
                checkFileDB();
                writeInfile(servername.Trim(),database.Trim(),username.Trim(),pass.Trim());
                return true;

            }

            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            {
                con.Close();
            }
            return false;
        }
        public static string GetTempDirectory()
        {
            return Environment.CurrentDirectory + @"\img\capturer\";
        }

        //create directory in c which conatain the file

        public void createInitialDirectory() 
        {
            try
            {
                
                if (!Directory.Exists(ClassConstantes.Table.InitialDirectory))
                {
                
                    Directory.CreateDirectory(ClassConstantes.Table.InitialDirectory);
                }
            }
            catch (Exception ex) 
            {
            MessageBox.Show(ex.Message,"Erreur De Creation");
            }
        
        }

        public void checkFileDB() 
        {

            try 
            {
                if (!File.Exists(ClassConstantes.Table.dbname)) 
                {
                    //create database name file
                    File.Create(ClassConstantes.Table.dbname);
                }
                if (!File.Exists(ClassConstantes.Table.servername))
                {
                    //create server file
                    File.Create(ClassConstantes.Table.servername);
                }
              
                if (!File.Exists(ClassConstantes.Table.username))
                {
                    //create username file
                    File.Create(ClassConstantes.Table.username);
                   
                }
                if (!File.Exists(ClassConstantes.Table.pasword))
                {
                    //create password file
                    File.Create(ClassConstantes.Table.pasword);
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void writeInfile(String server, String databasename, String username, String password) 
        {
            try
            {
                File.WriteAllText(ClassConstantes.Table.servername,server);
                File.WriteAllText(ClassConstantes.Table.dbname, databasename);
                File.WriteAllText(ClassConstantes.Table.username, username);
                File.WriteAllText(ClassConstantes.Table.pasword, password);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Dispose() 
        {
            cm.Dispose();
            if (con.State != ConnectionState.Closed)
                con.Close();
        }

        public void setParametre(SqlCommand cmd, String name, DbType type, int length, object parametresvalue)
        {
            IDbDataParameter a = cmd.CreateParameter();
            a.ParameterName = name;
            a.Size = length;
            a.DbType = type;
            if (parametresvalue == null)
            {
                if (!a.IsNullable)
                {
                    a.DbType = DbType.String;

                }
                a.Value = DBNull.Value;

            }
            else
                a.Value = parametresvalue;
            cmd.Parameters.Add(a);
        }

     }
}
