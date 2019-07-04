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
    public partial class UserControlStock : UserControl
    {
        int id = 0;
        bool edit = false;
        bool exist = false;
        String etat;
        ClassCommande commande = new ClassCommande();
        public UserControlStock()
        {
            InitializeComponent();
            id = 0;
        }

        private void UserControlStock_Load(object sender, EventArgs e)
        {
            navigationPane1.SelectedPage = navigationPage1;
            load();
            LoadViews();

        }
        void load() 
        {
            UserControlArticle article = new UserControlArticle();
            UserControlFournisseur fournisseur = new UserControlFournisseur();
            UserControlClient client = new UserControlClient();
            try
            {
                //add fournisseur
                panFournisseur.Controls.Clear();
                fournisseur.Dock = DockStyle.Fill;
                panFournisseur.Controls.Add(fournisseur);

                //add Article
                panArticle.Controls.Clear();
                article.Dock = DockStyle.Fill;
                panArticle.Controls.Add(article);


                //add client
                panClient.Controls.Clear();
                client.Dock = DockStyle.Fill;
                panClient.Controls.Add(client);


            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            
            }
        
        }
        bool verification() 
        {
            bool p = false;
            if (!(comboArticle.Text == "" || comboClient.Text == "" || txtQuantite.Text == "" || txtPrix.Text == "" || comboManiere.Text == ""))
                p = true;
            else
                ClassShowNotification.GetInstance().show("champs");
            return p;
           
        }
        bool verification1()
        {
            bool p = false;
            if (!(comboArticle1.Text == "" || comboNF.Text == "" || txtQuantite1.Text == "" || txtPrix1.Text == "" || comboManiere1.Text == ""))
                p = true;
            else
                ClassShowNotification.GetInstance().show("champs");
            return p;

        }
        void addToShop() 
        {
            if (verification()) 
            {
                
               
                    if (shop.Items.Count > 0)
                    {
                        if (edit)
                        {
                            var item = shop.SelectedItems;
                            item[0].SubItems[1].Text = comboArticle.Text ;
                             item[0].SubItems[2].Text = txtQuantite.Text ;
                             item[0].SubItems[3].Text =txtPrix.Text ;
                             item[0].SubItems[4].Text = comboClient.Text;
                             item[0].SubItems[5].Text= System.DateTime.Parse(comboDate.Value.ToString()).ToString();
                             item[0].SubItems[6].Text = comboManiere.Text;
                             ClassUser.GetInstance().GetUser();
                             resetSet(true);
                             edit = false;
                        }
                        else
                        {
                                foreach (ListViewItem items in shop.Items) 
                                {
                                    if (items.SubItems[1].Text == comboArticle.Text) 
                                    {
                                        MessageBox.Show("Cet Article existe Déjà");
                                        exist = true;
                                    }  
                                }
                                
                                if (!exist) 
                                {
                                    String[] row = new String[]
                                    {
                                     ""+id,
                                        comboArticle.Text,
                                        txtQuantite.Text,
                                        txtPrix.Text,
                                        comboClient.Text,
                                        System.DateTime.Parse(comboDate.Value.ToString()).ToString(),
                                        comboManiere.Text,
                                        ClassUser.GetInstance().GetUser()
                                    };
                                    shop.Items.Add(new ListViewItem(row));
                                    resetSet(true);
                                }
                                exist = false;

                            }

                        
                    }
                    else
                    {
                        String[] row = new String[]
                        {
                            ""+id,
                            comboArticle.Text,
                            txtQuantite.Text,
                            txtPrix.Text,
                            comboClient.Text,
                            System.DateTime.Parse(comboDate.Value.ToString()).ToString(),
                            comboManiere.Text,
                            ClassUser.GetInstance().GetUser()
                        };
                        shop.Items.Add(new ListViewItem(row));
                        etat = comboManiere.Text;
                        comboManiere.Enabled = true;
                        resetSet(true);

                    }
                
            }
            
        }
        void addToShop1()
        {
            if (verification1())
            {


                if (shop1.Items.Count > 0)
                {
                    if (edit)
                    {
                        var item = shop1.SelectedItems;
                        item[0].SubItems[1].Text = comboArticle1.Text;
                        item[0].SubItems[2].Text = txtQuantite1.Text;
                        item[0].SubItems[3].Text = txtPrix1.Text;
                        item[0].SubItems[4].Text = comboNF.Text;
                        item[0].SubItems[5].Text = System.DateTime.Parse(comboDate1.Value.ToString()).ToString();
                        item[0].SubItems[6].Text = comboManiere1.Text;
                        ClassUser.GetInstance().GetUser();
                        resetSet(true);
                        edit = false;
                    }
                    else
                    {
                        foreach (ListViewItem items in shop1.Items)
                        {
                            if (items.SubItems[1].Text == comboArticle1.Text)
                            {
                                MessageBox.Show("Cet Article existe Déjà");
                                exist = true;
                            }
                        }

                        if (!exist)
                        {
                            String[] row = new String[]
                                    {
                                     ""+id,
                                        comboArticle1.Text,
                                        txtQuantite1.Text,
                                        txtPrix1.Text,
                                        comboNF.Text,
                                        System.DateTime.Parse(comboDate1.Value.ToString()).ToString(),
                                        comboManiere1.Text,
                                        ClassUser.GetInstance().GetUser()
                                    };
                            shop1.Items.Add(new ListViewItem(row));
                            resetSet1(true);
                        }
                        exist = false;

                    }


                }
                else
                {
                    String[] row = new String[]
                        {
                            ""+id,
                            comboArticle1.Text,
                            txtQuantite1.Text,
                            txtPrix1.Text,
                            comboNF.Text,
                            System.DateTime.Parse(comboDate1.Value.ToString()).ToString(),
                            comboManiere1.Text,
                            ClassUser.GetInstance().GetUser()
                        };
                    shop1.Items.Add(new ListViewItem(row));
                    etat = comboManiere1.Text;
                    comboManiere1.Enabled = false;
                    resetSet1(true);

                }

            }

        }

        void resetSet1(bool p) 
        {
           switch(p)
           {
               case true:
                   comboArticle1.Text = null;
                   comboNF.Text = null;
                   txtPrix1.Text = null;
                   txtQuantite1.Text = null;
                   

                   break;
               case false:
                   id = int.Parse(GridViewCF.GetFocusedRowCellValue(GridViewCF.Columns[0]).ToString());
                    commande.id = id;
                    commande.ligne = shop1;
                    commande.addDetails1();
                  break;
           }
        }
        void resetSet(bool p)
        {
            switch (p)
            {
                case true:
                    comboArticle.Text = null;
                    comboClient.Text = null;
                    txtPrix.Text = null;
                    txtQuantite.Text = null;
                  

                    break;
                case false:
                    id = int.Parse(GridViewCClient.GetFocusedRowCellValue(GridViewCClient.Columns[0]).ToString());
                    commande.id = id;
                    commande.ligne = shop;
                    commande.addDetails();
                    break;
            }
        }
        void resetId() 
        {
            id = 0;
        }
        void addToList() 
        {
            comboArticle.Items.Clear();
            comboClient.Items.Clear();
            comboNF.Items.Clear();
            comboArticle1.Items.Clear();
            Article.GetInstance().getArtcle(comboArticle);
            Article.GetInstance().getArtcle(comboArticle1);
            ClassClient.GetInstance().GetClient(comboClient);
            ClassFournisseur.GetInstance().getFournisseur(comboNF);
        }

        private void comboArticle_MouseEnter(object sender, EventArgs e)
        {
            addToList();
        }

        private void actionButtons_Click(object sender, EventArgs e)
        {
            switch (((Control)sender).Name) 
            { 
                case "btAjouter":
                    addToShop();
                    break;
                case "btValider":
                    if (ClassUser.GetInstance().sNiveau > 1)
                    {

                        save();
                    }
                    else
                    {
                        ClassShowNotification.GetInstance().show("admin");
                    }
                    
                    break;
                case "btEnlever":
                    if (ClassUser.GetInstance().sNiveau > 1)
                    {

                        remove();
                    }
                    else
                    {
                        ClassShowNotification.GetInstance().show("admin");
                    }
                  
                    break;
                case "btSupprimer":
                    if (ClassUser.GetInstance().sNiveau > 1)
                    {

                        delete(id);
                    }
                    else
                    {
                        ClassShowNotification.GetInstance().show("admin");
                    }
                    
                    
                 break;
                case "btAjouter1":
                 addToShop1();
                 break;
                case "btValider1":
                 if (ClassUser.GetInstance().sNiveau > 1)
                 {

                     save1();
                 }
                 else
                 {
                     ClassShowNotification.GetInstance().show("admin");
                 }
                 
                 break;
                case "btEnlever1":
                 if (ClassUser.GetInstance().sNiveau > 1)
                 {

                     remove1();
                 }
                 else
                 {
                     ClassShowNotification.GetInstance().show("admin");
                 }
                 
                 break;
                case "btSupprimer1":
                 if (ClassUser.GetInstance().sNiveau > 1)
                 {

                     delete1(id);
                 }
                 else
                 {
                     ClassShowNotification.GetInstance().show("admin");
                 }
                 
                 break;
                case "btImprimer":
                 imprimer();
                 break;
                case "btImprimer1":
                 imprimer1();
                 break;
            }
        }
        void remove()
        {
            if (edit)
            {
                if (id == 0)
                {
                    var item = shop.SelectedItems;
                    shop.Items.Remove(item[0]);
                    resetSet(true);
                }
                else
                {
                    if (ClassMessageDialog.GetInstance().showDialog("Suppression", "Voulez-vous vraiment supprimer cette commmande ? Noter qu'elle sera impossible de la recuperer!"))
                    {
                        var item = shop.SelectedItems;

                        int idv = int.Parse(item[0].SubItems[0].Text);
                        int quantite = int.Parse(item[0].SubItems[2].Text);
                        commande.id = id;
                        commande.quantite = quantite;
                        ClassLigneCommande.GetInstance().ligneId= idv;
                        ClassLigneCommande.GetInstance().quantite = quantite;


                        if (commande.deletQuantie())
                        {
                            
                            if (ClassLigneCommande.GetInstance().delete())
                            {
                                ClassShowNotification.GetInstance().show("delete");
                                shop.Items.Remove(item[0]);
                                 resetSet(true);
                                LoadViews();
                                edit = false;
                            }

                        }

                    }
                }
            }
            else
                MessageBox.Show("Veuiller selectionner l'element a supprimer");


        }
        void delete(int id)
        {

            if (id != 0)
            {
                if (ClassMessageDialog.GetInstance().showDialog("Suppression", "Voulez vous vraiment effectuer cette suppression ?"))
                {
                    commande.id = id;
                    commande.ligne = shop;
                    if (commande.delete())
                    {
                        ClassShowNotification.GetInstance().show("delete");
                        shop.Items.Clear();
                        resetSet(true);
                        resetId();
                        LoadViews();
                    }
                }

            }
            else
            {
                MessageBox.Show("Veillez Selectionner une vente !");
            }
        }
        void save() 
        {
            if (shop.Items.Count > 0) 
            {
                int quantite=0;
                        foreach(ListViewItem items in shop.Items)
                        {
                            quantite   += int.Parse(items.SubItems[2].Text);
                        }
                            
                        commande.id = id;
                        commande.date = System.DateTime.Now;
                        commande.Etat = etat;
                        commande.quantite = quantite;
                        commande.ligne = shop;
                        comboManiere.Enabled = true;
                        if (commande.addCommand())
                        {
                            shop.Items.Clear();
                            LoadViews();
                            if (id == 0)
                            {
                                ClassShowNotification.GetInstance().show("Enreigistrement");
                                resetSet(true);
                                resetId();
                                
                            }

                            else 
                            {
                                ClassShowNotification.GetInstance().show("Modification");
                                resetId();
                                resetSet(true);
                            }
                        }
                  
           
            }
            else
                MessageBox.Show("Impossible d'effectuer la vente Votre panier est vide!", "Erreur");
            
        }
        void remove1()
        {
            if (edit)
            {
                if (id == 0)
                {
                    var item = shop1.SelectedItems;
                    shop1.Items.Remove(item[0]);
                    resetSet1(true);
                }
                else
                {
                    if (ClassMessageDialog.GetInstance().showDialog("Suppression", "Voulez-vous vraiment supprimer cette commmande ? Noter qu'elle sera impossible de la recuperer!"))
                    {
                        var item = shop1.SelectedItems;

                        int idv = int.Parse(item[0].SubItems[0].Text);
                        int quantite = int.Parse(item[0].SubItems[2].Text);
                        commande.id = id;
                        commande.quantite = quantite;
                        ClassLigneCommande.GetInstance().ligneId = idv;
                        ClassLigneCommande.GetInstance().quantite = quantite;


                        if (commande.deletQuantie())
                        {

                            if (ClassLigneCommande.GetInstance().delete())
                            {
                                ClassShowNotification.GetInstance().show("delete");
                                shop1.Items.Remove(item[0]);
                                resetSet1(true);
                                LoadViews();
                                edit = false;
                            }

                        }

                    }
                }
            }
            else
                MessageBox.Show("Veuiller selectionner l'element a supprimer");


        }
        void delete1(int id)
        {

            if (id != 0)
            {
                if (ClassMessageDialog.GetInstance().showDialog("Suppression", "Voulez vous vraiment effectuer cette suppression ?"))
                {
                    commande.id = id;
                    commande.ligne = shop1;
                    if (commande.delete())
                    {
                        ClassShowNotification.GetInstance().show("delete");
                        shop1.Items.Clear();
                        resetSet1(true);
                        resetId();
                        LoadViews();
                    }
                }

            }
            else
            {
                MessageBox.Show("Veillez Selectionner une vente !");
            }
        }
        void save1()
        {
            if (shop1.Items.Count > 0)
            {
                int quantite = 0;
                foreach (ListViewItem items in shop1.Items)
                {
                    quantite += int.Parse(items.SubItems[2].Text);
                }

                commande.id = id;
                commande.date = System.DateTime.Now;
                commande.Etat = etat;
                commande.quantite = quantite;
                commande.ligne = shop1;
                comboManiere1.Enabled = true;
                ClassLigneCommande.GetInstance().f = "ok";
                if (commande.addCommand())
                {
                    shop1.Items.Clear();
                    LoadViews();
                    if (id == 0)
                    {
                        ClassShowNotification.GetInstance().show("Enreigistrement");
                        resetSet1(true);
                        resetId();

                    }

                    else
                    {
                        ClassShowNotification.GetInstance().show("Modification");
                        resetId();
                        resetSet1(true);
                    }
                }


            }
            else
                MessageBox.Show("Impossible d'effectuer la vente Votre panier est vide!", "Erreur");

        }
        void imprimer() 
        {
            if (id != 0)
            {
                ClassReport.GetInstance().reportCommande(id);
                resetId();
            }
            else
                MessageBox.Show("Veuiller selection une commande!!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        void imprimer1()
        {
            if (id != 0)
            {
                ClassReport.GetInstance().reportCommandeF(id);
                resetId();
            }
            else
                MessageBox.Show("Veuiller selection une commande!!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void LoadViews() 
        {
            try 
            {
                GridControlCClient.DataSource = ClassChargerDataGrid.GetInstance().chargerCommande();
                GridControlCF.DataSource = ClassChargerDataGrid.GetInstance().chargerCommande1();
                if (GridViewCClient.RowCount > 0)
                    GridViewCClient.MoveFirst();
                if (GridViewCF.RowCount > 0)
                    GridViewCF.MoveFirst();
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        private void UserControlStock_MouseEnter(object sender, EventArgs e)
        {
            LoadViews();
        }

        private void shop_DoubleClick(object sender, EventArgs e)
        {
            try 
            {
                if (shop.Items.Count > 0) 
                {
                    var item = shop.SelectedItems;
                    
                    comboArticle.Text = item[0].SubItems[1].Text;
                    txtQuantite.Text = item[0].SubItems[2].Text;
                    txtPrix.Text = item[0].SubItems[3].Text;
                    comboClient.Text = item[0].SubItems[4].Text;
                    comboDate.Value = System.DateTime.Parse(item[0].SubItems[5].Text);
                    comboManiere.Text = item[0].SubItems[6].Text;
                    edit = true;
                   
                }
            
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        private void GridControlCClient_DoubleClick(object sender, EventArgs e)
        {
            resetSet(false);
        }

        

        private void shop_Click(object sender, EventArgs e)
        {
            edit = true;
        }

        private void comboArticle1_MouseEnter(object sender, EventArgs e)
        {
            addToList();
        }

        private void shop1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (shop1.Items.Count > 0)
                {
                    var item = shop1.SelectedItems;

                    comboArticle1.Text = item[0].SubItems[1].Text;
                    txtQuantite1.Text = item[0].SubItems[2].Text;
                    txtPrix1.Text = item[0].SubItems[3].Text;
                    comboNF.Text = item[0].SubItems[4].Text;
                    comboDate1.Value = System.DateTime.Parse(item[0].SubItems[5].Text);
                    comboManiere1.Text = item[0].SubItems[6].Text;
                    edit = true;

                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void shop1_Click(object sender, EventArgs e)
        {
            edit = true;
        }

        private void GridControlCF_DoubleClick(object sender, EventArgs e)
        {
            resetSet1(false);
        }

      

    }
}
