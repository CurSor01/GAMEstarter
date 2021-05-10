namespace GAMEstarter
{
    partial class FormScreenshots
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.btndelPhoto = new FontAwesome.Sharp.IconButton();
            this.btnAddSavePhoto = new FontAwesome.Sharp.IconButton();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.photosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameStartDBDataSet = new GAMEstarter.GameStartDBDataSet();
            this.photosTableAdapter = new GAMEstarter.GameStartDBDataSetTableAdapters.PhotosTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableAdapterManager = new GAMEstarter.GameStartDBDataSetTableAdapters.TableAdapterManager();
            this.name_imageLabel1 = new System.Windows.Forms.Label();
            this.id_gameLabel1 = new System.Windows.Forms.Label();
            this.dgvPhotoNames = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameStartDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhotoNames)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(239, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "*Щёлкните на картинку для изменения";
            // 
            // btndelPhoto
            // 
            this.btndelPhoto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btndelPhoto.FlatAppearance.BorderSize = 0;
            this.btndelPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelPhoto.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btndelPhoto.IconColor = System.Drawing.Color.Black;
            this.btndelPhoto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btndelPhoto.IconSize = 40;
            this.btndelPhoto.Location = new System.Drawing.Point(629, 224);
            this.btndelPhoto.Name = "btndelPhoto";
            this.btndelPhoto.Size = new System.Drawing.Size(40, 40);
            this.btndelPhoto.TabIndex = 8;
            this.btndelPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndelPhoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndelPhoto.UseVisualStyleBackColor = false;
            this.btndelPhoto.Click += new System.EventHandler(this.btndelPhoto_Click);
            // 
            // btnAddSavePhoto
            // 
            this.btnAddSavePhoto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddSavePhoto.FlatAppearance.BorderSize = 0;
            this.btnAddSavePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSavePhoto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddSavePhoto.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAddSavePhoto.IconColor = System.Drawing.Color.Black;
            this.btnAddSavePhoto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddSavePhoto.IconSize = 40;
            this.btnAddSavePhoto.Location = new System.Drawing.Point(233, 224);
            this.btnAddSavePhoto.Name = "btnAddSavePhoto";
            this.btnAddSavePhoto.Size = new System.Drawing.Size(390, 40);
            this.btnAddSavePhoto.TabIndex = 7;
            this.btnAddSavePhoto.Text = "Добавить новые скриншоты";
            this.btnAddSavePhoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddSavePhoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddSavePhoto.UseVisualStyleBackColor = false;
            this.btnAddSavePhoto.Click += new System.EventHandler(this.btnAddSavePhoto_Click);
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.photosBindingSource, "image", true));
            this.imagePictureBox.Location = new System.Drawing.Point(233, 3);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(436, 193);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePictureBox.TabIndex = 1;
            this.imagePictureBox.TabStop = false;
            this.imagePictureBox.Click += new System.EventHandler(this.imagePictureBox_Click);
            // 
            // photosBindingSource
            // 
            this.photosBindingSource.DataMember = "Photos";
            this.photosBindingSource.DataSource = this.gameStartDBDataSet;
            // 
            // gameStartDBDataSet
            // 
            this.gameStartDBDataSet.DataSetName = "GameStartDBDataSet";
            this.gameStartDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // photosTableAdapter
            // 
            this.photosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CardsTableAdapter = null;
            this.tableAdapterManager.GamesTableAdapter = null;
            this.tableAdapterManager.PhotosTableAdapter = this.photosTableAdapter;
            this.tableAdapterManager.StudiosTableAdapter = null;
            this.tableAdapterManager.TransactionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GAMEstarter.GameStartDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.VievsTableAdapter = null;
            // 
            // name_imageLabel1
            // 
            this.name_imageLabel1.AutoSize = true;
            this.name_imageLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photosBindingSource, "name_image", true));
            this.name_imageLabel1.Location = new System.Drawing.Point(606, 267);
            this.name_imageLabel1.Name = "name_imageLabel1";
            this.name_imageLabel1.Size = new System.Drawing.Size(63, 25);
            this.name_imageLabel1.TabIndex = 10;
            this.name_imageLabel1.Text = "label1";
            // 
            // id_gameLabel1
            // 
            this.id_gameLabel1.AutoSize = true;
            this.id_gameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photosBindingSource, "id_game", true));
            this.id_gameLabel1.Location = new System.Drawing.Point(12, 267);
            this.id_gameLabel1.Name = "id_gameLabel1";
            this.id_gameLabel1.Size = new System.Drawing.Size(63, 25);
            this.id_gameLabel1.TabIndex = 11;
            this.id_gameLabel1.Text = "label1";
            // 
            // dgvPhotoNames
            // 
            this.dgvPhotoNames.AllowUserToAddRows = false;
            this.dgvPhotoNames.AllowUserToDeleteRows = false;
            this.dgvPhotoNames.AllowUserToResizeColumns = false;
            this.dgvPhotoNames.AutoGenerateColumns = false;
            this.dgvPhotoNames.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPhotoNames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhotoNames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            this.dgvPhotoNames.DataSource = this.photosBindingSource;
            this.dgvPhotoNames.Location = new System.Drawing.Point(0, 1);
            this.dgvPhotoNames.Name = "dgvPhotoNames";
            this.dgvPhotoNames.ReadOnly = true;
            this.dgvPhotoNames.RowHeadersVisible = false;
            this.dgvPhotoNames.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPhotoNames.Size = new System.Drawing.Size(227, 263);
            this.dgvPhotoNames.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "name_image";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn3.HeaderText = "Название фото";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // FormScreenshots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(689, 294);
            this.Controls.Add(this.dgvPhotoNames);
            this.Controls.Add(this.id_gameLabel1);
            this.Controls.Add(this.name_imageLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btndelPhoto);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(this.btnAddSavePhoto);
            this.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormScreenshots";
            this.Text = "FormScreenshots";
            this.Load += new System.EventHandler(this.FormScreenshots_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameStartDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhotoNames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btndelPhoto;
        private FontAwesome.Sharp.IconButton btnAddSavePhoto;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private GameStartDBDataSet gameStartDBDataSet;
        private GameStartDBDataSetTableAdapters.PhotosTableAdapter photosTableAdapter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private GameStartDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label name_imageLabel1;
        public System.Windows.Forms.BindingSource photosBindingSource;
        private System.Windows.Forms.Label id_gameLabel1;
        private System.Windows.Forms.DataGridView dgvPhotoNames;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}