using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using FontAwesome.Sharp;
using MaterialSkin;

namespace GAMEstarter
{
    public partial class FormAccount : Form
    {
        public FormAccount()
        {
            InitializeComponent();
            Initiate();
        }

        private void FormAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameStartDBDataSet.Games' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.gameStartDBDataSet.Users);

            nicknameLabel1.ForeColor = mailLabel1.ForeColor = lblFio.ForeColor = FormDevBoard.color;
            panelSeparatorA.BackColor = lblRules.BackColor = FormDevBoard.color;


            panelSetA.Hide();

            ToolTip t = new ToolTip();
            t.SetToolTip(lblRules, Password.rules);
        }

        void Initiate()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue700,
                Primary.Blue700, Primary.Blue700, Accent.Blue700, TextShade.WHITE);
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
                || mail.IndexOf('@') == mail.Length - 1)
                return false;

            return true;
        }

        private void btnSetA_Click(object sender, EventArgs e)
        {
            if (btnSetA.Text == "Редактировать профиль")
            {
                btnSetA.IconChar = IconChar.Save;
                btnSetA.Text = "Сохранить изменения";
                panelSetA.Show();
            }
            else
            {
                if (passwordTextBox.Text != tbxRepPass.Text)
                {
                    MessageBox.Show("Пароли не совпадают", "Внимание",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!checkMail(mailTextBox.Text))
                {
                    MessageBox.Show("Такой почты не существует.\r\nПожалуйста, проверьте правильность написания",
                        "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Профиль успешно изменён",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnSetA.IconChar = IconChar.UserAlt;
                btnSetA.Text = "Редактировать профиль";
                panelSetA.Hide();
            }
        }

        private void ChangePhoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;

            photoPictureBox.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            btnSetA.Enabled = loginTextBox.Text != "" && mailTextBox.Text != ""
                && passwordTextBox.Text != "" && tbxRepPass.Text != "";

            mpbCorrectPass.Value = Password.checkPass(passwordTextBox.Text);
            if (tbxRepPass.Text == "") tbxRepPass.BackColor = Color.Red;
            else tbxRepPass.BackColor = SystemColors.Window;
        }

        private void pbShowPass_Click(object sender, EventArgs e)
        {
            if(pbShowPass.IconChar == IconChar.Eye)
            {
                pbShowPass.IconChar = IconChar.EyeSlash;
                passwordTextBox.UseSystemPasswordChar = tbxRepPass.UseSystemPasswordChar = false;
            }
            else
            {
                pbShowPass.IconChar = IconChar.Eye;
                passwordTextBox.UseSystemPasswordChar = tbxRepPass.UseSystemPasswordChar = true;
            }
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

        private void btnOpenCard_Click(object sender, EventArgs e)
        {
            if(btnOpenCard.Text == "Управление картами")
            {
                btnOpenCard.Text = "Закрыть панель";

                FormCardHolder frch = new FormCardHolder();
                string id = usersBindingSource.Filter.Replace("id_user = ", "");
                frch.id_user = Convert.ToInt32(id);
                OpenChildForm(frch);
            }
            else
            {
                activeForm.Close();
                btnOpenCard.Text = "Управление картами";
            }

        }
    }
}
