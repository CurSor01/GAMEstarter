
namespace GAMEstarter
{
    partial class FormStudioManage
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
            System.Windows.Forms.Label mailLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudioManage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvWorkers = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.workers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEditworker = new System.Windows.Forms.Panel();
            this.lblIdOwner = new System.Windows.Forms.Label();
            this.studiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameStartDBDataSet = new GAMEstarter.GameStartDBDataSet();
            this.id_studioLabel1 = new System.Windows.Forms.Label();
            this.panelSetS = new System.Windows.Forms.Panel();
            this.btnChangePhotoS = new FontAwesome.Sharp.IconButton();
            this.studio_nameLabel = new System.Windows.Forms.Label();
            this.studio_nameTextBox = new System.Windows.Forms.TextBox();
            this.btnSetS = new FontAwesome.Sharp.IconButton();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.studio_nameLabel1 = new System.Windows.Forms.Label();
            this.panelMessages = new System.Windows.Forms.Panel();
            this.panelTypeMessage = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.id_studioLabel2 = new System.Windows.Forms.Label();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.fioLabel1 = new System.Windows.Forms.Label();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.studiosTableAdapter = new GAMEstarter.GameStartDBDataSetTableAdapters.StudiosTableAdapter();
            this.tableAdapterManager = new GAMEstarter.GameStartDBDataSetTableAdapters.TableAdapterManager();
            this.usersTableAdapter = new GAMEstarter.GameStartDBDataSetTableAdapters.UsersTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            mailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkers)).BeginInit();
            this.panelEditworker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameStartDBDataSet)).BeginInit();
            this.panelSetS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.panelTypeMessage.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Location = new System.Drawing.Point(67, 321);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new System.Drawing.Size(70, 25);
            mailLabel.TabIndex = 2;
            mailLabel.Text = "E-mail:";
            // 
            // dgvWorkers
            // 
            this.dgvWorkers.AllowUserToAddRows = false;
            this.dgvWorkers.AllowUserToDeleteRows = false;
            this.dgvWorkers.AllowUserToResizeColumns = false;
            this.dgvWorkers.AllowUserToResizeRows = false;
            this.dgvWorkers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvWorkers.BackgroundColor = System.Drawing.Color.White;
            this.dgvWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Column1,
            this.workers});
            this.dgvWorkers.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvWorkers.Location = new System.Drawing.Point(1220, 0);
            this.dgvWorkers.Margin = new System.Windows.Forms.Padding(6);
            this.dgvWorkers.MultiSelect = false;
            this.dgvWorkers.Name = "dgvWorkers";
            this.dgvWorkers.RowHeadersVisible = false;
            this.dgvWorkers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWorkers.Size = new System.Drawing.Size(300, 853);
            this.dgvWorkers.TabIndex = 0;
            this.dgvWorkers.SelectionChanged += new System.EventHandler(this.dgvWorkers_SelectionChanged);
            // 
            // id
            // 
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.id.DefaultCellStyle = dataGridViewCellStyle7;
            this.id.HeaderText = "Column2";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // Column1
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle8.NullValue")));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column1.HeaderText = "";
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Width = 60;
            // 
            // workers
            // 
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.workers.DefaultCellStyle = dataGridViewCellStyle9;
            this.workers.HeaderText = "Работники студии";
            this.workers.Name = "workers";
            this.workers.Width = 210;
            // 
            // panelEditworker
            // 
            this.panelEditworker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEditworker.BackColor = System.Drawing.Color.White;
            this.panelEditworker.Controls.Add(this.lblIdOwner);
            this.panelEditworker.Controls.Add(this.id_studioLabel1);
            this.panelEditworker.Controls.Add(this.panelSetS);
            this.panelEditworker.Controls.Add(this.btnSetS);
            this.panelEditworker.Controls.Add(this.logoPictureBox);
            this.panelEditworker.Controls.Add(this.studio_nameLabel1);
            this.panelEditworker.Location = new System.Drawing.Point(758, 381);
            this.panelEditworker.Name = "panelEditworker";
            this.panelEditworker.Size = new System.Drawing.Size(443, 468);
            this.panelEditworker.TabIndex = 1;
            // 
            // lblIdOwner
            // 
            this.lblIdOwner.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studiosBindingSource, "id_owner", true));
            this.lblIdOwner.ForeColor = System.Drawing.Color.White;
            this.lblIdOwner.Location = new System.Drawing.Point(3, 26);
            this.lblIdOwner.Name = "lblIdOwner";
            this.lblIdOwner.Size = new System.Drawing.Size(63, 23);
            this.lblIdOwner.TabIndex = 8;
            this.lblIdOwner.Text = "label2";
            // 
            // studiosBindingSource
            // 
            this.studiosBindingSource.DataMember = "Studios";
            this.studiosBindingSource.DataSource = this.gameStartDBDataSet;
            // 
            // gameStartDBDataSet
            // 
            this.gameStartDBDataSet.DataSetName = "GameStartDBDataSet";
            this.gameStartDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // id_studioLabel1
            // 
            this.id_studioLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studiosBindingSource, "id_studio", true));
            this.id_studioLabel1.ForeColor = System.Drawing.Color.White;
            this.id_studioLabel1.Location = new System.Drawing.Point(3, 3);
            this.id_studioLabel1.Name = "id_studioLabel1";
            this.id_studioLabel1.Size = new System.Drawing.Size(63, 23);
            this.id_studioLabel1.TabIndex = 7;
            this.id_studioLabel1.Text = "label2";
            // 
            // panelSetS
            // 
            this.panelSetS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSetS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSetS.Controls.Add(this.btnChangePhotoS);
            this.panelSetS.Controls.Add(this.studio_nameLabel);
            this.panelSetS.Controls.Add(this.studio_nameTextBox);
            this.panelSetS.Location = new System.Drawing.Point(27, 314);
            this.panelSetS.Name = "panelSetS";
            this.panelSetS.Size = new System.Drawing.Size(386, 134);
            this.panelSetS.TabIndex = 6;
            this.panelSetS.Visible = false;
            // 
            // btnChangePhotoS
            // 
            this.btnChangePhotoS.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnChangePhotoS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnChangePhotoS.FlatAppearance.BorderSize = 0;
            this.btnChangePhotoS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePhotoS.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.btnChangePhotoS.IconColor = System.Drawing.Color.Black;
            this.btnChangePhotoS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChangePhotoS.Location = new System.Drawing.Point(0, 82);
            this.btnChangePhotoS.Name = "btnChangePhotoS";
            this.btnChangePhotoS.Size = new System.Drawing.Size(384, 50);
            this.btnChangePhotoS.TabIndex = 14;
            this.btnChangePhotoS.Text = "Изменить логотип";
            this.btnChangePhotoS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangePhotoS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangePhotoS.UseVisualStyleBackColor = false;
            this.btnChangePhotoS.Click += new System.EventHandler(this.btnChangePhotoS_Click);
            // 
            // studio_nameLabel
            // 
            this.studio_nameLabel.AutoSize = true;
            this.studio_nameLabel.Location = new System.Drawing.Point(17, 12);
            this.studio_nameLabel.Name = "studio_nameLabel";
            this.studio_nameLabel.Size = new System.Drawing.Size(264, 25);
            this.studio_nameLabel.TabIndex = 0;
            this.studio_nameLabel.Text = "Изменить название студии:";
            // 
            // studio_nameTextBox
            // 
            this.studio_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studiosBindingSource, "studio_name", true));
            this.studio_nameTextBox.Location = new System.Drawing.Point(22, 40);
            this.studio_nameTextBox.Name = "studio_nameTextBox";
            this.studio_nameTextBox.Size = new System.Drawing.Size(347, 33);
            this.studio_nameTextBox.TabIndex = 1;
            // 
            // btnSetS
            // 
            this.btnSetS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetS.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSetS.FlatAppearance.BorderSize = 0;
            this.btnSetS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetS.IconChar = FontAwesome.Sharp.IconChar.BlackTie;
            this.btnSetS.IconColor = System.Drawing.Color.Black;
            this.btnSetS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSetS.Location = new System.Drawing.Point(27, 258);
            this.btnSetS.Name = "btnSetS";
            this.btnSetS.Size = new System.Drawing.Size(386, 50);
            this.btnSetS.TabIndex = 5;
            this.btnSetS.Text = "Создать/изменить студию";
            this.btnSetS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSetS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetS.UseVisualStyleBackColor = false;
            this.btnSetS.Click += new System.EventHandler(this.btnSetS_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.studiosBindingSource, "logo", true));
            this.logoPictureBox.Location = new System.Drawing.Point(72, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(300, 210);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 4;
            this.logoPictureBox.TabStop = false;
            // 
            // studio_nameLabel1
            // 
            this.studio_nameLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studio_nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studiosBindingSource, "studio_name", true));
            this.studio_nameLabel1.Font = new System.Drawing.Font("Nirmala UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studio_nameLabel1.Location = new System.Drawing.Point(45, 222);
            this.studio_nameLabel1.Name = "studio_nameLabel1";
            this.studio_nameLabel1.Size = new System.Drawing.Size(352, 33);
            this.studio_nameLabel1.TabIndex = 3;
            this.studio_nameLabel1.Text = "Общество хороших людей";
            this.studio_nameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.studio_nameLabel1.Click += new System.EventHandler(this.studio_nameLabel1_Click);
            // 
            // panelMessages
            // 
            this.panelMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMessages.BackColor = System.Drawing.Color.White;
            this.panelMessages.Location = new System.Drawing.Point(12, 12);
            this.panelMessages.Name = "panelMessages";
            this.panelMessages.Size = new System.Drawing.Size(730, 569);
            this.panelMessages.TabIndex = 2;
            // 
            // panelTypeMessage
            // 
            this.panelTypeMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTypeMessage.BackColor = System.Drawing.Color.White;
            this.panelTypeMessage.Controls.Add(this.iconButton1);
            this.panelTypeMessage.Controls.Add(this.label1);
            this.panelTypeMessage.Controls.Add(this.textBox1);
            this.panelTypeMessage.Location = new System.Drawing.Point(12, 600);
            this.panelTypeMessage.Name = "panelTypeMessage";
            this.panelTypeMessage.Size = new System.Drawing.Size(730, 241);
            this.panelTypeMessage.TabIndex = 3;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 40;
            this.iconButton1.Location = new System.Drawing.Point(571, 184);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(149, 45);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.Text = "Добавить";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавить сообщение:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 31);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(712, 147);
            this.textBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.id_studioLabel2);
            this.panel1.Controls.Add(mailLabel);
            this.panel1.Controls.Add(this.mailTextBox);
            this.panel1.Controls.Add(this.fioLabel1);
            this.panel1.Controls.Add(this.photoPictureBox);
            this.panel1.Location = new System.Drawing.Point(758, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 354);
            this.panel1.TabIndex = 1;
            // 
            // id_studioLabel2
            // 
            this.id_studioLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "id_studio", true));
            this.id_studioLabel2.ForeColor = System.Drawing.Color.White;
            this.id_studioLabel2.Location = new System.Drawing.Point(3, 16);
            this.id_studioLabel2.Name = "id_studioLabel2";
            this.id_studioLabel2.Size = new System.Drawing.Size(63, 23);
            this.id_studioLabel2.TabIndex = 5;
            this.id_studioLabel2.Text = "label2";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.gameStartDBDataSet;
            // 
            // mailTextBox
            // 
            this.mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "mail", true));
            this.mailTextBox.Location = new System.Drawing.Point(143, 318);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.ReadOnly = true;
            this.mailTextBox.Size = new System.Drawing.Size(229, 33);
            this.mailTextBox.TabIndex = 3;
            // 
            // fioLabel1
            // 
            this.fioLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "fio", true));
            this.fioLabel1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fioLabel1.Location = new System.Drawing.Point(67, 289);
            this.fioLabel1.Name = "fioLabel1";
            this.fioLabel1.Size = new System.Drawing.Size(305, 23);
            this.fioLabel1.TabIndex = 2;
            this.fioLabel1.Text = "Артур шарифов";
            this.fioLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.usersBindingSource, "photo", true));
            this.photoPictureBox.Location = new System.Drawing.Point(72, 16);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(300, 270);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoPictureBox.TabIndex = 1;
            this.photoPictureBox.TabStop = false;
            // 
            // studiosTableAdapter
            // 
            this.studiosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CardsTableAdapter = null;
            this.tableAdapterManager.GamesTableAdapter = null;
            this.tableAdapterManager.PhotosTableAdapter = null;
            this.tableAdapterManager.StudiosTableAdapter = this.studiosTableAdapter;
            this.tableAdapterManager.TransactionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GAMEstarter.GameStartDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            this.tableAdapterManager.VievsTableAdapter = null;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Изображения|*.png;*.jpg|Анимации|*.gif|Все файлы|*.*";
            // 
            // FormStudioManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 853);
            this.Controls.Add(this.panelTypeMessage);
            this.Controls.Add(this.panelMessages);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelEditworker);
            this.Controls.Add(this.dgvWorkers);
            this.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormStudioManage";
            this.Text = "FormStudioManage";
            this.Load += new System.EventHandler(this.FormStudioManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkers)).EndInit();
            this.panelEditworker.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameStartDBDataSet)).EndInit();
            this.panelSetS.ResumeLayout(false);
            this.panelSetS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.panelTypeMessage.ResumeLayout(false);
            this.panelTypeMessage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWorkers;
        private System.Windows.Forms.Panel panelEditworker;
        private System.Windows.Forms.Panel panelMessages;
        private System.Windows.Forms.Panel panelTypeMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn workers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel1;
        private GameStartDBDataSet gameStartDBDataSet;
        private System.Windows.Forms.BindingSource studiosBindingSource;
        private GameStartDBDataSetTableAdapters.StudiosTableAdapter studiosTableAdapter;
        private GameStartDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label studio_nameLabel1;
        private FontAwesome.Sharp.IconButton btnSetS;
        private System.Windows.Forms.Panel panelSetS;
        private FontAwesome.Sharp.IconButton btnChangePhotoS;
        private System.Windows.Forms.Label studio_nameLabel;
        private System.Windows.Forms.TextBox studio_nameTextBox;
        private System.Windows.Forms.Label id_studioLabel1;
        private System.Windows.Forms.Label lblIdOwner;
        private GameStartDBDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label fioLabel1;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.Label id_studioLabel2;
    }
}