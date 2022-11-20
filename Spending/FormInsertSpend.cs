using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spending
{
    public partial class FormInsertSpend : Form
    {
        #region Form
        public FormInsertSpend()
        {
            InitializeComponent();
        }

        private void FormInsertSpend_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        #region Controls
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #endregion
    }
}
