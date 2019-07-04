namespace Fashion_Shop.design
{
    partial class UserControlFournisseur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlFournisseur));
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtFournPostnom = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.GridControlFournisseur = new DevExpress.XtraGrid.GridControl();
            this.GridViewFournisseur = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fournisseurId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.postnom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbfId = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtFournAddresse = new DevExpress.XtraEditors.MemoEdit();
            this.btSupprimer = new Bunifu.Framework.UI.BunifuThinButton2();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel15 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtFournTelephone = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtFournNom = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btEnregistrer = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlFournisseur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewFournisseur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFournAddresse.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtFournPostnom);
            this.panel3.Controls.Add(this.bunifuCustomLabel1);
            this.panel3.Controls.Add(this.GridControlFournisseur);
            this.panel3.Controls.Add(this.lbfId);
            this.panel3.Controls.Add(this.txtFournAddresse);
            this.panel3.Controls.Add(this.btSupprimer);
            this.panel3.Controls.Add(this.comboBox3);
            this.panel3.Controls.Add(this.bunifuCustomLabel15);
            this.panel3.Controls.Add(this.txtFournTelephone);
            this.panel3.Controls.Add(this.bunifuCustomLabel14);
            this.panel3.Controls.Add(this.txtFournNom);
            this.panel3.Controls.Add(this.btEnregistrer);
            this.panel3.Controls.Add(this.bunifuCustomLabel10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(748, 502);
            this.panel3.TabIndex = 1;
            // 
            // txtFournPostnom
            // 
            this.txtFournPostnom.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(154)))));
            this.txtFournPostnom.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFournPostnom.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(154)))));
            this.txtFournPostnom.BorderThickness = 3;
            this.txtFournPostnom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFournPostnom.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFournPostnom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFournPostnom.isPassword = false;
            this.txtFournPostnom.Location = new System.Drawing.Point(140, 53);
            this.txtFournPostnom.Margin = new System.Windows.Forms.Padding(4);
            this.txtFournPostnom.Name = "txtFournPostnom";
            this.txtFournPostnom.Size = new System.Drawing.Size(217, 35);
            this.txtFournPostnom.TabIndex = 48;
            this.txtFournPostnom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(20, 53);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(84, 21);
            this.bunifuCustomLabel1.TabIndex = 47;
            this.bunifuCustomLabel1.Text = "Post-nom :";
            // 
            // GridControlFournisseur
            // 
            this.GridControlFournisseur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridControlFournisseur.Location = new System.Drawing.Point(0, 311);
            this.GridControlFournisseur.MainView = this.GridViewFournisseur;
            this.GridControlFournisseur.Name = "GridControlFournisseur";
            this.GridControlFournisseur.Size = new System.Drawing.Size(748, 191);
            this.GridControlFournisseur.TabIndex = 46;
            this.GridControlFournisseur.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewFournisseur});
            this.GridControlFournisseur.DoubleClick += new System.EventHandler(this.GridControlFournisseur_DoubleClick);
            // 
            // GridViewFournisseur
            // 
            this.GridViewFournisseur.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Transparent;
            this.GridViewFournisseur.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridViewFournisseur.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.GridViewFournisseur.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.GridViewFournisseur.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.fournisseurId,
            this.nom,
            this.postnom,
            this.address,
            this.tel});
            this.GridViewFournisseur.GridControl = this.GridControlFournisseur;
            this.GridViewFournisseur.Name = "GridViewFournisseur";
            this.GridViewFournisseur.OptionsBehavior.Editable = false;
            this.GridViewFournisseur.OptionsFind.AlwaysVisible = true;
            // 
            // fournisseurId
            // 
            this.fournisseurId.Caption = "ID";
            this.fournisseurId.FieldName = "ID";
            this.fournisseurId.Name = "fournisseurId";
            // 
            // nom
            // 
            this.nom.Caption = "Fournisseur";
            this.nom.FieldName = "nom";
            this.nom.Name = "nom";
            this.nom.Visible = true;
            this.nom.VisibleIndex = 0;
            // 
            // postnom
            // 
            this.postnom.Caption = "postnom";
            this.postnom.FieldName = "postnom";
            this.postnom.Name = "postnom";
            this.postnom.Visible = true;
            this.postnom.VisibleIndex = 1;
            // 
            // address
            // 
            this.address.Caption = "Addresse";
            this.address.FieldName = "addresse";
            this.address.Name = "address";
            this.address.Visible = true;
            this.address.VisibleIndex = 2;
            // 
            // tel
            // 
            this.tel.Caption = "Telephone";
            this.tel.FieldName = "telephone";
            this.tel.Name = "tel";
            this.tel.Visible = true;
            this.tel.VisibleIndex = 3;
            // 
            // lbfId
            // 
            this.lbfId.AutoSize = true;
            this.lbfId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfId.Location = new System.Drawing.Point(20, 11);
            this.lbfId.Name = "lbfId";
            this.lbfId.Size = new System.Drawing.Size(0, 21);
            this.lbfId.TabIndex = 45;
            // 
            // txtFournAddresse
            // 
            this.txtFournAddresse.Location = new System.Drawing.Point(140, 163);
            this.txtFournAddresse.Name = "txtFournAddresse";
            this.txtFournAddresse.Size = new System.Drawing.Size(217, 60);
            this.txtFournAddresse.TabIndex = 44;
            // 
            // btSupprimer
            // 
            this.btSupprimer.ActiveBorderThickness = 1;
            this.btSupprimer.ActiveCornerRadius = 20;
            this.btSupprimer.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btSupprimer.ActiveForecolor = System.Drawing.Color.White;
            this.btSupprimer.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btSupprimer.BackColor = System.Drawing.Color.White;
            this.btSupprimer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSupprimer.BackgroundImage")));
            this.btSupprimer.ButtonText = "Supprimer";
            this.btSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSupprimer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSupprimer.ForeColor = System.Drawing.Color.SeaGreen;
            this.btSupprimer.IdleBorderThickness = 1;
            this.btSupprimer.IdleCornerRadius = 20;
            this.btSupprimer.IdleFillColor = System.Drawing.Color.White;
            this.btSupprimer.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btSupprimer.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btSupprimer.Location = new System.Drawing.Point(24, 248);
            this.btSupprimer.Margin = new System.Windows.Forms.Padding(5);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(113, 41);
            this.btSupprimer.TabIndex = 42;
            this.btSupprimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btSupprimer.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(-250, 232);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(217, 21);
            this.comboBox3.TabIndex = 41;
            // 
            // bunifuCustomLabel15
            // 
            this.bunifuCustomLabel15.AutoSize = true;
            this.bunifuCustomLabel15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel15.Location = new System.Drawing.Point(18, 163);
            this.bunifuCustomLabel15.Name = "bunifuCustomLabel15";
            this.bunifuCustomLabel15.Size = new System.Drawing.Size(81, 21);
            this.bunifuCustomLabel15.TabIndex = 37;
            this.bunifuCustomLabel15.Text = "Addresse :";
            // 
            // txtFournTelephone
            // 
            this.txtFournTelephone.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(154)))));
            this.txtFournTelephone.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFournTelephone.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(154)))));
            this.txtFournTelephone.BorderThickness = 3;
            this.txtFournTelephone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFournTelephone.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFournTelephone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFournTelephone.isPassword = false;
            this.txtFournTelephone.Location = new System.Drawing.Point(140, 108);
            this.txtFournTelephone.Margin = new System.Windows.Forms.Padding(4);
            this.txtFournTelephone.Name = "txtFournTelephone";
            this.txtFournTelephone.Size = new System.Drawing.Size(217, 35);
            this.txtFournTelephone.TabIndex = 36;
            this.txtFournTelephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(19, 108);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(87, 21);
            this.bunifuCustomLabel14.TabIndex = 35;
            this.bunifuCustomLabel14.Text = "Telephone :";
            // 
            // txtFournNom
            // 
            this.txtFournNom.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(154)))));
            this.txtFournNom.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFournNom.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(154)))));
            this.txtFournNom.BorderThickness = 3;
            this.txtFournNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFournNom.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFournNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFournNom.isPassword = false;
            this.txtFournNom.Location = new System.Drawing.Point(140, 11);
            this.txtFournNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtFournNom.Name = "txtFournNom";
            this.txtFournNom.Size = new System.Drawing.Size(217, 35);
            this.txtFournNom.TabIndex = 27;
            this.txtFournNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btEnregistrer
            // 
            this.btEnregistrer.ActiveBorderThickness = 1;
            this.btEnregistrer.ActiveCornerRadius = 20;
            this.btEnregistrer.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btEnregistrer.ActiveForecolor = System.Drawing.Color.White;
            this.btEnregistrer.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btEnregistrer.BackColor = System.Drawing.Color.White;
            this.btEnregistrer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btEnregistrer.BackgroundImage")));
            this.btEnregistrer.ButtonText = "Enreigistrer";
            this.btEnregistrer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEnregistrer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnregistrer.ForeColor = System.Drawing.Color.SeaGreen;
            this.btEnregistrer.IdleBorderThickness = 1;
            this.btEnregistrer.IdleCornerRadius = 20;
            this.btEnregistrer.IdleFillColor = System.Drawing.Color.White;
            this.btEnregistrer.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btEnregistrer.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btEnregistrer.Location = new System.Drawing.Point(244, 248);
            this.btEnregistrer.Margin = new System.Windows.Forms.Padding(5);
            this.btEnregistrer.Name = "btEnregistrer";
            this.btEnregistrer.Size = new System.Drawing.Size(113, 41);
            this.btEnregistrer.TabIndex = 23;
            this.btEnregistrer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btEnregistrer.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(20, 11);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(56, 21);
            this.bunifuCustomLabel10.TabIndex = 14;
            this.bunifuCustomLabel10.Text = "Nom  :";
            // 
            // UserControlFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Name = "UserControlFournisseur";
            this.Size = new System.Drawing.Size(748, 502);
            this.Load += new System.EventHandler(this.UserControlFournisseur_Load);
            this.MouseEnter += new System.EventHandler(this.UserControlFournisseur_MouseEnter);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlFournisseur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewFournisseur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFournAddresse.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel15;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtFournTelephone;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtFournNom;
        private Bunifu.Framework.UI.BunifuThinButton2 btEnregistrer;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuThinButton2 btSupprimer;
        private DevExpress.XtraEditors.MemoEdit txtFournAddresse;
        private Bunifu.Framework.UI.BunifuCustomLabel lbfId;
        private DevExpress.XtraGrid.GridControl GridControlFournisseur;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewFournisseur;
        private DevExpress.XtraGrid.Columns.GridColumn fournisseurId;
        private DevExpress.XtraGrid.Columns.GridColumn nom;
        private DevExpress.XtraGrid.Columns.GridColumn address;
        private DevExpress.XtraGrid.Columns.GridColumn tel;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtFournPostnom;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private DevExpress.XtraGrid.Columns.GridColumn postnom;
    }
}
