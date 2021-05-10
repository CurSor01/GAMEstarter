namespace GAMEstarter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mtbxLogin = new MaterialSkin.Controls.MaterialTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mbtnLogin = new MaterialSkin.Controls.MaterialButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblReg = new System.Windows.Forms.Label();
            this.mcbxShowPass = new MaterialSkin.Controls.MaterialCheckbox();
            this.mcbxRemember = new MaterialSkin.Controls.MaterialCheckbox();
            this.gameStartDBDataSet = new GAMEstarter.GameStartDBDataSet();
            this.bsUsers = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new GAMEstarter.GameStartDBDataSetTableAdapters.UsersTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.mbtnClose = new MaterialSkin.Controls.MaterialButton();
            this.roleLabel1 = new System.Windows.Forms.Label();
            this.mtbxPass = new MaterialSkin.Controls.MaterialTextBox();
            this.id_userLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameStartDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // mtbxLogin
            // 
            this.mtbxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbxLogin.Depth = 0;
            this.mtbxLogin.Font = new System.Drawing.Font("Roboto", 12F);
            this.mtbxLogin.Hint = "Логин";
            this.mtbxLogin.Location = new System.Drawing.Point(118, 181);
            this.mtbxLogin.MaxLength = 50;
            this.mtbxLogin.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbxLogin.Multiline = false;
            this.mtbxLogin.Name = "mtbxLogin";
            this.mtbxLogin.Size = new System.Drawing.Size(261, 50);
            this.mtbxLogin.TabIndex = 1;
            this.mtbxLogin.Text = "";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(112, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 56);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пожалуйста войдите чтобы продолжить";
            // 
            // mbtnLogin
            // 
            this.mbtnLogin.AutoSize = false;
            this.mbtnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnLogin.Depth = 0;
            this.mbtnLogin.DrawShadows = true;
            this.mbtnLogin.HighEmphasis = true;
            this.mbtnLogin.Icon = null;
            this.mbtnLogin.Location = new System.Drawing.Point(118, 422);
            this.mbtnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnLogin.Name = "mbtnLogin";
            this.mbtnLogin.Size = new System.Drawing.Size(261, 45);
            this.mbtnLogin.TabIndex = 5;
            this.mbtnLogin.Text = "Авторизация";
            this.mbtnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnLogin.UseAccentColor = false;
            this.mbtnLogin.UseVisualStyleBackColor = true;
            this.mbtnLogin.Click += new System.EventHandler(this.mbtnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(113, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Нет таккаунта?";
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.BackColor = System.Drawing.Color.White;
            this.lblReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReg.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.lblReg.Location = new System.Drawing.Point(255, 475);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(128, 25);
            this.lblReg.TabIndex = 6;
            this.lblReg.Text = "Регистрация";
            this.lblReg.Click += new System.EventHandler(this.lblReg_Click);
            // 
            // mcbxShowPass
            // 
            this.mcbxShowPass.AutoSize = true;
            this.mcbxShowPass.Depth = 0;
            this.mcbxShowPass.Location = new System.Drawing.Point(118, 298);
            this.mcbxShowPass.Margin = new System.Windows.Forms.Padding(0);
            this.mcbxShowPass.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mcbxShowPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcbxShowPass.Name = "mcbxShowPass";
            this.mcbxShowPass.Ripple = true;
            this.mcbxShowPass.Size = new System.Drawing.Size(165, 37);
            this.mcbxShowPass.TabIndex = 7;
            this.mcbxShowPass.Text = "Показать пароль";
            this.mcbxShowPass.UseVisualStyleBackColor = true;
            this.mcbxShowPass.CheckedChanged += new System.EventHandler(this.mcbxshowPass_CheckedChanged);
            // 
            // mcbxRemember
            // 
            this.mcbxRemember.AutoSize = true;
            this.mcbxRemember.Depth = 0;
            this.mcbxRemember.Location = new System.Drawing.Point(118, 335);
            this.mcbxRemember.Margin = new System.Windows.Forms.Padding(0);
            this.mcbxRemember.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mcbxRemember.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcbxRemember.Name = "mcbxRemember";
            this.mcbxRemember.Ripple = true;
            this.mcbxRemember.Size = new System.Drawing.Size(161, 37);
            this.mcbxRemember.TabIndex = 7;
            this.mcbxRemember.Text = "Запомнить меня";
            this.mcbxRemember.UseVisualStyleBackColor = true;
            // 
            // gameStartDBDataSet
            // 
            this.gameStartDBDataSet.DataSetName = "GameStartDBDataSet";
            this.gameStartDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsUsers
            // 
            this.bsUsers.DataMember = "Users";
            this.bsUsers.DataSource = this.gameStartDBDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(110, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "С возвращением";
            // 
            // mbtnClose
            // 
            this.mbtnClose.AutoSize = false;
            this.mbtnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnClose.Depth = 0;
            this.mbtnClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mbtnClose.DrawShadows = true;
            this.mbtnClose.Font = new System.Drawing.Font("Nirmala UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbtnClose.HighEmphasis = true;
            this.mbtnClose.Icon = null;
            this.mbtnClose.Location = new System.Drawing.Point(0, 504);
            this.mbtnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnClose.Name = "mbtnClose";
            this.mbtnClose.Size = new System.Drawing.Size(500, 40);
            this.mbtnClose.TabIndex = 8;
            this.mbtnClose.Text = "Выход";
            this.mbtnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.mbtnClose.UseAccentColor = false;
            this.mbtnClose.UseVisualStyleBackColor = true;
            this.mbtnClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // roleLabel1
            // 
            this.roleLabel1.AutoSize = true;
            this.roleLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "role", true));
            this.roleLabel1.ForeColor = System.Drawing.Color.White;
            this.roleLabel1.Location = new System.Drawing.Point(115, 391);
            this.roleLabel1.Name = "roleLabel1";
            this.roleLabel1.Size = new System.Drawing.Size(23, 25);
            this.roleLabel1.TabIndex = 11;
            this.roleLabel1.Text = "0";
            // 
            // mtbxPass
            // 
            this.mtbxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbxPass.Depth = 0;
            this.mtbxPass.Font = new System.Drawing.Font("Roboto", 12F);
            this.mtbxPass.Hint = "Пароль";
            this.mtbxPass.Location = new System.Drawing.Point(120, 247);
            this.mtbxPass.MaxLength = 50;
            this.mtbxPass.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbxPass.Multiline = false;
            this.mtbxPass.Name = "mtbxPass";
            this.mtbxPass.Password = true;
            this.mtbxPass.Size = new System.Drawing.Size(261, 50);
            this.mtbxPass.TabIndex = 2;
            this.mtbxPass.Text = "";
            // 
            // id_userLabel
            // 
            this.id_userLabel.AutoSize = true;
            this.id_userLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "id_user", true));
            this.id_userLabel.ForeColor = System.Drawing.Color.White;
            this.id_userLabel.Location = new System.Drawing.Point(144, 391);
            this.id_userLabel.Name = "id_userLabel";
            this.id_userLabel.Size = new System.Drawing.Size(23, 25);
            this.id_userLabel.TabIndex = 11;
            this.id_userLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GAMEstarter.Properties.Resources.BackReg;
            this.ClientSize = new System.Drawing.Size(500, 544);
            this.Controls.Add(this.mtbxPass);
            this.Controls.Add(this.id_userLabel);
            this.Controls.Add(this.roleLabel1);
            this.Controls.Add(this.mbtnClose);
            this.Controls.Add(this.mcbxRemember);
            this.Controls.Add(this.mcbxShowPass);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mbtnLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtbxLogin);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aвторизация";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmRegister_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.gameStartDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox mtbxLogin;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialButton mbtnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblReg;
        private MaterialSkin.Controls.MaterialCheckbox mcbxShowPass;
        private MaterialSkin.Controls.MaterialCheckbox mcbxRemember;
        private GameStartDBDataSet gameStartDBDataSet;
        private System.Windows.Forms.BindingSource bsUsers;
        private GameStartDBDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton mbtnClose;
        private System.Windows.Forms.Label roleLabel1;
        private MaterialSkin.Controls.MaterialTextBox mtbxPass;
        private System.Windows.Forms.Label id_userLabel;
    }
}

