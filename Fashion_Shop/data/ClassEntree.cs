using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_Shop.data
{
    class ClassEntree:data.ClassConfig
    {
        public int id {get;set;}
        public String nomArticle { get; set; }
        public String nomEmp { get; set; }
        public int quantite { get; set; }
        public int quantit { get; set; }
        public Decimal prix { get; set; }
        public DateTime date { get; set; }


        public Boolean save()
        {
            bool p = false;
            try 
            {
                if (createCommand()) 
                {
                    cm.CommandType = System.Data.CommandType.StoredProcedure;
                    cm.CommandText = "addEntree";
                    setParametre(cm, "@id", DbType.Int32, Int32.MaxValue, id);
                    setParametre(cm, "@quantite", DbType.Int32, Int32.MaxValue, quantite);
                    setParametre(cm, "@prixent", DbType.Decimal,Int32.MaxValue, prix);
                    setParametre(cm, "@dateEn", DbType.DateTime, 50, date);
                    setParametre(cm, "@nomEm", DbType.String, 50, nomEmp);
                    setParametre(cm, "@nomArticle", DbType.String, 30, nomArticle);
                    cm.ExecuteNonQuery();
                    ClassMagasin.GetInstance().quantite = quantit;
                    ClassMagasin.GetInstance().NomArticle = nomArticle;
                    if(ClassMagasin.GetInstance().addMagasin())
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

        public Boolean delete(int id) 
        {
            bool p = false;

            try 
            {
                if (createCommand()) 
                {
                    String sql = "Delete from " + ClassConstantes.Table.Table_Entree + " where entreeId=" + id;
                    cm.CommandText = sql;
                    cm.ExecuteNonQuery();
                    ClassMagasin.GetInstance().quantite = quantit;
                    if(ClassMagasin.GetInstance().delete())
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
