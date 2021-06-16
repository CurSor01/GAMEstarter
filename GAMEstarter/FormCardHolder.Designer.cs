
namespace GAMEstarter
{
    partial class FormCardHolder
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
            System.Windows.Forms.Label nubmLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCardHolder));
            this.nubmLabel = new System.Windows.Forms.Label();
            this.gameStartDBDataSet = new GAMEstarter.GameStartDBDataSet();
            this.cardsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardsTableAdapter = new GAMEstarter.GameStartDBDataSetTableAdapters.CardsTableAdapter();
            this.tableAdapterManager = new GAMEstarter.GameStartDBDataSetTableAdapters.TableAdapterManager();
            this.tbxValid = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCC = new System.Windows.Forms.Panel();
            this.tbxNumb = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxCVV = new System.Windows.Forms.MaskedTextBox();
            this.tbxCardHolder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nubmComboBox = new System.Windows.Forms.ComboBox();
            this.panelFormManage = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.tbxSumTr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSendMoney = new MaterialSkin.Controls.MaterialButton();
            this.cardTransaction = new MaterialSkin.Controls.MaterialCard();
            this.id_userLabel1 = new System.Windows.Forms.Label();
            this.id_cardLabel1 = new System.Windows.Forms.Label();
            this.panelCardManage = new MaterialSkin.Controls.MaterialCard();
            nubmLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameStartDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsBindingSource)).BeginInit();
            this.panelCC.SuspendLayout();
            this.panelFormManage.SuspendLayout();
            this.cardTransaction.SuspendLayout();
            this.panelCardManage.SuspendLayout();
            this.SuspendLayout();
            // 
            // nubmLabel1
            // 
            nubmLabel1.AutoSize = true;
            nubmLabel1.BackColor = System.Drawing.Color.Transparent;
            nubmLabel1.Location = new System.Drawing.Point(12, 12);
            nubmLabel1.Name = "nubmLabel1";
            nubmLabel1.Size = new System.Drawing.Size(183, 25);
            nubmLabel1.TabIndex = 7;
            nubmLabel1.Text = "Список ваших карт";
            // 
            // nubmLabel
            // 
            this.nubmLabel.AutoSize = true;
            this.nubmLabel.BackColor = System.Drawing.Color.Transparent;
            this.nubmLabel.ForeColor = System.Drawing.Color.White;
            this.nubmLabel.Location = new System.Drawing.Point(11, 79);
            this.nubmLabel.Name = "nubmLabel";
            this.nubmLabel.Size = new System.Drawing.Size(133, 25);
            this.nubmLabel.TabIndex = 4;
            this.nubmLabel.Text = "Номер карты:";
            // 
            // gameStartDBDataSet
            // 
            this.gameStartDBDataSet.DataSetName = "GameStartDBDataSet";
            this.gameStartDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cardsBindingSource
            // 
            this.cardsBindingSource.DataMember = "Cards";
            this.cardsBindingSource.DataSource = this.gameStartDBDataSet;
            // 
            // cardsTableAdapter
            // 
            this.cardsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CardsTableAdapter = this.cardsTableAdapter;
            this.tableAdapterManager.GamesTableAdapter = null;
            this.tableAdapterManager.GenresTableAdapter = null;
            this.tableAdapterManager.MessagesTableAdapter = null;
            this.tableAdapterManager.PhotosTableAdapter = null;
            this.tableAdapterManager.StudiosTableAdapter = null;
            this.tableAdapterManager.TransactionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GAMEstarter.GameStartDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.VievsTableAdapter = null;
            // 
            // tbxValid
            // 
            this.tbxValid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxValid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardsBindingSource, "data", true));
            this.tbxValid.Location = new System.Drawing.Point(117, 171);
            this.tbxValid.Mask = "00/00";
            this.tbxValid.Name = "tbxValid";
            this.tbxValid.ReadOnly = true;
            this.tbxValid.Size = new System.Drawing.Size(61, 26);
            this.tbxValid.TabIndex = 9;
            this.tbxValid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxValid.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "VALID\r\nTHRU";
            // 
            // panelCC
            // 
            this.panelCC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelCC.BackColor = System.Drawing.Color.Transparent;
            this.panelCC.BackgroundImage = global::GAMEstarter.Properties.Resources.Card_EMPTY;
            this.panelCC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelCC.Controls.Add(this.tbxNumb);
            this.panelCC.Controls.Add(this.label2);
            this.panelCC.Controls.Add(this.nubmLabel);
            this.panelCC.Controls.Add(this.tbxCVV);
            this.panelCC.Controls.Add(this.tbxValid);
            this.panelCC.Controls.Add(this.label1);
            this.panelCC.ForeColor = System.Drawing.Color.White;
            this.panelCC.Location = new System.Drawing.Point(5, 44);
            this.panelCC.Name = "panelCC";
            this.panelCC.Size = new System.Drawing.Size(320, 200);
            this.panelCC.TabIndex = 4;
            // 
            // tbxNumb
            // 
            this.tbxNumb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxNumb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardsBindingSource, "nubm", true));
            this.tbxNumb.Location = new System.Drawing.Point(16, 107);
            this.tbxNumb.Mask = "0000 0000 0000 0000";
            this.tbxNumb.Name = "tbxNumb";
            this.tbxNumb.ReadOnly = true;
            this.tbxNumb.Size = new System.Drawing.Size(282, 26);
            this.tbxNumb.TabIndex = 7;
            this.tbxNumb.ValidatingType = typeof(int);
            this.tbxNumb.TextChanged += new System.EventHandler(this.tbxNumb_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "CVC/CVV:";
            // 
            // tbxCVV
            // 
            this.tbxCVV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCVV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardsBindingSource, "cvv", true));
            this.tbxCVV.Location = new System.Drawing.Point(117, 139);
            this.tbxCVV.Mask = "000";
            this.tbxCVV.Name = "tbxCVV";
            this.tbxCVV.ReadOnly = true;
            this.tbxCVV.Size = new System.Drawing.Size(61, 26);
            this.tbxCVV.TabIndex = 8;
            this.tbxCVV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxCVV.UseSystemPasswordChar = true;
            // 
            // tbxCardHolder
            // 
            this.tbxCardHolder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbxCardHolder.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardsBindingSource, "fam", true));
            this.tbxCardHolder.Location = new System.Drawing.Point(5, 272);
            this.tbxCardHolder.MaxLength = 28;
            this.tbxCardHolder.Name = "tbxCardHolder";
            this.tbxCardHolder.ReadOnly = true;
            this.tbxCardHolder.Size = new System.Drawing.Size(320, 33);
            this.tbxCardHolder.TabIndex = 5;
            this.tbxCardHolder.Text = "\r\n\r\n";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Владелец карты:";
            // 
            // nubmComboBox
            // 
            this.nubmComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nubmComboBox.DataSource = this.cardsBindingSource;
            this.nubmComboBox.DisplayMember = "nubm";
            this.nubmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nubmComboBox.FormattingEnabled = true;
            this.nubmComboBox.Location = new System.Drawing.Point(46, 5);
            this.nubmComboBox.Name = "nubmComboBox";
            this.nubmComboBox.Size = new System.Drawing.Size(240, 33);
            this.nubmComboBox.TabIndex = 8;
            // 
            // panelFormManage
            // 
            this.panelFormManage.BackColor = System.Drawing.Color.Gainsboro;
            this.panelFormManage.Controls.Add(this.btnClose);
            this.panelFormManage.Controls.Add(nubmLabel1);
            this.panelFormManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFormManage.Location = new System.Drawing.Point(0, 0);
            this.panelFormManage.Name = "panelFormManage";
            this.panelFormManage.Size = new System.Drawing.Size(350, 40);
            this.panelFormManage.TabIndex = 10;
            this.panelFormManage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelFormManage_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.Location = new System.Drawing.Point(310, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButton2.BackColor = System.Drawing.Color.Gainsboro;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.Location = new System.Drawing.Point(292, 5);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(33, 33);
            this.iconButton2.TabIndex = 9;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 33;
            this.btnAdd.Location = new System.Drawing.Point(5, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(35, 33);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxSumTr
            // 
            this.tbxSumTr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSumTr.BackColor = System.Drawing.Color.White;
            this.tbxSumTr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxSumTr.Location = new System.Drawing.Point(175, 32);
            this.tbxSumTr.Name = "tbxSumTr";
            this.tbxSumTr.Size = new System.Drawing.Size(96, 33);
            this.tbxSumTr.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Сумма перевода:                     $";
            // 
            // btnSendMoney
            // 
            this.btnSendMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendMoney.AutoSize = false;
            this.btnSendMoney.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSendMoney.Depth = 0;
            this.btnSendMoney.DrawShadows = true;
            this.btnSendMoney.HighEmphasis = true;
            this.btnSendMoney.Icon = null;
            this.btnSendMoney.Location = new System.Drawing.Point(5, 75);
            this.btnSendMoney.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSendMoney.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSendMoney.Name = "btnSendMoney";
            this.btnSendMoney.Size = new System.Drawing.Size(320, 44);
            this.btnSendMoney.TabIndex = 12;
            this.btnSendMoney.Text = "Сделать пожертвование";
            this.btnSendMoney.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSendMoney.UseAccentColor = false;
            this.btnSendMoney.UseVisualStyleBackColor = true;
            this.btnSendMoney.Click += new System.EventHandler(this.btnSendMoney_Click);
            // 
            // cardTransaction
            // 
            this.cardTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardTransaction.Controls.Add(this.tbxSumTr);
            this.cardTransaction.Controls.Add(this.btnSendMoney);
            this.cardTransaction.Controls.Add(this.label4);
            this.cardTransaction.Depth = 0;
            this.cardTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardTransaction.Location = new System.Drawing.Point(10, 366);
            this.cardTransaction.Margin = new System.Windows.Forms.Padding(14);
            this.cardTransaction.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardTransaction.Name = "cardTransaction";
            this.cardTransaction.Padding = new System.Windows.Forms.Padding(14);
            this.cardTransaction.Size = new System.Drawing.Size(330, 140);
            this.cardTransaction.TabIndex = 13;
            // 
            // id_userLabel1
            // 
            this.id_userLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardsBindingSource, "id_user", true));
            this.id_userLabel1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.id_userLabel1.Location = new System.Drawing.Point(341, 475);
            this.id_userLabel1.Name = "id_userLabel1";
            this.id_userLabel1.Size = new System.Drawing.Size(22, 23);
            this.id_userLabel1.TabIndex = 14;
            this.id_userLabel1.Text = "0";
            // 
            // id_cardLabel1
            // 
            this.id_cardLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardsBindingSource, "id_card", true));
            this.id_cardLabel1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.id_cardLabel1.Location = new System.Drawing.Point(341, 452);
            this.id_cardLabel1.Name = "id_cardLabel1";
            this.id_cardLabel1.Size = new System.Drawing.Size(22, 23);
            this.id_cardLabel1.TabIndex = 16;
            this.id_cardLabel1.Text = "0";
            // 
            // panelCardManage
            // 
            this.panelCardManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelCardManage.Controls.Add(this.btnAdd);
            this.panelCardManage.Controls.Add(this.panelCC);
            this.panelCardManage.Controls.Add(this.nubmComboBox);
            this.panelCardManage.Controls.Add(this.tbxCardHolder);
            this.panelCardManage.Controls.Add(this.iconButton2);
            this.panelCardManage.Controls.Add(this.label3);
            this.panelCardManage.Depth = 0;
            this.panelCardManage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelCardManage.Location = new System.Drawing.Point(10, 47);
            this.panelCardManage.Margin = new System.Windows.Forms.Padding(14);
            this.panelCardManage.MouseState = MaterialSkin.MouseState.HOVER;
            this.panelCardManage.Name = "panelCardManage";
            this.panelCardManage.Padding = new System.Windows.Forms.Padding(14);
            this.panelCardManage.Size = new System.Drawing.Size(330, 310);
            this.panelCardManage.TabIndex = 17;
            // 
            // FormCardHolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(350, 500);
            this.Controls.Add(this.panelCardManage);
            this.Controls.Add(this.id_cardLabel1);
            this.Controls.Add(this.id_userLabel1);
            this.Controls.Add(this.cardTransaction);
            this.Controls.Add(this.panelFormManage);
            this.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormCardHolder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список ваших карт";
            this.Load += new System.EventHandler(this.FormCardHolder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameStartDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsBindingSource)).EndInit();
            this.panelCC.ResumeLayout(false);
            this.panelCC.PerformLayout();
            this.panelFormManage.ResumeLayout(false);
            this.panelFormManage.PerformLayout();
            this.cardTransaction.ResumeLayout(false);
            this.cardTransaction.PerformLayout();
            this.panelCardManage.ResumeLayout(false);
            this.panelCardManage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnClose;
        private GameStartDBDataSet gameStartDBDataSet;
        private System.Windows.Forms.BindingSource cardsBindingSource;
        private GameStartDBDataSetTableAdapters.CardsTableAdapter cardsTableAdapter;
        private GameStartDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label nubmLabel;
        private System.Windows.Forms.MaskedTextBox tbxValid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelCC;
        private System.Windows.Forms.MaskedTextBox tbxNumb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox tbxCVV;
        private System.Windows.Forms.TextBox tbxCardHolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox nubmComboBox;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panelFormManage;
        private System.Windows.Forms.TextBox tbxSumTr;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialButton btnSendMoney;
        private MaterialSkin.Controls.MaterialCard cardTransaction;
        private System.Windows.Forms.Label id_userLabel1;
        private System.Windows.Forms.Label id_cardLabel1;
        private MaterialSkin.Controls.MaterialCard panelCardManage;
    }
}