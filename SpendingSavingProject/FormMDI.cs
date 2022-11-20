using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Spending;
//using Saving;
//using Overzicht;

namespace SpendingSavingProject
{
    public partial class FormMDI : Form
    {
        #region Form
        public FormMDI()
        {
            InitializeComponent();
        }

        private void FormMDI_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
        #endregion

        #region Overzicht
        #endregion

        #region Spending
        private void menuInsertSpendToolStrip_Click(object sender, EventArgs e)
        {
            FormInsertSpend frm = FormInsertSpend.GetInstance();
            LaunchScreen(frm);
        }
        #endregion

        #region Saving
        #endregion

        #region Functions
        void LaunchScreen(Form frm)
        {
            Application.DoEvents();
            frm.MdiParent = this;
            frm.Show();
        }
        #endregion
    }
}
