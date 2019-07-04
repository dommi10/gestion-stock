namespace Fashion_Shop.design
{
    partial class UserControlEntrer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlEntrer));
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboEnArticle = new MetroFramework.Controls.MetroComboBox();
            this.comboEnClient = new MetroFramework.Controls.MetroComboBox();
            this.btASupprimer = new Bunifu.Framework.UI.BunifuThinButton2();
            this.GridControlAchat = new DevExpress.XtraGrid.GridControl();
            this.GridViewAchat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btAjouter = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtEnDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtEnPrix = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtEnQuantite = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.panEmploye = new System.Windows.Forms.Panel();
            this.navigationPage3 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.panArticle = new System.Windows.Forms.Panel();
            this.navigationPage4 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.panFourn = new System.Windows.Forms.Panel();
            this.navigationPane1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlAchat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewAchat)).BeginInit();
            this.navigationPage2.SuspendLayout();
            this.navigationPage3.SuspendLayout();
            this.navigationPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPage1);
            this.navigationPane1.Controls.Add(this.navigationPage2);
            this.navigationPane1.Controls.Add(this.navigationPage3);
            this.navigationPane1.Controls.Add(this.navigationPage4);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2,
            this.navigationPage3,
            this.navigationPage4});
            this.navigationPane1.RegularSize = new System.Drawing.Size(836, 576);
            this.navigationPane1.SelectedPage = this.navigationPage1;
            this.navigationPane1.SelectedPageIndex = 0;
            this.navigationPane1.Size = new System.Drawing.Size(836, 576);
            this.navigationPane1.TabIndex = 0;
            this.navigationPane1.Text = "Achat Marchandise";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Achat Marchandise";
            this.navigationPage1.Controls.Add(this.panel1);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(711, 516);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.comboEnArticle);
            this.panel1.Controls.Add(this.comboEnClient);
            this.panel1.Controls.Add(this.btASupprimer);
            this.panel1.Controls.Add(this.GridControlAchat);
            this.panel1.Controls.Add(this.btAjouter);
            this.panel1.Controls.Add(this.txtEnDate);
            this.panel1.Controls.Add(this.bunifuCustomLabel5);
            this.panel1.Controls.Add(this.txtEnPrix);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.txtEnQuantite);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 516);
            this.panel1.TabIndex = 0;
            // 
            // comboEnArticle
            // 
            this.comboEnArticle.FormattingEnabled = true;
            this.comboEnArticle.ItemHeight = 23;
            this.comboEnArticle.Location = new System.Drawing.Point(151, 12);
            this.comboEnArticle.Name = "comboEnArticle";
            this.comboEnArticle.Size = new System.Drawing.Size(217, 29);
            this.comboEnArticle.TabIndex = 16;
            this.comboEnArticle.UseSelectable = true;
            this.comboEnArticle.MouseEnter += new System.EventHandler(this.comboEnArticle_MouseEnter);
            // 
            // comboEnClient
            // 
            this.comboEnClient.FormattingEnabled = true;
            this.comboEnClient.ItemHeight = 23;
            this.comboEnClient.Location = new System.Drawing.Point(156, 188);
            this.comboEnClient.Name = "comboEnClient";
            this.comboEnClient.Size = new System.Drawing.Size(212, 29);
            this.comboEnClient.TabIndex = 15;
            this.comboEnClient.UseSelectable = true;
            // 
            // btASupprimer
            // 
            this.btASupprimer.ActiveBorderThickness = 1;
            this.btASupprimer.ActiveCornerRadius = 20;
            this.btASupprimer.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btASupprimer.ActiveForecolor = System.Drawing.Color.White;
            this.btASupprimer.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btASupprimer.BackColor = System.Drawing.Color.White;
            this.btASupprimer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btASupprimer.BackgroundImage")));
            this.btASupprimer.ButtonText = "Supprimer";
            this.btASupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btASupprimer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btASupprimer.ForeColor = System.Drawing.Color.SeaGreen;
            this.btASupprimer.IdleBorderThickness = 1;
            this.btASupprimer.IdleCornerRadius = 20;
            this.btASupprimer.IdleFillColor = System.Drawing.Color.White;
            this.btASupprimer.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btASupprimer.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btASupprimer.Location = new System.Drawing.Point(83, 236);
            this.btASupprimer.Margin = new System.Windows.Forms.Padding(5);
            this.btASupprimer.Name = "btASupprimer";
            this.btASupprimer.Size = new System.Drawing.Size(113, 41);
            this.btASupprimer.TabIndex = 14;
            this.btASupprimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btASupprimer.Click += new System.EventHandler(this.actionButtons_Click);
            // 
            // GridControlAchat
            // 
            this.GridControlAchat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridControlAchat.Location = new System.Drawing.Point(-1, 285);
            this.GridControlAchat.MainView = this.GridViewAchat;
            this.GridControlAchat.Name = "GridControlAchat";
            this.GridControlAchat.Size = new System.Drawing.Size(711, 231);
            this.GridControlAchat.TabIndex = 13;
            this.GridControlAchat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewAchat});
          
            this.GridControlAchat.DoubleClick += new System.EventHandler(this.GridControlAchat_DoubleClick);
            // 
            // GridViewAchat
            // 
            this.GridViewAchat.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.GridViewAchat.GridControl = this.GridControlAchat;
            this.GridViewAchat.Name = "GridViewAchat";
            this.GridViewAchat.OptionsBehavior.Editable = false;
            this.GridViewAchat.OptionsFind.AlwaysVisible = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Article";
            this.gridColumn2.FieldName = "Article";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Quantite";
            this.gridColumn3.FieldName = "Quantite";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Prix";
            this.gridColumn4.FieldName = "Prix";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Date";
            this.gridColumn5.FieldName = "Date_";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Employe";
            this.gridColumn6.FieldName = "Employe";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // btAjouter
            // 
            this.btAjouter.ActiveBorderThickness = 1;
            this.btAjouter.ActiveCornerRadius = 20;
            this.btAjouter.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btAjouter.ActiveForecolor = System.Drawing.Color.White;
            this.btAjouter.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btAjouter.BackColor = System.Drawing.Color.White;
            this.btAjouter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAjouter.BackgroundImage")));
            this.btAjouter.ButtonText = "Valider";
            this.btAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAjouter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAjouter.ForeColor = System.Drawing.Color.SeaGreen;
            this.btAjouter.IdleBorderThickness = 1;
            this.btAjouter.IdleCornerRadius = 20;
            this.btAjouter.IdleFillColor = System.Drawing.Color.White;
            this.btAjouter.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btAjouter.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btAjouter.Location = new System.Drawing.Point(255, 236);
            this.btAjouter.Margin = new System.Windows.Forms.Padding(5);
            this.btAjouter.Name = "btAjouter";
            this.btAjouter.Size = new System.Drawing.Size(113, 41);
            this.btAjouter.TabIndex = 10;
            this.btAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btAjouter.Click += new System.EventHandler(this.actionButtons_Click);
            // 
            // txtEnDate
            // 
            this.txtEnDate.BackColor = System.Drawing.Color.SeaGreen;
            this.txtEnDate.BorderRadius = 0;
            this.txtEnDate.ForeColor = System.Drawing.Color.White;
            this.txtEnDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtEnDate.FormatCustom = null;
            this.txtEnDate.Location = new System.Drawing.Point(151, 150);
            this.txtEnDate.Name = "txtEnDate";
            this.txtEnDate.Size = new System.Drawing.Size(217, 25);
            this.txtEnDate.TabIndex = 9;
            this.txtEnDate.Value = new System.DateTime(2017, 11, 7, 12, 59, 37, 462);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(3, 151);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(97, 21);
            this.bunifuCustomLabel5.TabIndex = 8;
            this.bunifuCustomLabel5.Text = "Date Entrée :";
            // 
            // txtEnPrix
            // 
            this.txtEnPrix.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(154)))));
            this.txtEnPrix.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEnPrix.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(154)))));
            this.txtEnPrix.BorderThickness = 3;
            this.txtEnPrix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEnPrix.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEnPrix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEnPrix.isPassword = false;
            this.txtEnPrix.Location = new System.Drawing.Point(151, 99);
            this.txtEnPrix.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnPrix.Name = "txtEnPrix";
            this.txtEnPrix.Size = new System.Drawing.Size(217, 35);
            this.txtEnPrix.TabIndex = 7;
            this.txtEnPrix.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(3, 110);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(43, 21);
            this.bunifuCustomLabel4.TabIndex = 6;
            this.bunifuCustomLabel4.Text = "Prix :";
            // 
            // txtEnQuantite
            // 
            this.txtEnQuantite.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(154)))));
            this.txtEnQuantite.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEnQuantite.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(154)))));
            this.txtEnQuantite.BorderThickness = 3;
            this.txtEnQuantite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEnQuantite.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEnQuantite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEnQuantite.isPassword = false;
            this.txtEnQuantite.Location = new System.Drawing.Point(151, 48);
            this.txtEnQuantite.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnQuantite.Name = "txtEnQuantite";
            this.txtEnQuantite.Size = new System.Drawing.Size(217, 35);
            this.txtEnQuantite.TabIndex = 5;
            this.txtEnQuantite.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(3, 59);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(77, 21);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "Quantité :";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(3, 196);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(147, 21);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "Nom de l\'employer:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(127, 21);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Nom de l\'article :";
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "Employé";
            this.navigationPage2.Controls.Add(this.panEmploye);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(711, 516);
            // 
            // panEmploye
            // 
            this.panEmploye.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panEmploye.Location = new System.Drawing.Point(0, 0);
            this.panEmploye.Name = "panEmploye";
            this.panEmploye.Size = new System.Drawing.Size(711, 516);
            this.panEmploye.TabIndex = 0;
            // 
            // navigationPage3
            // 
            this.navigationPage3.Caption = "Article";
            this.navigationPage3.Controls.Add(this.panArticle);
            this.navigationPage3.Name = "navigationPage3";
            this.navigationPage3.Size = new System.Drawing.Size(711, 516);
            // 
            // panArticle
            // 
            this.panArticle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panArticle.Location = new System.Drawing.Point(0, 0);
            this.panArticle.Name = "panArticle";
            this.panArticle.Size = new System.Drawing.Size(711, 516);
            this.panArticle.TabIndex = 0;
            // 
            // navigationPage4
            // 
            this.navigationPage4.Caption = "Fournisseur";
            this.navigationPage4.Controls.Add(this.panFourn);
            this.navigationPage4.Name = "navigationPage4";
            this.navigationPage4.Size = new System.Drawing.Size(711, 516);
            // 
            // panFourn
            // 
            this.panFourn.BackColor = System.Drawing.Color.White;
            this.panFourn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panFourn.Location = new System.Drawing.Point(0, 0);
            this.panFourn.Name = "panFourn";
            this.panFourn.Size = new System.Drawing.Size(711, 516);
            this.panFourn.TabIndex = 0;
            // 
            // UserControlEntrer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.navigationPane1);
            this.Name = "UserControlEntrer";
            this.Size = new System.Drawing.Size(836, 576);
            this.Load += new System.EventHandler(this.UserControlEntrer_Load);
            this.MouseEnter += new System.EventHandler(this.UserControlEntrer_MouseEnter);
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlAchat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewAchat)).EndInit();
            this.navigationPage2.ResumeLayout(false);
            this.navigationPage3.ResumeLayout(false);
            this.navigationPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btAjouter;
        private Bunifu.Framework.UI.BunifuDatepicker txtEnDate;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtEnPrix;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtEnQuantite;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panEmploye;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage3;
        private System.Windows.Forms.Panel panArticle;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage4;
        private System.Windows.Forms.Panel panFourn;
        private DevExpress.XtraGrid.GridControl GridControlAchat;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewAchat;
        private Bunifu.Framework.UI.BunifuThinButton2 btASupprimer;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private MetroFramework.Controls.MetroComboBox comboEnArticle;
        private MetroFramework.Controls.MetroComboBox comboEnClient;
    }
}
