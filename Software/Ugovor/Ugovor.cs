using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vedrana
{
    public partial class Ugovor : Form
    {
        string OIB = "";
        string ImeIPrezime = "";
        public Ugovor(string oib, string imeprezime)
        {
            InitializeComponent();
            OIB = oib;
            ImeIPrezime = imeprezime;
        }

        private void Ugovor_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("ImeIPrezime", ImeIPrezime));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("OIB", OIB));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Datum", DateTime.Now.ToString()));

            this.reportViewer1.RefreshReport();
        }
    }
}
