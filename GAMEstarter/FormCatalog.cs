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
        }

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
    }
}
