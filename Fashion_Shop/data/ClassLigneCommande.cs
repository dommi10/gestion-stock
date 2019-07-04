using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Fashion_Shop.data
{
    class ClassLigneCommande : data.ClassConfig
    {
        public ListView ligne { get; set; }
        public int ligneId { get; set; }
        public int quantite { get; set; }
        public String nomClient { get; set; }
        public String nomFournisseur { get; set; }
        public Decimal prix { get; set; }
        public String nomArticle { get; set; }
        public String etat { get; set; }
        public String user { get; set; }
        public DateTime date { get; set; }
        public String nomUtilisateur { get; set; }
        public int commandeId { get; set; }
        public String f { get; set; }
        public static ClassLigneCommande objet { get; set; }

        public static ClassLigneCommande GetInstance() 
        {
            if (objet == null)
                objet = new ClassLigneCommande();
            return objet;
        }
        public Boolean addLigne() 
        {
            bool p = true;
            try 
            {
                foreach (ListViewItem item in ligne.Items) 
                {
                    if (createCommand()) 
                    {
                        ligneId = int.Parse(item.SubItems[0].Text);
                        nomArticle = item.SubItems[1].Text;
                        quantite = int.Parse(item.SubItems[2].Text);
                        prix = Decimal.Parse(item.SubItems[3].Text);
                        if(f == null)
                            nomClient = item.SubItems[4].Text;
                        else
                            nomFournisseur = item.SubItems[4].Text;
                        date = System.DateTime.Parse(item.SubItems[5].Text);
                        etat = item.SubItems[6].Text;
                        nomUtilisateur = item.SubItems[7].Text;

                        cm.CommandType = CommandType.StoredProcedure;
                        cm.CommandText = "addLigneCommand";
                        setParametre(cm, "@idcommand", DbType.Int32, Int32.MaxValue, commandeId);
                        setParametre(cm, "idligne", DbType.Int32, Int32.MaxValue, ligneId);
                        setParametre(cm, "@quantite", DbType.Int32, Int32.MaxValue, quantite);
                        setParametre(cm, "@nomClient", DbType.String, 50, nomClient);
                        setParametre(cm, "@nomFourn", DbType.String, 50, nomFournisseur);
                        setParametre(cm, "@prixvente", DbType.Decimal, Int32.MaxValue, prix);
                        setParametre(cm, "@nomart", DbType.String, 30, nomArticle);
                        setParametre(cm, "@nomuser", DbType.String, 50, nomUtilisateur);
                        setParametre(cm, "@Etat", DbType.String, 30, etat);
                        setParametre(cm, "@date", DbType.DateTime, 50, date);
                        cm.ExecuteNonQuery();
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
                p = true;
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
                    String sql = "Delete from tlignecommande  where lignecommandeId=" + ligneId;
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
