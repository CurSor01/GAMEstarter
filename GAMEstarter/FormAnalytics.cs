using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.IO;

namespace GAMEstarter
{
    public partial class FormAnalytics : Form
    {
        public FormAnalytics()
        {
            InitializeComponent();
        }

        public int id_studio, id_user;
        Color color;
        private void FormAnalytics_Load(object sender, EventArgs e)
        {
            Application.DoEvents();

            color = FormDevBoard.color;
            label1.ForeColor = label2.ForeColor =
                label3.ForeColor = label5.ForeColor = color;

            LoadInfo();
            try
            {
                LoadData();
                LoadCards();
            }
            catch
            {
                lblMNow.Text += "Недоступно"; 
                lblCurrent.Text = "Недоступно";
            }

            BackColor = FormDevBoard.color;
        }

        void LoadInfo()
        {
            SqlConnection con = new SqlConnection(Form1.txtcon);
            string txtquery = @"select fam + ' (' + nickname + ') ' + user_name as fio, photo, logo, studio_name 
from Users, Studios 
where Studios.id_studio = " + id_studio + " and id_user = " + id_user;

            SqlCommand query1 = new SqlCommand(txtquery, con);
            con.Open();

            SqlDataReader read = query1.ExecuteReader();
            read.Read();

            studio_nameLabel1.Text = read["studio_name"].ToString();
            fioLabel1.Text = read["fio"].ToString();

            byte[] bytes = (byte[])read["photo"];
            if (bytes != null) photoPictureBox.Image = byteArrayToImage(bytes);
            bytes = (byte[])read["logo"];
            if (bytes != null) logoPictureBox.Image = byteArrayToImage(bytes);

            con.Close();
        }

        void LoadData()
        {
            SqlConnection con = new SqlConnection(Form1.txtcon);
            string txtquery = @"select sum(m_need) as need, sum(m_have) as have, sum(m_have_now) as now
from Games
where Games.id_studio = " + id_studio;

            SqlCommand query1 = new SqlCommand(txtquery, con);
            con.Open();

            SqlDataReader read = query1.ExecuteReader();
            read.Read();

            lblMNow.Text += "\r\n" + read["now"] + "$";
            double need = Convert.ToDouble(read["need"]);
            double have = Convert.ToDouble(read["have"]);
            int sum = Convert.ToInt32(have / need * 100);

            cardAnalytics crd = new cardAnalytics("");
            crd.lblMHave.Text = have.ToString();
            crd.lblMNeed.Text = need.ToString();

            crd.cpbMoney.Value = sum;
            crd.cpbMoney.ProgressColor = color;
            panelMainBar.Controls.Add(crd);

            con.Close();
        }
        
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }


        List<string> lstId = new List<string>();
        void LoadCards()
        {
            panelProgressBars.Controls.Clear();
            lstId.Clear();
            SqlConnection con = new SqlConnection(Form1.txtcon);
            string txtquery = "select id_game, game_name, image_min, data_exit " +
                "from Games where id_studio = " + id_studio + 
                " ORDER BY id_game DESC";
            con.Open();

            SqlCommand query1 = new SqlCommand(txtquery, con);
            SqlDataReader read = query1.ExecuteReader();
            while (read.Read())
            {
                lstId.Add(read["id_game"].ToString());

                if (Convert.ToDateTime(read["data_exit"]) < DateTime.Now) continue;

                byte[] bytes = (byte[])read["image_min"];
                if (bytes != null) pbCurrent.Image = byteArrayToImage(bytes);

                lblCurrent.Text = read["game_name"].ToString();
            }

            con.Close();
            
            for (int i = 0; i <= lstId.Count - 1; i++)
            {
                cardAnalytics crd = new cardAnalytics(lstId[i]);
                crd.Dock = DockStyle.Left;
                panelProgressBars.Controls.Add(crd);
            }
        }
    }
}
