namespace GAMEstarter
{
    partial class FormRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistration));
            this.label1 = new System.Windows.Forms.Label();
            this.mtbxLogin = new MaterialSkin.Controls.MaterialTextBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameStartDBDataSet = new GAMEstarter.GameStartDBDataSet();
            this.mtbxMail = new MaterialSkin.Controls.MaterialTextBox();
            this.mtbxPass = new MaterialSkin.Controls.MaterialTextBox();
            this.mtbxRepPass = new MaterialSkin.Controls.MaterialTextBox();
            this.mcbxShowPass = new MaterialSkin.Controls.MaterialCheckbox();
            this.mbtnReg = new MaterialSkin.Controls.MaterialButton();
            this.usersTableAdapter = new GAMEstarter.GameStartDBDataSetTableAdapters.UsersTableAdapter();
            this.mbtnClose = new MaterialSkin.Controls.MaterialButton();
            this.tableAdapterManager = new GAMEstarter.GameStartDBDataSetTableAdapters.TableAdapterManager();
            this.roleLabel1 = new System.Windows.Forms.Label();
            this.msDeveloper = new MaterialSkin.Controls.MaterialSwitch();
            this.label2 = new System.Windows.Forms.Label();
            this.mpbCorrectPass = new MaterialSkin.Controls.MaterialProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRules = new System.Windows.Forms.Label();
            this.mtbxLink = new MaterialSkin.Controls.MaterialTextBox();
            this.id_studioLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameStartDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(133, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Регистрация";
            // 
            // mtbxLogin
            // 
            this.mtbxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbxLogin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "login", true));
            this.mtbxLogin.Depth = 0;
            this.mtbxLogin.Font = new System.Drawing.Font("Roboto", 12F);
            this.mtbxLogin.Hint = "Придумайте логин";
            this.mtbxLogin.Location = new System.Drawing.Point(119, 186);
            this.mtbxLogin.MaxLength = 50;
            this.mtbxLogin.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbxLogin.Multiline = false;
            this.mtbxLogin.Name = "mtbxLogin";
            this.mtbxLogin.Size = new System.Drawing.Size(261, 50);
            this.mtbxLogin.TabIndex = 2;
            this.mtbxLogin.Text = "";
            this.mtbxLogin.TextChanged += new System.EventHandler(this.mtbxPass_TextChanged);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.gameStartDBDataSet;
            // 
            // gameStartDBDataSet
            // 
            this.gameStartDBDataSet.DataSetName = "GameStartDBDataSet";
            this.gameStartDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mtbxMail
            // 
            this.mtbxMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbxMail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "mail", true));
            this.mtbxMail.Depth = 0;
            this.mtbxMail.Font = new System.Drawing.Font("Roboto", 12F);
            this.mtbxMail.Hint = "Введите почту";
            this.mtbxMail.Location = new System.Drawing.Point(119, 129);
            this.mtbxMail.MaxLength = 50;
            this.mtbxMail.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbxMail.Multiline = false;
            this.mtbxMail.Name = "mtbxMail";
            this.mtbxMail.Size = new System.Drawing.Size(261, 50);
            this.mtbxMail.TabIndex = 1;
            this.mtbxMail.Text = "";
            this.mtbxMail.TextChanged += new System.EventHandler(this.mtbxPass_TextChanged);
            // 
            // mtbxPass
            // 
            this.mtbxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbxPass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "password", true));
            this.mtbxPass.Depth = 0;
            this.mtbxPass.Font = new System.Drawing.Font("Roboto", 12F);
            this.mtbxPass.Hint = "Придумайте пароль";
            this.mtbxPass.Location = new System.Drawing.Point(119, 273);
            this.mtbxPass.MaxLength = 50;
            this.mtbxPass.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbxPass.Multiline = false;
            this.mtbxPass.Name = "mtbxPass";
            this.mtbxPass.Password = true;
            this.mtbxPass.Size = new System.Drawing.Size(261, 50);
            this.mtbxPass.TabIndex = 3;
            this.mtbxPass.Text = "";
            this.mtbxPass.TextChanged += new System.EventHandler(this.mtbxPass_TextChanged);
            // 
            // mtbxRepPass
            // 
            this.mtbxRepPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbxRepPass.Depth = 0;
            this.mtbxRepPass.Font = new System.Drawing.Font("Roboto", 12F);
            this.mtbxRepPass.Hint = "Повторите пароль";
            this.mtbxRepPass.Location = new System.Drawing.Point(119, 329);
            this.mtbxRepPass.MaxLength = 50;
            this.mtbxRepPass.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbxRepPass.Multiline = false;
            this.mtbxRepPass.Name = "mtbxRepPass";
            this.mtbxRepPass.Password = true;
            this.mtbxRepPass.Size = new System.Drawing.Size(261, 50);
            this.mtbxRepPass.TabIndex = 4;
            this.mtbxRepPass.Text = "";
            this.mtbxRepPass.TextChanged += new System.EventHandler(this.mtbxPass_TextChanged);
            // 
            // mcbxShowPass
            // 
            this.mcbxShowPass.AutoSize = true;
            this.mcbxShowPass.BackColor = System.Drawing.Color.Transparent;
            this.mcbxShowPass.Depth = 0;
            this.mcbxShowPass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mcbxShowPass.Location = new System.Drawing.Point(119, 380);
            this.mcbxShowPass.Margin = new System.Windows.Forms.Padding(0);
            this.mcbxShowPass.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mcbxShowPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcbxShowPass.Name = "mcbxShowPass";
            this.mcbxShowPass.Ripple = true;
            this.mcbxShowPass.Size = new System.Drawing.Size(165, 37);
            this.mcbxShowPass.TabIndex = 7;
            this.mcbxShowPass.Text = "Показать пароль";
            this.mcbxShowPass.UseVisualStyleBackColor = false;
            this.mcbxShowPass.CheckedChanged += new System.EventHandler(this.materialCheckbox1_CheckedChanged);
            // 
            // mbtnReg
            // 
            this.mbtnReg.AutoSize = false;
            this.mbtnReg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnReg.Depth = 0;
            this.mbtnReg.DrawShadows = true;
            this.mbtnReg.Enabled = false;
            this.mbtnReg.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbtnReg.HighEmphasis = true;
            this.mbtnReg.Icon = null;
            this.mbtnReg.Location = new System.Drawing.Point(121, 452);
            this.mbtnReg.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnReg.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnReg.Name = "mbtnReg";
            this.mbtnReg.Size = new System.Drawing.Size(259, 45);
            this.mbtnReg.TabIndex = 9;
            this.mbtnReg.Text = "Регистрация";
            this.mbtnReg.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnReg.UseAccentColor = false;
            this.mbtnReg.UseVisualStyleBackColor = true;
            this.mbtnReg.Click += new System.EventHandler(this.mbtnReg_Click);
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // mbtnClose
            // 
            this.mbtnClose.AutoSize = false;
            this.mbtnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnClose.Depth = 0;
            this.mbtnClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mbtnClose.DrawShadows = true;
            this.mbtnClose.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbtnClose.HighEmphasis = true;
            this.mbtnClose.Icon = null;
            this.mbtnClose.Location = new System.Drawing.Point(0, 538);
            this.mbtnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnClose.Name = "mbtnClose";
            this.mbtnClose.Size = new System.Drawing.Size(508, 45);
            this.mbtnClose.TabIndex = 8;
            this.mbtnClose.Text = "Перейти к авторизации";
            this.mbtnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.mbtnClose.UseAccentColor = false;
            this.mbtnClose.UseVisualStyleBackColor = true;
            this.mbtnClose.Click += new System.EventHandler(this.mbtnClose_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CardsTableAdapter = null;
            this.tableAdapterManager.GamesTableAdapter = null;
            this.tableAdapterManager.PhotosTableAdapter = null;
            this.tableAdapterManager.StudiosTableAdapter = null;
            this.tableAdapterManager.TransactionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GAMEstarter.GameStartDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            this.tableAdapterManager.VievsTableAdapter = null;
            // 
            // roleLabel1
            // 
            this.roleLabel1.AutoSize = true;
            this.roleLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "role", true));
            this.roleLabel1.ForeColor = System.Drawing.Color.White;
            this.roleLabel1.Location = new System.Drawing.Point(90, 247);
            this.roleLabel1.Name = "roleLabel1";
            this.roleLabel1.Size = new System.Drawing.Size(23, 25);
            this.roleLabel1.TabIndex = 10;
            this.roleLabel1.Text = "0";
            // 
            // msDeveloper
            // 
            this.msDeveloper.AutoSize = true;
            this.msDeveloper.Depth = 0;
            this.msDeveloper.Location = new System.Drawing.Point(119, 413);
            this.msDeveloper.Margin = new System.Windows.Forms.Padding(0);
            this.msDeveloper.MouseLocation = new System.Drawing.Point(-1, -1);
            this.msDeveloper.MouseState = MaterialSkin.MouseState.HOVER;
            this.msDeveloper.Name = "msDeveloper";
            this.msDeveloper.Ripple = true;
            this.msDeveloper.Size = new System.Drawing.Size(169, 37);
            this.msDeveloper.TabIndex = 8;
            this.msDeveloper.Text = "Я разработчик";
            this.msDeveloper.UseVisualStyleBackColor = true;
            this.msDeveloper.CheckedChanged += new System.EventHandler(this.msDeveloper_CheckedChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(135, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 56);
            this.label2.TabIndex = 11;
            this.label2.Text = "Пожалуйста, заполните все поля";
            // 
            // mpbCorrectPass
            // 
            this.mpbCorrectPass.Depth = 0;
            this.mpbCorrectPass.Location = new System.Drawing.Point(120, 263);
            this.mpbCorrectPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.mpbCorrectPass.Name = "mpbCorrectPass";
            this.mpbCorrectPass.Size = new System.Drawing.Size(260, 5);
            this.mpbCorrectPass.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.mpbCorrectPass.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(138, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Надёжность пароля:";
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.lblRules.Font = new System.Drawing.Font("Roboto Slab", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRules.Location = new System.Drawing.Point(119, 239);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(18, 22);
            this.lblRules.TabIndex = 11;
            this.lblRules.Text = "?";
            // 
            // mtbxLink
            // 
            this.mtbxLink.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbxLink.Depth = 0;
            this.mtbxLink.Font = new System.Drawing.Font("Roboto", 12F);
            this.mtbxLink.Hint = "Ссылка-приглашение";
            this.mtbxLink.Location = new System.Drawing.Point(291, 400);
            this.mtbxLink.MaxLength = 50;
            this.mtbxLink.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbxLink.Multiline = false;
            this.mtbxLink.Name = "mtbxLink";
            this.mtbxLink.Size = new System.Drawing.Size(197, 50);
            this.mtbxLink.TabIndex = 13;
            this.mtbxLink.Text = "";
            // 
            // id_studioLabel1
            // 
            this.id_studioLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "id_studio", true));
            this.id_studioLabel1.ForeColor = System.Drawing.Color.White;
            this.id_studioLabel1.Location = new System.Drawing.Point(90, 273);
            this.id_studioLabel1.Name = "id_studioLabel1";
            this.id_studioLabel1.Size = new System.Drawing.Size(23, 23);
            this.id_studioLabel1.TabIndex = 16;
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GAMEstarter.Properties.Resources.BackReg;
            this.ClientSize = new System.Drawing.Size(508, 583);
            this.Controls.Add(this.id_studioLabel1);
            this.Controls.Add(this.mtbxLink);
            this.Controls.Add(this.mpbCorrectPass);
            this.Controls.Add(this.lblRules);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.msDeveloper);
            this.Controls.Add(this.roleLabel1);
            this.Controls.Add(this.mbtnClose);
            this.Controls.Add(this.mbtnReg);
            this.Controls.Add(this.mcbxShowPass);
            this.Controls.Add(this.mtbxMail);
            this.Controls.Add(this.mtbxRepPass);
            this.Controls.Add(this.mtbxPass);
            this.Controls.Add(this.mtbxLogin);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.FormRegistration_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormRegistration_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameStartDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox mtbxLogin;
        private MaterialSkin.Controls.MaterialTextBox mtbxMail;
        private MaterialSkin.Controls.MaterialTextBox mtbxPass;
        private MaterialSkin.Controls.MaterialTextBox mtbxRepPass;
        private MaterialSkin.Controls.MaterialCheckbox mcbxShowPass;
        private MaterialSkin.Controls.MaterialButton mbtnReg;
        private GameStartDBDataSet gameStartDBDataSet;
        private GameStartDBDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private MaterialSkin.Controls.MaterialButton mbtnClose;
        private GameStartDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label roleLabel1;
        public System.Windows.Forms.BindingSource usersBindingSource;
        private MaterialSkin.Controls.MaterialSwitch msDeveloper;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialProgressBar mpbCorrectPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRules;
        private MaterialSkin.Controls.MaterialTextBox mtbxLink;
        private System.Windows.Forms.Label id_studioLabel1;
    }
}