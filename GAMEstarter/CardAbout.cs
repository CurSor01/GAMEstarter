using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.IO;

namespace GAMEstarter
{
    public partial class CardAbout : UserControl
    {
        public string CurId;
        public string codename;
        Color color = FormDevBoard.color;
        public CardAbout(string id)
        {
            InitializeComponent();
            CurId = id;
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void CardAbout_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Form1.txtcon);
            string txtquery = "select * from Games where id_game = " + CurId;
            SqlCommand query1 = new SqlCommand(txtquery, con);
            con.Open();

            SqlDataReader read = query1.ExecuteReader();
            read.Read();

            codename = read["codename"].ToString();
            lblName.Text = string.Format("{0} ({1})", read["game_name"].ToString(), codename);
            lblGenre.Text = read["genre"].ToString();
            lblMNeed.Text = read["m_need"].ToString();
            lblMHave.Text = read["m_have"].ToString();
            btnEdit.Tag = btnDel.Tag = CurId;

            string date = read["data_exit"].ToString();

            if (date == "") lblDatExt.Text = "Не установлена";
            else
            {
                DateTime dt = Convert.ToDateTime(date);
                lblDatExt.Text = dt.ToShortDateString();
                if (Convert.ToDateTime(date).Date < DateTime.Now.Date)
                    pbCheck.Show();
            }

            byte[] bytes;
            try
            {
                bytes = (byte[])read["image_max"];
                if (bytes != null)
                    pbPreviev.Image = byteArrayToImage(bytes);
            }
            catch
            {

            }


            double mhave = Convert.ToDouble(read["m_have"]), mneed = Convert.ToDouble(read["m_need"]);
            try { cpbMoney.Value = Convert.ToInt32(mhave / mneed * 100); }
            catch { cpbMoney.Value = 100; }
            
            cpbMoney.ProgressColor = color;

            con.Close();
        }
    }
}
