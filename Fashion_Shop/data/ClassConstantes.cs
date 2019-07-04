using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_Shop.data
{
    class ClassConstantes
    {
        public class Table 
        {
            //about databse

            public static String Table_Fournisseur = "tfournisseur";
            public static String Table_Article = "tArticle";
            public static String Table_Client = "tclient";
            public static String Table_Employe = "tEmploye";
            public static String Table_Entree = "tEntree";
            public static String Table_Magasin = "tMagasin";
            public static String Table_Vente = "tvente";
            public static String Table_sortie = "tsortie";
            public static String Table_Commande = "tcommande";
            public static String View_Fournissseur = "listFournisseur";
            public static String VName_Fournisseur = "VN_Fournisseur";
            public static String VName_Client = "VN_Client";
            public static String VName_Employe = "VN_Employe";
            public static String VName_Article = "VN_Article";
            public static String View_Article = "listArticle";
            public static String View_Client = "listClient";
            public static String View_Employe = "listEmploye";
            public static String View_Commande = "listCommande";
            public static String View_Commande1 = "listCommande1";
            public static String View_Entree = "listEntree";
            public static String View_LigneC = "ligneClient";
            public static String View_LigneF = "ligneFourn";
            public static String View_logs = "listLogs";
            public static String View_Magasin = "listMagasin";
            public static String View_sortie = "listSortie";
            public static String View_users = "listUtilisateur";
            public static String View_vente = "listVente";


            //about file

            public static string InitialDirectory = "C:\\GESTIONSTOCK";
            public static string dbname = "C:\\GESTIONSTOCK\\dbname.txt";
            public static string pasword = "C:\\GESTIONSTOCK\\password.txt";
            public static string username = "C:\\GESTIONSTOCK\\username.txt";
            public static string servername = "C:\\GESTIONSTOCK\\server.txt";
            public static string port = "C:\\GESTIONSTOCK\\port.txt";
        
        }
    }
}
