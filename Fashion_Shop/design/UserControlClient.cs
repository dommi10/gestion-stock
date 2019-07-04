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
    public partial class UserControlClient : UserControl
    {
        Char sexe;
        int id = 0;
        ClassNotification notification = new ClassNotification();
        ClassClient client = new ClassClient();
        public UserControlClient()
        {
            InitializeComponent();
            id = 0;
        }

        private void chkClientH_OnChange(object sender, EventArgs e)
        {
            if(chkClientF.Checked)
                chkClientF.Checked = false;
            sexe = 'M';
        }

        private void chkClientF_OnChange(object sender, EventArgs e)
        {
            if (chkClientH.Checked)
                chkClientH.Checked = false;
            sexe = 'F';
        }

        void addClient() 
        {
          
            if(verification())
            {
                client.clientId = id;
                client.clientName = txtClientName.Text.Trim();
                client.clientNumber = txtClientTel.Text.Trim();
                client.clientAddress = txtClientAddresse.Text.Trim();
                client.clientSexe = sexe;

                if (client.addClient()) 
                {
                    loadViews();
                    resetSet(true);
                    if (id == 0)
                        ClassShowNotification.GetInstance().show("Enreigistrement");
                    else
                        ClassShowNotification.GetInstance().show("Modification");

                }
            }
        }
        void resetSet(Boolean test) 
        {
            switch (test) 
            {
                case true:
                    txtClientName.Text = "";
                    txtClientTel.Text = "";
                    txtClientAddresse.Text = "";
                    id = 0;
                    break;
                case false:
                    id = int.Parse(GridViewClient.GetFocusedRowCellValue(GridViewClient.Columns[0]).ToString());
                    txtClientName.Text = GridViewClient.GetFocusedRowCellValue(GridViewClient.Columns[1]).ToString();
                    txtClientTel.Text = GridViewClient.GetFocusedRowCellValue(GridViewClient.Columns[4]).ToString();
                    if (Char.Parse(GridViewClient.GetFocusedRowCellValue(GridViewClient.Columns[2]).ToString()) == 'M')
                    {
                        chkClientH.Checked = true;
                        chkClientF.Checked = false;
                    }
                       
                    else
                    {
                        chkClientF.Checked = true;
                        chkClientH.Checked = false;
                    }
                       
                    txtClientAddresse.Text = GridViewClient.GetFocusedRowCellValue(GridViewClient.Columns[3]).ToString();

                    break;
            
            }
            
        }

        void loadViews() 
        {
            try 
            {
                GridControlClient.DataSource = ClassChargerDataGrid.GetInstance().chargerClient();

                if (GridViewClient.RowCount > 0)
                    GridViewClient.MoveFirst();
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);            
            }
        
        }

        private void actionButtons_Click(object sender, EventArgs e)
        {
            switch (((Control)sender).Name) 
            {
                case "btCEnreigistre":
                    addClient();
                    break;
                case "btCSupprimer":
                    if (ClassUser.GetInstance().sNiveau > 1)
                    {
                        Supprimer(id);
                    }
                    else
                    {
                        ClassShowNotification.GetInstance().show("admin");
                    }
                    
                    break;
            }
        }

        private void UserControlClient_Load(object sender, EventArgs e)
        {
            sexe = 'M';
            loadViews();
        }

        void Supprimer(int id) 
        {
            if (ClassMessageDialog.GetInstance().showDialog("Suppression","Voulez-vous vraiment supprimer ce client")) 
            {
                if (client.delete(id)) 
                {
                    loadViews();
                    resetSet(true);
                    ClassShowNotification.GetInstance().show("delete");
                }
            }
        }
        Boolean verification() 
        {
            Boolean test = true;
            if (txtClientName.Text == "" || txtClientTel.Text == "" || txtClientAddresse.Text == "")
            {
                test = false;
                ClassShowNotification.GetInstance().show("champs");
            }
            return test;
        }

        private void GridControlClient_DoubleClick(object sender, EventArgs e)
        {
            resetSet(false);
        }

        

       

       
    }
}
