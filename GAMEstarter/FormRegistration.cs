using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;

namespace GAMEstarter
{
    public partial class FormRegistration : Form
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

        public FormRegistration()
        {
            InitializeComponent();
            
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameStartDBDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.gameStartDBDataSet.Users);
            roleLabel1.Text = "0";

            ToolTip t = new ToolTip();
            t.SetToolTip(lblRules, Password.rules);

            usersBindingSource.AddNew();
            mtbxLink.Hide();
        }
        
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void FormRegistration_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, new IntPtr(HT_CAPTION), IntPtr.Zero);
            }
        }

        private void materialCheckbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!mcbxShowPass.Checked)
            {
                mtbxPass.Password = true;
                mtbxRepPass.Password = true;
            }
            else
            {
                mtbxPass.Password = false;
                mtbxRepPass.Password = false;
            }
        }

        private void mbtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mtbxPass_TextChanged(object sender, EventArgs e)
        {
            mbtnReg.Enabled = mtbxLogin.Text != "" && mtbxMail.Text != ""
                && mtbxPass.Text != "" && mtbxRepPass.Text != "";

            mpbCorrectPass.Value = Password.checkPass(mtbxPass.Text);
        }

        bool checkMail(string mail)
        {
            if (mail == "") return false;
            int count = 0;

            for (int i = 0; i <= mail.Length - 1; i++)
            {
                if (mail[i] == '@') count++;
            }

            if (count != 1
                || mail.IndexOf('@') == 0
                || mail.IndexOf('@') == mail.Length - 1) return false;

            return true;
        }

        private void mbtnReg_Click(object sender, EventArgs e)
        {
            if (!msDeveloper.Checked) roleLabel1.Text = "0";
            else
            {
                roleLabel1.Text = "1";
                if (mtbxLink.Text != "")
                    if (mtbxLink.Text.IndexOf("private/link/ids=") != -1)
                    {
                        string owner = mtbxLink.Text.Replace("private/link/ids=", "");
                        id_studioLabel1.Text = owner;
                    }
            }

            if (mtbxPass.Text != mtbxRepPass.Text)
            {
                MaterialMessageBox.Show("Пароли не совпадают","Внимание",
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            if (!checkMail(mtbxMail.Text))
            {
                MaterialMessageBox.Show("Такой почты не существует.\r\nПожалуйста, проверьте правильность написания", 
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            usersBindingSource.EndEdit();
            usersTableAdapter.Update(gameStartDBDataSet.Users);

            MaterialMessageBox.Show("Регистрация успешно завершена",
                "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void msDeveloper_CheckedChanged(object sender, EventArgs e)
        {
            if (msDeveloper.Checked) mtbxLink.Show();
            else mtbxLink.Hide();
        }
    }
}
