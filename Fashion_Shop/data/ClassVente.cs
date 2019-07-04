using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fashion_Shop.data
{
    class ClassVente : data.ClassConfig
    {
        public int VenteId { get; set; }
        public String nomArticle { get; set; }
        public int quantite { get; set; }
        public DateTime date { get; set; }
        public String nomEmploye { get; set; }
        public String client { get; set; }
        public static ClassVente objet;
        public ListView listview{get;set;} 
        public int sortieId{get;set;}
        public decimal prix { get; set; }
   


        public static ClassVente GetInstance() 
        {
            if (objet == null)
                objet = new ClassVente();
            return objet;
        }
        public Boolean addVente()
        {
            bool p = false;
            try
            {
                foreach (ListViewItem item in listview.Items)
                {
                    if (createCommand())
                    {
                        
                   
                        VenteId = int.Parse(item.SubItems[0].Text);
                        nomArticle = item.SubItems[1].Text;
                        quantite = int.Parse(item.SubItems[2].Text);
                        prix = Decimal.Parse(item.SubItems[3].Text);
                        date = System.DateTime.Parse(item.SubItems[4].Text);
                        nomEmploye = item.SubItems[5].Text;
                        client = item.SubItems[6].Text;
                        
                       
                        //begin
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.CommandText = "addVente";
                        setParametre(cm, "@id", DbType.Int32, Int32.MaxValue, VenteId);
                        setParametre(cm, "@quantite", DbType.Int32, Int32.MaxValue, quantite);
                        setParametre(cm, "dateVente", DbType.DateTime, 50, date);
                        setParametre(cm, "@nomEmp", DbType.String, 50, nomEmploye);
                        setParametre(cm, "@nomArticle", DbType.String, 50, nomArticle);
                        setParametre(cm, "@refsortie", DbType.Int32, Int32.MaxValue, sortieId);
                        setParametre(cm, "@prix", DbType.Decimal, Int32.MaxValue, prix);
                        setParametre(cm, "@nomClient", DbType.String, 50, client);
                        cm.ExecuteNonQuery();
                       
                        ClassMagasin.GetInstance().NomArticle = nomArticle;
                        ClassMagasin.GetInstance().quantite = quantite;
                        ClassMagasin.GetInstance().deleteQuant();
                        Dispose();
                    
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
                  p = true;
            }
            return p;
        }

        public Boolean delete() 
        {
            bool p = false;
            try
            {
                ClassMagasin.GetInstance().NomArticle = designation();
                ClassMagasin.GetInstance().quantite = quantite;
                ClassMagasin.GetInstance().quantitealarm = 4;
                ClassMagasin.GetInstance().addMagasin();

                if (createCommand()) 
                {
                    String sql = "Delete from " + ClassConstantes.Table.Table_Vente + " where venteId=" + VenteId;
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
        public Boolean deleteQuantite() 
        {
            bool p = false;
            try
            {
                ClassMagasin.GetInstance().NomArticle = designation();
                ClassMagasin.GetInstance().quantite = quantite;
                ClassMagasin.GetInstance().quantitealarm = 4;
                ClassMagasin.GetInstance().addMagasin();
                if (createCommand())
                {
                    String sql = "Update " + ClassConstantes.Table.Table_Vente + " set quantiteven = 0 where venteId=" + VenteId;
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
        public String designation() 
        {
            String name = String.Empty;
            try 
            {
                if (createCommand())
                {
                    String sql = "select nom from " + ClassConstantes.Table.Table_Vente + " inner join " + ClassConstantes.Table.Table_Article + " on " + ClassConstantes.Table.Table_Article + ".id =" + ClassConstantes.Table.Table_Vente + ".refarticle where venteId=" + VenteId;
                    cm.CommandText = sql;
                    dr = cm.ExecuteReader();
                    if(dr.Read())
                    {
                        name = dr.GetValue(0).ToString();
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
            return name;
        }
        public Boolean update() 
        {
            bool p = false;
            try
            {
                if (createCommand())
                {
                    String sql = "Update " + ClassConstantes.Table.Table_Vente + " set quantiteven = "+quantite+" where venteId=" + VenteId;
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
