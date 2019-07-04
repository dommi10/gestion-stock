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
    public partial class UserControlSettings : UserControl
    {
        ClassConfig classConnexion = new ClassConfig();
        ClassNotification notification = new ClassNotification();
        ClassUser usern = new ClassUser();
        Boolean test = false;
        int id = 0;
        public UserControlSettings()
        {
            InitializeComponent();
            id = 0;
        }

        private void actionbuttons_Click(object sender, EventArgs e)
        {
            switch (((Control)sender).Name) 
            {
                case "btTest":
                    if (ClassUser.GetInstance().sNiveau > 2)
                    {
                        Test();
                    }
                    else
                    {
                        ClassShowNotification.GetInstance().show("admin");
                    }
                    
                    break;
                case "btConfCon":
                    if (ClassUser.GetInstance().sNiveau > 2)
                    {
                        save();
                    }
                    else
                    {
                        ClassShowNotification.GetInstance().show("admin");
                    }
                    
                    break;
                case "btdele":
                    if (ClassUser.GetInstance().sNiveau > 2)
                    {
                        delete(); 
                    }
                    else
                    {
                        ClassShowNotification.GetInstance().show("admin");
                    }
                    
                    break;
                case "btEnreigistrer":
                    if (ClassUser.GetInstance().sNiveau > 2)
                    {
                        saveUser();
                    }
                    else
                    {
                        ClassShowNotification.GetInstance().show("admin");
                    }
                    
                    break;
            
            }
           
        }

        Boolean Test() 
        {
            if (verification())
            {
                if (classConnexion.setConfiguration(txtServerName.Text, txtDatabase.Text, txtCUsername.Text, txtCPassword.Text))
                {
                    ClassShowNotification.GetInstance().show("testok");
                    test = true;
                    return true;
                }

                else
                {

                    reset(true);
                    test = false;
                    ClassShowNotification.GetInstance().show("testNo");
                }
                return false;
            }
            return false;
        }
        Boolean verification() 
        {
            if (txtServerName.Text == "" || txtCUsername.Text == "" || txtCPassword.Text == "" || txtDatabase.Text == "")
            {
                ClassShowNotification.GetInstance().show("champs");
                return false;
            }
            return true;
            
        }
        void reset(bool p) 
        {
            switch (p) 
            {
                case true:
                id=0;
                txtUsername.Text =null;
                txtPassword.Text =null;
                txtNiveau.Text =null;
                txtServerName.Text = "";
                txtCUsername.Text = "";
                txtCPassword.Text = "";
                txtDatabase.Text = "";
                    break;
                case false:
                    id= int.Parse(GridViewUser.GetFocusedRowCellValue(GridViewUser.Columns[0]).ToString());
                    txtUsername.Text = GridViewUser.GetFocusedRowCellValue(GridViewUser.Columns[1]).ToString();
                    txtPassword.Text = GridViewUser.GetFocusedRowCellValue(GridViewUser.Columns[2]).ToString();
                    int n = int.Parse(GridViewUser.GetFocusedRowCellValue(GridViewUser.Columns[3]).ToString());
                    if (n == 1) 
                    txtNiveau.Text = "user";
                    else if(n == 2)
                        txtNiveau.Text = "Admin";
                    else
                        txtNiveau.Text = "Super Admin";
                   break;
            }
            
        }
        
        void save() 
        {
            if (verification()) 
            {
                if (test)
                {
                   
                    classConnexion.writeInfile(txtServerName.Text, txtDatabase.Text, txtCUsername.Text, txtCPassword.Text);
                    reset(true);
                    ClassShowNotification.GetInstance().show("configok");
                }
                else
                    ClassShowNotification.GetInstance().show("configNo");
            
            }
           
           
        }
        void delete() 
        {
            if (id != 0) 
            {
                if (ClassMessageDialog.GetInstance().showDialog("Supprission", "Voulez-vous vraiment supprimer cet utilisateur"))
                {
                    usern.idUser = id;
                    if (usern.delete())
                    {
                        ClassShowNotification.GetInstance().show("delete");
                        reset(true);
                        LoadView();
                    }
                }
            }
            else 
            {
                MessageBox.Show("Veillez selectionner un utilisateur", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void LoadView() 
        {
            try 
            {
                GridControlUser.DataSource = ClassChargerDataGrid.GetInstance().chargerUtilisateur();
                if (GridViewUser.RowCount > 0)
                    GridViewUser.MoveFirst();
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        
        void saveUser() 
        {
            if (verification1()) 
            {
                usern.idUser = id;
                usern.Username = txtUsername.Text;
                usern.password = txtPassword.Text;
                if (txtNiveau.Text == "Admin")
                    usern.niveau = 2;
                else if (txtNiveau.Text == "Super Admin")
                    usern.niveau = 2;
                else
                    usern.niveau = 1;

                if (usern.addUser()) 
                {
                    LoadView();


                    if (id == 0)
                    {

                        ClassShowNotification.GetInstance().show("Enreigistrement");
                        reset(true);
                    }
                    else
                    {
                        ClassShowNotification.GetInstance().show("Modification");
                        reset(true);
                    }
                        
                }


            }  
        }
        bool verification1() 
        {
            bool p = true;
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtNiveau.Text == "")
            {
                ClassShowNotification.GetInstance().show("champs");
            }
            return p;
        }

        private void UserControlSettings_Load(object sender, EventArgs e)
        {
            LoadView();
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            LoadView();
        }

        private void GridControlUser_DoubleClick(object sender, EventArgs e)
        {
            reset(false);
        }

       

        

    }
}
