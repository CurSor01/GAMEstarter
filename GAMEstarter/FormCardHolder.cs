using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FontAwesome.Sharp;

namespace GAMEstarter
{
    public partial class FormCardHolder : Form
    {
        public int id_user;

        public FormCardHolder()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
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
                panelCardManage.Location = new Point(10,6);
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
    }
}
