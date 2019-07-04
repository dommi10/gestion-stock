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
    public partial class FormLogin : Form
    {
        ClassLogin login;
        ClassNotification notification = new ClassNotification();
        public FormLogin()
        {
            InitializeComponent();
            
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            quitter();
            
        }
        public void quitter() {
            if (DialogResult.Yes == MessageBox.Show("Voulez-vous fermer l'application ?", "Quitter", MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            Application.Exit();
          
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                connexion();
                notification.showNotification("Success", "Login Success", Environment.CurrentDirectory + @"\images\Ok.ico");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void connexion() {
            if (txtUsername.Text == "" || txtPassword.Text == null)
            {
                labErreur.Text = "Veiller completer tous les champs";
                labErreur.Visible = true;
            }
            else {
                
                ClassUser.GetInstance().Username = txtUsername.Text;
                ClassUser.GetInstance().password = txtPassword.Text;
                if (ClassUser.GetInstance().login()) 
                {
                    this.Hide();
                    new FormMain().Show();
                    
                }
                else
                {
                    labErreur.Text = "Nom d'utilisateur ou mot de passe incorrect";
                }
                
                labErreur.Visible = true;
                txtUsername.Text = null;
                txtPassword.Text = null;

            
            }
                
        
        }

        private void txtUsername_MouseEnter(object sender, EventArgs e)
        {
            labErreur.Visible = false;
        }

        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            labErreur.Visible = false;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
             login = new ClassLogin();
        }

       
    }
}
