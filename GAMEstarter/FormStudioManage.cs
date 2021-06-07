using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAMEstarter
{
    public partial class FormStudioManage : Form
    {
        public int idCur = -1, idStudcur = -1;

        public FormStudioManage()
        {
            InitializeComponent();
        }

        bool newDev = false;
        private void FormStudioManage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameStartDBDataSet.Messages' table. You can move, or remove it, as needed.
            this.messagesTableAdapter.Fill(this.gameStartDBDataSet.Messages);
            // TODO: This line of code loads data into the 'gameStartDBDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.gameStartDBDataSet.Users);
            // TODO: This line of code loads data into the 'gameStartDBDataSet.Studios' table. You can move, or remove it, as needed.
            this.studiosTableAdapter.Fill(this.gameStartDBDataSet.Studios);


            usersBindingSource.Filter = "id_user = " + idCur;
            if (lblIdOwner.Text != idCur.ToString()) panelMessages.Hide();

            newDev = id_studioLabel2.Text == "";
            if (newDev)
            {
                logoPictureBox.Visible = studio_nameLabel1.Visible = false;
            }
            else
            {
                idStudcur = Convert.ToInt32(id_studioLabel2.Text);

                studiosBindingSource.Filter = 
                messagesBindingSource.Filter = "id_studio = " + idStudcur;
                LoadWorkers();
            }

            string txtCopy = "Нажмите\r\nчтобы скопировать\r\nссылку-приглашение";
            ToolTip t2 = new ToolTip();
            t2.SetToolTip(studio_nameLabel1, txtCopy);
        }

        void LoadWorkers()
        {
            SqlConnection con = new SqlConnection(Form1.txtcon);
            string txtquery = @"select id_user, fam + ' ' + user_name as fio, 
photo, mail from Users where id_studio = " + idStudcur;

            con.Open();
            SqlCommand query1 = new SqlCommand(txtquery, con);
            SqlDataReader read = query1.ExecuteReader();
            while (read.Read())
            {
                if (read["id_user"].ToString() == idCur.ToString()) continue;

                string txtfio = read["fio"] + "\r\n" + read["mail"];

                byte[] bytes;
                bytes = (byte[])read["photo"];
                if (bytes != null)
                    dgvWorkers.Rows.Add(read["id_user"], byteArrayToImage(bytes), txtfio);
                else
                    dgvWorkers.Rows.Add(read["id_user"], null, txtfio);
            }
            con.Close();
        }

        private void studiosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studiosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gameStartDBDataSet);

        }

        private void btnSetS_Click(object sender, EventArgs e)
        {
            if (!newDev && idCur.ToString() != lblIdOwner.Text)
            {
                MessageBox.Show("Вы не владелец этой студии", "Внимание!");
                return;
            }

            if (btnSetS.Text == "Создать/изменить студию")
            {
                if (newDev)
                {
                    studiosBindingSource.AddNew();
                    lblIdOwner.Text = idStudcur.ToString();
                    logoPictureBox.Visible = studio_nameLabel1.Visible = true;
                }

                btnSetS.IconChar = IconChar.Save;
                btnSetS.Text = "Сохранить изменения";
                panelSetS.Show();
            }
            else
            {
                if (studio_nameTextBox.Text == "")
                {
                    MessageBox.Show("Название студии не может быть пустым", "Внимание!");
                    return;
                }

                lblIdOwner.Text = idCur.ToString();

                studiosBindingSource.Filter =
                messagesBindingSource.Filter = "id_studio = " + idStudcur;

                studiosBindingSource.EndEdit();
                studiosTableAdapter.Update(gameStartDBDataSet.Studios);

                if (newDev)
                {
                    id_studioLabel2.Text = id_studioLabel1.Text;
                    idStudcur = Convert.ToInt32(id_studioLabel1.Text);

                    usersBindingSource.EndEdit();
                    usersTableAdapter.Update(gameStartDBDataSet.Users);

                    newDev = false; 
                    panelMessages.Show();
                }

                MessageBox.Show("Студия успешно изменена",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnSetS.IconChar = IconChar.BlackTie;
                btnSetS.Text = "Создать/изменить студию";
                panelSetS.Hide();
                LoadWorkers();
            }
        }

        private void studio_nameLabel1_Click(object sender, EventArgs e)
        {
            string link = "private/link/ids=" + idStudcur.ToString();
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

        private void btnChangePhotoS_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            logoPictureBox.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void dgvWorkers_SelectionChanged(object sender, EventArgs e)
        {
            usersBindingSource.Filter = "id_user = " + dgvWorkers.CurrentRow.Cells[0].Value;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            messagesBindingSource.AddNew();
            id_studioLabel3.Text = idStudcur.ToString();
            messageLabel1.Text = tbxMessage.Text;

            messagesBindingSource.EndEdit();
            messagesTableAdapter.Update(gameStartDBDataSet.Messages);

            messageLabel1.Text = tbxMessage.Text = "";
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
    }
}
