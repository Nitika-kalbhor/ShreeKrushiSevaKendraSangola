using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dlogic_Wholesaler.ReportFrom
{
    public partial class frmRptAccountLedger : Form
    {
        public frmRptAccountLedger()
        {
            InitializeComponent();
        }

        private void frmRptAccountLedger_Load(object sender, EventArgs e)
        {

            this.rptAccountLedger.RefreshReport();
        }
    }
}
