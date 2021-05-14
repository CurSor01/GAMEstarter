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

        Settings c = new Settings();
        string txtcolors = "", ChildColor = "", DefChild = "";

        private void FormSettings_Load(object sender, EventArgs e)
        {
            for(int i = 0; i <= c.ColorList.Count - 1; i++)
            {
                cmbChildColor.Items.Add(c.ColorList[i]);
            }
            btnSave.BackColor = FormDevBoard.color;
            
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey key = currentUserKey.OpenSubKey("GameSTARTER\\Settings");
            
            txtcolors = key.GetValue("colors").ToString();
            cbxClock.Checked = Convert.ToBoolean(key.GetValue("clock"));
            cbxHidePanel.Checked = Convert.ToBoolean(key.GetValue("hide_panel"));
            ChildColor = key.GetValue("child_color").ToString();
            DefChild = key.GetValue("child_start").ToString();
            key.Close();

            if(ChildColor != "")
            {
                cbxCustomChild.Checked = true;

                for (int i = 0; i <= cmbChildColor.Items.Count - 1; i++)
                {
                    if (cmbChildColor.Items[i].ToString() == ChildColor)
                        cmbChildColor.SelectedIndex = i;
                }
                btnSave.Hide();
            }

            if(DefChild != "")
            {
                cbxDefPanel.Checked = true;

                for (int i = 0; i <= cmbDefPanel.Items.Count - 1; i++)
                {
                    if (cmbDefPanel.Items[i].ToString() == DefChild)
                        cmbDefPanel.SelectedIndex = i;
                }
                btnSave.Hide();
            }
        }

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Требуется перезагрузка.\r\nПродолжить?",
                "Внимание!", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.No) return;

            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey key = currentUserKey.CreateSubKey("GameSTARTER\\Settings");
            key.SetValue("colors", txtcolors);
            key.SetValue("clock", cbxClock.Checked);

            if (cbxCustomChild.Checked)
                key.SetValue("child_color", cmbChildColor.Text);
            else
                key.SetValue("child_color", "");

            if(cbxDefPanel.Checked)
                key.SetValue("child_start", cmbDefPanel.Text);
            else
                key.SetValue("child_start", "");

            key.SetValue("hide_panel", cbxHidePanel.Checked);
            key.Close();

            Application.Restart();
        }
    }
}
