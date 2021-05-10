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
    public partial class FormIcons : Form
    {
        public FormIcons()
        {
            InitializeComponent();
        }

        public string id_game;
        private void FormTrailer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameStartDBDataSet.Games' table. You can move, or remove it, as needed.
            this.gamesTableAdapter.Fill(this.gameStartDBDataSet.Games);
            gamesBindingSource.Filter = "id_game = " + id_game;
        }

        private void image_minPictureBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                image_minPictureBox.Image = Image.FromFile(openFileDialog1.FileName);
                gamesBindingSource.EndEdit();
                gamesTableAdapter.Update(gameStartDBDataSet.Games);
            }
        }

        private void image_maxPictureBox_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                image_maxPictureBox.Image = Image.FromFile(openFileDialog1.FileName);
                gamesBindingSource.EndEdit();
                gamesTableAdapter.Update(gameStartDBDataSet.Games);
            }
        }
    }
}
