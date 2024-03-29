﻿namespace GAMEstarter
{
    partial class FormAccount
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
            System.Windows.Forms.Label nicknameLabel;
            System.Windows.Forms.Label famLabel;
            System.Windows.Forms.Label user_nameLabel;
            System.Windows.Forms.Label nicknameLabel2;
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label mailLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccount));
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.btnOpenCard = new FontAwesome.Sharp.IconButton();
            this.btnSetA = new FontAwesome.Sharp.IconButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lblIdUsr = new System.Windows.Forms.Label();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameStartDBDataSet = new GAMEstarter.GameStartDBDataSet();
            this.lblIdCurStudio = new System.Windows.Forms.Label();
            this.lblIdOwner = new System.Windows.Forms.Label();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.lblIdStudio = new System.Windows.Forms.Label();
            this.roleLabel1 = new System.Windows.Forms.Label();
            this.lblFio = new System.Windows.Forms.Label();
            this.nicknameLabel1 = new System.Windows.Forms.Label();
            this.mailLabel1 = new System.Windows.Forms.Label();
            this.fioLabel1 = new System.Windows.Forms.Label();
            this.panelSetA = new System.Windows.Forms.Panel();
            this.pbShowPass = new FontAwesome.Sharp.IconPictureBox();
            this.lblRules = new System.Windows.Forms.Label();
            this.mpbCorrectPass = new MaterialSkin.Controls.MaterialProgressBar();
            this.btnChangePhotoA = new FontAwesome.Sharp.IconButton();
            this.panelSeparatorA = new System.Windows.Forms.Panel();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.tbxRepPass = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.nicknameTextBox = new System.Windows.Forms.TextBox();
            this.user_nameTextBox = new System.Windows.Forms.TextBox();
            this.famTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.usersTableAdapter = new GAMEstarter.GameStartDBDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new GAMEstarter.GameStartDBDataSetTableAdapters.TableAdapterManager();
            nicknameLabel = new System.Windows.Forms.Label();
            famLabel = new System.Windows.Forms.Label();
            user_nameLabel = new System.Windows.Forms.Label();
            nicknameLabel2 = new System.Windows.Forms.Label();
            loginLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            mailLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameStartDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.panelSetA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowPass)).BeginInit();
            this.SuspendLayout();
            // 
            // nicknameLabel
            // 
            nicknameLabel.AutoSize = true;
            nicknameLabel.Location = new System.Drawing.Point(157, 120);
            nicknameLabel.Name = "nicknameLabel";
            nicknameLabel.Size = new System.Drawing.Size(95, 25);
            nicknameLabel.TabIndex = 4;
            nicknameLabel.Text = "Никнейм:";
            // 
            // famLabel
            // 
            famLabel.AutoSize = true;
            famLabel.Location = new System.Drawing.Point(13, 76);
            famLabel.Name = "famLabel";
            famLabel.Size = new System.Drawing.Size(97, 25);
            famLabel.TabIndex = 0;
            famLabel.Text = "Фамилия:";
            // 
            // user_nameLabel
            // 
            user_nameLabel.AutoSize = true;
            user_nameLabel.Location = new System.Drawing.Point(13, 12);
            user_nameLabel.Name = "user_nameLabel";
            user_nameLabel.Size = new System.Drawing.Size(52, 25);
            user_nameLabel.TabIndex = 2;
            user_nameLabel.Text = "Имя:";
            // 
            // nicknameLabel2
            // 
            nicknameLabel2.AutoSize = true;
            nicknameLabel2.Location = new System.Drawing.Point(214, 12);
            nicknameLabel2.Name = "nicknameLabel2";
            nicknameLabel2.Size = new System.Drawing.Size(95, 25);
            nicknameLabel2.TabIndex = 4;
            nicknameLabel2.Text = "Никнейм:";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(13, 168);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(70, 25);
            loginLabel.TabIndex = 6;
            loginLabel.Text = "Логин:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(252, 169);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(82, 25);
            passwordLabel.TabIndex = 8;
            passwordLabel.Text = "Пароль:";
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Location = new System.Drawing.Point(214, 76);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new System.Drawing.Size(71, 25);
            mailLabel.TabIndex = 10;
            mailLabel.Text = "E-Mail:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(150, 204);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(184, 25);
            label1.TabIndex = 8;
            label1.Text = "Повтроите пароль:";
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelMain.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panelMain.Controls.Add(this.panelChildForm);
            this.panelMain.Controls.Add(this.btnOpenCard);
            this.panelMain.Controls.Add(this.btnSetA);
            this.panelMain.Controls.Add(this.materialCard1);
            this.panelMain.Controls.Add(this.panelSetA);
            this.panelMain.Location = new System.Drawing.Point(10, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1200, 721);
            this.panelMain.TabIndex = 1;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Location = new System.Drawing.Point(719, 129);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(340, 330);
            this.panelChildForm.TabIndex = 3;
            // 
            // btnOpenCard
            // 
            this.btnOpenCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenCard.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnOpenCard.FlatAppearance.BorderSize = 0;
            this.btnOpenCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenCard.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.btnOpenCard.IconColor = System.Drawing.Color.Black;
            this.btnOpenCard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOpenCard.Location = new System.Drawing.Point(719, 73);
            this.btnOpenCard.Name = "btnOpenCard";
            this.btnOpenCard.Size = new System.Drawing.Size(340, 50);
            this.btnOpenCard.TabIndex = 0;
            this.btnOpenCard.Text = "Управление картами";
            this.btnOpenCard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenCard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenCard.UseVisualStyleBackColor = false;
            this.btnOpenCard.Click += new System.EventHandler(this.btnOpenCard_Click);
            // 
            // btnSetA
            // 
            this.btnSetA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetA.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSetA.FlatAppearance.BorderSize = 0;
            this.btnSetA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetA.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnSetA.IconColor = System.Drawing.Color.Black;
            this.btnSetA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSetA.Location = new System.Drawing.Point(87, 239);
            this.btnSetA.Name = "btnSetA";
            this.btnSetA.Size = new System.Drawing.Size(615, 50);
            this.btnSetA.TabIndex = 0;
            this.btnSetA.Text = "Редактировать профиль";
            this.btnSetA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSetA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetA.UseVisualStyleBackColor = false;
            this.btnSetA.Click += new System.EventHandler(this.btnSetA_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblIdUsr);
            this.materialCard1.Controls.Add(this.lblIdCurStudio);
            this.materialCard1.Controls.Add(this.lblIdOwner);
            this.materialCard1.Controls.Add(this.photoPictureBox);
            this.materialCard1.Controls.Add(this.lblIdStudio);
            this.materialCard1.Controls.Add(this.roleLabel1);
            this.materialCard1.Controls.Add(this.lblFio);
            this.materialCard1.Controls.Add(nicknameLabel);
            this.materialCard1.Controls.Add(this.nicknameLabel1);
            this.materialCard1.Controls.Add(this.mailLabel1);
            this.materialCard1.Controls.Add(this.fioLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(87, 72);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(615, 170);
            this.materialCard1.TabIndex = 2;
            // 
            // lblIdUsr
            // 
            this.lblIdUsr.AutoSize = true;
            this.lblIdUsr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "id_user", true));
            this.lblIdUsr.ForeColor = System.Drawing.Color.White;
            this.lblIdUsr.Location = new System.Drawing.Point(547, 66);
            this.lblIdUsr.Name = "lblIdUsr";
            this.lblIdUsr.Size = new System.Drawing.Size(22, 25);
            this.lblIdUsr.TabIndex = 7;
            this.lblIdUsr.Text = "0";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.gameStartDBDataSet;
            this.usersBindingSource.Filter = "";
            // 
            // gameStartDBDataSet
            // 
            this.gameStartDBDataSet.DataSetName = "GameStartDBDataSet";
            this.gameStartDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblIdCurStudio
            // 
            this.lblIdCurStudio.AutoSize = true;
            this.lblIdCurStudio.ForeColor = System.Drawing.Color.White;
            this.lblIdCurStudio.Location = new System.Drawing.Point(575, 41);
            this.lblIdCurStudio.Name = "lblIdCurStudio";
            this.lblIdCurStudio.Size = new System.Drawing.Size(22, 25);
            this.lblIdCurStudio.TabIndex = 10;
            this.lblIdCurStudio.Text = "0";
            // 
            // lblIdOwner
            // 
            this.lblIdOwner.AutoSize = true;
            this.lblIdOwner.BackColor = System.Drawing.Color.Transparent;
            this.lblIdOwner.ForeColor = System.Drawing.Color.White;
            this.lblIdOwner.Location = new System.Drawing.Point(575, 66);
            this.lblIdOwner.Name = "lblIdOwner";
            this.lblIdOwner.Size = new System.Drawing.Size(22, 25);
            this.lblIdOwner.TabIndex = 4;
            this.lblIdOwner.Text = "0";
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.usersBindingSource, "photo", true));
            this.photoPictureBox.Location = new System.Drawing.Point(1, 0);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(150, 150);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoPictureBox.TabIndex = 9;
            this.photoPictureBox.TabStop = false;
            // 
            // lblIdStudio
            // 
            this.lblIdStudio.AutoSize = true;
            this.lblIdStudio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "id_studio", true));
            this.lblIdStudio.ForeColor = System.Drawing.Color.White;
            this.lblIdStudio.Location = new System.Drawing.Point(547, 41);
            this.lblIdStudio.Name = "lblIdStudio";
            this.lblIdStudio.Size = new System.Drawing.Size(22, 25);
            this.lblIdStudio.TabIndex = 8;
            this.lblIdStudio.Text = "0";
            // 
            // roleLabel1
            // 
            this.roleLabel1.AutoSize = true;
            this.roleLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "role", true));
            this.roleLabel1.ForeColor = System.Drawing.Color.White;
            this.roleLabel1.Location = new System.Drawing.Point(547, 14);
            this.roleLabel1.Name = "roleLabel1";
            this.roleLabel1.Size = new System.Drawing.Size(22, 25);
            this.roleLabel1.TabIndex = 7;
            this.roleLabel1.Text = "0";
            // 
            // lblFio
            // 
            this.lblFio.AutoSize = true;
            this.lblFio.Location = new System.Drawing.Point(157, 16);
            this.lblFio.Name = "lblFio";
            this.lblFio.Size = new System.Drawing.Size(145, 25);
            this.lblFio.TabIndex = 6;
            this.lblFio.Text = "Пользователь:";
            // 
            // nicknameLabel1
            // 
            this.nicknameLabel1.AutoSize = true;
            this.nicknameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "nickname", true));
            this.nicknameLabel1.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nicknameLabel1.Location = new System.Drawing.Point(258, 120);
            this.nicknameLabel1.Name = "nicknameLabel1";
            this.nicknameLabel1.Size = new System.Drawing.Size(196, 25);
            this.nicknameLabel1.TabIndex = 5;
            this.nicknameLabel1.Text = "GoodPeopleParadise";
            // 
            // mailLabel1
            // 
            this.mailLabel1.AutoSize = true;
            this.mailLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "mail", true));
            this.mailLabel1.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailLabel1.Location = new System.Drawing.Point(157, 69);
            this.mailLabel1.Name = "mailLabel1";
            this.mailLabel1.Size = new System.Drawing.Size(235, 25);
            this.mailLabel1.TabIndex = 4;
            this.mailLabel1.Text = "ivanovIvan@yandex.com";
            // 
            // fioLabel1
            // 
            this.fioLabel1.AutoSize = true;
            this.fioLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "fio", true));
            this.fioLabel1.Location = new System.Drawing.Point(157, 41);
            this.fioLabel1.Name = "fioLabel1";
            this.fioLabel1.Size = new System.Drawing.Size(219, 25);
            this.fioLabel1.TabIndex = 1;
            this.fioLabel1.Text = "Владимиров Владимир";
            // 
            // panelSetA
            // 
            this.panelSetA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSetA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSetA.Controls.Add(this.pbShowPass);
            this.panelSetA.Controls.Add(this.lblRules);
            this.panelSetA.Controls.Add(this.mpbCorrectPass);
            this.panelSetA.Controls.Add(this.btnChangePhotoA);
            this.panelSetA.Controls.Add(this.panelSeparatorA);
            this.panelSetA.Controls.Add(mailLabel);
            this.panelSetA.Controls.Add(this.mailTextBox);
            this.panelSetA.Controls.Add(label1);
            this.panelSetA.Controls.Add(passwordLabel);
            this.panelSetA.Controls.Add(this.tbxRepPass);
            this.panelSetA.Controls.Add(this.passwordTextBox);
            this.panelSetA.Controls.Add(loginLabel);
            this.panelSetA.Controls.Add(this.loginTextBox);
            this.panelSetA.Controls.Add(nicknameLabel2);
            this.panelSetA.Controls.Add(this.nicknameTextBox);
            this.panelSetA.Controls.Add(user_nameLabel);
            this.panelSetA.Controls.Add(this.user_nameTextBox);
            this.panelSetA.Controls.Add(famLabel);
            this.panelSetA.Controls.Add(this.famTextBox);
            this.panelSetA.Location = new System.Drawing.Point(87, 294);
            this.panelSetA.Name = "panelSetA";
            this.panelSetA.Size = new System.Drawing.Size(615, 293);
            this.panelSetA.TabIndex = 1;
            this.panelSetA.Visible = false;
            // 
            // pbShowPass
            // 
            this.pbShowPass.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pbShowPass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pbShowPass.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.pbShowPass.IconColor = System.Drawing.SystemColors.ControlText;
            this.pbShowPass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbShowPass.Location = new System.Drawing.Point(506, 165);
            this.pbShowPass.Name = "pbShowPass";
            this.pbShowPass.Size = new System.Drawing.Size(32, 32);
            this.pbShowPass.TabIndex = 16;
            this.pbShowPass.TabStop = false;
            this.pbShowPass.Click += new System.EventHandler(this.pbShowPass_Click);
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.lblRules.Font = new System.Drawing.Font("Roboto Slab", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRules.Location = new System.Drawing.Point(542, 167);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(18, 22);
            this.lblRules.TabIndex = 15;
            this.lblRules.Text = "?";
            // 
            // mpbCorrectPass
            // 
            this.mpbCorrectPass.Depth = 0;
            this.mpbCorrectPass.Location = new System.Drawing.Point(340, 159);
            this.mpbCorrectPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.mpbCorrectPass.Name = "mpbCorrectPass";
            this.mpbCorrectPass.Size = new System.Drawing.Size(160, 5);
            this.mpbCorrectPass.TabIndex = 14;
            // 
            // btnChangePhotoA
            // 
            this.btnChangePhotoA.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnChangePhotoA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnChangePhotoA.FlatAppearance.BorderSize = 0;
            this.btnChangePhotoA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePhotoA.IconChar = FontAwesome.Sharp.IconChar.Camera;
            this.btnChangePhotoA.IconColor = System.Drawing.Color.Black;
            this.btnChangePhotoA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChangePhotoA.Location = new System.Drawing.Point(0, 241);
            this.btnChangePhotoA.Name = "btnChangePhotoA";
            this.btnChangePhotoA.Size = new System.Drawing.Size(613, 50);
            this.btnChangePhotoA.TabIndex = 13;
            this.btnChangePhotoA.Text = "Изменить фото профиля";
            this.btnChangePhotoA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangePhotoA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangePhotoA.UseVisualStyleBackColor = false;
            this.btnChangePhotoA.Click += new System.EventHandler(this.ChangePhoto_Click);
            // 
            // panelSeparatorA
            // 
            this.panelSeparatorA.Location = new System.Drawing.Point(0, 146);
            this.panelSeparatorA.Name = "panelSeparatorA";
            this.panelSeparatorA.Size = new System.Drawing.Size(613, 7);
            this.panelSeparatorA.TabIndex = 12;
            // 
            // mailTextBox
            // 
            this.mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "mail", true));
            this.mailTextBox.Location = new System.Drawing.Point(219, 104);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(250, 32);
            this.mailTextBox.TabIndex = 11;
            this.mailTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // tbxRepPass
            // 
            this.tbxRepPass.Location = new System.Drawing.Point(340, 201);
            this.tbxRepPass.Name = "tbxRepPass";
            this.tbxRepPass.Size = new System.Drawing.Size(160, 32);
            this.tbxRepPass.TabIndex = 9;
            this.tbxRepPass.UseSystemPasswordChar = true;
            this.tbxRepPass.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(340, 165);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(160, 32);
            this.passwordTextBox.TabIndex = 9;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // loginTextBox
            // 
            this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "login", true));
            this.loginTextBox.Location = new System.Drawing.Point(89, 165);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(160, 32);
            this.loginTextBox.TabIndex = 7;
            this.loginTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // nicknameTextBox
            // 
            this.nicknameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "nickname", true));
            this.nicknameTextBox.Location = new System.Drawing.Point(218, 40);
            this.nicknameTextBox.Name = "nicknameTextBox";
            this.nicknameTextBox.Size = new System.Drawing.Size(251, 32);
            this.nicknameTextBox.TabIndex = 5;
            // 
            // user_nameTextBox
            // 
            this.user_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "user_name", true));
            this.user_nameTextBox.Location = new System.Drawing.Point(18, 40);
            this.user_nameTextBox.Name = "user_nameTextBox";
            this.user_nameTextBox.Size = new System.Drawing.Size(165, 32);
            this.user_nameTextBox.TabIndex = 3;
            this.user_nameTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // famTextBox
            // 
            this.famTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "fam", true));
            this.famTextBox.Location = new System.Drawing.Point(18, 104);
            this.famTextBox.Name = "famTextBox";
            this.famTextBox.Size = new System.Drawing.Size(178, 32);
            this.famTextBox.TabIndex = 1;
            this.famTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Изображения|*.png;*.jpg|Анимации|*.gif|Все файлы|*.*";
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CardsTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.GamesTableAdapter = null;
            this.tableAdapterManager.GenresTableAdapter = null;
            this.tableAdapterManager.MessagesTableAdapter = null;
            this.tableAdapterManager.PhotosTableAdapter = null;
            this.tableAdapterManager.StudiosTableAdapter = null;
            this.tableAdapterManager.TransactionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GAMEstarter.GameStartDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.VievsTableAdapter = null;
            // 
            // FormAccount
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1220, 721);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактировать аккаунт";
            this.Load += new System.EventHandler(this.FormAccount_Load);
            this.panelMain.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameStartDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.panelSetA.ResumeLayout(false);
            this.panelSetA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowPass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private FontAwesome.Sharp.IconButton btnSetA;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Label lblFio;
        private System.Windows.Forms.Label nicknameLabel1;
        private System.Windows.Forms.Label mailLabel1;
        private System.Windows.Forms.Label fioLabel1;
        private System.Windows.Forms.Panel panelSetA;
        private System.Windows.Forms.TextBox nicknameTextBox;
        private System.Windows.Forms.TextBox user_nameTextBox;
        private System.Windows.Forms.TextBox famTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Panel panelSeparatorA;
        private System.Windows.Forms.TextBox mailTextBox;
        private FontAwesome.Sharp.IconButton btnChangePhotoA;
        private System.Windows.Forms.TextBox tbxRepPass;
        private System.Windows.Forms.Label lblIdStudio;
        private System.Windows.Forms.Label roleLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MaterialSkin.Controls.MaterialProgressBar mpbCorrectPass;
        private System.Windows.Forms.Label lblRules;
        private FontAwesome.Sharp.IconPictureBox pbShowPass;
        public System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.Label lblIdOwner;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private GameStartDBDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private GameStartDBDataSet gameStartDBDataSet;
        private System.Windows.Forms.Label lblIdCurStudio;
        private GameStartDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblIdUsr;
        private System.Windows.Forms.Panel panelChildForm;
        private FontAwesome.Sharp.IconButton btnOpenCard;
    }
}