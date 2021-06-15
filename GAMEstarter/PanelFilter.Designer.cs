
namespace GAMEstarter
{
    partial class PanelFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cardGenre = new MaterialSkin.Controls.MaterialCard();
            this.lblClearSelection = new System.Windows.Forms.Label();
            this.dgvGenres = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblGenre = new System.Windows.Forms.Label();
            this.panelCards = new System.Windows.Forms.Panel();
            this.cardGenre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenres)).BeginInit();
            this.SuspendLayout();
            // 
            // cardGenre
            // 
            this.cardGenre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cardGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardGenre.Controls.Add(this.lblClearSelection);
            this.cardGenre.Controls.Add(this.dgvGenres);
            this.cardGenre.Controls.Add(this.lblGenre);
            this.cardGenre.Depth = 0;
            this.cardGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardGenre.Location = new System.Drawing.Point(3, 27);
            this.cardGenre.Margin = new System.Windows.Forms.Padding(26, 27, 26, 27);
            this.cardGenre.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardGenre.Name = "cardGenre";
            this.cardGenre.Padding = new System.Windows.Forms.Padding(26, 27, 26, 27);
            this.cardGenre.Size = new System.Drawing.Size(288, 678);
            this.cardGenre.TabIndex = 0;
            // 
            // lblClearSelection
            // 
            this.lblClearSelection.AutoSize = true;
            this.lblClearSelection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClearSelection.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClearSelection.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblClearSelection.Location = new System.Drawing.Point(204, 18);
            this.lblClearSelection.Name = "lblClearSelection";
            this.lblClearSelection.Size = new System.Drawing.Size(78, 17);
            this.lblClearSelection.TabIndex = 2;
            this.lblClearSelection.Text = "(Очистить)";
            this.lblClearSelection.Visible = false;
            this.lblClearSelection.Click += new System.EventHandler(this.lblClearSelection_Click);
            // 
            // dgvGenres
            // 
            this.dgvGenres.AllowUserToAddRows = false;
            this.dgvGenres.AllowUserToDeleteRows = false;
            this.dgvGenres.AllowUserToResizeColumns = false;
            this.dgvGenres.AllowUserToResizeRows = false;
            this.dgvGenres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvGenres.BackgroundColor = System.Drawing.Color.White;
            this.dgvGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenres.ColumnHeadersVisible = false;
            this.dgvGenres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvGenres.Location = new System.Drawing.Point(0, 38);
            this.dgvGenres.MultiSelect = false;
            this.dgvGenres.Name = "dgvGenres";
            this.dgvGenres.RowHeadersVisible = false;
            this.dgvGenres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvGenres.Size = new System.Drawing.Size(288, 640);
            this.dgvGenres.TabIndex = 1;
            this.dgvGenres.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGenres_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(4, 10);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(64, 25);
            this.lblGenre.TabIndex = 0;
            this.lblGenre.Text = "Жанр:";
            // 
            // panelCards
            // 
            this.panelCards.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCards.AutoScroll = true;
            this.panelCards.Location = new System.Drawing.Point(310, 27);
            this.panelCards.Name = "panelCards";
            this.panelCards.Size = new System.Drawing.Size(742, 678);
            this.panelCards.TabIndex = 1;
            // 
            // PanelFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelCards);
            this.Controls.Add(this.cardGenre);
            this.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PanelFilter";
            this.Size = new System.Drawing.Size(1055, 732);
            this.Load += new System.EventHandler(this.PanelFilter_Load);
            this.cardGenre.ResumeLayout(false);
            this.cardGenre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard cardGenre;
        private System.Windows.Forms.DataGridView dgvGenres;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label lblClearSelection;
        public System.Windows.Forms.Panel panelCards;
    }
}
