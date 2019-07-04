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
using System.IO;

namespace Fashion_Shop.design
{
    public partial class UserControlEmploye : UserControl
    {
        int id = 0;
        Char sexe = 'M';
        String filename;
        String type = "png";
        Byte[] images = null;
        ClassEmploye employe = new ClassEmploye();
        
        public UserControlEmploye()
        {
            InitializeComponent();
            id = 0;
        }

        private void UserControlEmploye_Load(object sender, EventArgs e)
        {
            LoadView();
            convertImageToBinnary(pictureBox1.Image);
            comboEmploye.Items.Add("Magasinier");
            comboEmploye.Items.Add("Employer");
            comboEmploye.Items.Add("Admin");
            comboEmploye.Items.Add("DG");
            comboEmploye.Items.Add("Magasinier");
        }
        private void choose()
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg|PNG|*.png", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {

                    filename = ofd.FileName;
                    if (filename.Contains(".jpg"))
                        type = "jpg";
                    else
                        type = "png";
                    pictureBox1.Image = Image.FromFile(filename);
                    convertImageToBinnary(pictureBox1.Image);


                }

            }
        }
        byte[] convertImageToBinnary(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                switch (type)
                {
                    case "png":
                        image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    case "jpg":
                        image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                }
                images = ms.ToArray();
                return ms.ToArray();

            }

        }

        void LoadView() 
        {
            try 
            {
                GridControlClient.DataSource = ClassChargerDataGrid.GetInstance().chargerEmploye();

                if (GridViewClient.RowCount > 0)
                    GridViewClient.MoveFirst();

            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            switch (((Control)sender).Name) 
            {
                case "btClientEnreigister":
                    save(id);
                    break;
                case "btClientSupprimer":
                    if (ClassUser.GetInstance().sNiveau > 2)
                    {
                        Supprimer(id);
                    }
                    else
                    {
                        ClassShowNotification.GetInstance().show("admin");
                    }
                    
                    
                    break;
                case "btCChoisir":
                    choose();
                    break;
                case "chkClientH":
                    loadSexe('M');
                    break;
                case "chkClientF":
                    loadSexe('F');
                    break;

            
            }
        }

        void save(int id) 
        {
            if (verification()) 
            {
                convertImageToBinnary(pictureBox1.Image);
                employe.employeID = id;
                employe.employeName = txtCNom.Text;
                employe.employePostnom = txtCPostnom.Text;
                employe.employePrenom = txtCPrenom.Text;
                employe.employePoste = comboEmploye.Text;
                employe.employeMatricule = "FSHOP-MATRICULE-EMP-" + comboEmploye.Text + txtCNom.Text + txtCPostnom.Text + txtCPrenom.Text;
                employe.employeNumber = txtCTelephone.Text;
                employe.employeAddresse = txtCAddresse.Text;
                employe.employeImage = images;
                employe.employeSexe = sexe;
                employe.employeAge = dtClient.Value.ToString();

                if (employe.addEmploye()) 
                {
                    LoadView();
                    resetSet(true);
                    if (id == 0) 
                    {
                        
                        ClassShowNotification.GetInstance().show("Enreigistrement");
                    }
                    else 
                    {
                        ClassShowNotification.GetInstance().show("Modification");
                    }

                }
            
            }
        
        }
        private Image convertBinaryToImage(Byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        private void resetSet(bool p)
        {
            switch (p) 
            {
                case true :
                    id = 0;
                    txtCNom.Text = "";
                    txtCPostnom.Text = "";
                    txtCPrenom.Text = "";
                    txtCAddresse.Text = "";
                    txtCTelephone.Text = "";
                    pictureBox1.Image = null;
                    loadSexe('M');
                    txtCMatricule.Text = "";
                    images = null;
                    comboEmploye.SelectedItem = null;
                    break;
                case false:
                    id = int.Parse(GridViewClient.GetFocusedRowCellValue(GridViewClient.Columns[0]).ToString());
                    txtCMatricule.Text = GridViewClient.GetFocusedRowCellValue(GridViewClient.Columns[1]).ToString();
                    txtCNom.Text = GridViewClient.GetFocusedRowCellValue(GridViewClient.Columns[2]).ToString();
                    txtCPostnom.Text = GridViewClient.GetFocusedRowCellValue(GridViewClient.Columns[3]).ToString();
                    txtCPrenom.Text = GridViewClient.GetFocusedRowCellValue(GridViewClient.Columns[4]).ToString();
                    if (Char.Parse(GridViewClient.GetFocusedRowCellValue(GridViewClient.Columns[5]).ToString()) == 'M')
                        loadSexe('M');
                    else
                        loadSexe('F');
                    dtClient.Value = System.DateTime.Parse(GridViewClient.GetFocusedRowCellValue(GridViewClient.Columns[6]).ToString());
                    comboEmploye.SelectedItem = GridViewClient.GetFocusedRowCellValue(GridViewClient.Columns[7]).ToString();
                    txtCTelephone.Text = GridViewClient.GetFocusedRowCellValue(GridViewClient.Columns[8]).ToString();
                    txtCAddresse.Text = GridViewClient.GetFocusedRowCellValue(GridViewClient.Columns[9]).ToString();
                    Byte[] image = (Byte[])GridViewClient.GetFocusedRowCellValue(GridViewClient.Columns[10]);
                    pictureBox1.Image = convertBinaryToImage(image);
                    break;
            }
        }
        Boolean verification() 
        {
            Boolean test= true;
            if (txtCNom.Text == "" || txtCPostnom.Text == "" || txtCPrenom.Text == "" || txtCTelephone.Text == "" || txtCAddresse.Text == "" || pictureBox1.Image == null)
                {
                    ClassShowNotification.GetInstance().show("champs");
                    test = false;
            
                }
            return test;

        
        }
        void loadSexe(Char sexe) 
        {
            switch (sexe) 
            {
                case 'M':
                    chkClientH.Checked = true;
                    chkClientF.Checked = false;
                    sexe = 'M';
                    break;
                case 'F':
                    chkClientH.Checked = false;
                    chkClientF.Checked = true;
                    sexe = 'F';
                    break;
            }
        }

        void Supprimer(int id) 
        {
            if (id != 0) 
            {
                if (ClassMessageDialog.GetInstance().showDialog("Suppression", "Voulez-vous vraiment supprimer cet employer ?"))
                {

                    if (employe.delete(id)) 
                    {
                        LoadView();
                        resetSet(true);
                        ClassShowNotification.GetInstance().show("delete");
                    }
                        
                }
            }
        }
        private void GridControlClient_DoubleClick(object sender, EventArgs e)
        {
            resetSet(false);
        }
    }
}
