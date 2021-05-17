namespace GAMEstarter
{
    partial class FormdataExit
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
            System.Windows.Forms.Label data_exitLabel;
            System.Windows.Forms.Label label1;
            this.gameStartDBDataSet = new GAMEstarter.GameStartDBDataSet();
            this.gamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gamesTableAdapter = new GAMEstarter.GameStartDBDataSetTableAdapters.GamesTableAdapter();
            this.tableAdapterManager = new GAMEstarter.GameStartDBDataSetTableAdapters.TableAdapterManager();
            this.data_exitDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.btnPC = new FontAwesome.Sharp.IconButton();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.btnPS = new FontAwesome.Sharp.IconButton();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.btnXB = new FontAwesome.Sharp.IconButton();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.btnSW = new FontAwesome.Sharp.IconButton();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.btnMB = new FontAwesome.Sharp.IconButton();
            this.platformLabel1 = new System.Windows.Forms.Label();
            data_exitLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameStartDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.materialCard5.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_exitLabel
            // 
            data_exitLabel.AutoSize = true;
            data_exitLabel.Location = new System.Drawing.Point(139, 16);
            data_exitLabel.Name = "data_exitLabel";
            data_exitLabel.Size = new System.Drawing.Size(132, 25);
            data_exitLabel.TabIndex = 1;
            data_exitLabel.Text = "Дата выхода:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(280, 55);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(117, 25);
            label1.TabIndex = 9;
            label1.Text = "Платформы";
            // 
            // gameStartDBDataSet
            // 
            this.gameStartDBDataSet.DataSetName = "GameStartDBDataSet";
            this.gameStartDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gamesBindingSource
            // 
            this.gamesBindingSource.DataMember = "Games";
            this.gamesBindingSource.DataSource = this.gameStartDBDataSet;
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
            this.tableAdapterManager.PhotosTableAdapter = null;
            this.tableAdapterManager.StudiosTableAdapter = null;
            this.tableAdapterManager.TransactionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GAMEstarter.GameStartDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.VievsTableAdapter = null;
            // 
            // data_exitDateTimePicker
            // 
            this.data_exitDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.gamesBindingSource, "data_exit", true));
            this.data_exitDateTimePicker.Location = new System.Drawing.Point(277, 12);
            this.data_exitDateTimePicker.Name = "data_exitDateTimePicker";
            this.data_exitDateTimePicker.Size = new System.Drawing.Size(216, 33);
            this.data_exitDateTimePicker.TabIndex = 2;
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btnPC);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(12, 83);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(130, 130);
            this.materialCard1.TabIndex = 8;
            // 
            // btnPC
            // 
            this.btnPC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPC.FlatAppearance.BorderSize = 0;
            this.btnPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPC.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPC.IconChar = FontAwesome.Sharp.IconChar.Desktop;
            this.btnPC.IconColor = System.Drawing.Color.Black;
            this.btnPC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPC.IconSize = 75;
            this.btnPC.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPC.Location = new System.Drawing.Point(14, 14);
            this.btnPC.Name = "btnPC";
            this.btnPC.Size = new System.Drawing.Size(102, 102);
            this.btnPC.TabIndex = 0;
            this.btnPC.Text = "PC";
            this.btnPC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPC.UseVisualStyleBackColor = true;
            this.btnPC.Click += new System.EventHandler(this.btnPC_Click);
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.btnPS);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(146, 83);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(130, 130);
            this.materialCard2.TabIndex = 8;
            // 
            // btnPS
            // 
            this.btnPS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPS.FlatAppearance.BorderSize = 0;
            this.btnPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPS.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPS.IconChar = FontAwesome.Sharp.IconChar.Playstation;
            this.btnPS.IconColor = System.Drawing.Color.Black;
            this.btnPS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPS.IconSize = 75;
            this.btnPS.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPS.Location = new System.Drawing.Point(14, 14);
            this.btnPS.Name = "btnPS";
            this.btnPS.Size = new System.Drawing.Size(102, 102);
            this.btnPS.TabIndex = 1;
            this.btnPS.Text = "PS4/PS5";
            this.btnPS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPS.UseVisualStyleBackColor = true;
            this.btnPS.Click += new System.EventHandler(this.btnPC_Click);
            // 
            // materialCard3
            // 
            this.materialCard3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.btnXB);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(281, 83);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(130, 130);
            this.materialCard3.TabIndex = 8;
            // 
            // btnXB
            // 
            this.btnXB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXB.FlatAppearance.BorderSize = 0;
            this.btnXB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXB.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXB.IconChar = FontAwesome.Sharp.IconChar.Xbox;
            this.btnXB.IconColor = System.Drawing.Color.Black;
            this.btnXB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXB.IconSize = 75;
            this.btnXB.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXB.Location = new System.Drawing.Point(14, 14);
            this.btnXB.Name = "btnXB";
            this.btnXB.Size = new System.Drawing.Size(102, 102);
            this.btnXB.TabIndex = 1;
            this.btnXB.Text = "XBOX";
            this.btnXB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnXB.UseVisualStyleBackColor = true;
            this.btnXB.Click += new System.EventHandler(this.btnPC_Click);
            // 
            // materialCard4
            // 
            this.materialCard4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.btnSW);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(415, 83);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(130, 130);
            this.materialCard4.TabIndex = 8;
            // 
            // btnSW
            // 
            this.btnSW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSW.FlatAppearance.BorderSize = 0;
            this.btnSW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSW.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSW.IconChar = FontAwesome.Sharp.IconChar.Gamepad;
            this.btnSW.IconColor = System.Drawing.Color.Black;
            this.btnSW.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSW.IconSize = 75;
            this.btnSW.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSW.Location = new System.Drawing.Point(14, 14);
            this.btnSW.Name = "btnSW";
            this.btnSW.Size = new System.Drawing.Size(102, 102);
            this.btnSW.TabIndex = 1;
            this.btnSW.Text = "Switch";
            this.btnSW.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSW.UseVisualStyleBackColor = true;
            this.btnSW.Click += new System.EventHandler(this.btnPC_Click);
            // 
            // materialCard5
            // 
            this.materialCard5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.BackgroundImage = global::GAMEstarter.Properties.Resources.Logo_full4;
            this.materialCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.materialCard5.Controls.Add(this.btnMB);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(549, 83);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(130, 130);
            this.materialCard5.TabIndex = 8;
            // 
            // btnMB
            // 
            this.btnMB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMB.FlatAppearance.BorderSize = 0;
            this.btnMB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMB.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMB.IconChar = FontAwesome.Sharp.IconChar.MobileAlt;
            this.btnMB.IconColor = System.Drawing.Color.Black;
            this.btnMB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMB.IconSize = 75;
            this.btnMB.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMB.Location = new System.Drawing.Point(14, 14);
            this.btnMB.Name = "btnMB";
            this.btnMB.Size = new System.Drawing.Size(102, 102);
            this.btnMB.TabIndex = 1;
            this.btnMB.Text = "Mobile";
            this.btnMB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMB.UseVisualStyleBackColor = true;
            this.btnMB.Click += new System.EventHandler(this.btnPC_Click);
            // 
            // platformLabel1
            // 
            this.platformLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gamesBindingSource, "platform", true));
            this.platformLabel1.ForeColor = System.Drawing.Color.Black;
            this.platformLabel1.Location = new System.Drawing.Point(5, 294);
            this.platformLabel1.Name = "platformLabel1";
            this.platformLabel1.Size = new System.Drawing.Size(667, 23);
            this.platformLabel1.TabIndex = 10;
            this.platformLabel1.Text = "label2";
            // 
            // FormdataExit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(692, 326);
            this.Controls.Add(this.platformLabel1);
            this.Controls.Add(label1);
            this.Controls.Add(this.materialCard5);
            this.Controls.Add(this.materialCard4);
            this.Controls.Add(this.materialCard3);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(data_exitLabel);
            this.Controls.Add(this.data_exitDateTimePicker);
            this.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormdataExit";
            this.Text = "FormdataExit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormdataExit_FormClosing);
            this.Load += new System.EventHandler(this.FormdataExit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameStartDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.materialCard4.ResumeLayout(false);
            this.materialCard5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GameStartDBDataSet gameStartDBDataSet;
        private System.Windows.Forms.BindingSource gamesBindingSource;
        private GameStartDBDataSetTableAdapters.GamesTableAdapter gamesTableAdapter;
        private GameStartDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker data_exitDateTimePicker;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private FontAwesome.Sharp.IconButton btnPC;
        private FontAwesome.Sharp.IconButton btnPS;
        private FontAwesome.Sharp.IconButton btnXB;
        private FontAwesome.Sharp.IconButton btnSW;
        private FontAwesome.Sharp.IconButton btnMB;
        private System.Windows.Forms.Label platformLabel1;
    }
}