using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHXeMay
{
    public partial class FormInHoaDon : Form
    {
        public FormInHoaDon()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CrystalReportHoaDon mrpt = new CrystalReportHoaDon();
            crystalReportViewer1.ReportSource = mrpt;
            mrpt.SetDatabaseLogon("sa", "10021091$", "VINHKHANG", "QLCHXeMay_CSharp");
            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.DisplayToolbar = true;
            crystalReportViewer1.Refresh();
        }
    }
}
