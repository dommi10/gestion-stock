using Fashion_Shop.design;
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
using System.IO;

namespace Fashion_Shop
{
    public partial class Form1 : Form
    {
        ClassConfig cofing = null;
        ClassNotification notification = new ClassNotification();
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                this.Hide();
                progressBar1.Value = 0;
                timer1.Stop();
                FormConfig log = new FormConfig();
                log.Show();
            }
            else
                progressBar1.Value += 1;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                timer1.Start();
                
                cofing = new ClassConfig();
                cofing.createInitialDirectory();
                cofing.checkFileDB();
            }
            catch (Exception ex) 
            {
                notification.showNotification("Error",Application.ProductName +"CREATION DES FICHIERS A ECHOUERS"+ex.Message,Environment.CurrentDirectory + @"\images\Error_100px.png");
            
            }
            
        }
    }
}
