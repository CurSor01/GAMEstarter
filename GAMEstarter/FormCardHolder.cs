using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FontAwesome.Sharp;

namespace GAMEstarter
{
    public partial class FormCardHolder : Form
    {
        public int id_user, id_game, m_have, m_now;

        public FormCardHolder()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Операция отменена", "Внимание!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void FormCardHolder_Load(object sender, EventArgs e)
        {
            this.cardsTableAdapter.Fill(this.gameStartDBDataSet.Cards);
            cardsBindingSource.Filter = "id_user = " + id_user;

            if (Parent != null)
            {
                panelFormManage.Visible = 
                    cardTransaction.Visible = false;
                panelCardManage.Location = new Point(5,6);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.IconChar == IconChar.Plus)
            {
                btnAdd.IconChar = IconChar.CheckCircle;

                tbxCardHolder.ReadOnly = tbxNumb.ReadOnly =
                    tbxCVV.ReadOnly = tbxValid.ReadOnly = false;

                cardsBindingSource.AddNew();
            }
            else
            {
                id_userLabel1.Text = id_user.ToString();
                cardsBindingSource.EndEdit();
                cardsTableAdapter.Update(gameStartDBDataSet.Cards);

                tbxCardHolder.ReadOnly = tbxNumb.ReadOnly =
                    tbxCVV.ReadOnly = tbxValid.ReadOnly = true;

                btnAdd.IconChar = IconChar.Plus;
                MessageBox.Show("Карта успешно сохранена", "Внимание!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                }
                catch
                {
                    MessageBox.Show("Не все поля карты заполнены", "Внимание!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void tbxNumb_TextChanged(object sender, EventArgs e)
        {
            string num;
            num = tbxNumb.Text[0].ToString();

            if (num == "2") panelCC.BackgroundImage = Properties.Resources.Card_MYR;
            else if (num == "3") panelCC.BackgroundImage = Properties.Resources.Card_AE;
            else if (num == "4") panelCC.BackgroundImage = Properties.Resources.Card_VISA;
            else if (num == "5") panelCC.BackgroundImage = Properties.Resources.Card_MC;
            else if (num == "6") panelCC.BackgroundImage = Properties.Resources.Card_UP;
            else panelCC.BackgroundImage = Properties.Resources.Card_EMPTY;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void btnSendMoney_Click(object sender, EventArgs e)
        {
            try
            {
                Transaction();

                MessageBox.Show("Пожертвование произведено успешно!", "Внимание!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch
            {
                MessageBox.Show("Пожертвование не произведено, проверьте подключение к интернету",
                    "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Transaction()
        {
            SqlConnection con = new SqlConnection(Form1.txtcon);
            string txtquery1 = $@"insert into Transactions (id_user, id_game, sum)
values ({id_user}, {id_game},{tbxSumTr.Text})";

            int sumplus = Convert.ToInt32(tbxSumTr.Text);
            string txtquery2 = $"update games set m_have = {m_have + sumplus} where id_game = {id_game}";
            string txtquery3 = $"update games set m_have_now = {m_have + sumplus} where id_game = {id_game}";

            con.Open();
            SqlCommand query1 = new SqlCommand(txtquery1, con);
            query1.ExecuteNonQuery();

            query1 = new SqlCommand(txtquery2, con);
            query1.ExecuteNonQuery();

            query1 = new SqlCommand(txtquery3, con);
            query1.ExecuteNonQuery();

            con.Close();
        }

        private void panelFormManage_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, new IntPtr(HT_CAPTION), IntPtr.Zero);
            }
        }
    }
}
