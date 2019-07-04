using Fashion_Shop.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fashion_Shop.design
{
    public partial class FormConfig : Form
    {
        bool test;
        ClassConfig classConnexion = new ClassConfig();
        public FormConfig()
        {
            InitializeComponent();
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            switch (((Control)sender).Name) 
            {
                    
                case "btfermer":
                    Application.Exit();
                    break;
                case "btTest":
                    Test();
                    break;
                case "btConfCon":
                    save();
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
             
                   
                    txtServerName.Text = "";
                    txtCUsername.Text = "";
                    txtCPassword.Text = "";
                    txtDatabase.Text = "";
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
                    this.Hide();
                    new FormLogin().Show();
                }
                else
                    ClassShowNotification.GetInstance().show("configNo");

            }


        }
    }
}
