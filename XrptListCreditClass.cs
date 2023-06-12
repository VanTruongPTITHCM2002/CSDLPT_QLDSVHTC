using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_TC
{
    public partial class XrptListCreditClass : DevExpress.XtraReports.UI.XtraReport
    {
        public XrptListCreditClass()
        {
            InitializeComponent();
        }
        public XrptListCreditClass(String schoolYear, int semester)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connectString;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = schoolYear;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = semester;
            this.sqlDataSource1.Fill();
        }
    }
}
