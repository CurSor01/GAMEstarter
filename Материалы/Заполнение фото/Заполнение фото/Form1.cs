using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Заполнение_фото
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameStartDBDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.gameStartDBDataSet.Users);
        }

        private void btnLoad_Click1(object sender, EventArgs e)
        {
            Activate();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();
                for (int i = 0; i <= usersBindingSource.Count - 1; i++)
                {
                    usersBindingSource.Position = i;
                    try
                    {
                        photoPictureBox.Image = Image.FromFile(Path.GetDirectoryName(openFileDialog1.FileName) + "\\" + id_userTextBox.Text + ".jpg");
                    }
                    catch { }
                }
                usersBindingSource.Position = 0;
            }
        }

        private void btnSave_Click1(object sender, EventArgs e)
        {
            try
            {
                usersBindingSource.EndEdit();
                usersTableAdapter.Update(gameStartDBDataSet.Users);
                MessageBox.Show("Сохранено");
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gameStartDBDataSet);

        }
    }
}
