namespace GAMEstarter
{
    partial class FormSettings
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
            this.cbxAutoLoad = new System.Windows.Forms.CheckBox();
            this.cbxCustomChild = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxClock = new System.Windows.Forms.CheckBox();
            this.panelColors = new System.Windows.Forms.Panel();
            this.lblWhite = new System.Windows.Forms.Label();
            this.lblGlass = new System.Windows.Forms.Label();
            this.lblPink = new System.Windows.Forms.Label();
            this.lblCyan = new System.Windows.Forms.Label();
            this.lblAzure = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblYellow = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.cmbDefPanel = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxDefPanel = new System.Windows.Forms.CheckBox();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.pbChildColor = new System.Windows.Forms.PictureBox();
            this.cmbChildColor = new System.Windows.Forms.ComboBox();
            this.cbxHidePanel = new System.Windows.Forms.CheckBox();
            this.panelColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbChildColor)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxAutoLoad
            // 
            this.cbxAutoLoad.AutoSize = true;
            this.cbxAutoLoad.Location = new System.Drawing.Point(17, 18);
            this.cbxAutoLoad.Name = "cbxAutoLoad";
            this.cbxAutoLoad.Size = new System.Drawing.Size(534, 29);
            this.cbxAutoLoad.TabIndex = 0;
            this.cbxAutoLoad.Text = "Автозагрузка приложения (перезагрузка не требуется)";
            this.cbxAutoLoad.UseVisualStyleBackColor = true;
            // 
            // cbxCustomChild
            // 
            this.cbxCustomChild.AutoSize = true;
            this.cbxCustomChild.Location = new System.Drawing.Point(17, 86);
            this.cbxCustomChild.Name = "cbxCustomChild";
            this.cbxCustomChild.Size = new System.Drawing.Size(372, 29);
            this.cbxCustomChild.TabIndex = 1;
            this.cbxCustomChild.Text = "Использовать один цвет для вкладок";
            this.cbxCustomChild.UseVisualStyleBackColor = true;
            this.cbxCustomChild.CheckedChanged += new System.EventHandler(this.cbxCustomChild_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выбрать тему приложения:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(276, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Выбрать";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbxClock
            // 
            this.cbxClock.AutoSize = true;
            this.cbxClock.Checked = true;
            this.cbxClock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxClock.Location = new System.Drawing.Point(17, 121);
            this.cbxClock.Name = "cbxClock";
            this.cbxClock.Size = new System.Drawing.Size(337, 29);
            this.cbxClock.TabIndex = 13;
            this.cbxClock.Text = "Показывать часы в главном меню";
            this.cbxClock.UseVisualStyleBackColor = true;
            this.cbxClock.CheckedChanged += new System.EventHandler(this.cbxClock_CheckedChanged);
            // 
            // panelColors
            // 
            this.panelColors.Controls.Add(this.lblWhite);
            this.panelColors.Controls.Add(this.lblGlass);
            this.panelColors.Controls.Add(this.lblPink);
            this.panelColors.Controls.Add(this.lblCyan);
            this.panelColors.Controls.Add(this.lblAzure);
            this.panelColors.Controls.Add(this.lblGreen);
            this.panelColors.Controls.Add(this.lblYellow);
            this.panelColors.Controls.Add(this.lblRed);
            this.panelColors.Controls.Add(this.lblBlue);
            this.panelColors.Controls.Add(this.pictureBox1);
            this.panelColors.Controls.Add(this.pictureBox2);
            this.panelColors.Controls.Add(this.pictureBox3);
            this.panelColors.Controls.Add(this.pictureBox4);
            this.panelColors.Controls.Add(this.pictureBox9);
            this.panelColors.Controls.Add(this.pictureBox5);
            this.panelColors.Controls.Add(this.pictureBox8);
            this.panelColors.Controls.Add(this.pictureBox6);
            this.panelColors.Controls.Add(this.pictureBox7);
            this.panelColors.Location = new System.Drawing.Point(17, 223);
            this.panelColors.Name = "panelColors";
            this.panelColors.Size = new System.Drawing.Size(640, 274);
            this.panelColors.TabIndex = 15;
            this.panelColors.Visible = false;
            // 
            // lblWhite
            // 
            this.lblWhite.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhite.Location = new System.Drawing.Point(215, 241);
            this.lblWhite.Name = "lblWhite";
            this.lblWhite.Size = new System.Drawing.Size(100, 25);
            this.lblWhite.TabIndex = 20;
            this.lblWhite.Tag = "8 8 1";
            this.lblWhite.Text = "Белый";
            this.lblWhite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGlass
            // 
            this.lblGlass.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGlass.Location = new System.Drawing.Point(109, 241);
            this.lblGlass.Name = "lblGlass";
            this.lblGlass.Size = new System.Drawing.Size(100, 25);
            this.lblGlass.TabIndex = 19;
            this.lblGlass.Tag = "7 7 1";
            this.lblGlass.Text = "Стекло";
            this.lblGlass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPink
            // 
            this.lblPink.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPink.Location = new System.Drawing.Point(3, 242);
            this.lblPink.Name = "lblPink";
            this.lblPink.Size = new System.Drawing.Size(100, 25);
            this.lblPink.TabIndex = 18;
            this.lblPink.Tag = "6 6 1";
            this.lblPink.Text = "Розовый";
            this.lblPink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCyan
            // 
            this.lblCyan.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCyan.Location = new System.Drawing.Point(533, 106);
            this.lblCyan.Name = "lblCyan";
            this.lblCyan.Size = new System.Drawing.Size(100, 25);
            this.lblCyan.TabIndex = 17;
            this.lblCyan.Tag = "5 5 0";
            this.lblCyan.Text = "Голубой";
            this.lblCyan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAzure
            // 
            this.lblAzure.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAzure.Location = new System.Drawing.Point(427, 106);
            this.lblAzure.Name = "lblAzure";
            this.lblAzure.Size = new System.Drawing.Size(100, 25);
            this.lblAzure.TabIndex = 16;
            this.lblAzure.Tag = "4 4 0";
            this.lblAzure.Text = "Лазурный";
            this.lblAzure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGreen
            // 
            this.lblGreen.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreen.Location = new System.Drawing.Point(321, 106);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(100, 25);
            this.lblGreen.TabIndex = 15;
            this.lblGreen.Tag = "3 3 0";
            this.lblGreen.Text = "Зелёный";
            this.lblGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYellow
            // 
            this.lblYellow.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYellow.Location = new System.Drawing.Point(215, 106);
            this.lblYellow.Name = "lblYellow";
            this.lblYellow.Size = new System.Drawing.Size(100, 25);
            this.lblYellow.TabIndex = 14;
            this.lblYellow.Tag = "2 2 0";
            this.lblYellow.Text = "Жёлтый";
            this.lblYellow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRed
            // 
            this.lblRed.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRed.Location = new System.Drawing.Point(109, 106);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(100, 25);
            this.lblRed.TabIndex = 13;
            this.lblRed.Tag = "1 1 0";
            this.lblRed.Text = "Красный";
            this.lblRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBlue
            // 
            this.lblBlue.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlue.Location = new System.Drawing.Point(3, 106);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(100, 25);
            this.lblBlue.TabIndex = 12;
            this.lblBlue.Tag = "0 0 0";
            this.lblBlue.Text = "Синий";
            this.lblBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GAMEstarter.Properties.Resources.Group_0;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GAMEstarter.Properties.Resources.Group_1;
            this.pictureBox2.Location = new System.Drawing.Point(109, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GAMEstarter.Properties.Resources.Group_2;
            this.pictureBox3.Location = new System.Drawing.Point(215, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GAMEstarter.Properties.Resources.Group_3;
            this.pictureBox4.Location = new System.Drawing.Point(321, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 100);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::GAMEstarter.Properties.Resources.Group_8;
            this.pictureBox9.Location = new System.Drawing.Point(215, 139);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(100, 100);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 11;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::GAMEstarter.Properties.Resources.Group_4;
            this.pictureBox5.Location = new System.Drawing.Point(427, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 100);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::GAMEstarter.Properties.Resources.Group_7;
            this.pictureBox8.Location = new System.Drawing.Point(109, 139);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(100, 100);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 10;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::GAMEstarter.Properties.Resources.Group_5;
            this.pictureBox6.Location = new System.Drawing.Point(533, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 100);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::GAMEstarter.Properties.Resources.Group_6;
            this.pictureBox7.Location = new System.Drawing.Point(3, 139);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(100, 100);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 9;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // cmbDefPanel
            // 
            this.cmbDefPanel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDefPanel.FormattingEnabled = true;
            this.cmbDefPanel.Items.AddRange(new object[] {
            "Аналитика",
            "Мои проекты",
            "Аккаунт",
            "Студия"});
            this.cmbDefPanel.Location = new System.Drawing.Point(312, 150);
            this.cmbDefPanel.Name = "cmbDefPanel";
            this.cmbDefPanel.Size = new System.Drawing.Size(161, 33);
            this.cmbDefPanel.TabIndex = 16;
            this.cmbDefPanel.Visible = false;
            this.cmbDefPanel.SelectedIndexChanged += new System.EventHandler(this.cmbDefPanel_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.cbxDefPanel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.pbChildColor);
            this.panel1.Controls.Add(this.cmbChildColor);
            this.panel1.Controls.Add(this.cbxHidePanel);
            this.panel1.Controls.Add(this.cbxAutoLoad);
            this.panel1.Controls.Add(this.cmbDefPanel);
            this.panel1.Controls.Add(this.cbxCustomChild);
            this.panel1.Controls.Add(this.panelColors);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbxClock);
            this.panel1.Location = new System.Drawing.Point(10, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 600);
            this.panel1.TabIndex = 17;
            // 
            // cbxDefPanel
            // 
            this.cbxDefPanel.AutoSize = true;
            this.cbxDefPanel.Location = new System.Drawing.Point(17, 152);
            this.cbxDefPanel.Name = "cbxDefPanel";
            this.cbxDefPanel.Size = new System.Drawing.Size(289, 29);
            this.cbxDefPanel.TabIndex = 23;
            this.cbxDefPanel.Text = "Выбрать стартовую вкладку:";
            this.cbxDefPanel.UseVisualStyleBackColor = true;
            this.cbxDefPanel.CheckedChanged += new System.EventHandler(this.cbxDefPanel_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSave.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 40;
            this.btnSave.Location = new System.Drawing.Point(338, 548);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(517, 40);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Сохранить изменения (требуется перезагрузка)";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pbChildColor
            // 
            this.pbChildColor.Location = new System.Drawing.Point(501, 83);
            this.pbChildColor.Name = "pbChildColor";
            this.pbChildColor.Size = new System.Drawing.Size(100, 100);
            this.pbChildColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbChildColor.TabIndex = 21;
            this.pbChildColor.TabStop = false;
            this.pbChildColor.Visible = false;
            // 
            // cmbChildColor
            // 
            this.cmbChildColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChildColor.FormattingEnabled = true;
            this.cmbChildColor.Location = new System.Drawing.Point(393, 84);
            this.cmbChildColor.Name = "cmbChildColor";
            this.cmbChildColor.Size = new System.Drawing.Size(102, 33);
            this.cmbChildColor.TabIndex = 17;
            this.cmbChildColor.Visible = false;
            this.cmbChildColor.SelectedIndexChanged += new System.EventHandler(this.cmbChildColor_SelectedIndexChanged);
            // 
            // cbxHidePanel
            // 
            this.cbxHidePanel.AutoSize = true;
            this.cbxHidePanel.Location = new System.Drawing.Point(17, 48);
            this.cbxHidePanel.Name = "cbxHidePanel";
            this.cbxHidePanel.Size = new System.Drawing.Size(390, 29);
            this.cbxHidePanel.TabIndex = 0;
            this.cbxHidePanel.Text = "Свернуть боковую панель при загрузке";
            this.cbxHidePanel.UseVisualStyleBackColor = true;
            this.cbxHidePanel.CheckedChanged += new System.EventHandler(this.cbxHidePanel_CheckedChanged);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1220, 600);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormSettings";
            this.Text = "Настройки программы";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.panelColors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbChildColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxAutoLoad;
        private System.Windows.Forms.CheckBox cbxCustomChild;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbxClock;
        private System.Windows.Forms.Panel panelColors;
        private System.Windows.Forms.ComboBox cmbDefPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCyan;
        private System.Windows.Forms.Label lblAzure;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblYellow;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblWhite;
        private System.Windows.Forms.Label lblGlass;
        private System.Windows.Forms.Label lblPink;
        private System.Windows.Forms.ComboBox cmbChildColor;
        private System.Windows.Forms.PictureBox pbChildColor;
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.CheckBox cbxDefPanel;
        private System.Windows.Forms.CheckBox cbxHidePanel;
    }
}