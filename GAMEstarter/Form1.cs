using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace GAMEstarter
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public static string txtcon = @"Data Source=REDGALAXYBOSS\SQLEXPRESS;Initial Catalog=GameStartDB;Integrated Security=True";

        private void frmRegister_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, new IntPtr(HT_CAPTION), IntPtr.Zero);
            }
        }

        public Form1()
        {
            InitializeComponent();
            Initiate();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }

        void Initiate()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue700,
                Primary.Blue700, Primary.Blue700, Accent.Blue700, TextShade.WHITE);
        }

        private void mcbxshowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (!mcbxShowPass.Checked) mtbxPass.Password = true;
            else mtbxPass.Password = false;
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bsUsers.EndEdit();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameStartDBDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.gameStartDBDataSet.Users);
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblReg_Click(object sender, EventArgs e)
        {
            FormRegistration frmReg = new FormRegistration();
            frmReg.usersBindingSource.AddNew();

            Hide();
            frmReg.ShowDialog();
            Show();

            usersTableAdapter.Fill(gameStartDBDataSet.Users);
        }

        public static string idUser = "";
        private void mbtnLogin_Click(object sender, EventArgs e)
        {
            if (mtbxLogin.Text == "" || mtbxPass.Text == "") return;
            

            string txtfilter = String.Format("login = '{0}' and password = '{1}'",
                mtbxLogin.Text, mtbxPass.Text);

            bsUsers.Filter = txtfilter;

            if (bsUsers.Count == 0)
            {
                MaterialMessageBox.Show("Нет пользователя с указанным логином, и паролем!",
                    "Внимание!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            if (mcbxRemember.Checked)
            {
                RegistryKey currentUserKey = Registry.CurrentUser;
                RegistryKey key = currentUserKey.CreateSubKey("GameSTARTER");
                key.SetValue("login", mtbxLogin.Text);
                key.SetValue("password", mtbxPass.Text);
                key.Close();
            }
            idUser = id_userLabel.Text;
            Hide();
            if (roleLabel1.Text == "0")
            {
                FormCatalog frmCat = new FormCatalog();
                frmCat.ShowDialog();
            }
            else
            {
                FormDevBoard frmDev = new FormDevBoard();
                frmDev.idCur = Convert.ToInt32(id_userLabel.Text);
                frmDev.ShowDialog();
            }
            Initiate();
            try
            {
                Show();
            }
            catch { }

            mtbxLogin.Clear(); mtbxPass.Clear();
            
            mtbxLogin.Focus();
            bsUsers.Filter = null;
            this.usersTableAdapter.Fill(gameStartDBDataSet.Users);
        }
    }
}
