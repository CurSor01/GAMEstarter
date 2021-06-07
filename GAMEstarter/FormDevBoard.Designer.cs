namespace GAMEstarter
{
    partial class FormDevBoard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDevBoard));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCatalog = new FontAwesome.Sharp.IconButton();
            this.btnStudio = new FontAwesome.Sharp.IconButton();
            this.btnAccount = new FontAwesome.Sharp.IconButton();
            this.btnEditPr = new FontAwesome.Sharp.IconButton();
            this.btnAnalytics = new FontAwesome.Sharp.IconButton();
            this.btnHideMenu = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.panelFormManage = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelDownSepar = new System.Windows.Forms.Panel();
            this.panelClock = new System.Windows.Forms.Panel();
            this.lblMDY = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.panelClock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.panelMenu.Controls.Add(this.btnCatalog);
            this.panelMenu.Controls.Add(this.btnStudio);
            this.panelMenu.Controls.Add(this.btnAccount);
            this.panelMenu.Controls.Add(this.btnEditPr);
            this.panelMenu.Controls.Add(this.btnAnalytics);
            this.panelMenu.Controls.Add(this.btnHideMenu);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnExit);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(6);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 981);
            this.panelMenu.TabIndex = 0;
            // 
            // btnCatalog
            // 
            this.btnCatalog.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCatalog.FlatAppearance.BorderSize = 0;
            this.btnCatalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatalog.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatalog.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCatalog.IconChar = FontAwesome.Sharp.IconChar.TabletAlt;
            this.btnCatalog.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnCatalog.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCatalog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatalog.Location = new System.Drawing.Point(0, 300);
            this.btnCatalog.Margin = new System.Windows.Forms.Padding(6);
            this.btnCatalog.Name = "btnCatalog";
            this.btnCatalog.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCatalog.Size = new System.Drawing.Size(220, 60);
            this.btnCatalog.TabIndex = 16;
            this.btnCatalog.Text = "Каталог";
            this.btnCatalog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatalog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCatalog.UseVisualStyleBackColor = true;
            this.btnCatalog.Click += new System.EventHandler(this.btnCatalog_Click);
            // 
            // btnStudio
            // 
            this.btnStudio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudio.FlatAppearance.BorderSize = 0;
            this.btnStudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudio.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnStudio.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnStudio.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnStudio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStudio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudio.Location = new System.Drawing.Point(0, 240);
            this.btnStudio.Margin = new System.Windows.Forms.Padding(6);
            this.btnStudio.Name = "btnStudio";
            this.btnStudio.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnStudio.Size = new System.Drawing.Size(220, 60);
            this.btnStudio.TabIndex = 15;
            this.btnStudio.Text = "Студия";
            this.btnStudio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStudio.UseVisualStyleBackColor = true;
            this.btnStudio.Click += new System.EventHandler(this.btnStudio_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAccount.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnAccount.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(0, 180);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(6);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAccount.Size = new System.Drawing.Size(220, 60);
            this.btnAccount.TabIndex = 14;
            this.btnAccount.Text = "Аккаунт";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnEditPr
            // 
            this.btnEditPr.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditPr.FlatAppearance.BorderSize = 0;
            this.btnEditPr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPr.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPr.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditPr.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnEditPr.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditPr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditPr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditPr.Location = new System.Drawing.Point(0, 120);
            this.btnEditPr.Margin = new System.Windows.Forms.Padding(6);
            this.btnEditPr.Name = "btnEditPr";
            this.btnEditPr.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnEditPr.Size = new System.Drawing.Size(220, 60);
            this.btnEditPr.TabIndex = 13;
            this.btnEditPr.Text = "Проекты";
            this.btnEditPr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditPr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditPr.UseVisualStyleBackColor = true;
            this.btnEditPr.Click += new System.EventHandler(this.btnEditPr_Click);
            // 
            // btnAnalytics
            // 
            this.btnAnalytics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnalytics.FlatAppearance.BorderSize = 0;
            this.btnAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalytics.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalytics.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAnalytics.IconChar = FontAwesome.Sharp.IconChar.ChartArea;
            this.btnAnalytics.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnAnalytics.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAnalytics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnalytics.Location = new System.Drawing.Point(0, 60);
            this.btnAnalytics.Margin = new System.Windows.Forms.Padding(6);
            this.btnAnalytics.Name = "btnAnalytics";
            this.btnAnalytics.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAnalytics.Size = new System.Drawing.Size(220, 60);
            this.btnAnalytics.TabIndex = 12;
            this.btnAnalytics.Text = "Аналитика";
            this.btnAnalytics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnalytics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnalytics.UseVisualStyleBackColor = true;
            this.btnAnalytics.Click += new System.EventHandler(this.btnAnalytics_Click);
            // 
            // btnHideMenu
            // 
            this.btnHideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(64)))), ((int)(((byte)(171)))));
            this.btnHideMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHideMenu.FlatAppearance.BorderSize = 0;
            this.btnHideMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideMenu.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHideMenu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHideMenu.IconChar = FontAwesome.Sharp.IconChar.EllipsisV;
            this.btnHideMenu.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnHideMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHideMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHideMenu.Location = new System.Drawing.Point(0, 0);
            this.btnHideMenu.Margin = new System.Windows.Forms.Padding(6);
            this.btnHideMenu.Name = "btnHideMenu";
            this.btnHideMenu.Padding = new System.Windows.Forms.Padding(8, 0, 20, 0);
            this.btnHideMenu.Size = new System.Drawing.Size(220, 60);
            this.btnHideMenu.TabIndex = 11;
            this.btnHideMenu.Text = "Скрыть меню";
            this.btnHideMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHideMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHideMenu.UseVisualStyleBackColor = false;
            this.btnHideMenu.Click += new System.EventHandler(this.btnHideMenu_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 801);
            this.btnHome.Margin = new System.Windows.Forms.Padding(6);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnHome.Size = new System.Drawing.Size(220, 60);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "Домой";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.SlidersH;
            this.btnSettings.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 861);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(6);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSettings.Size = new System.Drawing.Size(220, 60);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "Настройки";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(64)))), ((int)(((byte)(171)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnExit.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 921);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnExit.Size = new System.Drawing.Size(220, 60);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Выход";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelFormManage
            // 
            this.panelFormManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.panelFormManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFormManage.Location = new System.Drawing.Point(220, 0);
            this.panelFormManage.Margin = new System.Windows.Forms.Padding(6);
            this.panelFormManage.Name = "panelFormManage";
            this.panelFormManage.Size = new System.Drawing.Size(1564, 60);
            this.panelFormManage.TabIndex = 1;
            this.panelFormManage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelFormManage_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(64)))), ((int)(((byte)(171)))));
            this.panelChildForm.Controls.Add(this.panelDownSepar);
            this.panelChildForm.Controls.Add(this.panelClock);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(220, 60);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1564, 921);
            this.panelChildForm.TabIndex = 3;
            // 
            // panelDownSepar
            // 
            this.panelDownSepar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.panelDownSepar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDownSepar.Location = new System.Drawing.Point(0, 861);
            this.panelDownSepar.Name = "panelDownSepar";
            this.panelDownSepar.Size = new System.Drawing.Size(1564, 60);
            this.panelDownSepar.TabIndex = 3;
            // 
            // panelClock
            // 
            this.panelClock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelClock.Controls.Add(this.lblMDY);
            this.panelClock.Controls.Add(this.lblTime);
            this.panelClock.Controls.Add(this.pictureBox1);
            this.panelClock.Location = new System.Drawing.Point(456, 297);
            this.panelClock.Name = "panelClock";
            this.panelClock.Size = new System.Drawing.Size(658, 310);
            this.panelClock.TabIndex = 2;
            // 
            // lblMDY
            // 
            this.lblMDY.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMDY.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMDY.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMDY.Location = new System.Drawing.Point(0, 270);
            this.lblMDY.Name = "lblMDY";
            this.lblMDY.Size = new System.Drawing.Size(658, 30);
            this.lblMDY.TabIndex = 3;
            this.lblMDY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTime.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTime.Location = new System.Drawing.Point(0, 200);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(658, 70);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "00:00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::GAMEstarter.Properties.Resources.Logo_full4;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(658, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormDevBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1784, 981);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelFormManage);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1440, 800);
            this.Name = "FormDevBoard";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameSTARTER - Начало работы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDevBoard_FormClosing);
            this.Load += new System.EventHandler(this.FormDevBoard_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.panelClock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelFormManage;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panelDownSepar;
        private System.Windows.Forms.Panel panelClock;
        private System.Windows.Forms.Label lblMDY;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnCatalog;
        private FontAwesome.Sharp.IconButton btnStudio;
        private FontAwesome.Sharp.IconButton btnAccount;
        private FontAwesome.Sharp.IconButton btnEditPr;
        private FontAwesome.Sharp.IconButton btnAnalytics;
        private FontAwesome.Sharp.IconButton btnHideMenu;
    }
}