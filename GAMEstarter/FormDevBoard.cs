using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FontAwesome.Sharp;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Globalization;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GAMEstarter
{
    public partial class FormDevBoard : Form
    {
        public FormDevBoard()
        {
            InitializeComponent();
        }
        
        #region Управление формой
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;

            lblTime.Text = dt.ToString("HH:mm:ss");

            string dov = CultureInfo.CurrentCulture.TextInfo.
                ToTitleCase(dt.ToString("dddd", CultureInfo.GetCultureInfo("ru-ru")));
            lblMDY.Text = (dov + ", " + dt.ToLongDateString()).ToString();
        }

        void VisibleMenu()
        {
            if (btnHideMenu.Text != "")
            {
                btnHideMenu.IconChar = IconChar.ThList;
                btnHideMenu.Text = btnAnalytics.Text =
                    btnEditPr.Text = btnAccount.Text =
                    btnStudio.Text = btnCatalog.Text =
                    btnHome.Text = btnSettings.Text = btnExit.Text = "";
                //btnAddPr.Text = "";
                panelMenu.Width = 70;
            }
            else
            {
                btnHideMenu.IconChar = IconChar.EllipsisV;

                btnHideMenu.Text = "Скрыть меню";
                btnAnalytics.Text = "Аналитаика";
                btnEditPr.Text = "Проекты";
                //btnAddPr.Text = "Создать проект";
                btnAccount.Text = "Аккаунт";
                btnStudio.Text = "Студия";
                btnCatalog.Text = "Каталог";
                btnHome.Text = "Домой";
                btnSettings.Text = "Настройки";
                btnExit.Text = "Выход";

                panelMenu.Width = 220;
            }
        }

        private void btnHideMenu_Click(object sender, EventArgs e)
        {
            VisibleMenu();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FormDevBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Дизайн

        Settings Settings = new Settings();

        private void FormDevBoard_Load(object sender, EventArgs e)
        {
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            Settings.getSettings();
            lblTime.Visible = lblMDY.Visible = Settings.Clock;


            panelMenu.BackColor = btnExit.BackColor = 
                panelFormManage.BackColor = panelDownSepar.BackColor = Settings.Ucolor;

            panelChildForm.BackColor = btnHideMenu.BackColor = btnExit.BackColor = Settings.Dcolor;

            btnHideMenu.ForeColor = btnAnalytics.ForeColor = btnEditPr.ForeColor =
                btnAccount.ForeColor = btnStudio.ForeColor = btnCatalog.ForeColor =
                btnHome.ForeColor = btnSettings.ForeColor = btnExit.ForeColor =
                lblTime.ForeColor = lblMDY.ForeColor = Settings.Fcolor;

            btnHideMenu.IconColor = btnAnalytics.IconColor = btnEditPr.IconColor =
                btnAccount.IconColor = btnStudio.IconColor = btnCatalog.IconColor =
                btnHome.IconColor = btnSettings.IconColor = btnExit.IconColor = Settings.Fcolor;

            if (Settings.ChildStart != "") OpenDefault(Settings.ChildStart);
            if (Settings.HidePanel) btnHideMenu_Click(sender, e);

            hasStudio = CheckStudio(idCur);
        }

        private IconButton currentButton;
        private Panel leftBorderBtn;
        int tempIndex;
        private Random random = new Random();
        private Color SelectThemeColor()
        {
            if(Settings.ChildColor != "")
                return ColorTranslator.FromHtml(Settings.ChildColor);

            int index = random.Next(Settings.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(Settings.ColorList.Count);
            }
            tempIndex = index;
            string color = Settings.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            DisableButton();
            if (senderBtn == null) return;

            currentButton = (IconButton)senderBtn;
            currentButton.BackColor = Color.FromArgb(14, 52, 65);
            panelFormManage.BackColor = color;
            panelDownSepar.BackColor = color;
            currentButton.ForeColor = color;
            currentButton.IconColor = color;

            leftBorderBtn.BackColor = color;
            leftBorderBtn.Location = new Point(0, currentButton.Location.Y);
            leftBorderBtn.Show();
            leftBorderBtn.BringToFront();
        }

        private void DisableButton()
        {
            if (currentButton == null) return;

            currentButton.BackColor = Settings.Ucolor;
            panelFormManage.BackColor = Settings.Ucolor;
            panelDownSepar.BackColor = Settings.Ucolor;

            currentButton.ForeColor = Settings.Fcolor;
            currentButton.IconColor = Settings.Fcolor;
            leftBorderBtn.Hide();
        }

        #endregion

        #region Код
        void OpenDefault(string name)
        {
            if (name == "Аналитика") btnAnalytics_Click(btnAnalytics, new EventArgs());
            if (name == "Проекты") btnEditPr_Click(btnEditPr, new EventArgs());
            if (name == "Аккаунт") btnAccount_Click(btnAccount, new EventArgs());
            if (name == "Студия") btnStudio_Click(btnStudio, new EventArgs());
            if (name == "Каталог") btnCatalog_Click(btnCatalog, new EventArgs());
        }

        public static Color color;
        public int idCur, idStudCur;
        public bool hasStudio;

        private Form activeForm;
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();

            color = SelectThemeColor();
            ActivateButton(btnSender, color);
            panelDownSepar.Visible = panelFormManage.Visible = true;

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            Text = "GameSTARTER - " + childForm.Text;
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            if (!hasStudio)
            {
                if (MessageBox.Show("Для начала вам необходимо создать студию. Перейти к созданию?",
                    "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No) return;

                btnStudio_Click(sender as Button, e);
            }
            else
            {
                FormAnalytics fra = new FormAnalytics();
                fra.id_studio = idStudCur;
                fra.id_user = idCur;
                OpenChildForm(fra, sender);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти из аккаунта? " +
                "\r\nПри повторном входе потребуется снова ввести пароль", "Внимание",
                MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.No) return;

            Registry.CurrentUser.DeleteSubKeyTree("GameSTARTER");

            Application.Restart();
        }

        bool CheckStudio(int id)
        {
            bool flag = true;
            string txtquery = @"select id_studio from Users where id_user = " + id;

            SqlConnection con = new SqlConnection(Form1.txtcon);

            con.Open();
            SqlCommand query1 = new SqlCommand(txtquery, con);
            SqlDataReader read = query1.ExecuteReader();
            read.Read();

            try
            {
                if (read["id_studio"] == null) flag = true;
                else idStudCur = Convert.ToInt32(read["id_studio"]);
                con.Close();
            }
            catch { flag = false; }
            
            return flag;
        }

        private void btnEditPr_Click(object sender, EventArgs e)
        {
            if (!hasStudio)
            {
                if (MessageBox.Show("Для начала вам необходимо создать студию. Перейти к созданию?",
                    "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No) return;

                btnStudio_Click(sender as Button, e);
            }
            else
            {
                FormMyPr frmp = new FormMyPr();
                frmp.id_studio = idStudCur.ToString();
                OpenChildForm(frmp, sender);
            }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            sender = btnAccount;
            FormAccount fra = new FormAccount();
            fra.usersBindingSource.Filter = "id_user = " + idCur;
            OpenChildForm(fra, sender);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSettings(), sender);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (activeForm == null) return;
            if (MessageBox.Show("Все несохранённые данные исчезнут.\r\nВыйти в панель управления?", 
                "Внимание", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No) return;

            if (panelDownSepar.Visible == false)
                panelDownSepar.Visible = panelFormManage.Visible = true;

            DisableButton();
            activeForm.Close();
            Text = "GameSTARTER - Панель управления";
        }

        private void btnStudio_Click(object sender, EventArgs e)
        {
            FormStudioManage frsm = new FormStudioManage();
            frsm.idCur = idCur;
            OpenChildForm(frsm, sender);
        }

        private void btnCatalog_Click(object sender, EventArgs e)
        {
            FormCatalog frc = new FormCatalog();
            frc.panelHeader.Hide();
            frc.idCur = idCur;

            OpenChildForm(frc, sender);
            panelDownSepar.Visible = panelFormManage.Visible = false;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        
        private void panelFormManage_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, new IntPtr(HT_CAPTION), IntPtr.Zero);
            }
        }
        #endregion
    }
}
