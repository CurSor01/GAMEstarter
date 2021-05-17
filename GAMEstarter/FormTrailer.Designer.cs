namespace GAMEstarter
{
    partial class FormTrailer
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
            this.panelVideo = new System.Windows.Forms.Panel();
            this.gameStartDBDataSet = new GAMEstarter.GameStartDBDataSet();
            this.gamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gamesTableAdapter = new GAMEstarter.GameStartDBDataSetTableAdapters.GamesTableAdapter();
            this.trailer_linkTextBox = new System.Windows.Forms.TextBox();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.gameStartDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelVideo
            // 
            this.panelVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelVideo.Location = new System.Drawing.Point(12, 53);
            this.panelVideo.Name = "panelVideo";
            this.panelVideo.Size = new System.Drawing.Size(843, 498);
            this.panelVideo.TabIndex = 8;
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
            // trailer_linkTextBox
            // 
            this.trailer_linkTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trailer_linkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gamesBindingSource, "trailer_link", true));
            this.trailer_linkTextBox.Location = new System.Drawing.Point(12, 12);
            this.trailer_linkTextBox.Name = "trailer_linkTextBox";
            this.trailer_linkTextBox.Size = new System.Drawing.Size(797, 33);
            this.trailer_linkTextBox.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.Black;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 40;
            this.btnSearch.Location = new System.Drawing.Point(815, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FormTrailer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(867, 563);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.trailer_linkTextBox);
            this.Controls.Add(this.panelVideo);
            this.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormTrailer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Изменить трейлер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTrailer_FormClosing);
            this.Load += new System.EventHandler(this.FormTrailer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameStartDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelVideo;
        private GameStartDBDataSet gameStartDBDataSet;
        private System.Windows.Forms.BindingSource gamesBindingSource;
        private GameStartDBDataSetTableAdapters.GamesTableAdapter gamesTableAdapter;
        private System.Windows.Forms.TextBox trailer_linkTextBox;
        private FontAwesome.Sharp.IconButton btnSearch;
    }
}