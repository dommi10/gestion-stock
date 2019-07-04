using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Fashion_Shop.data;
using System.Collections;

namespace Fashion_Shop.design
{
    public partial class UserControlArticle : UserControl
    {
        int id=0;
        Article article = new Article();

        public UserControlArticle()
        {
            InitializeComponent();
            id = 0;
        }

        void Save(int id) 
        {
            if (verification())
            {
                id = int.Parse(txtCode.Text.Trim());
                article.id = id;
                article.designation = txtdesc.Text.Trim();
                article.pays = txtpays.Text.Trim();
                article.ville = txtville.Text.Trim();
                article.qten = float.Parse(txtqte.Text.Trim());
                article.qtein = float.Parse(txtqtes.Text.Trim());
                article.date = daten.Value;
                article.dates = dates.Value;

                if (article.addArctile())
                {
                    if (id != 0)
                    {
                        ClassShowNotification.GetInstance().show("Modification");
                        resetSet(true);
                    }
                    else 
                    {
                        ClassShowNotification.GetInstance().show("Enreigistrement");
                        resetSet(true);
                    }
                    loadViews();
                }
            }
        
        }
        void supprimer(int id) 
        {
            if (id != 0)
            {
                if (verification())
                {
                    if (ClassMessageDialog.GetInstance().showDialog("Suppression", "Voulez-vous vraiment supprimer ce produit ?"))
                    {
                        if (article.delete(id))
                        {
                            loadViews();
                            resetSet(true);
                            ClassShowNotification.GetInstance().show("delete");
                        }
                    }
                        
                }
            }
            else
                ClassShowNotification.GetInstance().show("selection");        
        }
        private void resetSet(bool p)
        {
            switch (p) 
            {
                case true:
                    id = 0;
                    txtCode.Text = "0";
                    txtdesc.Text="";
                    txtpays.Text = "";
                    txtville.Text = "";
                    txtqte.Text = "";
                    txtqtes.Text = "";
                    break;
                case false:
                    
                    id = int.Parse(GridViewArticle.GetFocusedRowCellValue("CODE").ToString());
                    txtCode.Text = GridViewArticle.GetFocusedRowCellValue("CODE").ToString();
                    txtdesc.Text = GridViewArticle.GetFocusedRowCellValue("DESIGNATION").ToString();
                    txtville.Text = GridViewArticle.GetFocusedRowCellValue("VILLEPROV").ToString();
                    txtpays.Text = GridViewArticle.GetFocusedRowCellValue("PAYSPROV").ToString();
                    txtqte.Text = GridViewArticle.GetFocusedRowCellValue("QTEEN").ToString();
                    txtqtes.Text = GridViewArticle.GetFocusedRowCellValue("QTEIN").ToString();
                    break;
            }
        }
        private void actionbutton_Click(object sender, EventArgs e)
        {
            switch (((Control)sender).Name) 
            {
                case "btEnrter":
                    Save(id);
                    break;
                case "btSupp":
                    if (ClassUser.GetInstance().sNiveau > 1) 
                    {
                        supprimer(id);
                    }
                    else 
                    {
                        ClassShowNotification.GetInstance().show("admin");
                    }
                    
                    break;
            }
        }
        private void UserControlArticle_Load(object sender, EventArgs e)
        {
            try
            {
                loadViews();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void loadViews()
        {
            try 
            {
                GridControlArticle.DataSource = ClassChargerDataGrid.GetInstance().chargerArticle();
                if (GridViewArticle.RowCount > 0)
                    GridViewArticle.MoveFirst();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool verification()
        {
            if (txtCode.Text == "" || txtdesc.Text == "" || txtdesc.Text.Trim() == "" || txtpays.Text.Trim() == "" 
                || txtqte.Text.Trim()=="" || txtqtes.Text.Trim()=="" || txtville.Text.Trim()=="")
            {
                ClassShowNotification.GetInstance().show("champs");
                return false;

            }
               
            else
                return true;
        }
        private void GridControlArticle_DoubleClick(object sender, EventArgs e)
        {
            resetSet(false);
        }
    }
}
