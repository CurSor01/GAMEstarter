using CefSharp.WinForms;
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
    public partial class FormTrailer : Form
    {
        public string id_game;
        public FormTrailer()
        {
            InitializeComponent();
        }

        private void FormTrailer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gameStartDBDataSet.Games' table. You can move, or remove it, as needed.
            this.gamesTableAdapter.Fill(this.gameStartDBDataSet.Games);
            gamesBindingSource.Filter = "id_game = " + id_game;

            if(trailer_linkTextBox.Text != "")
            {
                panelVideo.Controls.Clear();
                string link = editlink(trailer_linkTextBox.Text);
                ChromiumWebBrowser webBrowser = new ChromiumWebBrowser(link);
                panelVideo.Controls.Add(webBrowser);
            }
        }

        string editlink(string link)
        {
            string code = "ffff";

            code = "";
            for (int i = link.Length - 11; i <= link.Length - 1; i++)
            {
                code += link[i];
            }

            return "https://www.youtube.com/embed/" + code;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (trailer_linkTextBox.Text == "") return;

            panelVideo.Controls.Clear();
            string link = editlink(trailer_linkTextBox.Text);
            ChromiumWebBrowser webBrowser = new ChromiumWebBrowser(link);
            panelVideo.Controls.Add(webBrowser);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (trailer_linkTextBox.Text == "") return;

            gamesBindingSource.EndEdit();
            gamesTableAdapter.Update(gameStartDBDataSet.Games);
        }
    }
}
