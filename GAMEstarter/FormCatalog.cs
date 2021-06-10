using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAMEstarter
{
    public partial class FormCatalog : Form
    {
        #region Управление формой

        private void FormCatalog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (panelHeader.Visible) Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти из аккаунта? " +
                "\r\nПри повторном входе потребуется снова ввести пароль", "Внимание",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No) return;

            Registry.CurrentUser.DeleteSubKeyTree("GameSTARTER");

            Application.Restart();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, new IntPtr(HT_CAPTION), IntPtr.Zero);
            }
        }

        #endregion

        SqlConnection con = new SqlConnection(Form1.txtcon);
        public int idCur = -1;

        public FormCatalog()
        {
            InitializeComponent();
        }

        public struct game
        {
            public int id;
            public string name;
            public Image Image;
            public string desc;
        }

        List<game> lstGamesTop = new List<game>();
        List<game> lstGamesSoon = new List<game>();

        private void FormCatalog_Load(object sender, EventArgs e)
        {
            Application.DoEvents();
            if (!panelHeader.Visible)
            {
                //panelFilters.Visible = panel1.Visible = false;
                panelChildForm.Location = new Point(10, 53);
                panelChildForm.Size = new Size(1147, 900);
            }
            else LoadName();

            LoadListsTop();
            LoadListSoon();
        }

        #region Профиль пользователя
        void LoadName()
        {
            con.Open();
            string txtquery = @"select fam + ' (' + nickname + ') ' + user_name as fio, photo 
from users where id_user = " + idCur;

            SqlCommand query1 = new SqlCommand(txtquery, con);
            SqlDataReader read = query1.ExecuteReader();

            read.Read();

            byte[] bytes;
            try
            {
                bytes = (byte[])read["photo"];
                if (bytes != null)
                    pbPhoto.Image = byteArrayToImage(bytes);
            }
            catch { }

            string txtname = read["fio"].ToString();
            txtname = txtname.Replace(" () ", " ");
            if (txtname.Length > 15) txtname = txtname.Remove(15, txtname.Length - 15) + "...";
            lblName.Text = txtname;

            con.Close();
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            FormAccount fra = new FormAccount();
            fra.usersBindingSource.Filter = "id_user = " + idCur;
            fra.ShowDialog();
            if (panelHeader.Visible) LoadName();
        }
        #endregion

        void LoadListsTop()
        {
            SqlConnection con = new SqlConnection(Form1.txtcon);
            string txtquery = @"select top 3 g.id_game, g.game_name, g.[description], g.image_max, 
(select count(*) from Vievs where Vievs.id_game = g.id_game) as vievcount
from games g
where g.visible = 'true'
order by vievcount desc";

            con.Open();
            SqlCommand query1 = new SqlCommand(txtquery, con);
            SqlDataReader read = query1.ExecuteReader();

            byte[] bytes;
            game g;
            while (read.Read())
            {
                g.id = (int)read["id_game"];
                g.name = read["game_name"].ToString();
                g.desc = read["description"].ToString();

                bytes = (byte[])read["image_max"];
                if (bytes != null)
                    g.Image = byteArrayToImage(bytes);
                else g.Image = null;

                lstGamesTop.Add(g);
            }
            LoadCardTop(0);

            con.Close();
        }

        void LoadCardTop(int num)
        {
            pbGameIcon.Image = lstGamesTop[num].Image;
            lblGameName.Text = lstGamesTop[num].name;
            lblDesc.Text = "Об этой игре:\r\n" + lstGamesTop[num].desc;
        }

        void LoadListSoon()
        {
            SqlConnection con = new SqlConnection(Form1.txtcon);
            string txtquery = @"select top 4 g.id_game, g.game_name, g.description, g.image_min, g.data_exit
from Games g
where g.visible = 'true'
order by g.data_exit asc";

            con.Open();
            SqlCommand query1 = new SqlCommand(txtquery, con);
            SqlDataReader read = query1.ExecuteReader();

            byte[] bytes;
            game g;
            while (read.Read())
            {
                g.id = (int)read["id_game"];
                g.name = read["game_name"].ToString();
                g.desc = read["description"].ToString();

                bytes = (byte[])read["image_min"];
                if (bytes != null)
                    g.Image = byteArrayToImage(bytes);
                else g.Image = null;

                lstGamesSoon.Add(g);
            }

            pbSoon1.Image = lstGamesSoon[0].Image;
            lblSoon1.Text = lstGamesSoon[0].name;
            pbSoon2.Image = lstGamesSoon[1].Image;
            lblSoon2.Text = lstGamesSoon[1].name;
            pbSoon3.Image = lstGamesSoon[2].Image;
            lblSoon3.Text = lstGamesSoon[2].name;
            pbSoon4.Image = lstGamesSoon[3].Image;
            lblSoon4.Text = lstGamesSoon[3].name;

            con.Close();
        }

        int page = 0;
        private void pbPrev_Click(object sender, EventArgs e)
        {
            if (page == 0) return;
            page--;
            LoadCardTop(page);
        }

        private void pbNext_Click(object sender, EventArgs e)
        {
            if (page == lstGamesTop.Count - 1) return;
            page++;
            LoadCardTop(page);
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
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void pbGameIcon_Click(object sender, EventArgs e)
        {
            panelHead.Visible = panelSoon.Visible = false;
            FormRevGame frg = new FormRevGame();
            frg.idGame = lstGamesTop[page].id;
            OpenChildForm(frg);
            btnBack.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            activeForm.Close();
            panelHead.Visible = panelSoon.Visible = true;
            btnBack.Hide();
        }
    }
}
