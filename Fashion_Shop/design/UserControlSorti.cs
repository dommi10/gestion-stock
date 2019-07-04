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
    public partial class UserControlSorti : UserControl
    {
        int id = 0;
        ClassSortie sortie = new ClassSortie();
        bool edit = false;
        bool sort = false;
        bool exist = false;
        decimal pri;
      
        public UserControlSorti()
        {
            InitializeComponent();
            id = 0;
        }

        private void UserControlSorti_Load(object sender, EventArgs e)
        {
            load();
            LoadViews();
        }

        void load() 
        {
            UserControlEmploye employe = new UserControlEmploye();
            UserControlArticle article = new UserControlArticle();
            UserControlFournisseur fournisseur = new UserControlFournisseur();
            UserControlClient client = new UserControlClient();
            try
            {
                panFournisseur.Controls.Clear();
                panArticle.Controls.Clear();
                panel.Controls.Clear();
                panel3.Controls.Clear();
                employe.Dock = DockStyle.Fill;
                article.Dock = DockStyle.Fill;
                fournisseur.Dock = DockStyle.Fill;
                client.Dock = DockStyle.Fill;
                panFournisseur.Controls.Add(employe);
                panArticle.Controls.Add(article);
                panel.Controls.Add(fournisseur);
                panel3.Controls.Add(client);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            navigationPane1.SelectedPage = navigationPage1;
        }

        private void actionButtons_Click(object sender, EventArgs e)
        {
            switch (((Control)sender).Name) 
            {
                case "btVEnreigistre":
                    save(id);
                    break;
                case "btAjouter":
                    addToSHop();
                    break;
                case "btEnlever":
                    if (ClassUser.GetInstance().sNiveau > 2)
                    {

                        remove();
                    }
                    else
                    {
                        ClassShowNotification.GetInstance().show("admin");
                    }
                    
                    break;
                case "btvSupprimer":
                    if (ClassUser.GetInstance().sNiveau > 2)
                    {
                        delete(id);
                    }
                    else
                    {
                        ClassShowNotification.GetInstance().show("admin");
                    }
                    
                    break;
                case "btvImprimer":
                    imprimer();
                    break;
            }
           
           
        }
        void imprimer() 
        {
            if (id != 0)
                ClassReport.GetInstance().reportVente(id);
            else
                MessageBox.Show("Veiller selectionner une vente avant d'imprimer", "Impression");
        
        }
        void delete(int id) 
        {
           
                if (id != 0)
                {
                    if (ClassMessageDialog.GetInstance().showDialog("Suppression", "Voulez vous vraiment effectuer cette suppression ?"))
                    {
                        sortie.sortieId = id;
                        sortie.listview = shop;
                        if (sortie.delete())
                        {
                        ClassShowNotification.GetInstance().show("delete");
                        tp.Text = "0";
                        label2.Text = "0";
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
        void addToList() 
        {
            comboArticle.Items.Clear();
            comboVEmplo.Items.Clear();
            comboClient.Items.Clear();
            ClassEmploye.GetInstance().getEmploye(comboVEmplo);
            Article.GetInstance().getArtcleV(comboArticle);
            ClassClient.GetInstance().GetClient(comboClient);
        }
        void remove() 
        {
            if (edit)
            {
                if (id == 0)
                {
                    var item = shop.SelectedItems;
                    shop.Items.Remove(item[0]);
                    label2.Text = (int.Parse(label2.Text) - 1).ToString();
                    resetSet(true);
                }
                else 
                {
                    if(ClassMessageDialog.GetInstance().showDialog("Suppression","Voulez-vous vraiment supprimer cette vente? Noter qu'elle sera impossible de la recuperer!"))
                    {
                        var item = shop.SelectedItems;
                        
                        int idv = int.Parse(item[0].SubItems[0].Text);
                        int quantite = int.Parse(item[0].SubItems[2].Text);
                        sortie.sortieId = id;
                        sortie.quantite = quantite;
                        ClassVente.GetInstance().VenteId = idv;
                        ClassVente.GetInstance().sortieId = id;
                        ClassVente.GetInstance().quantite = quantite;

                        
                        if (sortie.deletQuantie()) 
                        {
                            pri = Decimal.Parse((int.Parse(item[0].SubItems[2].Text) * Decimal.Parse(item[0].SubItems[3].Text)).ToString());
                            if (ClassVente.GetInstance().delete()) 
                            {
                                ClassShowNotification.GetInstance().show("delete");
                                shop.Items.Remove(item[0]);
                                label2.Text = (int.Parse(label2.Text) - 1).ToString();
                               
                                tp.Text = (Decimal.Parse(tp.Text) - pri).ToString();
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

        void addToSHop()
        {
            if (verification()) 
            {
                
                ClassMagasin.GetInstance().NomArticle = comboArticle.Text;
                int quantit = int.Parse(txtQuantite.Text);
                int quantite = ClassMagasin.GetInstance().getQuantite() - quantit;
                if (quantite > 4)
                {
                    if (shop.Items.Count > 0)
                    {
                        if (edit)
                        {
                            
                            tp.Text = (Decimal.Parse(tp.Text) + ((Decimal.Parse(txtVPrix.Text) * int.Parse(txtQuantite.Text))-pri).ToString());
                            var item = shop.SelectedItems;
                            if (id == 0)
                                item[0].SubItems[0].Text = "" + id;
                            item[0].SubItems[1].Text = comboArticle.Text;
                            item[0].SubItems[2].Text = txtQuantite.Text;
                            item[0].SubItems[3].Text = txtVPrix.Text;
                            item[0].SubItems[4].Text = comboDate.Value.ToString();
                            item[0].SubItems[5].Text = comboVEmplo.Text;
                            item[0].SubItems[6].Text = comboClient.Text;
                            item[0].SubItems[7].Text = ClassUser.GetInstance().GetUser();
                            ClassVente.GetInstance().VenteId = int.Parse(item[0].SubItems[0].Text);
                            ClassVente.GetInstance().quantite = int.Parse(item[0].SubItems[2].Text);
                            ClassVente.GetInstance().update();
                            resetSet(true);
                            edit = false;
                                    
                         }
                        else
                        {
                            foreach (ListViewItem items in shop.Items)
                            {
                                
                                if (items.SubItems[1].Text == comboArticle.Text)
                                {
                            
                                    MessageBox.Show("Ce produit existe déjà");
                                    exist = true;
                                    resetSet(true);
                                }
                            }
                            if (!exist) 
                            {
                                String[] line = new String[]
                                          {
                                            ""+id,
                                            comboArticle.Text,
                                            txtQuantite.Text,
                                            txtVPrix.Text,
                                            comboDate.Value.ToString(),
                                            comboVEmplo.Text,
                                            comboClient.Text,
                                            ClassUser.GetInstance().GetUser()
                      
                                          };

                                shop.Items.Add(new ListViewItem(line));
                                
                                label2.Text = (int.Parse(label2.Text) + 1).ToString();
                                tp.Text = (Decimal.Parse(tp.Text) + (Decimal.Parse(txtVPrix.Text) * int.Parse(txtQuantite.Text))).ToString();
                                resetSet(true);
                            }
                            exist = false;
                            
                        }
                    }
                    else 
                    {
                        String[] line = new String[]
                      {
                        ""+id,
                        comboArticle.Text,
                        txtQuantite.Text,
                        txtVPrix.Text,
                        comboDate.Value.ToString(),
                        comboVEmplo.Text,
                        comboClient.Text,
                        ClassUser.GetInstance().GetUser()
                      
                      };
                       
                        shop.Items.Add(new ListViewItem(line));
                        tp.Text = (Decimal.Parse(tp.Text) + (Decimal.Parse(txtVPrix.Text) * int.Parse(txtQuantite.Text))).ToString();
                        resetSet(true);
                        label2.Text = (int.Parse(label2.Text) + 1).ToString();
                    }
                    
                }
                else
                    MessageBox.Show("La quantite stock est insufisante :","Attention",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                
             
            }
        }

        private void comboArticle_MouseEnter(object sender, EventArgs e)
        {
            addToList();
        }


        void save(int id) 
        {
           
                if (shop.Items.Count > 0)
                {
                    foreach (ListViewItem item in shop.Items)
                    {
                        ClassMagasin.GetInstance().NomArticle = item.SubItems[1].Text;
                        int quantite = ClassMagasin.GetInstance().getQuantite() - (int.Parse(item.SubItems[2].Text));
                        if (quantite > 4)
                        {
                            sort = true;
                        }

                    }
                    if (sort == true)
                    {
                        
                        int quantite = 0;
                        foreach(ListViewItem item in shop.Items)
                        {
                            quantite += int.Parse(item.SubItems[2].Text);
                        }
                        
                        sortie.sortieId = id;
                        sortie.date = System.DateTime.Now;
                        sortie.nomUtilisateur = ClassUser.GetInstance().GetUser();
                        sortie.quantite = quantite;
                        sortie.listview = shop;
                        if (sortie.addSortie())
                        {
                            shop.Items.Clear();
                            tp.Text = "0";
                            label2.Text="0";
                            
                            
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
                        MessageBox.Show("Cette sortie ne sera pas Valide tant que la quantite de l'un des articles est supperieur a la quantite disponible ");
                }
                else
                    MessageBox.Show("Impossible d'effectuer la vente Votre panier est vide!","Erreur");

            
        }
        void LoadViews() 
        {
            try 
            {
                GridControlVente.DataSource = ClassChargerDataGrid.GetInstance().chargerSortie();
                if (GridViewVente.RowCount > 0)
                    GridViewVente.MoveFirst();
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        Boolean verification() 
        {
            bool p = false;
            if (!(txtQuantite.Text == "" || txtVPrix.Text == "" || comboArticle.Text == "" || comboVEmplo.Text == "" || comboClient.Text  ==""))
                p = true;
            else
                ClassShowNotification.GetInstance().show("champs");
            return p;

        }

        void resetSet(bool p) 
        {
            switch (p) 
            {
                case true:
                    
                    txtQuantite.Text = null;
                    txtVPrix.Text = null;
                    comboDate.Text = null;
                    comboArticle.Text = null;
                    comboVEmplo.Text = null;
                    comboClient.Text = null;
                 
                    break;
                case false:
                    label2.Text = "0";
                    tp.Text = "0";
                    id = int.Parse(GridViewVente.GetFocusedRowCellValue(GridViewVente.Columns[0]).ToString());
                    sortie.sortieId = id;
                    sortie.listview = shop;
                    sortie.detailSortie();
                    label2.Text = sortie.total.ToString();
                    tp.Text = sortie.pri.ToString();
                    break;
            }
        }
        void resetId()
        { 
            id = 0; 
        }



        private void shop_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (shop.Items.Count > 0) 
                {
                    var item = shop.SelectedItems;
                    comboArticle.Text = item[0].SubItems[1].Text;
                    txtQuantite.Text =  item[0].SubItems[2].Text;
                    txtVPrix.Text =     item[0].SubItems[3].Text;
                    comboDate.Value =   System.DateTime.Parse(item[0].SubItems[4].Text);
                    comboVEmplo.Text =   item[0].SubItems[5].Text;
                    comboClient.Text = item[0].SubItems[6].Text;
                    pri = Decimal.Parse((int.Parse(item[0].SubItems[2].Text) * Decimal.Parse(item[0].SubItems[3].Text)).ToString()); 
                    edit = true;
                    if (id != 0)
                    {
                        ClassVente.GetInstance().VenteId = int.Parse(item[0].SubItems[0].Text);
                        ClassVente.GetInstance().quantite = int.Parse(item[0].SubItems[2].Text);
                        ClassVente.GetInstance().deleteQuantite();
                    }
                         
                }
            
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        private void GridControlVente_DoubleClick(object sender, EventArgs e)
        {
            resetSet(false);
        }

        private void shop_Click(object sender, EventArgs e)
        {
            edit = true;
        }

        private void btvImprimer_MouseEnter(object sender, EventArgs e)
        {
            LoadViews();
        }

        private void UserControlSorti_MouseEnter(object sender, EventArgs e)
        {
            LoadViews();
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            LoadViews();
        }

       
     

        

       
    }
}
