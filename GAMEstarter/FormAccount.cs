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

        bool newDev = false;
        private void FormAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameStartDBDataSet.Games' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.gameStartDBDataSet.Users);
            this.studiosTableAdapter.Fill(this.gameStartDBDataSet.Studios);

            nicknameLabel1.ForeColor = mailLabel1.ForeColor = lblFio.ForeColor = FormDevBoard.color;
            panelSeparatorA.BackColor = lblRules.BackColor = FormDevBoard.color;

            newDev = lblIdStudio.Text == "";
            if (roleLabel1.Text != "0")
            {
                if (!newDev) studiosBindingSource.Filter = "id_studio = " + lblIdStudio.Text;
                else logoPictureBox.Visible = studio_nameLabel1.Visible = false;
            }
            else
            {
                materialCard2.Visible = btnSetS.Visible = id_studioTextBox.Visible = lblCod.Visible = false;
            }

            panelSetA.Hide(); panelSetS.Hide();
            string txtCopy = "Нажмите\r\nчтобы скопировать\r\nссылку-приглашение";

            ToolTip t = new ToolTip();
            t.SetToolTip(lblRules, Password.rules);
            ToolTip t2 = new ToolTip();
            t.SetToolTip(studio_nameLabel1, txtCopy);
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

                string studid = id_studioTextBox.Text;
                try
                {
                    usersBindingSource.EndEdit();
                    usersTableAdapter.Update(gameStartDBDataSet.Users);
                }
                catch
                {
                    MessageBox.Show("Студии с таким кодом не существует",
                        "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    id_studioTextBox.Text = studid;
                    return;
                }

                MessageBox.Show("Профиль успешно изменён",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if(lblIdStudio.Text != "") studiosBindingSource.Filter = "id_studio = " + lblIdStudio.Text;
                btnSetA.IconChar = IconChar.UserAlt;
                btnSetA.Text = "Редактировать профиль";
                panelSetA.Hide();
            }
        }

        private void ChangePhoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;

            if (sender as Button == btnChangePhotoA)
                photoPictureBox.Image = Image.FromFile(openFileDialog1.FileName);
            else logoPictureBox.Image = Image.FromFile(openFileDialog1.FileName);
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

        private void btnSetS_Click(object sender, EventArgs e)
        {

            if (!newDev && lblIdUsr.Text != lblIdOwner.Text)
            {
                MessageBox.Show("Вы не владелец этой студии","Внимание!");
                return;
            }

            if (btnSetS.Text == "Создать/изменить студию")
            {
                if (newDev)
                {
                    studiosBindingSource.AddNew();
                    lblIdOwner.Text = lblIdStudio.Text;
                    logoPictureBox.Visible = studio_nameLabel1.Visible = true;
                }

                btnSetS.IconChar = IconChar.Save;
                btnSetS.Text = "Сохранить изменения";
                panelSetS.Show();
            }
            else
            {
                if(studio_nameTextBox.Text == "")
                {
                    MessageBox.Show("Название студии не может быть пустым","Внимание!");
                    return;
                }

                lblIdOwner.Text = lblIdUsr.Text;


                studiosBindingSource.EndEdit();
                studiosTableAdapter.Update(gameStartDBDataSet.Studios);
                
                if (newDev)
                {
                    lblIdStudio.Text = lblIdCurStudio.Text;

                    usersBindingSource.EndEdit();
                    usersTableAdapter.Update(gameStartDBDataSet.Users);
                    newDev = false;
                }

                MessageBox.Show("Студия успешно изменена",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                btnSetS.IconChar = IconChar.BlackTie;
                btnSetS.Text = "Создать/изменить студию";
                panelSetS.Hide();
            }
        }

        private void studio_nameLabel1_Click(object sender, EventArgs e)
        {
            string link = "private/link/ids=" + lblIdStudio.Text;
            Clipboard.SetText(link);
            studio_nameLabel1.BackColor = Color.LightGreen;
            studio_nameLabel1.Text = "Ссылка скопирована";
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            studio_nameLabel1.BackColor = Color.White;
            this.studiosTableAdapter.Fill(this.gameStartDBDataSet.Studios);
            timer1.Enabled = false;
        }
    }
}
