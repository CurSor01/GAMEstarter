using CefSharp.WinForms;
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
    public partial class FormRevGame : Form
    {
        public int idGame;
        int idStudio;
        string videolink;
        public FormRevGame()
        {
            InitializeComponent();
        }

        private void FormRevGame_Load(object sender, EventArgs e)
        {
            CheckViev();

            LoadInfo();
            LoadStudio();
        }

        void CheckViev()
        {
            SqlConnection con = new SqlConnection(Form1.txtcon);
            string txtquery = "insert into Vievs(id_game, data_viev) " +
                $"values({idGame}, '{DateTime.Now.ToShortDateString()}')";

            con.Open(); 
            
            SqlCommand query2 = new SqlCommand("set dateformat dmy", con);
            query2.ExecuteNonQuery();

            SqlCommand query1 = new SqlCommand(txtquery, con);
            query1.ExecuteNonQuery();

            con.Close();
        }

        void LoadInfo()
        {
            SqlConnection con = new SqlConnection(Form1.txtcon);
            string txtquery = "select * from games where id_game = " + idGame;
            string txtquery2 = "select * from photos where id_game = " + idGame;
            string other = "";

            con.Open();

            SqlCommand query1 = new SqlCommand(txtquery, con);
            SqlDataReader read = query1.ExecuteReader();
            read.Read();

            lblName.Text = read["game_name"].ToString();
            tbxDescription.Text = "Об этой игре: \r\n" + read["description"];

            other = read["genre"].ToString();
            if (other == "") lblGenre.Text = "Не установлен";
            else lblGenre.Text = other;

            other = read["platform"].ToString().Replace(" ", " | ");
            if (other == "") lblPlatforms.Text = "Не установлены";
            else lblPlatforms.Text = other;

            idStudio = Convert.ToInt32(read["id_studio"]);

            try
            {
                DateTime dt = Convert.ToDateTime(read["data_exit"]);
                lblDateExt.Text = dt.ToShortDateString();
            }
            catch
            {
                lblDateExt.Text = "Не установлена";
            }

            int need = Convert.ToInt32(read["m_need"]),
            have = Convert.ToInt32(read["m_have"]);

            lblSum.Text = have + "/" + need + " $"; 

            byte[] bytes;
            try
            {
                bytes = (byte[])read["image_max"];
                if (bytes != null)
                    pbGameIcon.Image = byteArrayToImage(bytes);
            }
            catch { }
            videolink = read["trailer_link"].ToString();
            con.Close();

            con.Open();
            query1 = new SqlCommand(txtquery2, con);
            read = query1.ExecuteReader();

            while (read.Read())
            {
                PictureBox pbScreenshot = new PictureBox();
                try
                {
                    bytes = (byte[])read["image"];
                    if (bytes != null)
                        pbScreenshot.Image = byteArrayToImage(bytes);
                }
                catch { }

                pbScreenshot.SizeMode = PictureBoxSizeMode.Zoom;
                pbScreenshot.Dock = DockStyle.Left;
                pbScreenshot.Click += PbScreenshot_Click;

                Panel pSep = new Panel();
                pSep.Dock = DockStyle.Left;
                pSep.Width = 10;

                panelScreenshots.Controls.Add(pbScreenshot);
                panelScreenshots.Controls.Add(pSep);
            }
            con.Close();

            if (videolink == null) return;

            IconButton btnTrailer = new IconButton();
            btnTrailer.Dock = DockStyle.Left;
            btnTrailer.IconChar = IconChar.Video;
            btnTrailer.Text = "Трейлер";
            btnTrailer.Click += BtnTrailer_Click;
            btnTrailer.TextImageRelation = TextImageRelation.ImageAboveText;
            btnTrailer.Width = 100;
            panelScreenshots.Controls.Add(btnTrailer);
        }

        ChromiumWebBrowser webBrowser;
        private void BtnTrailer_Click(object sender, EventArgs e)
        {
            if (pbVievScreenshot.Controls.Count > 0) return;
            string link = editlink(videolink);

            webBrowser = new ChromiumWebBrowser(link);
            pbVievScreenshot.Controls.Add(webBrowser);
        }
        string editlink(string link)
        {
            string code = "";
            for (int i = link.Length - 11; i <= link.Length - 1; i++)
            {
                code += link[i];
            }

            return "https://www.youtube.com/embed/" + code;
        }

        void LoadStudio()
        {
            SqlConnection con = new SqlConnection(Form1.txtcon);
            string txtquery = "select * from studios where id_studio = " + idStudio;

            con.Open();

            SqlCommand query1 = new SqlCommand(txtquery, con);
            SqlDataReader read = query1.ExecuteReader();
            read.Read();

            lblstudioName.Text = read["studio_name"].ToString(); byte[] bytes;
            try
            {
                bytes = (byte[])read["logo"];
                if (bytes != null)
                    pbStudioLogo.Image = byteArrayToImage(bytes);
            }
            catch { }
            con.Close();
        }

        private void PbScreenshot_Click(object sender, EventArgs e)
        {
            if(webBrowser != null)webBrowser.Dispose();
            pbVievScreenshot.Controls.Clear();
            pbVievScreenshot.Image = (sender as PictureBox).Image;
        }

        Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
    }
}
