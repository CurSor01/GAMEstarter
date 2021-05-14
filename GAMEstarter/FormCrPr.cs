using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FontAwesome.Sharp;

namespace GAMEstarter
{
    public partial class FormCrPr : Form
    {
        public FormCrPr()
        {
            InitializeComponent();
        }

        public static string name = "";
        void LoadName()
        {
            FormNameProject frnp = new FormNameProject();
            frnp.ShowDialog();
            if (name == "") name = "Пустой проект";
            Text = "Создать новый проект: " + name;

            gamesBindingSource.AddNew();
            codenameTextBox.Text = name;
            m_haveLabel1.Text = "0";
            m_have_nowLabel1.Text = "0";
            visibleLabel1.Text = "False";
            id_studioLabel1.Text = Form1.idUser;
        }

        List<string> lstgenre = new List<string>()
        {
            "Action", "Action-RPG", "Платформер",
            "Шутер", "Файтинг", "Beat-em Up",
            "Сетлс-экшен", "Выживание",
            "Ритм-игра", "Action-Adventure",
            "Survivat-Horror", "Метроидвания",
            "Приключения (квесты)", "Текстовые квесты",
            "Графические квесты", "Визуальная новелла",
            "Интерактивние кино", "3D в реальном времени",
            "Ролевые игры", "MMORPG",
            "Rougelike", "Тактические RPG",
            "RPG с открытым миром", "Партийные RPG",
            "JRPG", "Симуляторы",
            "Стратегии", "Стратегии в реальнм времени",
            "MOBA", "Tower Defendse",
            "Пошаговые стратегии", "Спорт", "Гонки",
            "Головоломки", "Настольные",
            "Логические", "С эелементами программирования",
            "Обучение", "Фитнес", "Кликер", "Другое"
        };

        private void FormCrPr_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameStartDBDataSet.Games' table. You can move, or remove it, as needed.
            this.gamesTableAdapter.Fill(this.gameStartDBDataSet.Games);

            if (gamesBindingSource.Filter == null) LoadName();
            else
            {
                Text = codenameTextBox.Text;
                //btnPlace.Visible = visibleLabel1.Text != "True";
            }

            if (visibleLabel1.Text == "True")
            {
                btnPlace.Text = "Сохранить изменения";
                btnSave.Hide();
            }

            try
            {
                DateTime dt = Convert.ToDateTime(data_exitLabel1.Text);
                if (dt < DateTime.Now)
                    if (MessageBox.Show("Вы собираетесь редактировать проект, который уже вышел. Продолжить?",
                        "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) Close();
            }catch { return; }

            btnPlace.BackColor = FormDevBoard.color;
            for(int i = 0; i <= lstgenre.Count - 1; i++)
                genreComboBox.Items.Add(lstgenre[i]);

            BackColor = FormDevBoard.color;
        }

        private void m_needTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
            if (e.KeyChar == (char)Keys.Back) e.Handled = false;
        }

        public string id_studio;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (codenameTextBox.Text == ""
                || game_nameTextBox.Text == ""
                || m_needTextBox.Text == ""
                || genreComboBox.Text == "") return;

            if (date_createLabel1.Text == "")
                date_createLabel1.Text = DateTime.Now.ToShortDateString();

            if (id_studioLabel1.Text == "")
                id_studioLabel1.Text = id_studio;

            gamesBindingSource.EndEdit();
            gamesTableAdapter.Update(gameStartDBDataSet.Games);

            if (activeForm != null)
                activeForm.Close();

            DisableButton();
        }

        private void btnPlace_Click(object sender, EventArgs e)
        {
            if (codenameTextBox.Text == ""
                || game_nameTextBox.Text == ""
                || m_needTextBox.Text == "") return;

            if (date_createLabel1.Text == "")
                date_createLabel1.Text = DateTime.Now.ToShortDateString();
            
            if (id_studioLabel1.Text == "")
                id_studioLabel1.Text = id_studio;
            visibleLabel1.Text = "True";

            gamesBindingSource.EndEdit();
            gamesTableAdapter.Update(gameStartDBDataSet.Games);

            if (activeForm != null)
            {
                activeForm.Close();
            }

            DisableButton();
            btnSave.Hide();
            btnPlace.Text = btnPlace.Text.Replace("*", "");
        }

        #region Изменение кнопки и открытие формы
        private Form activeForm;
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();

            ActivateButton(btnSender, FormDevBoard.color);

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private IconButton currentButton;
        private void ActivateButton(object senderBtn, Color color)
        {
            DisableButton();
            if (senderBtn == null) return;
            if (btnPlace.Text.IndexOf("*") == -1)
                btnPlace.Text += "*";
            
            currentButton = (IconButton)senderBtn;
            currentButton.BackColor = Color.FromArgb(14, 52, 65);
            currentButton.ForeColor = color;
            currentButton.IconColor = color;
        }

        private void DisableButton()
        {
            if (currentButton == null) return;

            currentButton.BackColor = SystemColors.InactiveCaption;
            currentButton.ForeColor = SystemColors.ControlText;
            currentButton.IconColor = Color.Black;
        }
        #endregion
        
        private void btnScreenshots_Click(object sender, EventArgs e)
        {
            if (id_gameLabel2.Text == "-1")
            {
                MessageBox.Show("Для продолжения сохраните проект",
                    "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FormScreenshots frsc = new FormScreenshots();
            frsc.id_game = id_gameLabel2.Text;
            OpenChildForm(frsc, sender);
        }

        private void btndateExit_Click(object sender, EventArgs e)
        {
            if (id_gameLabel2.Text == "-1")
            {
                MessageBox.Show("Для продолжения сохраните проект",
                    "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FormdataExit frde = new FormdataExit();
            frde.id_game = id_gameLabel2.Text;
            OpenChildForm(frde, sender);
        }

        private void btnIcons_Click(object sender, EventArgs e)
        {
            if (id_gameLabel2.Text == "-1")
            {
                MessageBox.Show("Для продолжения сохраните проект",
                    "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FormIcons fri = new FormIcons();
            fri.id_game = id_gameLabel2.Text;
            OpenChildForm(fri,sender);
        }

        private void btnTrailer_Click(object sender, EventArgs e)
        {
            if (id_gameLabel2.Text == "-1")
            {
                MessageBox.Show("Для продолжения сохраните проект",
                    "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (activeForm != null) activeForm.Close();
            FormTrailer frt = new FormTrailer();
            frt.id_game = id_gameLabel2.Text;
            ActivateButton(sender, FormDevBoard.color);
            frt.ShowDialog();
            DisableButton();
        }
    }
}
