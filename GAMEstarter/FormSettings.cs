using Microsoft.Win32;
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
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        Settings Settings = new Settings();
        string txtcolors = "", ChildColor = "", DefChild = "";

        private void FormSettings_Load(object sender, EventArgs e)
        {
            for(int i = 0; i <= Settings.ColorList.Count - 1; i++)
            {
                cmbChildColor.Items.Add(Settings.ColorList[i]);
            }

            btnSave.BackColor = FormDevBoard.color;

            Settings.getSettings();
            txtcolors = Settings.listcolors;
            DefChild = Settings.ChildStart;
            ChildColor = Settings.ChildColor;

            cbxClock.Checked = Settings.Clock;
            cbxHidePanel.Checked = Settings.HidePanel;

            if(ChildColor != "")
            {
                cbxCustomChild.Checked = true;

                for (int i = 0; i <= cmbChildColor.Items.Count - 1; i++)
                {
                    if (cmbChildColor.Items[i].ToString() == ChildColor)
                        cmbChildColor.SelectedIndex = i;
                }
            }

            if(DefChild != "")
            {
                cbxDefPanel.Checked = true;

                for (int i = 0; i <= cmbDefPanel.Items.Count - 1; i++)
                {
                    if (cmbDefPanel.Items[i].ToString() == DefChild)
                        cmbDefPanel.SelectedIndex = i;
                }
            }

            btnSave.Hide();
        }

        void DisableColors()
        {
            lblBlue.Text = "Синий";
            lblRed.Text = "Красный";
            lblYellow.Text = "Жёлтый";
            lblGreen.Text = "Зелёный";
            lblAzure.Text = "Лазурный";
            lblCyan.Text = "Голубой";
            lblPink.Text = "Розовый";
            lblGlass.Text = "Стекло";
            lblWhite.Text = "Белый";
        }
        void EnableColor(string label)
        {
            Label lbl = null;

            switch (label)
            {
                case "0 0 0":
                    lbl = lblBlue;
                    break;

                case "1 1 0":
                    lbl = lblRed;
                    break;

                case "2 2 0":
                    lbl = lblYellow;
                    break;

                case "3 3 0":
                    lbl = lblGreen;
                    break;

                case "4 4 0":
                    lbl = lblAzure;
                    break;

                case "5 5 0":
                    lbl = lblCyan;
                    break;

                case "6 6 1":
                    lbl = lblPink;
                    break;

                case "7 7 1":
                    lbl = lblGlass;
                    break;

                case "8 8 1":
                    lbl = lblWhite;
                    break;
            }

            lbl.Text = "Выбрано";
            pbBorders.Location = new Point(lbl.Location.X - 5, lbl.Location.Y - 7);
            pbBorders.SendToBack();
            pbBorders.Visible = true;
            txtcolors = label;
        }

        #region Кнопки
        private void label2_Click(object sender, EventArgs e)
        {
            if(label2.Text != "Закрыть")
            {
                label2.Text = "Закрыть";
                panelColors.Show();
                EnableColor(txtcolors);
            }
            else
            {
                label2.Text = "Выбрать";
                panelColors.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DisableColors();
            EnableColor("0 0 0");
            btnSave.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DisableColors();
            EnableColor("1 1 0");
            btnSave.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DisableColors();
            EnableColor("2 2 0");
            btnSave.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DisableColors();
            EnableColor("3 3 0");
            btnSave.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DisableColors();
            EnableColor("4 4 0");
            btnSave.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DisableColors();
            EnableColor("5 5 0");
            btnSave.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            DisableColors();
            EnableColor("6 6 1");
            btnSave.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            DisableColors();
            EnableColor("7 7 1");
            btnSave.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            DisableColors();
            EnableColor("8 8 1");
            btnSave.Show();
        }
        #endregion

        #region Переключатели
        private void cmbChildColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbChildColor.BackColor = ColorTranslator.FromHtml(cmbChildColor.Text);
            btnSave.Show();
        }

        private void cbxCustomChild_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCustomChild.Checked)
            {
                cmbChildColor.Visible =
                pbChildColor.Visible = true;
            }
            else
            {
                cmbChildColor.Visible =
                pbChildColor.Visible = false;
            }
        }

        private void cbxClock_CheckedChanged(object sender, EventArgs e)
        {
            btnSave.Show();
        }

        private void cmbDefPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSave.Show();
        }

        private void cbxHidePanel_CheckedChanged(object sender, EventArgs e)
        {
            btnSave.Show();
        }

        private void cbxDefPanel_CheckedChanged(object sender, EventArgs e)
        {
            btnSave.Show();
            if (cbxDefPanel.Checked)
                cmbDefPanel.Show();
            else cmbDefPanel.Hide();
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Требуется перезагрузка.\r\nПродолжить?",
                "Внимание!", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.No) return;

            Settings.listcolors = txtcolors;
            Settings.Clock = cbxClock.Checked;
            Settings.HidePanel = cbxHidePanel.Checked;

            if (cbxCustomChild.Checked)
                Settings.ChildColor = cmbChildColor.Text;
            else
                Settings.ChildColor = "";

            if (cbxDefPanel.Checked)
                Settings.ChildStart = cmbDefPanel.Text;
            else
                Settings.ChildStart = "";

            Settings.setSettings();
            Application.Restart();
        }
    }
}
