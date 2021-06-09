namespace GAMEstarter
{
    partial class CardAbout
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
            this.cpbMoney = new CircularProgressBar.CircularProgressBar();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDatExt = new System.Windows.Forms.Label();
            this.lblMHave = new System.Windows.Forms.Label();
            this.lblMNeed = new System.Windows.Forms.Label();
            this.panelSeparator = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.pbCheck = new System.Windows.Forms.PictureBox();
            this.btnDel = new FontAwesome.Sharp.IconButton();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.pbPreviev = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreviev)).BeginInit();
            this.SuspendLayout();
            // 
            // cpbMoney
            // 
            this.cpbMoney.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbMoney.AnimationSpeed = 500;
            this.cpbMoney.BackColor = System.Drawing.Color.Transparent;
            this.cpbMoney.Dock = System.Windows.Forms.DockStyle.Right;
            this.cpbMoney.Font = new System.Drawing.Font("Nirmala UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.cpbMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpbMoney.InnerColor = System.Drawing.Color.White;
            this.cpbMoney.InnerMargin = 2;
            this.cpbMoney.InnerWidth = -1;
            this.cpbMoney.Location = new System.Drawing.Point(850, 0);
            this.cpbMoney.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cpbMoney.MarqueeAnimationSpeed = 2000;
            this.cpbMoney.Name = "cpbMoney";
            this.cpbMoney.OuterColor = System.Drawing.Color.Silver;
            this.cpbMoney.OuterMargin = -25;
            this.cpbMoney.OuterWidth = 25;
            this.cpbMoney.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cpbMoney.ProgressWidth = 10;
            this.cpbMoney.SecondaryFont = new System.Drawing.Font("Nirmala UI", 14F);
            this.cpbMoney.Size = new System.Drawing.Size(150, 150);
            this.cpbMoney.StartAngle = 270;
            this.cpbMoney.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.cpbMoney.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbMoney.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.cpbMoney.SubscriptText = "";
            this.cpbMoney.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbMoney.SuperscriptMargin = new System.Windows.Forms.Padding(20, -20, 0, 0);
            this.cpbMoney.SuperscriptText = "";
            this.cpbMoney.TabIndex = 0;
            this.cpbMoney.TextMargin = new System.Windows.Forms.Padding(10, -8, 0, 0);
            this.cpbMoney.Value = 50;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(330, 11);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(505, 37);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "BigNameGame 4: Abandoned Names";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Дата выхода:";
            // 
            // lblDatExt
            // 
            this.lblDatExt.AutoSize = true;
            this.lblDatExt.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblDatExt.Location = new System.Drawing.Point(330, 73);
            this.lblDatExt.Name = "lblDatExt";
            this.lblDatExt.Size = new System.Drawing.Size(150, 30);
            this.lblDatExt.TabIndex = 4;
            this.lblDatExt.Text = "20.08.2020 г.";
            // 
            // lblMHave
            // 
            this.lblMHave.BackColor = System.Drawing.Color.White;
            this.lblMHave.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblMHave.Location = new System.Drawing.Point(878, 48);
            this.lblMHave.Name = "lblMHave";
            this.lblMHave.Size = new System.Drawing.Size(94, 25);
            this.lblMHave.TabIndex = 9;
            this.lblMHave.Text = "99999999";
            this.lblMHave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMNeed
            // 
            this.lblMNeed.BackColor = System.Drawing.Color.White;
            this.lblMNeed.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblMNeed.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMNeed.Location = new System.Drawing.Point(878, 76);
            this.lblMNeed.Name = "lblMNeed";
            this.lblMNeed.Size = new System.Drawing.Size(94, 25);
            this.lblMNeed.TabIndex = 10;
            this.lblMNeed.Text = "88888888";
            this.lblMNeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSeparator
            // 
            this.panelSeparator.BackColor = System.Drawing.Color.Black;
            this.panelSeparator.Location = new System.Drawing.Point(878, 76);
            this.panelSeparator.Name = "panelSeparator";
            this.panelSeparator.Size = new System.Drawing.Size(94, 2);
            this.panelSeparator.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(520, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Жанр:";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblGenre.Location = new System.Drawing.Point(520, 71);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(174, 30);
            this.lblGenre.TabIndex = 13;
            this.lblGenre.Text = "Метроидвания";
            // 
            // pbCheck
            // 
            this.pbCheck.BackColor = System.Drawing.Color.Transparent;
            this.pbCheck.Image = global::GAMEstarter.Properties.Resources.success;
            this.pbCheck.Location = new System.Drawing.Point(850, 0);
            this.pbCheck.Name = "pbCheck";
            this.pbCheck.Size = new System.Drawing.Size(150, 150);
            this.pbCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCheck.TabIndex = 14;
            this.pbCheck.TabStop = false;
            this.pbCheck.Visible = false;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Red;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDel.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDel.IconColor = System.Drawing.Color.Black;
            this.btnDel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDel.IconSize = 40;
            this.btnDel.Location = new System.Drawing.Point(605, 107);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(230, 40);
            this.btnDel.TabIndex = 8;
            this.btnDel.Text = "Удалить проект";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDel.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnEdit.IconColor = System.Drawing.Color.Black;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.IconSize = 40;
            this.btnEdit.Location = new System.Drawing.Point(330, 107);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(268, 40);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Редактировать проект";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // pbPreviev
            // 
            this.pbPreviev.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbPreviev.Location = new System.Drawing.Point(0, 0);
            this.pbPreviev.Name = "pbPreviev";
            this.pbPreviev.Size = new System.Drawing.Size(320, 150);
            this.pbPreviev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPreviev.TabIndex = 5;
            this.pbPreviev.TabStop = false;
            // 
            // CardAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pbCheck);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelSeparator);
            this.Controls.Add(this.lblMNeed);
            this.Controls.Add(this.lblMHave);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.pbPreviev);
            this.Controls.Add(this.lblDatExt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cpbMoney);
            this.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "CardAbout";
            this.Size = new System.Drawing.Size(1000, 150);
            this.Load += new System.EventHandler(this.CardAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreviev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar cpbMoney;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbPreviev;
        public FontAwesome.Sharp.IconButton btnEdit;
        public FontAwesome.Sharp.IconButton btnDel;
        private System.Windows.Forms.Label lblMHave;
        private System.Windows.Forms.Label lblMNeed;
        private System.Windows.Forms.Panel panelSeparator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.PictureBox pbCheck;
        public System.Windows.Forms.Label lblDatExt;
    }
}
