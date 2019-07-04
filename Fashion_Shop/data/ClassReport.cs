using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fashion_Shop.report;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraReports.UI;
using System.Globalization;
namespace Fashion_Shop.data
{
    class ClassReport : data.ClassConfig
    {
        
        bonClient report = new bonClient();
        bonFourn report1 = new bonFourn();

        public static ClassReport objet;

        public static ClassReport GetInstance() 
        {
            if (objet == null)
                objet = new ClassReport();
            return objet;
        }

        public void reportVente(int id)
        {
            Facture report = new Facture();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Facture WHERE sortieId= " + id, getChaine()))
            {
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    report.DataAdapter = da;
                    using (ReportPrintTool printReport = new ReportPrintTool(report))
                    {
                        printReport.ShowPreviewDialog();
                    }
                }
            }
        
        }
        public void reportCommande(int id)
        {

            
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Commande WHERE refcomande= " + id, getChaine()))
            {
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    report.DataAdapter = da;
                    using (ReportPrintTool printReport = new ReportPrintTool(report))
                    {
                        printReport.ShowPreviewDialog();
                    }
                }
            }

        }
        public void reportCommandeF(int id)
        {


            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CommandeF WHERE refcomande= " + id, getChaine()))
            {
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    report1.DataAdapter = da;
                    using (ReportPrintTool printReport = new ReportPrintTool(report1))
                    {
                        printReport.ShowPreviewDialog();
                    }
                }
            }

        }
        public void reportClient(String nom)
        {
            Employe report = new Employe();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM listEmploye WHERE nom+' '+postnom+' '+prenom ='"+nom+"'", getChaine()))
            {
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    report.DataAdapter = da;
                    using (ReportPrintTool printReport = new ReportPrintTool(report))
                    {
                        printReport.ShowPreviewDialog();
                    }
                }


            }
        }
        public void reportClient() 
        {
            Employe report = new Employe();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM listEmploye ", getChaine()))
            {
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    report.DataAdapter = da;
                    using (ReportPrintTool printReport = new ReportPrintTool(report))
                    {
                        printReport.ShowPreviewDialog();
                    }
                }
            

        }
        }

        //public void reportArticle(String nom) 
        //{
        //    Article report = new Article();
        //    using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM situation where Article='"+nom+"'", getChaine()))
        //    {
        //        da.Fill(dt);

        //        if (dt.Rows.Count > 0)
        //        {
        //            report.DataAdapter = da;
        //            using (ReportPrintTool printReport = new ReportPrintTool(report))
        //            {
        //                printReport.ShowPreviewDialog();
        //            }
        //        }
        //    }
        //}
        //public void reportArticle()
        //{
        //    Article report = new Article();
        //    using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM situation ", getChaine()))
        //    {
        //        da.Fill(dt);

        //        if (dt.Rows.Count > 0)
        //        {
        //            report.DataAdapter = da;
        //            using (ReportPrintTool printReport = new ReportPrintTool(report))
        //            {
        //                printReport.ShowPreviewDialog();
        //            }
        //        }
        //    }
        //}
        //public void reportArticle1(String date,String nom)
        //{
            

        //    Article report = new Article();
        //    DateTime dat = System.DateTime.Parse(date);
        
        //    String dati = String.Format("{0:yyyy-MM-dd}",dat);

        //    String datIn = dati+"%";
           
        //    String sql = "SELECT * FROM situation where convert(varchar(25),Date_,126) like '" + datIn + "'  and Article='" + nom + "'";
        //    using (SqlDataAdapter da = new SqlDataAdapter(sql, getChaine()))
        //    {
        //        da.Fill(dt);

        //        if (dt.Rows.Count > 0)
        //        {
        //            report.DataAdapter = da;
        //            using (ReportPrintTool printReport = new ReportPrintTool(report))
        //            {
        //                printReport.ShowPreviewDialog();
        //            }
        //        }
        //    }
        //}

        //public void reportArticle2(String date,String date2, String nom)
        //{


        //    Article report = new Article();
        //    DateTime dat = System.DateTime.Parse(date);
        //    DateTime dat1 = System.DateTime.Parse(date2);

        //    String dati = String.Format("{0:yyyy-MM-dd}", dat);
        //    String dati1 = String.Format("{0:yyyy-MM-dd}", date2);

        //    String datIn = dati + " 00:00:00";
        //    String datIn2 = dati + " 23:59:59";

        //    String sql = "SELECT * FROM situation where Date_  between cast('" + datIn + "' as datetime) and cast('" + datIn2 + "' as datetime) and Article='" + nom + "'";
        //    using (SqlDataAdapter da = new SqlDataAdapter(sql, getChaine()))
        //    {
        //        da.Fill(dt);

        //        if (dt.Rows.Count > 0)
        //        {
        //            report.DataAdapter = da;
        //            using (ReportPrintTool printReport = new ReportPrintTool(report))
        //            {
        //                printReport.ShowPreviewDialog();
        //            }
        //        }
        //    }
        //}
        
    }
}
