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
    public partial class FormdataExit : Form
    {
        public FormdataExit()
        {
            InitializeComponent();
        }

        public string id_game;
        
        private void FormdataExit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameStartDBDataSet.Games' table. You can move, or remove it, as needed.
            this.gamesTableAdapter.Fill(this.gameStartDBDataSet.Games);
            gamesBindingSource.Filter = "id_game = " + id_game;

            getPlatform(e);
        }

        void getPlatform(EventArgs e)
        {
            if (platformLabel1.Text.IndexOf("PC") != -1)
                btnPC_Click(btnPC, e);

            if (platformLabel1.Text.IndexOf("PS4 / PS5") != -1)
                btnPC_Click(btnPS, e);

            if (platformLabel1.Text.IndexOf("XBOX") != -1)
                btnPC_Click(btnXB, e);

            if (platformLabel1.Text.IndexOf("Switch") != -1)
                btnPC_Click(btnSW, e);

            if (platformLabel1.Text.IndexOf("Mobile") != -1)
                btnPC_Click(btnMB, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            setPaltform();

            gamesBindingSource.EndEdit();
            gamesTableAdapter.Update(gameStartDBDataSet.Games);
            MessageBox.Show("Данные сохранены", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void setPaltform()
        {
            string platforms = "";
            if (btnPC.ForeColor == Color.WhiteSmoke) platforms += " PC";
            if (btnPS.ForeColor == Color.WhiteSmoke) platforms += " PS4 / PS5";
            if (btnXB.ForeColor == Color.WhiteSmoke) platforms += " XBOX";
            if (btnSW.ForeColor == Color.WhiteSmoke) platforms += " Switch";
            if (btnMB.ForeColor == Color.WhiteSmoke) platforms += " Mobile";
            platformLabel1.Text = platforms.Trim();
        }

        private void btnPC_Click(object sender, EventArgs e)
        {
            if((sender as FontAwesome.Sharp.IconButton).ForeColor != Color.WhiteSmoke)
            {
                (sender as FontAwesome.Sharp.IconButton).ForeColor = Color.WhiteSmoke;
                (sender as FontAwesome.Sharp.IconButton).IconColor = Color.WhiteSmoke;

                string name = (sender as FontAwesome.Sharp.IconButton).Name;
                FontAwesome.Sharp.IconButton btn = sender as FontAwesome.Sharp.IconButton;
                switch (name)
                {
                    case "btnPC":
                        btn.BackColor = Color.Black;
                        break;

                    case "btnPS":
                        btn.BackColor = Color.DodgerBlue;
                        break;

                    case "btnXB":
                        btn.BackColor = Color.LimeGreen;
                        break;

                    case "btnSW":
                        btn.BackColor = Color.Red;
                        break;

                    case "btnMB":
                        btn.BackColor = Color.Gray;
                        break;

                }
            }
            else
            {
                (sender as FontAwesome.Sharp.IconButton).ForeColor = SystemColors.ControlText;
                (sender as FontAwesome.Sharp.IconButton).IconColor = SystemColors.ControlText;
                (sender as FontAwesome.Sharp.IconButton).BackColor = Color.White;
            }
        }
    }
}
