using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin.Controls;

namespace GAMEstarter
{
    public partial class FormMyPr : Form
    {
        public string id_studio;

        public FormMyPr()
        {
            InitializeComponent();
        }
        
        List<string> lstId = new List<string>();
        void LoadCards()
        {
            panelCardsContent.Controls.Clear();
            lstId.Clear();
            SqlConnection con = new SqlConnection(Form1.txtcon);
            string txtquery = "select id_game from Games where id_studio = " + id_studio;
            con.Open();

            SqlCommand query1 = new SqlCommand(txtquery, con);
            SqlDataReader read = query1.ExecuteReader();
            while (read.Read())
            {
                lstId.Add(read["id_game"].ToString());
            }

            con.Close();

            int curY = 10;
            for (int i = 0; i <= lstId.Count - 1; i++)
            {
                MaterialCard card = new MaterialCard();
                card.Size = new Size(1000, 150);
                card.Location = new Point(100, curY);
                panelCardsContent.Controls.Add(card);

                CardAbout crd = new CardAbout(lstId[i]);
                crd.btnEdit.Click += btnEdit_Click;
                crd.btnDel.Click += BtnDel_Click;
                card.Controls.Add(crd);
                curY += 160;
            }
        }

        bool CheckBalance(string id)
        {
            SqlConnection con = new SqlConnection(Form1.txtcon);
            string txtquery = "select m_have from Games where id_game = " + id;
            con.Open();
            SqlCommand query1 = new SqlCommand(txtquery, con);
            SqlDataReader read = query1.ExecuteReader();
            read.Read();
            int count = Convert.ToInt32(read["m_have"]);
            con.Close();
            return count > 0;
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            string CurId = (sender as Button).Tag.ToString();
            if (CheckBalance(CurId))
            {
                MessageBox.Show("Вы не можете удалить проект, в который произведены пожертвования",
                "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Вы действительно хотите удалить проект?", 
                "Внимание!", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.No) return;

            SqlConnection con = new SqlConnection(Form1.txtcon);
            string txtquery = "delete from Games where id_game = " + CurId;
            con.Open();
            SqlCommand query1 = new SqlCommand(txtquery, con);
            query1.ExecuteNonQuery();
            con.Close();
        }

        private void FormMyPr_Load(object sender, EventArgs e)
        {
            LoadCards();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormCrPr frcp = new FormCrPr();
            frcp.id_studio = id_studio;
            frcp.gamesBindingSource.Filter = "id_game = " + (sender as Button).Tag;
            frcp.ShowDialog();

            LoadCards();
        }
        
        private void btnAddPr_Click(object sender, EventArgs e)
        {
            FormCrPr frcp = new FormCrPr();
            frcp.id_studio = id_studio;
            frcp.ShowDialog();

            LoadCards();
        }
    }
}
