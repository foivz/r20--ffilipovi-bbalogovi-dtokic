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

namespace Vedrana.Statistika
{
    public partial class Statistika : Form
    {
        public Statistika()
        {
            InitializeComponent();
        }

        private void Statistika_Load(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                var n = (from nx in context.seNarucujes
                         select nx).ToList();
                var p = (from px in context.proizvods
                         select px).ToList();
                var rds = new ReportDataSource("DataSet", n);
                var rds2 = new ReportDataSource("DataSet2", p);

                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(rds);
                this.reportViewer1.LocalReport.DataSources.Add(rds2);
                this.reportViewer1.RefreshReport();
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
