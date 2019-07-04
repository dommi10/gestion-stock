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
    public partial class UserControlInventaire : UserControl
    {
        String me;
        public UserControlInventaire()
        {
            InitializeComponent();
          
        }

       

        private void combo_MouseEnter(object sender, EventArgs e)
        {
            addToList();
        }
        void addToList() 
        {
            comboArticle.Items.Clear();
            comboArticle1.Items.Clear();
            comboArticle2.Items.Clear();
            comboNom.Items.Clear();

            Article.GetInstance().getArtcleV(comboArticle);
            Article.GetInstance().getArtcleV(comboArticle1);
            Article.GetInstance().getArtcleV(comboArticle2);
            ClassEmploye.GetInstance().getEmploye(comboNom);
           
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            if (comboNom.Enabled) 
            {   
                if(comboNom.Text == "")
                    MessageBox.Show("Veillwer selectionner un nom","Erreur");
                else
                    ClassReport.GetInstance().reportClient(comboNom.Text.Trim());

            }
            else
                ClassReport.GetInstance().reportClient();
                
        }
        void check() 
        {
            if (tous.Checked == true) 
            {
                sepci.Checked = false;
                comboNom.Enabled = false;
            }
            else 
            {
                tous.Checked = false;
                comboNom.Enabled = true;
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //if (comboArticle.Text == "")
            //    MessageBox.Show("Veiller selectionner un Article", "Erreur");
            //else
            //    ClassReport.GetInstance().reportArticle(comboArticle.Text);
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            //if(comboArticle1.Text =="" || combodate1.Text =="")
            //    MessageBox.Show("Veiller selectionner un Article", "Erreur");
            //else
            //    ClassReport.GetInstance().reportArticle1(System.DateTime.Parse(combodate1.Text).ToString(), (comboArticle1.Text));
        }

       
        private void comboNom_MouseEnter(object sender, EventArgs e)
        {
            addToList();
        }

        private void sepci_Click(object sender, EventArgs e)
        {
            check();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            //if (comboArticle2.Text == "" || combodatetime.Text == "" || combodatetimee.Text=="")
            //    MessageBox.Show("Veller completer tous les champs", "Erreur");
            //else
            //    ClassReport.GetInstance().reportArticle2(combodatetime.Text, combodatetimee.Text, comboArticle2.Text);
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            //ClassReport.GetInstance().reportArticle();
        }

        
      

       
    }
}
