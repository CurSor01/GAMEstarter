namespace GAMEstarter
{
    partial class FormIcons
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
            System.Windows.Forms.Label image_maxLabel;
            System.Windows.Forms.Label image_minLabel;
            this.gameStartDBDataSet = new GAMEstarter.GameStartDBDataSet();
            this.gamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gamesTableAdapter = new GAMEstarter.GameStartDBDataSetTableAdapters.GamesTableAdapter();
            this.image_maxPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.image_minPictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            image_maxLabel = new System.Windows.Forms.Label();
            image_minLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameStartDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_maxPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_minPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // image_maxLabel
            // 
            image_maxLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            image_maxLabel.AutoSize = true;
            image_maxLabel.Location = new System.Drawing.Point(269, 8);
            image_maxLabel.Name = "image_maxLabel";
            image_maxLabel.Size = new System.Drawing.Size(87, 25);
            image_maxLabel.TabIndex = 1;
            image_maxLabel.Text = "Превью:";
            // 
            // image_minLabel
            // 
            image_minLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            image_minLabel.AutoSize = true;
            image_minLabel.Location = new System.Drawing.Point(113, 8);
            image_minLabel.Name = "image_minLabel";
            image_minLabel.Size = new System.Drawing.Size(79, 25);
            image_minLabel.TabIndex = 2;
            image_minLabel.Text = "Иконка:";
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
            // image_maxPictureBox
            // 
            this.image_maxPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.image_maxPictureBox.BackColor = System.Drawing.Color.DarkGray;
            this.image_maxPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.gamesBindingSource, "image_max", true));
            this.image_maxPictureBox.Location = new System.Drawing.Point(274, 36);
            this.image_maxPictureBox.Name = "image_maxPictureBox";
            this.image_maxPictureBox.Size = new System.Drawing.Size(320, 150);
            this.image_maxPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image_maxPictureBox.TabIndex = 2;
            this.image_maxPictureBox.TabStop = false;
            this.image_maxPictureBox.Click += new System.EventHandler(this.image_maxPictureBox_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.label1.Location = new System.Drawing.Point(119, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Нажмите на нужное поле для редактирования";
            // 
            // image_minPictureBox
            // 
            this.image_minPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.image_minPictureBox.BackColor = System.Drawing.Color.DarkGray;
            this.image_minPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.gamesBindingSource, "image_min", true));
            this.image_minPictureBox.Location = new System.Drawing.Point(118, 36);
            this.image_minPictureBox.Name = "image_minPictureBox";
            this.image_minPictureBox.Size = new System.Drawing.Size(150, 150);
            this.image_minPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image_minPictureBox.TabIndex = 3;
            this.image_minPictureBox.TabStop = false;
            this.image_minPictureBox.Click += new System.EventHandler(this.image_minPictureBox_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(394, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "460 X 215";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "215 X 215";
            // 
            // FormIcons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(687, 259);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(image_minLabel);
            this.Controls.Add(this.image_minPictureBox);
            this.Controls.Add(image_maxLabel);
            this.Controls.Add(this.image_maxPictureBox);
            this.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormIcons";
            this.Text = "FormTrailer";
            this.Load += new System.EventHandler(this.FormTrailer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameStartDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_maxPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_minPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GameStartDBDataSet gameStartDBDataSet;
        private System.Windows.Forms.BindingSource gamesBindingSource;
        private GameStartDBDataSetTableAdapters.GamesTableAdapter gamesTableAdapter;
        private System.Windows.Forms.PictureBox image_maxPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox image_minPictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}