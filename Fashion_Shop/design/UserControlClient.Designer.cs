namespace Fashion_Shop.design
{
    partial class UserControlClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlClient));
            this.panel3 = new System.Windows.Forms.Panel();
            this.GridControlClient = new DevExpress.XtraGrid.GridControl();
            this.GridViewClient = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clientID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clientSexe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clientAdd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.telephone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtClientAddresse = new DevExpress.XtraEditors.MemoEdit();
            this.btCSupprimer = new Bunifu.Framework.UI.BunifuThinButton2();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel15 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtClientTel = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.gg = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chkClientF = new Bunifu.Framework.UI.BunifuCheckbox();
            this.dd = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chkClientH = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtClientName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btCEnreigistre = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClientAddresse.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.GridControlClient);
            this.panel3.Controls.Add(this.txtClientAddresse);
            this.panel3.Controls.Add(this.btCSupprimer);
            this.panel3.Controls.Add(this.comboBox3);
            this.panel3.Controls.Add(this.bunifuCustomLabel15);
            this.panel3.Controls.Add(this.txtClientTel);
            this.panel3.Controls.Add(this.bunifuCustomLabel14);
            this.panel3.Controls.Add(this.gg);
            this.panel3.Controls.Add(this.chkClientF);
            this.panel3.Controls.Add(this.dd);
            this.panel3.Controls.Add(this.chkClientH);
            this.panel3.Controls.Add(this.bunifuCustomLabel11);
            this.panel3.Controls.Add(this.txtClientName);
            this.panel3.Controls.Add(this.btCEnreigistre);
            this.panel3.Controls.Add(this.bunifuCustomLabel10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(748, 502);
            this.panel3.TabIndex = 2;
            // 
            // GridControlClient
            // 
            this.GridControlClient.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridControlClient.Location = new System.Drawing.Point(0, 309);
            this.GridControlClient.MainView = this.GridViewClient;
            this.GridControlClient.Name = "GridControlClient";
            this.GridControlClient.Size = new System.Drawing.Size(748, 193);
            this.GridControlClient.TabIndex = 44;
            this.GridControlClient.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewClient});
            this.GridControlClient.DoubleClick += new System.EventHandler(this.GridControlClient_DoubleClick);
            // 
            // GridViewClient
            // 
            this.GridViewClient.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clientID,
            this.nom,
            this.clientSexe,
            this.clientAdd,
            this.telephone});
            this.GridViewClient.GridControl = this.GridControlClient;
            this.GridViewClient.Name = "GridViewClient";
            this.GridViewClient.OptionsBehavior.Editable = false;
            this.GridViewClient.OptionsFind.AlwaysVisible = true;
            // 
            // clientID
            // 
            this.clientID.Caption = "ID";
            this.clientID.FieldName = "clientId";
            this.clientID.Name = "clientID";
            // 
            // nom
            // 
            this.nom.Caption = "nom";
            this.nom.FieldName = "nom";
            this.nom.Name = "nom";
            this.nom.Visible = true;
            this.nom.VisibleIndex = 0;
            // 
            // clientSexe
            // 
            this.clientSexe.Caption = "Sexe";
            this.clientSexe.FieldName = "sexe";
            this.clientSexe.Name = "clientSexe";
            this.clientSexe.Visible = true;
            this.clientSexe.VisibleIndex = 1;
            // 
            // clientAdd
            // 
            this.clientAdd.Caption = "Addresse";
            this.clientAdd.FieldName = "addresse";
            this.clientAdd.Name = "clientAdd";
            this.clientAdd.Visible = true;
            this.clientAdd.VisibleIndex = 2;
            // 
            // telephone
            // 
            this.telephone.Caption = "Telephone";
            this.telephone.FieldName = "telephone";
            this.telephone.Name = "telephone";
            this.telephone.Visible = true;
            this.telephone.VisibleIndex = 3;
            // 
            // txtClientAddresse
            // 
            this.txtClientAddresse.Location = new System.Drawing.Point(141, 167);
            this.txtClientAddresse.Name = "txtClientAddresse";
            this.txtClientAddresse.Size = new System.Drawing.Size(217, 85);
            this.txtClientAddresse.TabIndex = 43;
            // 
            // btCSupprimer
            // 
            this.btCSupprimer.ActiveBorderThickness = 1;
            this.btCSupprimer.ActiveCornerRadius = 20;
            this.btCSupprimer.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btCSupprimer.ActiveForecolor = System.Drawing.Color.White;
            this.btCSupprimer.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btCSupprimer.BackColor = System.Drawing.Color.White;
            this.btCSupprimer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCSupprimer.BackgroundImage")));
            this.btCSupprimer.ButtonText = "Supprimer";
            this.btCSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCSupprimer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCSupprimer.ForeColor = System.Drawing.Color.SeaGreen;
            this.btCSupprimer.IdleBorderThickness = 1;
            this.btCSupprimer.IdleCornerRadius = 20;
            this.btCSupprimer.IdleFillColor = System.Drawing.Color.White;
            this.btCSupprimer.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btCSupprimer.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btCSupprimer.Location = new System.Drawing.Point(24, 260);
            this.btCSupprimer.Margin = new System.Windows.Forms.Padding(5);
            this.btCSupprimer.Name = "btCSupprimer";
            this.btCSupprimer.Size = new System.Drawing.Size(113, 41);
            this.btCSupprimer.TabIndex = 42;
            this.btCSupprimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btCSupprimer.Click += new System.EventHandler(this.actionButtons_Click);
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
            this.bunifuCustomLabel15.Location = new System.Drawing.Point(20, 207);
            this.bunifuCustomLabel15.Name = "bunifuCustomLabel15";
            this.bunifuCustomLabel15.Size = new System.Drawing.Size(81, 21);
            this.bunifuCustomLabel15.TabIndex = 37;
            this.bunifuCustomLabel15.Text = "Addresse :";
            // 
            // txtClientTel
            // 
            this.txtClientTel.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(154)))));
            this.txtClientTel.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtClientTel.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(154)))));
            this.txtClientTel.BorderThickness = 3;
            this.txtClientTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClientTel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtClientTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtClientTel.isPassword = false;
            this.txtClientTel.Location = new System.Drawing.Point(141, 125);
            this.txtClientTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtClientTel.Name = "txtClientTel";
            this.txtClientTel.Size = new System.Drawing.Size(217, 35);
            this.txtClientTel.TabIndex = 36;
            this.txtClientTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(20, 125);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(87, 21);
            this.bunifuCustomLabel14.TabIndex = 35;
            this.bunifuCustomLabel14.Text = "Telephone :";
            // 
            // gg
            // 
            this.gg.AutoSize = true;
            this.gg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gg.Location = new System.Drawing.Point(265, 77);
            this.gg.Name = "gg";
            this.gg.Size = new System.Drawing.Size(62, 21);
            this.gg.TabIndex = 34;
            this.gg.Text = "Femme";
            // 
            // chkClientF
            // 
            this.chkClientF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkClientF.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkClientF.Checked = false;
            this.chkClientF.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chkClientF.ForeColor = System.Drawing.Color.White;
            this.chkClientF.Location = new System.Drawing.Point(338, 78);
            this.chkClientF.Name = "chkClientF";
            this.chkClientF.Size = new System.Drawing.Size(20, 20);
            this.chkClientF.TabIndex = 33;
            this.chkClientF.OnChange += new System.EventHandler(this.chkClientF_OnChange);
            // 
            // dd
            // 
            this.dd.AutoSize = true;
            this.dd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dd.Location = new System.Drawing.Point(137, 76);
            this.dd.Name = "dd";
            this.dd.Size = new System.Drawing.Size(66, 21);
            this.dd.TabIndex = 32;
            this.dd.Text = "Homme";
            // 
            // chkClientH
            // 
            this.chkClientH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chkClientH.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkClientH.Checked = true;
            this.chkClientH.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chkClientH.ForeColor = System.Drawing.Color.White;
            this.chkClientH.Location = new System.Drawing.Point(209, 77);
            this.chkClientH.Name = "chkClientH";
            this.chkClientH.Size = new System.Drawing.Size(20, 20);
            this.chkClientH.TabIndex = 31;
            this.chkClientH.OnChange += new System.EventHandler(this.chkClientH_OnChange);
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(20, 75);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(49, 21);
            this.bunifuCustomLabel11.TabIndex = 30;
            this.bunifuCustomLabel11.Text = "Sexe :";
            // 
            // txtClientName
            // 
            this.txtClientName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(154)))));
            this.txtClientName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtClientName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(154)))));
            this.txtClientName.BorderThickness = 3;
            this.txtClientName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClientName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtClientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtClientName.isPassword = false;
            this.txtClientName.Location = new System.Drawing.Point(140, 18);
            this.txtClientName.Margin = new System.Windows.Forms.Padding(4);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(217, 35);
            this.txtClientName.TabIndex = 27;
            this.txtClientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btCEnreigistre
            // 
            this.btCEnreigistre.ActiveBorderThickness = 1;
            this.btCEnreigistre.ActiveCornerRadius = 20;
            this.btCEnreigistre.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btCEnreigistre.ActiveForecolor = System.Drawing.Color.White;
            this.btCEnreigistre.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btCEnreigistre.BackColor = System.Drawing.Color.White;
            this.btCEnreigistre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCEnreigistre.BackgroundImage")));
            this.btCEnreigistre.ButtonText = "Enreigistrer";
            this.btCEnreigistre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCEnreigistre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCEnreigistre.ForeColor = System.Drawing.Color.SeaGreen;
            this.btCEnreigistre.IdleBorderThickness = 1;
            this.btCEnreigistre.IdleCornerRadius = 20;
            this.btCEnreigistre.IdleFillColor = System.Drawing.Color.White;
            this.btCEnreigistre.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btCEnreigistre.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btCEnreigistre.Location = new System.Drawing.Point(245, 260);
            this.btCEnreigistre.Margin = new System.Windows.Forms.Padding(5);
            this.btCEnreigistre.Name = "btCEnreigistre";
            this.btCEnreigistre.Size = new System.Drawing.Size(113, 41);
            this.btCEnreigistre.TabIndex = 23;
            this.btCEnreigistre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btCEnreigistre.Click += new System.EventHandler(this.actionButtons_Click);
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(20, 18);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(56, 21);
            this.bunifuCustomLabel10.TabIndex = 14;
            this.bunifuCustomLabel10.Text = "Nom  :";
            // 
            // UserControlClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Name = "UserControlClient";
            this.Size = new System.Drawing.Size(748, 502);
            this.Load += new System.EventHandler(this.UserControlClient_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClientAddresse.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.MemoEdit txtClientAddresse;
        private Bunifu.Framework.UI.BunifuThinButton2 btCSupprimer;
        private System.Windows.Forms.ComboBox comboBox3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel15;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtClientTel;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private Bunifu.Framework.UI.BunifuCheckbox chkClientF;
        private Bunifu.Framework.UI.BunifuCustomLabel dd;
        private Bunifu.Framework.UI.BunifuCheckbox chkClientH;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtClientName;
        private Bunifu.Framework.UI.BunifuThinButton2 btCEnreigistre;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private DevExpress.XtraGrid.GridControl GridControlClient;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewClient;
        private Bunifu.Framework.UI.BunifuCustomLabel gg;
        private DevExpress.XtraGrid.Columns.GridColumn clientID;
        private DevExpress.XtraGrid.Columns.GridColumn nom;
        private DevExpress.XtraGrid.Columns.GridColumn clientSexe;
        private DevExpress.XtraGrid.Columns.GridColumn clientAdd;
        private DevExpress.XtraGrid.Columns.GridColumn telephone;
    }
}
