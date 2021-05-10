namespace GAMEstarter
{
    partial class FormMyPr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMyPr));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelCardsContent = new System.Windows.Forms.Panel();
            this.mcardAddPr = new MaterialSkin.Controls.MaterialCard();
            this.btnAddPr = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.mcardAddPr.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.panelCardsContent);
            this.panel1.Controls.Add(this.mcardAddPr);
            this.panel1.Location = new System.Drawing.Point(10, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 600);
            this.panel1.TabIndex = 0;
            // 
            // panelCardsContent
            // 
            this.panelCardsContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelCardsContent.AutoScroll = true;
            this.panelCardsContent.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panelCardsContent.Location = new System.Drawing.Point(0, 140);
            this.panelCardsContent.Name = "panelCardsContent";
            this.panelCardsContent.Size = new System.Drawing.Size(1200, 460);
            this.panelCardsContent.TabIndex = 1;
            // 
            // mcardAddPr
            // 
            this.mcardAddPr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcardAddPr.Controls.Add(this.btnAddPr);
            this.mcardAddPr.Depth = 0;
            this.mcardAddPr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcardAddPr.Location = new System.Drawing.Point(100, 30);
            this.mcardAddPr.Margin = new System.Windows.Forms.Padding(26, 27, 26, 27);
            this.mcardAddPr.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcardAddPr.Name = "mcardAddPr";
            this.mcardAddPr.Padding = new System.Windows.Forms.Padding(26, 27, 26, 27);
            this.mcardAddPr.Size = new System.Drawing.Size(1000, 80);
            this.mcardAddPr.TabIndex = 0;
            // 
            // btnAddPr
            // 
            this.btnAddPr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPr.IconChar = FontAwesome.Sharp.IconChar.NotesMedical;
            this.btnAddPr.IconColor = System.Drawing.Color.Black;
            this.btnAddPr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddPr.Location = new System.Drawing.Point(0, 1);
            this.btnAddPr.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddPr.Name = "btnAddPr";
            this.btnAddPr.Size = new System.Drawing.Size(1000, 79);
            this.btnAddPr.TabIndex = 0;
            this.btnAddPr.Text = "Новый проект";
            this.btnAddPr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddPr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddPr.UseVisualStyleBackColor = true;
            this.btnAddPr.Click += new System.EventHandler(this.btnAddPr_Click);
            // 
            // FormMyPr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1220, 600);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormMyPr";
            this.Text = "Обозреватель проектов";
            this.Load += new System.EventHandler(this.FormMyPr_Load);
            this.panel1.ResumeLayout(false);
            this.mcardAddPr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialCard mcardAddPr;
        private FontAwesome.Sharp.IconButton btnAddPr;
        private System.Windows.Forms.Panel panelCardsContent;
    }
}