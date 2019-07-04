using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fashion_Shop.data;

namespace Fashion_Shop.design
{
    public partial class FormMain : Form
    {
        UserControlEntrer entrer = new UserControlEntrer();
        UserControlSorti sorti = new UserControlSorti();
        UserControlHome home = new UserControlHome();
        UserControlStock stock = new UserControlStock();
        UserControlInventaire inventaire = new UserControlInventaire();
        UserControlSettings settings = new UserControlSettings();
        public FormMain()
        {
            InitializeComponent();
        }

       

        private void actionControleBt_Click_1(object sender, EventArgs e)
        {
            switch (((Control)sender).Name) 
            {
                case "BtHCMin":
                    WindowState = FormWindowState.Minimized;
                    break;
                case "BtHCMaxim":
                    if (WindowState == FormWindowState.Normal)
                        WindowState = FormWindowState.Maximized;
                    else
                        WindowState = FormWindowState.Normal;
                    break;
                case "btHClose":
                    if (DialogResult.Yes == MessageBox.Show("Voulez-vous vraiment quitter l'application ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                        Application.Exit();
                    break;
                
            }
            

        }

        

        private void FormMain_Load(object sender, EventArgs e)
        {
            changeControl(home);
            labUser.Text = ClassUser.GetInstance().sUsername;
            if (ClassUser.GetInstance().sNiveau == 1)
            {
                low.Visible = true;
                hight.Visible = false;
                med.Visible = false;
            }
            else if (ClassUser.GetInstance().sNiveau == 2)
            {
                low.Visible = false;
                hight.Visible = false;
                med.Visible = true;
            }
            else 
            {
                low.Visible = false;
                hight.Visible = true;
                med.Visible = false;
            }
            
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormLogin().Show();
            
        }


        public void changeControl(UserControl control) 
        {
            try
            {
                panelContrainer.Controls.Clear();
                control.Dock = DockStyle.Fill;
                panelContrainer.Controls.Add(control);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

     

        private void bunifuImageButton1_Click_2(object sender, EventArgs e)
        {
            if (panel3.Width == 50)
            {
                panel3.Visible = false;
                slidemenu.Visible = false;
                panel3.Width = 211;
                bunifuTransition1.ShowSync(panel3);
                

            }
            else
            {
                panel3.Visible = false;
                slidemenu.Visible = true;
                panel3.Width = 50;
                bunifuTransition1.ShowSync(panel3);
            
            }
        }

        

        private void slidemenu_Click_1(object sender, EventArgs e)
        {
            if (panel3.Width == 50)
            {
                panel3.Visible = false;
                slidemenu.Visible = false;
                panel3.Width = 211;
                bunifuTransition1.ShowSync(panel3);


            }
            else
            {
                panel3.Visible = false;
                slidemenu.Visible = true;
                panel3.Width = 50;
                bunifuTransition1.ShowSync(panel3);

            }
        }

       

        private void actionBouton_Click(object sender, EventArgs e)
        {

            switch (((Control)sender).Name) 
            {
                case "btHHome":
                    changeControl(home);
                    break;
                case "BtHAppro":
                    changeControl(entrer);
                    break;
                case "BtHDistrib":
                    changeControl(sorti);
                    break;
                case "BtHStock":
                    changeControl(stock);
                    break;
                case "BtHInventaire":
                    changeControl(inventaire);
                    break;
                case "BtHParam":
                    changeControl(settings);
                    break;
            }
        }

        

        
    }
}
