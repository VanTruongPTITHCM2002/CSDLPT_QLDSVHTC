using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_TC
{
    public partial class XrptStudentScores : DevExpress.XtraReports.UI.XtraReport
    {
        public XrptStudentScores()
        {
            InitializeComponent();
        }
        public XrptStudentScores(String studentNumber)
        {
            InitializeComponent();

            this.sqlDataSource1.Connection.ConnectionString = Program.connectString;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = studentNumber;
            this.sqlDataSource1.Fill();
        }
    }
}
