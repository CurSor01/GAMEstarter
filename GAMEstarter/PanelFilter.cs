using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAMEstarter
{
    public partial class PanelFilter : UserControl
    {
        public string search;
        public string genre;
        public PanelFilter()
        {
            InitializeComponent();
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
            "Обучение", "Фитнес", "Кликер"
        };

        List<string> lstId = new List<string>();

        void LoadCards()
        {
            panelCards.Controls.Clear();
            lstId.Clear();
            SqlConnection con = new SqlConnection(Form1.txtcon);
            string txtquery = "select id_game from Games where visible = 'true' ";

            if (genre != "")
                txtquery += genre;
            if (search != "")
                txtquery += search;
            con.Open();

            SqlCommand query1 = new SqlCommand(txtquery, con);
            SqlDataReader read = query1.ExecuteReader();
            while (read.Read())
            {
                lstId.Add(read["id_game"].ToString());
            }

            con.Close();

            int curY = 10;
            for (int i = lstId.Count - 1; i >= 0; i--)
            {
                MaterialCard card = new MaterialCard();
                card.Size = new Size(750, 150);
                card.Location = new Point(3, curY);
                panelCards.Controls.Add(card);

                CardAbout crd = new CardAbout(lstId[i]) { flag = true };
                crd.btnDel.Visible = false;

                crd.btnEdit.Tag = lstId[i];
                crd.btnEdit.Text = "Подробнее";
                crd.btnEdit.IconChar = 
                    FontAwesome.Sharp.IconChar.ThList;
                crd.btnEdit.Width = 400;
                crd.btnEdit.Click += BtnEdit_Click;

                card.Controls.Add(crd);
                curY += 160;
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            cardGenre.Visible = panelCards.Visible = false;

            FormRevGame frg = new FormRevGame();
            frg.idGame = Convert.ToInt32((sender as Button).Tag);
            OpenChildForm(frg);
        }

        private Form activeForm;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Controls.Add(childForm);
            Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void PanelFilter_Load(object sender, EventArgs e)
        {
            foreach (string genre in lstgenre)
                dgvGenres.Rows.Add(genre);
            dgvGenres.ClearSelection();
            LoadCards();
        }

        private void dgvGenres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            genre = $"and genre like '{dgvGenres.CurrentRow.Cells[0].Value}'";

            lblClearSelection.Show();
            LoadCards();
        }

        private void lblClearSelection_Click(object sender, EventArgs e)
        {
            genre = "";
            dgvGenres.ClearSelection();

            lblClearSelection.Hide();
            LoadCards();
        }
    }
}
