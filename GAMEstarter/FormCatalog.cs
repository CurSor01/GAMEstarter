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
    public partial class FormCatalog : Form
    {
        public FormCatalog()
        {
            InitializeComponent();
        }

        private void FormCatalog_Load(object sender, EventArgs e)
        {
            if(!panelHeader.Visible)
            {
                panelChildForm.Location = new Point(10, 0);
                panelChildForm.Size = new Size(1200, 900);
            }
        }

        private void FormCatalog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(panelHeader.Visible)
            Application.Exit();
        }
    }
}
