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

namespace GAMEstarter
{
    public partial class cardAnalytics : UserControl
    {
        public cardAnalytics(string id)
        {
            InitializeComponent();

            if (id == "") return;
            int curID = Convert.ToInt32(id);
            LoadProgress(curID,FormDevBoard.color);
        }

        void LoadProgress(int id, Color color)
        {
            SqlConnection con = new SqlConnection(Form1.txtcon);
            string txtquery = "select m_need, m_have, game_name, data_exit from Games where id_game = " + id;
            SqlCommand query1 = new SqlCommand(txtquery, con);
            con.Open();

            SqlDataReader read = query1.ExecuteReader();
            read.Read();

            if (Convert.ToDateTime(read["data_exit"]).Date < DateTime.Now.Date)
                pbCheck.Show();

            lblMNeed.Text = read["m_need"].ToString();
            lblMHave.Text = read["m_have"].ToString();
            lblName.Text = read["game_name"].ToString();
            lblName.ForeColor = color;
            cpbMoney.ProgressColor = color;

            double mhave = Convert.ToDouble(read["m_have"]), mneed = Convert.ToDouble(read["m_need"]);
            try { cpbMoney.Value = Convert.ToInt32(mhave / mneed * 100); }
            catch { cpbMoney.Value = 100; }

            con.Close();
        }
    }
}
