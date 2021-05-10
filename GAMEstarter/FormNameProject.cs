using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin;

namespace GAMEstarter
{
    public partial class FormNameProject : Form
    {
        public FormNameProject()
        {
            InitializeComponent();
        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            FormCrPr.name = tbxName.Text;
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormNameProject_Load(object sender, EventArgs e)
        {
            Color color = FormDevBoard.color;
            tbxName.Focus();
        }
    }
}
