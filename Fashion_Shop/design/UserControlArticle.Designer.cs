namespace Fashion_Shop.design
{
    partial class UserControlArticle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlArticle));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dates = new MetroFramework.Controls.MetroDateTime();
            this.daten = new MetroFramework.Controls.MetroDateTime();
            this.GridControlArticle = new DevExpress.XtraGrid.GridControl();
            this.GridViewArticle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Produit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.descr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.image_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nomFoum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtdesc = new DevExpress.XtraEditors.MemoEdit();
            this.btEnrter = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btSupp = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel16 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtville = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtqtes = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtqte = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtpays = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtCode = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlArticle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewArticle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdesc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dates);
            this.panel2.Controls.Add(this.daten);
            this.panel2.Controls.Add(this.GridControlArticle);
            this.panel2.Controls.Add(this.txtdesc);
            this.panel2.Controls.Add(this.btEnrter);
            this.panel2.Controls.Add(this.btSupp);
            this.panel2.Controls.Add(this.bunifuCustomLabel2);
            this.panel2.Controls.Add(this.bunifuCustomLabel16);
            this.panel2.Controls.Add(this.txtville);
            this.panel2.Controls.Add(this.txtqtes);
            this.panel2.Controls.Add(this.txtqte);
            this.panel2.Controls.Add(this.txtpays);
            this.panel2.Controls.Add(this.txtCode);
            this.panel2.Controls.Add(this.bunifuCustomLabel4);
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Controls.Add(this.bunifuCustomLabel3);
            this.panel2.Controls.Add(this.bunifuCustomLabel8);
            this.panel2.Controls.Add(this.bunifuCustomLabel9);
            this.panel2.Controls.Add(this.bunifuCustomLabel10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(711, 441);
            this.panel2.TabIndex = 3;
            // 
            // dates
            // 
            this.dates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dates.Location = new System.Drawing.Point(507, 52);
            this.dates.MinimumSize = new System.Drawing.Size(0, 29);
            this.dates.Name = "dates";
            this.dates.Size = new System.Drawing.Size(200, 29);
            this.dates.TabIndex = 49;
            // 
            // daten
            // 
            this.daten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.daten.Location = new System.Drawing.Point(505, 8);
            this.daten.MinimumSize = new System.Drawing.Size(0, 29);
            this.daten.Name = "daten";
            this.daten.Size = new System.Drawing.Size(200, 29);
            this.daten.TabIndex = 48;
            // 
            // GridControlArticle
            // 
            this.GridControlArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridControlArticle.Location = new System.Drawing.Point(0, 257);
            this.GridControlArticle.MainView = this.GridViewArticle;
            this.GridControlArticle.Name = "GridControlArticle";
            this.GridControlArticle.Size = new System.Drawing.Size(711, 184);
            this.GridControlArticle.TabIndex = 47;
            this.GridControlArticle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewArticle});
            this.GridControlArticle.DoubleClick += new System.EventHandler(this.GridControlArticle_DoubleClick);
            // 
            // GridViewArticle
            // 
            this.GridViewArticle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.Produit,
            this.descr,
            this.image_,
            this.nomFoum,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.GridViewArticle.GridControl = this.GridControlArticle;
            this.GridViewArticle.Name = "GridViewArticle";
            this.GridViewArticle.OptionsBehavior.Editable = false;
            this.GridViewArticle.OptionsFind.AlwaysVisible = true;
            // 
            // ID
            // 
            this.ID.Caption = "CODE";
            this.ID.FieldName = "CODE";
            this.ID.Name = "ID";
            // 
            // Produit
            // 
            this.Produit.Caption = "DESIGNATION";
            this.Produit.FieldName = "DESIGNATION";
            this.Produit.Name = "Produit";
            this.Produit.Visible = true;
            this.Produit.VisibleIndex = 0;
            // 
            // descr
            // 
            this.descr.Caption = "PAYS DE PROVANCE";
            this.descr.FieldName = "PAYSPROV";
            this.descr.Name = "descr";
            this.descr.Visible = true;
            this.descr.VisibleIndex = 1;
            // 
            // image_
            // 
            this.image_.Caption = "VILLE DE PROVENANCE";
            this.image_.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.image_.FieldName = "VILLEPROV";
            this.image_.Name = "image_";
            // 
            // nomFoum
            // 
            this.nomFoum.Caption = "DATE NAISSANCE";
            this.nomFoum.FieldName = "DATEEN";
            this.nomFoum.Name = "nomFoum";
            this.nomFoum.Visible = true;
            this.nomFoum.VisibleIndex = 2;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "DATE DE SORTE";
            this.gridColumn2.FieldName = "DATESORT";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "QUANTITE ENTREE";
            this.gridColumn3.FieldName = "QTEEN";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "QUANTITE INITIALE";
            this.gridColumn4.FieldName = "QTEIN";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 5;
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(167, 48);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(217, 48);
            this.txtdesc.TabIndex = 45;
            // 
            // btEnrter
            // 
            this.btEnrter.ActiveBorderThickness = 1;
            this.btEnrter.ActiveCornerRadius = 20;
            this.btEnrter.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btEnrter.ActiveForecolor = System.Drawing.Color.White;
            this.btEnrter.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btEnrter.BackColor = System.Drawing.Color.White;
            this.btEnrter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btEnrter.BackgroundImage")));
            this.btEnrter.ButtonText = "Enregistrer";
            this.btEnrter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEnrter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnrter.ForeColor = System.Drawing.Color.SeaGreen;
            this.btEnrter.IdleBorderThickness = 1;
            this.btEnrter.IdleCornerRadius = 20;
            this.btEnrter.IdleFillColor = System.Drawing.Color.White;
            this.btEnrter.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btEnrter.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btEnrter.Location = new System.Drawing.Point(60, 208);
            this.btEnrter.Margin = new System.Windows.Forms.Padding(5);
            this.btEnrter.Name = "btEnrter";
            this.btEnrter.Size = new System.Drawing.Size(137, 41);
            this.btEnrter.TabIndex = 43;
            this.btEnrter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btEnrter.Click += new System.EventHandler(this.actionbutton_Click);
            // 
            // btSupp
            // 
            this.btSupp.ActiveBorderThickness = 1;
            this.btSupp.ActiveCornerRadius = 20;
            this.btSupp.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btSupp.ActiveForecolor = System.Drawing.Color.White;
            this.btSupp.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btSupp.BackColor = System.Drawing.Color.White;
            this.btSupp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSupp.BackgroundImage")));
            this.btSupp.ButtonText = "Supprimer";
            this.btSupp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSupp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSupp.ForeColor = System.Drawing.Color.SeaGreen;
            this.btSupp.IdleBorderThickness = 1;
            this.btSupp.IdleCornerRadius = 20;
            this.btSupp.IdleFillColor = System.Drawing.Color.White;
            this.btSupp.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btSupp.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btSupp.Location = new System.Drawing.Point(255, 208);
            this.btSupp.Margin = new System.Windows.Forms.Padding(5);
            this.btSupp.Name = "btSupp";
            this.btSupp.Size = new System.Drawing.Size(113, 41);
            this.btSupp.TabIndex = 42;
            this.btSupp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btSupp.Click += new System.EventHandler(this.actionbutton_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(394, 53);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(79, 21);
            this.bunifuCustomLabel2.TabIndex = 40;
            this.bunifuCustomLabel2.Text = "Date Sorti";
            // 
            // bunifuCustomLabel16
            // 
            this.bunifuCustomLabel16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel16.AutoSize = true;
            this.bunifuCustomLabel16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel16.Location = new System.Drawing.Point(392, 8);
            this.bunifuCustomLabel16.Name = "bunifuCustomLabel16";
            this.bunifuCustomLabel16.Size = new System.Drawing.Size(90, 21);
            this.bunifuCustomLabel16.TabIndex = 40;
            this.bunifuCustomLabel16.Text = "Date Entrée";
            // 
            // txtville
            // 
            this.txtville.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(154)))));
            this.txtville.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtville.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(154)))));
            this.txtville.BorderThickness = 3;
            this.txtville.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtville.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtville.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtville.isPassword = false;
            this.txtville.Location = new System.Drawing.Point(167, 148);
            this.txtville.Margin = new System.Windows.Forms.Padding(4);
            this.txtville.Name = "txtville";
            this.txtville.Size = new System.Drawing.Size(217, 37);
            this.txtville.TabIndex = 27;
            this.txtville.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtqtes
            // 
            this.txtqtes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtqtes.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(154)))));
            this.txtqtes.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtqtes.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(154)))));
            this.txtqtes.BorderThickness = 3;
            this.txtqtes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtqtes.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtqtes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtqtes.isPassword = false;
            this.txtqtes.Location = new System.Drawing.Point(508, 149);
            this.txtqtes.Margin = new System.Windows.Forms.Padding(4);
            this.txtqtes.Name = "txtqtes";
            this.txtqtes.Size = new System.Drawing.Size(200, 37);
            this.txtqtes.TabIndex = 27;
            this.txtqtes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtqte
            // 
            this.txtqte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtqte.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(154)))));
            this.txtqte.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtqte.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(154)))));
            this.txtqte.BorderThickness = 3;
            this.txtqte.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtqte.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtqte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtqte.isPassword = false;
            this.txtqte.Location = new System.Drawing.Point(508, 102);
            this.txtqte.Margin = new System.Windows.Forms.Padding(4);
            this.txtqte.Name = "txtqte";
            this.txtqte.Size = new System.Drawing.Size(200, 37);
            this.txtqte.TabIndex = 27;
            this.txtqte.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtpays
            // 
            this.txtpays.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(154)))));
            this.txtpays.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpays.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(154)))));
            this.txtpays.BorderThickness = 3;
            this.txtpays.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpays.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtpays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpays.isPassword = false;
            this.txtpays.Location = new System.Drawing.Point(167, 103);
            this.txtpays.Margin = new System.Windows.Forms.Padding(4);
            this.txtpays.Name = "txtpays";
            this.txtpays.Size = new System.Drawing.Size(217, 37);
            this.txtpays.TabIndex = 27;
            this.txtpays.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCode
            // 
            this.txtCode.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(154)))));
            this.txtCode.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCode.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(154)))));
            this.txtCode.BorderThickness = 3;
            this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode.Enabled = false;
            this.txtCode.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCode.isPassword = false;
            this.txtCode.Location = new System.Drawing.Point(167, 4);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(217, 37);
            this.txtCode.TabIndex = 27;
            this.txtCode.Text = "0";
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(386, 157);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(120, 21);
            this.bunifuCustomLabel4.TabIndex = 16;
            this.bunifuCustomLabel4.Text = "Quantité Initiale";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 153);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(146, 21);
            this.bunifuCustomLabel1.TabIndex = 16;
            this.bunifuCustomLabel1.Text = "Ville de provenance";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(386, 110);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(118, 21);
            this.bunifuCustomLabel3.TabIndex = 16;
            this.bunifuCustomLabel3.Text = "Quantité Entrée";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(3, 51);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(96, 21);
            this.bunifuCustomLabel8.TabIndex = 18;
            this.bunifuCustomLabel8.Text = "Description :";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(3, 108);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(147, 21);
            this.bunifuCustomLabel9.TabIndex = 16;
            this.bunifuCustomLabel9.Text = "Pays de provenance";
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(3, 4);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(46, 21);
            this.bunifuCustomLabel10.TabIndex = 14;
            this.bunifuCustomLabel10.Text = "Code";
            // 
            // UserControlArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "UserControlArticle";
            this.Size = new System.Drawing.Size(711, 441);
            this.Load += new System.EventHandler(this.UserControlArticle_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlArticle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewArticle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdesc.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuThinButton2 btEnrter;
        private Bunifu.Framework.UI.BunifuThinButton2 btSupp;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel16;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCode;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private DevExpress.XtraEditors.MemoEdit txtdesc;
        private DevExpress.XtraGrid.GridControl GridControlArticle;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewArticle;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn Produit;
        private DevExpress.XtraGrid.Columns.GridColumn descr;
        private DevExpress.XtraGrid.Columns.GridColumn image_;
        private DevExpress.XtraGrid.Columns.GridColumn nomFoum;
        private MetroFramework.Controls.MetroDateTime dates;
        private MetroFramework.Controls.MetroDateTime daten;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtville;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtqtes;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtqte;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtpays;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
    }
}
