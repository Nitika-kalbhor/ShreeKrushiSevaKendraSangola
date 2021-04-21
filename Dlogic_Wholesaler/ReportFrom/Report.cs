using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataAccessLayer.controller;
using DataAccessLayer.models;
using MetroFramework.Forms;
using MetroFramework.Fonts;


namespace Dlogic_Wholesaler.ReportFroms
{
    public partial class Report : MetroForm
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape)
            {
                this.Close();
            }
         
        }
    }
}
