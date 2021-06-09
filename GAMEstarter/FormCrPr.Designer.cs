namespace GAMEstarter
{
    partial class FormCrPr
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
            System.Windows.Forms.Label codenameLabel;
            System.Windows.Forms.Label game_nameLabel;
            System.Windows.Forms.Label m_needLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label genreLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrPr));
            this.panel1 = new System.Windows.Forms.Panel();
            this.data_exitLabel1 = new System.Windows.Forms.Label();
            this.gamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameStartDBDataSet = new GAMEstarter.GameStartDBDataSet();
            this.date_createLabel1 = new System.Windows.Forms.Label();
            this.btnScreenshots = new FontAwesome.Sharp.IconButton();
            this.btnTrailer = new FontAwesome.Sharp.IconButton();
            this.id_gameLabel2 = new System.Windows.Forms.Label();
            this.btndateExit = new FontAwesome.Sharp.IconButton();
            this.btnIcons = new FontAwesome.Sharp.IconButton();
            this.visibleLabel1 = new System.Windows.Forms.Label();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btnPlace = new FontAwesome.Sharp.IconButton();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.panelChildForm = new MaterialSkin.Controls.MaterialCard();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.m_have_nowLabel1 = new System.Windows.Forms.Label();
            this.id_studioLabel1 = new System.Windows.Forms.Label();
            this.m_haveLabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_needTextBox = new System.Windows.Forms.TextBox();
            this.game_nameTextBox = new System.Windows.Forms.TextBox();
            this.codenameTextBox = new System.Windows.Forms.TextBox();
            this.gamesTableAdapter = new GAMEstarter.GameStartDBDataSetTableAdapters.GamesTableAdapter();
            this.tableAdapterManager = new GAMEstarter.GameStartDBDataSetTableAdapters.TableAdapterManager();
            codenameLabel = new System.Windows.Forms.Label();
            game_nameLabel = new System.Windows.Forms.Label();
            m_needLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            genreLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameStartDBDataSet)).BeginInit();
            this.materialCard3.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // codenameLabel
            // 
            codenameLabel.AutoSize = true;
            codenameLabel.Location = new System.Drawing.Point(84, 14);
            codenameLabel.Name = "codenameLabel";
            codenameLabel.Size = new System.Drawing.Size(181, 25);
            codenameLabel.TabIndex = 0;
            codenameLabel.Text = "Название проекта:";
            // 
            // game_nameLabel
            // 
            game_nameLabel.AutoSize = true;
            game_nameLabel.Location = new System.Drawing.Point(60, 58);
            game_nameLabel.Name = "game_nameLabel";
            game_nameLabel.Size = new System.Drawing.Size(208, 25);
            game_nameLabel.TabIndex = 2;
            game_nameLabel.Text = "Название видеоигры:";
            // 
            // m_needLabel
            // 
            m_needLabel.AutoSize = true;
            m_needLabel.Location = new System.Drawing.Point(58, 118);
            m_needLabel.Name = "m_needLabel";
            m_needLabel.Size = new System.Drawing.Size(207, 25);
            m_needLabel.TabIndex = 4;
            m_needLabel.Text = "Сумма на разработку:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            descriptionLabel.Location = new System.Drawing.Point(14, 14);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(428, 25);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Описание:";
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Location = new System.Drawing.Point(411, 118);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new System.Drawing.Size(69, 25);
            genreLabel.TabIndex = 0;
            genreLabel.Text = " Жанр:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.data_exitLabel1);
            this.panel1.Controls.Add(this.date_createLabel1);
            this.panel1.Controls.Add(this.btnScreenshots);
            this.panel1.Controls.Add(this.btnTrailer);
            this.panel1.Controls.Add(this.id_gameLabel2);
            this.panel1.Controls.Add(this.btndateExit);
            this.panel1.Controls.Add(this.btnIcons);
            this.panel1.Controls.Add(this.visibleLabel1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnPlace);
            this.panel1.Controls.Add(this.materialCard3);
            this.panel1.Controls.Add(this.panelChildForm);
            this.panel1.Controls.Add(this.materialCard1);
            this.panel1.Location = new System.Drawing.Point(10, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1206, 570);
            this.panel1.TabIndex = 0;
            // 
            // data_exitLabel1
            // 
            this.data_exitLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gamesBindingSource, "data_exit", true));
            this.data_exitLabel1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.data_exitLabel1.Location = new System.Drawing.Point(79, 546);
            this.data_exitLabel1.Name = "data_exitLabel1";
            this.data_exitLabel1.Size = new System.Drawing.Size(100, 23);
            this.data_exitLabel1.TabIndex = 15;
            this.data_exitLabel1.Text = "label2";
            // 
            // gamesBindingSource
            // 
            this.gamesBindingSource.DataMember = "Games";
            this.gamesBindingSource.DataSource = this.gameStartDBDataSet;
            // 
            // gameStartDBDataSet
            // 
            this.gameStartDBDataSet.DataSetName = "GameStartDBDataSet";
            this.gameStartDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // date_createLabel1
            // 
            this.date_createLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.date_createLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gamesBindingSource, "date_create", true));
            this.date_createLabel1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.date_createLabel1.Location = new System.Drawing.Point(619, 538);
            this.date_createLabel1.Name = "date_createLabel1";
            this.date_createLabel1.Size = new System.Drawing.Size(100, 23);
            this.date_createLabel1.TabIndex = 14;
            // 
            // btnScreenshots
            // 
            this.btnScreenshots.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnScreenshots.FlatAppearance.BorderSize = 0;
            this.btnScreenshots.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScreenshots.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnScreenshots.IconChar = FontAwesome.Sharp.IconChar.Images;
            this.btnScreenshots.IconColor = System.Drawing.Color.Black;
            this.btnScreenshots.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnScreenshots.IconSize = 40;
            this.btnScreenshots.Location = new System.Drawing.Point(184, 186);
            this.btnScreenshots.Name = "btnScreenshots";
            this.btnScreenshots.Size = new System.Drawing.Size(180, 40);
            this.btnScreenshots.TabIndex = 13;
            this.btnScreenshots.Text = "Скриншоты";
            this.btnScreenshots.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnScreenshots.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnScreenshots.UseVisualStyleBackColor = false;
            this.btnScreenshots.Click += new System.EventHandler(this.btnScreenshots_Click);
            // 
            // btnTrailer
            // 
            this.btnTrailer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTrailer.FlatAppearance.BorderSize = 0;
            this.btnTrailer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrailer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTrailer.IconChar = FontAwesome.Sharp.IconChar.Video;
            this.btnTrailer.IconColor = System.Drawing.Color.Black;
            this.btnTrailer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTrailer.IconSize = 40;
            this.btnTrailer.Location = new System.Drawing.Point(370, 186);
            this.btnTrailer.Name = "btnTrailer";
            this.btnTrailer.Size = new System.Drawing.Size(180, 40);
            this.btnTrailer.TabIndex = 8;
            this.btnTrailer.Text = "Трейлер";
            this.btnTrailer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrailer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrailer.UseVisualStyleBackColor = false;
            this.btnTrailer.Click += new System.EventHandler(this.btnTrailer_Click);
            // 
            // id_gameLabel2
            // 
            this.id_gameLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.id_gameLabel2.AutoSize = true;
            this.id_gameLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gamesBindingSource, "id_game", true));
            this.id_gameLabel2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.id_gameLabel2.Location = new System.Drawing.Point(51, 538);
            this.id_gameLabel2.Name = "id_gameLabel2";
            this.id_gameLabel2.Size = new System.Drawing.Size(22, 25);
            this.id_gameLabel2.TabIndex = 12;
            this.id_gameLabel2.Text = "0";
            // 
            // btndateExit
            // 
            this.btndateExit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btndateExit.FlatAppearance.BorderSize = 0;
            this.btndateExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndateExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btndateExit.IconChar = FontAwesome.Sharp.IconChar.Certificate;
            this.btndateExit.IconColor = System.Drawing.Color.Black;
            this.btndateExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btndateExit.IconSize = 40;
            this.btndateExit.Location = new System.Drawing.Point(579, 186);
            this.btndateExit.Name = "btndateExit";
            this.btndateExit.Size = new System.Drawing.Size(140, 40);
            this.btndateExit.TabIndex = 9;
            this.btndateExit.Text = "Прочее";
            this.btndateExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndateExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndateExit.UseVisualStyleBackColor = false;
            this.btndateExit.Click += new System.EventHandler(this.btndateExit_Click);
            // 
            // btnIcons
            // 
            this.btnIcons.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnIcons.FlatAppearance.BorderSize = 0;
            this.btnIcons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIcons.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIcons.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.btnIcons.IconColor = System.Drawing.Color.Black;
            this.btnIcons.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIcons.IconSize = 40;
            this.btnIcons.Location = new System.Drawing.Point(14, 186);
            this.btnIcons.Name = "btnIcons";
            this.btnIcons.Size = new System.Drawing.Size(140, 40);
            this.btnIcons.TabIndex = 7;
            this.btnIcons.Text = "Иконки";
            this.btnIcons.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIcons.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIcons.UseVisualStyleBackColor = false;
            this.btnIcons.Click += new System.EventHandler(this.btnIcons_Click);
            // 
            // visibleLabel1
            // 
            this.visibleLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.visibleLabel1.AutoSize = true;
            this.visibleLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gamesBindingSource, "visible", true));
            this.visibleLabel1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.visibleLabel1.Location = new System.Drawing.Point(560, 538);
            this.visibleLabel1.Name = "visibleLabel1";
            this.visibleLabel1.Size = new System.Drawing.Size(53, 25);
            this.visibleLabel1.TabIndex = 1;
            this.visibleLabel1.Text = "False";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSave.IconColor = System.Drawing.Color.Black;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 40;
            this.btnSave.Location = new System.Drawing.Point(730, 446);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(456, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Сохранить проект невидимым";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPlace
            // 
            this.btnPlace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPlace.FlatAppearance.BorderSize = 0;
            this.btnPlace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlace.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPlace.IconChar = FontAwesome.Sharp.IconChar.PaintRoller;
            this.btnPlace.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnPlace.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlace.IconSize = 40;
            this.btnPlace.Location = new System.Drawing.Point(730, 492);
            this.btnPlace.Name = "btnPlace";
            this.btnPlace.Size = new System.Drawing.Size(456, 40);
            this.btnPlace.TabIndex = 5;
            this.btnPlace.Text = "Выставить в каталог";
            this.btnPlace.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlace.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlace.UseVisualStyleBackColor = false;
            this.btnPlace.Click += new System.EventHandler(this.btnPlace_Click);
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.descriptionTextBox);
            this.materialCard3.Controls.Add(descriptionLabel);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(730, 18);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(456, 411);
            this.materialCard3.TabIndex = 4;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gamesBindingSource, "description", true));
            this.descriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionTextBox.Location = new System.Drawing.Point(14, 39);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(428, 358);
            this.descriptionTextBox.TabIndex = 2;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelChildForm.Depth = 0;
            this.panelChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelChildForm.Location = new System.Drawing.Point(14, 234);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(14);
            this.panelChildForm.MouseState = MaterialSkin.MouseState.HOVER;
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Padding = new System.Windows.Forms.Padding(14);
            this.panelChildForm.Size = new System.Drawing.Size(703, 298);
            this.panelChildForm.TabIndex = 3;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(genreLabel);
            this.materialCard1.Controls.Add(this.genreComboBox);
            this.materialCard1.Controls.Add(this.m_have_nowLabel1);
            this.materialCard1.Controls.Add(this.id_studioLabel1);
            this.materialCard1.Controls.Add(this.m_haveLabel1);
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Controls.Add(m_needLabel);
            this.materialCard1.Controls.Add(this.m_needTextBox);
            this.materialCard1.Controls.Add(game_nameLabel);
            this.materialCard1.Controls.Add(this.game_nameTextBox);
            this.materialCard1.Controls.Add(codenameLabel);
            this.materialCard1.Controls.Add(this.codenameTextBox);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(14, 18);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(703, 160);
            this.materialCard1.TabIndex = 2;
            // 
            // genreComboBox
            // 
            this.genreComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gamesBindingSource, "genre", true));
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(486, 115);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(200, 33);
            this.genreComboBox.TabIndex = 1;
            // 
            // m_have_nowLabel1
            // 
            this.m_have_nowLabel1.AutoSize = true;
            this.m_have_nowLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gamesBindingSource, "m_have_now", true));
            this.m_have_nowLabel1.ForeColor = System.Drawing.Color.White;
            this.m_have_nowLabel1.Location = new System.Drawing.Point(9, 85);
            this.m_have_nowLabel1.Name = "m_have_nowLabel1";
            this.m_have_nowLabel1.Size = new System.Drawing.Size(22, 25);
            this.m_have_nowLabel1.TabIndex = 1;
            this.m_have_nowLabel1.Text = "0";
            // 
            // id_studioLabel1
            // 
            this.id_studioLabel1.AutoSize = true;
            this.id_studioLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gamesBindingSource, "id_studio", true));
            this.id_studioLabel1.ForeColor = System.Drawing.Color.White;
            this.id_studioLabel1.Location = new System.Drawing.Point(9, 11);
            this.id_studioLabel1.Name = "id_studioLabel1";
            this.id_studioLabel1.Size = new System.Drawing.Size(22, 25);
            this.id_studioLabel1.TabIndex = 1;
            this.id_studioLabel1.Text = "0";
            // 
            // m_haveLabel1
            // 
            this.m_haveLabel1.AutoSize = true;
            this.m_haveLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gamesBindingSource, "m_have", true));
            this.m_haveLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.m_haveLabel1.Location = new System.Drawing.Point(9, 36);
            this.m_haveLabel1.Name = "m_haveLabel1";
            this.m_haveLabel1.Size = new System.Drawing.Size(22, 25);
            this.m_haveLabel1.TabIndex = 1;
            this.m_haveLabel1.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "$";
            // 
            // m_needTextBox
            // 
            this.m_needTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gamesBindingSource, "m_need", true));
            this.m_needTextBox.Location = new System.Drawing.Point(271, 115);
            this.m_needTextBox.Name = "m_needTextBox";
            this.m_needTextBox.Size = new System.Drawing.Size(110, 33);
            this.m_needTextBox.TabIndex = 5;
            this.m_needTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m_needTextBox_KeyPress);
            // 
            // game_nameTextBox
            // 
            this.game_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gamesBindingSource, "game_name", true));
            this.game_nameTextBox.Location = new System.Drawing.Point(271, 55);
            this.game_nameTextBox.Name = "game_nameTextBox";
            this.game_nameTextBox.Size = new System.Drawing.Size(415, 33);
            this.game_nameTextBox.TabIndex = 3;
            // 
            // codenameTextBox
            // 
            this.codenameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gamesBindingSource, "codename", true));
            this.codenameTextBox.Location = new System.Drawing.Point(271, 11);
            this.codenameTextBox.Name = "codenameTextBox";
            this.codenameTextBox.Size = new System.Drawing.Size(415, 33);
            this.codenameTextBox.TabIndex = 1;
            // 
            // gamesTableAdapter
            // 
            this.gamesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CardsTableAdapter = null;
            this.tableAdapterManager.GamesTableAdapter = this.gamesTableAdapter;
            this.tableAdapterManager.GenresTableAdapter = null;
            this.tableAdapterManager.MessagesTableAdapter = null;
            this.tableAdapterManager.PhotosTableAdapter = null;
            this.tableAdapterManager.StudiosTableAdapter = null;
            this.tableAdapterManager.TransactionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GAMEstarter.GameStartDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.VievsTableAdapter = null;
            // 
            // FormCrPr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1220, 570);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormCrPr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создать новый проект";
            this.Load += new System.EventHandler(this.FormCrPr_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameStartDBDataSet)).EndInit();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private GameStartDBDataSet gameStartDBDataSet;
        private GameStartDBDataSetTableAdapters.GamesTableAdapter gamesTableAdapter;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnPlace;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialCard panelChildForm;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Label m_haveLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_needTextBox;
        private System.Windows.Forms.TextBox game_nameTextBox;
        private System.Windows.Forms.TextBox codenameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label visibleLabel1;
        private FontAwesome.Sharp.IconButton btnTrailer;
        private FontAwesome.Sharp.IconButton btnIcons;
        public System.Windows.Forms.BindingSource gamesBindingSource;
        private System.Windows.Forms.Label id_studioLabel1;
        private GameStartDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private FontAwesome.Sharp.IconButton btndateExit;
        private System.Windows.Forms.Label id_gameLabel2;
        private FontAwesome.Sharp.IconButton btnScreenshots;
        private System.Windows.Forms.Label m_have_nowLabel1;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.Label date_createLabel1;
        private System.Windows.Forms.Label data_exitLabel1;
    }
}