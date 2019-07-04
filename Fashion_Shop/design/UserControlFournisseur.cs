using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fashion_Shop.data;

namespace Fashion_Shop.design
{
    public partial class UserControlFournisseur : UserControl
    {
       
        int id =0;
        ClassFournisseur fournisseur = new ClassFournisseur();
        ClassNotification notification = new ClassNotification();
        public UserControlFournisseur()
        {
            InitializeComponent();
            id = 0;
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            switch (((Control)sender).Name) 
            {
                case "btEnregistrer":
                    addFournisseur(id);
                    break;
                case "btSupprimer":
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

        Boolean verification() 
        {
            if (txtFournNom.Text == "" || txtFournAddresse.Text == "" || txtFournTelephone.Text == "" || txtFournPostnom.Text =="") 
            {
                ClassShowNotification.GetInstance().show("champs");
                return false;
            }
            return true;
        }
        void addFournisseur(int id) 
        {
            if (verification()) 
            {
                fournisseur.fournisseurId = id;
                
                fournisseur.fournisseurName = txtFournNom.Text;
                fournisseur.fournisseurPost = txtFournPostnom.Text;
                fournisseur.fournisseurNumber = txtFournTelephone.Text;
                fournisseur.fournisseurAddress = txtFournAddresse.Text;
                if (fournisseur.addFournisseur()) 
                {
                    if (id != 0)
                    {
                        LoadView();
                        resetSet(true);
                        ClassShowNotification.GetInstance().show("Modification");
                    }
                        
                    else
                    {
                        LoadView();
                        resetSet(true);
                        ClassShowNotification.GetInstance().show("Enreigistrement");

                    }
                }
                
            }
        
        }
        void supprimer(int id) 
        {
            if (id != 0)
            {
                if (verification())
                {
                    if (ClassMessageDialog.GetInstance().showDialog( "Suppression","Voulez-vous vraiment supprimer ce fournisseur"))
                    {
                        if (fournisseur.deleteFournisseur(id))
                        {
                            ClassShowNotification.GetInstance().show("delete");
                            resetSet(true);
                            LoadView();
                        }
                    }

                }
            }
            else
                ClassShowNotification.GetInstance().show("selection");
        }

      
        

       private void UserControlFournisseur_Load(object sender, EventArgs e)
        {
            LoadView();
        }
        void resetSet(Boolean test) 
        {
            switch (test) 
            {
                case true:
                    txtFournAddresse.Text = "";
                    txtFournNom.Text = "";
                    txtFournTelephone.Text = "";
                    txtFournPostnom.Text = "";
                    lbfId.Text = "";
                    id = 0;
                    break;
                case false:
                        id = int.Parse(GridViewFournisseur.GetFocusedRowCellValue(GridViewFournisseur.Columns[0]).ToString());
                        txtFournNom.Text = GridViewFournisseur.GetFocusedRowCellValue(GridViewFournisseur.Columns[1]).ToString();
                        txtFournPostnom.Text = GridViewFournisseur.GetFocusedRowCellValue(GridViewFournisseur.Columns[2]).ToString();
                        txtFournAddresse.Text = GridViewFournisseur.GetFocusedRowCellValue(GridViewFournisseur.Columns[3]).ToString();
                        txtFournTelephone.Text = GridViewFournisseur.GetFocusedRowCellValue(GridViewFournisseur.Columns[4]).ToString();
                    break;
            }
        }

        void LoadView() 
        {
            try
            {
                GridControlFournisseur.DataSource = ClassChargerDataGrid.GetInstance().chargerFournisseur();

                if (GridViewFournisseur.RowCount > 0)
                    GridViewFournisseur.MoveFirst();

            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        
        }
        private void UserControlFournisseur_MouseEnter(object sender, EventArgs e)
        {
            LoadView();
        }

        private void GridControlFournisseur_DoubleClick(object sender, EventArgs e)
        {
            resetSet(false);
        }
       
    }
}
