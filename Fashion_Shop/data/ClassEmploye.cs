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
    class ClassEmploye : data.ClassConfig
    {
        public int employeID { get; set; }
        public String employeName { get; set; }
        public String employeMatricule { get; set; }
        public String employePostnom { get; set; }
        public String employePrenom { get; set; }
        public String employePoste { get; set; }
        public String employeNumber { get; set; }
        public String employeAddresse { get; set; }
        public Byte[] employeImage { get; set; }
        public Char employeSexe { get; set; }
        public String employeAge { get; set; }
        public static ClassEmploye objet;
        

        public static ClassEmploye GetInstance() 
        {
            if (objet == null) 
            {
                objet = new ClassEmploye();
            }
                
            return objet;
        }

        public Boolean addEmploye() 
        {
            Boolean test = false;
            try
            {
                if (createCommand()) 
                {
                    cm.CommandText = "addEmploye";
                    cm.CommandType = CommandType.StoredProcedure;
                    setParametre(cm, "@id", DbType.Int32, Int32.MaxValue, employeID);
                    setParametre(cm, "@matricule", DbType.String, 30, employeMatricule);
                    setParametre(cm, "@nom", DbType.String, 30, employeName);
                    setParametre(cm, "@postnom", DbType.String, 30, employePostnom);
                    setParametre(cm, "@prenom", DbType.String, 30, employePrenom);
                    setParametre(cm, "@sexe", DbType.String, 1, employeSexe);
                    setParametre(cm, "@age", DbType.String, 30, employeAge);
                    setParametre(cm, "@poste", DbType.String, 30, employePoste);
                    setParametre(cm, "@telephone", DbType.String, 30, employeNumber);
                    setParametre(cm, "@addresse", DbType.String, 100, employeAddresse);
                    setParametre(cm, "@imageEmp", DbType.Binary, Int32.MaxValue, employeImage);
                    
                    cm.ExecuteNonQuery();
                    test = true;
                
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
            return test;
        
        }
        public Boolean delete(int id) 
        {

            Boolean test = false;
            try
            {
                if (createCommand())
                {
                    String sql = "Delete from " + ClassConstantes.Table.Table_Employe + " where employeId = " + id;
                    cm.CommandText = sql;
                    
                    cm.ExecuteNonQuery();
                    test = true;

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
            return test;
        
        }

        public void getEmploye(ComboBox combo) 
        {
           
            try
            {
                if (createCommand()) 
                {
                    String sql = "Select nom from " + ClassConstantes.Table.VName_Employe+ " ORDER By nom";
                    cm.CommandText = sql;

                    dr=  cm.ExecuteReader();
                    while (dr.Read()) 
                    {
                        combo.Items.Add(dr.GetValue(0));
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

        public int getId() 
        {
            int id=0;

            try
            {
                if (createCommand())
                {
                    String sql = "Select ID from " + ClassConstantes.Table.VName_Employe + " where nom ="+employeName;
                    cm.CommandText = sql;

                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        id = int.Parse(dr.GetValue(0).ToString());
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
            return id;
        }
    }
}
