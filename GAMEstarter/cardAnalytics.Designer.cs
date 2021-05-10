namespace GAMEstarter
{
    partial class cardAnalytics
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
            this.panelSeparator = new System.Windows.Forms.Panel();
            this.lblMNeed = new System.Windows.Forms.Label();
            this.lblMHave = new System.Windows.Forms.Label();
            this.cpbMoney = new CircularProgressBar.CircularProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.pbCheck = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSeparator
            // 
            this.panelSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSeparator.BackColor = System.Drawing.Color.Black;
            this.panelSeparator.Location = new System.Drawing.Point(32, 96);
            this.panelSeparator.Margin = new System.Windows.Forms.Padding(6);
            this.panelSeparator.Name = "panelSeparator";
            this.panelSeparator.Size = new System.Drawing.Size(140, 4);
            this.panelSeparator.TabIndex = 15;
            // 
            // lblMNeed
            // 
            this.lblMNeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMNeed.BackColor = System.Drawing.Color.Transparent;
            this.lblMNeed.Font = new System.Drawing.Font("Nirmala UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMNeed.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMNeed.Location = new System.Drawing.Point(32, 96);
            this.lblMNeed.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMNeed.Name = "lblMNeed";
            this.lblMNeed.Size = new System.Drawing.Size(140, 36);
            this.lblMNeed.TabIndex = 14;
            this.lblMNeed.Text = "000000";
            this.lblMNeed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMHave
            // 
            this.lblMHave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMHave.BackColor = System.Drawing.Color.Transparent;
            this.lblMHave.Font = new System.Drawing.Font("Nirmala UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMHave.Location = new System.Drawing.Point(32, 60);
            this.lblMHave.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMHave.Name = "lblMHave";
            this.lblMHave.Size = new System.Drawing.Size(140, 34);
            this.lblMHave.TabIndex = 13;
            this.lblMHave.Text = "000000";
            this.lblMHave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // cpbMoney
            // 
            this.cpbMoney.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbMoney.AnimationSpeed = 2000;
            this.cpbMoney.BackColor = System.Drawing.Color.Transparent;
            this.cpbMoney.Dock = System.Windows.Forms.DockStyle.Top;
            this.cpbMoney.Font = new System.Drawing.Font("Nirmala UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.cpbMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpbMoney.InnerColor = System.Drawing.Color.White;
            this.cpbMoney.InnerMargin = 0;
            this.cpbMoney.InnerWidth = -1;
            this.cpbMoney.Location = new System.Drawing.Point(0, 0);
            this.cpbMoney.Margin = new System.Windows.Forms.Padding(11, 15, 11, 15);
            this.cpbMoney.MarqueeAnimationSpeed = 2000;
            this.cpbMoney.Name = "cpbMoney";
            this.cpbMoney.OuterColor = System.Drawing.Color.Silver;
            this.cpbMoney.OuterMargin = -25;
            this.cpbMoney.OuterWidth = 25;
            this.cpbMoney.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cpbMoney.ProgressWidth = 15;
            this.cpbMoney.SecondaryFont = new System.Drawing.Font("Nirmala UI", 14F);
            this.cpbMoney.Size = new System.Drawing.Size(200, 200);
            this.cpbMoney.StartAngle = 270;
            this.cpbMoney.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.cpbMoney.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbMoney.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.cpbMoney.SubscriptText = "";
            this.cpbMoney.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbMoney.SuperscriptMargin = new System.Windows.Forms.Padding(20, -20, 0, 0);
            this.cpbMoney.SuperscriptText = "";
            this.cpbMoney.TabIndex = 14;
            this.cpbMoney.TextMargin = new System.Windows.Forms.Padding(10, -8, 0, 0);
            this.cpbMoney.Value = 50;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 3);
            this.panel1.TabIndex = 16;
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(0, 203);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(200, 34);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Greate Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbCheck
            // 
            this.pbCheck.BackColor = System.Drawing.Color.Transparent;
            this.pbCheck.Image = global::GAMEstarter.Properties.Resources.success;
            this.pbCheck.Location = new System.Drawing.Point(0, 0);
            this.pbCheck.Name = "pbCheck";
            this.pbCheck.Size = new System.Drawing.Size(200, 200);
            this.pbCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCheck.TabIndex = 20;
            this.pbCheck.TabStop = false;
            this.pbCheck.Visible = false;
            // 
            // cardAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pbCheck);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSeparator);
            this.Controls.Add(this.lblMNeed);
            this.Controls.Add(this.lblMHave);
            this.Controls.Add(this.cpbMoney);
            this.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "cardAnalytics";
            this.Size = new System.Drawing.Size(200, 237);
            ((System.ComponentModel.ISupportInitialize)(this.pbCheck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSeparator;
        public System.Windows.Forms.Label lblMNeed;
        public System.Windows.Forms.Label lblMHave;
        public CircularProgressBar.CircularProgressBar cpbMoney;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pbCheck;
    }
}
