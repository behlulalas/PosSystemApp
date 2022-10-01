using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace CoreTech.Forms.RaportViewer
{
    public partial class ReportViewer : DevExpress.XtraEditors.XtraForm
    {
        public ReportViewer(XtraReport report)
        {
            InitializeComponent();
            try
            {
                documentViewer1.DocumentSource = report;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}