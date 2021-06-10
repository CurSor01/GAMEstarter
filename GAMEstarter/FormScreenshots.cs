using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAMEstarter
{
    public partial class FormScreenshots : Form
    {
        public FormScreenshots()
        {
            InitializeComponent();
        }

        public string id_game;
        private void btnAddSavePhoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                for(int i = 0; i<= openFileDialog1.FileNames.Length - 1; i++)
                {
                    photosBindingSource.AddNew();
                    imagePictureBox.Image = Image.FromFile(openFileDialog1.FileNames[i]);
                    name_imageLabel1.Text = openFileDialog1.SafeFileNames[i];
                    id_gameLabel1.Text = id_game;
                }

                photosBindingSource.EndEdit();
                photosTableAdapter.Update(gameStartDBDataSet.Photos);
            }
        }

        private void btndelPhoto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить выбранные скриншоты?\r\nЭто действие необратимо",
                "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No) return;

            for(int i = dgvPhotoNames.RowCount - 1; i >= 0; i--)
            {
                if (dgvPhotoNames.Rows[i].Selected) continue;

                photosBindingSource.RemoveAt(i);
            }

            photosBindingSource.EndEdit();
            photosTableAdapter.Update(gameStartDBDataSet.Photos);
        }

        private void FormScreenshots_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameStartDBDataSet.Photos' table. You can move, or remove it, as needed.
            this.photosTableAdapter.Fill(this.gameStartDBDataSet.Photos);
            photosBindingSource.Filter = "id_game = " + id_game;
        }

        private void imagePictureBox_Click(object sender, EventArgs e)
        {
            if (imagePictureBox.Image == null) return;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imagePictureBox.Image = Image.FromFile(openFileDialog1.FileName);
                name_imageLabel1.Text = openFileDialog1.SafeFileName;
                id_gameLabel1.Text = id_game;
                photosBindingSource.EndEdit();
                photosTableAdapter.Update(gameStartDBDataSet.Photos);
            }
        }
    }
}
