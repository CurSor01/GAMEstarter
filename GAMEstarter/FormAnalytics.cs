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

        public int id_studio;
        Color color;
        private void FormAnalytics_Load(object sender, EventArgs e)
        {
            this.studiosTableAdapter.Fill(this.gameStartDBDataSet.Studios);
            this.usersTableAdapter.Fill(this.gameStartDBDataSet.Users);

            color = FormDevBoard.color;
            label1.ForeColor = label2.ForeColor =
                label3.ForeColor = label5.ForeColor = color;

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
