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
    public partial class UserControlEntrer : UserControl
    {
        ClassClient client = new ClassClient();
        UserControlEmploye employe = new UserControlEmploye();
        UserControlArticle article = new UserControlArticle();
        UserControlFournisseur fournisseur = new UserControlFournisseur();
        ClassEntree entree = new ClassEntree();
        int id = 0;
        int quantit = 0;
        public UserControlEntrer()
        {
            InitializeComponent();
            id = 0;
            
            
        }

        void addToList() 
        {
            //comboEnClient.Items.Clear();
            //comboEnArticle.Items.Clear();

            //ClassEmploye.GetInstance().getEmploye(comboEnClient);
            //Article.GetInstance().getArtcle(comboEnArticle);
        }

        private void UserControlEntrer_Load(object sender, EventArgs e)
        {
            load();
            addToList();
            loadViews();
        
           

        }
        void load() 
        {
           
            try
            {
                //clear all 
                panEmploye.Controls.Clear();
                panArticle.Controls.Clear();
                panFourn.Controls.Clear();
                //for client
                employe.Dock = DockStyle.Fill;
                panEmploye.Controls.Add(employe);
                //for article
                article.Dock = DockStyle.Fill;
                panArticle.Controls.Add(article);
                //for fournisseur
                fournisseur.Dock = DockStyle.Fill;
                panFourn.Controls.Add(fournisseur);

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            
            }
        
        }

        private void actionButtons_Click(object sender, EventArgs e)
        {
            switch (((Control)sender).Name) 
            {
                case "btAjouter":
                    save(id);
                    break;
                case "btASupprimer":
                    if (ClassUser.GetInstance().sNiveau > 2)
                    {
                        delete(id);
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
            Boolean test= true;
            if (comboEnClient.SelectedText == null || txtEnQuantite.Text == "" || txtEnPrix.Text == "" || comboEnArticle.SelectedText== null)
            {
                test = false;
                ClassShowNotification.GetInstance().show("champs");

            }

            return test;
        }
        void resetSet(bool p) 
        {
            switch (p) 
            {
                case true:
               comboEnArticle.SelectedItem = null;
               txtEnQuantite.Text ="";
               txtEnPrix.Text ="";
               comboEnClient.SelectedItem =null;
               quantit = 0;
               id = 0;
            
                    break;
                case false:
                    id = int.Parse(GridViewAchat.GetFocusedRowCellValue(GridViewAchat.Columns[0]).ToString());
                    comboEnArticle.Text = GridViewAchat.GetFocusedRowCellValue(GridViewAchat.Columns[1]).ToString();
                    txtEnPrix.Text = GridViewAchat.GetFocusedRowCellValue(GridViewAchat.Columns[3]).ToString();
                    quantit = int.Parse(GridViewAchat.GetFocusedRowCellValue(GridViewAchat.Columns[2]).ToString());
                    txtEnQuantite.Text = GridViewAchat.GetFocusedRowCellValue(GridViewAchat.Columns[2]).ToString();
                    comboEnClient.Text = GridViewAchat.GetFocusedRowCellValue(GridViewAchat.Columns[5]).ToString();
                    break;
            }
        }
        void save(int id) 
        {
            if (verification()) 
            {
                
                entree.id = id;
                entree.nomArticle = comboEnArticle.Text;
                entree.nomEmp = comboEnClient.Text;
                ClassMagasin.GetInstance().NomArticle = comboEnArticle.Text;
                ClassMagasin.GetInstance().quantite = quantit;
                entree.quantit = int.Parse(txtEnQuantite.Text);
                entree.quantite = int.Parse(txtEnQuantite.Text);
                entree.prix = Decimal.Parse(txtEnPrix.Text);
                entree.date =txtEnDate.Value.ToLocalTime();
                if (id != 0)
                {
                    if (ClassMagasin.GetInstance().deleteQuant()) 
                    {
                        if (entree.save())
                        {
                            resetSet(true);
                            loadViews();
                            ClassShowNotification.GetInstance().show("Modification");
                        }
                    } 
                     

                }
                else
                {
                    if (entree.save())
                    {
                        resetSet(true);
                        loadViews();


                        ClassShowNotification.GetInstance().show("Enreigistrement");
                    }
                }
            
            }
            
        }
        void delete(int id) 
        {
            if (id !=0) 
            {
                if (ClassMessageDialog.GetInstance().showDialog("Suppression", "Voulez-vous vraiment supprimer cet entrer?"))
                {
                    entree.quantit = int.Parse(txtEnQuantite.Text);
                    ClassMagasin.GetInstance().NomArticle = comboEnArticle.Text;
                    
                    quantit =ClassMagasin.GetInstance().getQuantite();
                    quantit = quantit - entree.quantit;
                    if (quantit > 0)
                    {
                        if (entree.delete(id))
                            ClassShowNotification.GetInstance().show("delete");
                        loadViews();
                        resetSet(true);

                    }
                    else 
                    {
                        ClassShowNotification.GetInstance().show("suppression");
                    }
                  
                    
                
                }
            }
        }

        private void loadViews()
        {
            //try
            //{
            //    GridControlAchat.DataSource = ClassChargerDataGrid.GetInstance().chargerEntree();

            //    if (GridViewAchat.RowCount > 0)
            //        GridViewAchat.MoveFirst();

            //}
            //catch (Exception ex)
            //{
            //    throw new Exception(ex.Message);
            //}
        }

        private void comboClient_MouseEnter(object sender, EventArgs e)
        {
            addToList();
        }

        private void comboEnArticle_MouseEnter(object sender, EventArgs e)
        {
            addToList();
        }

       
        private void UserControlEntrer_MouseEnter(object sender, EventArgs e)
        {
            loadViews();
        }

        private void GridControlAchat_DoubleClick(object sender, EventArgs e)
        {
            resetSet(false);
        }


    }
}
