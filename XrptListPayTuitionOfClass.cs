using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_TC
{
    public partial class XrptListPayTuitionOfClass : DevExpress.XtraReports.UI.XtraReport
    {
        public XrptListPayTuitionOfClass()
        {
            InitializeComponent();
        }

        public XrptListPayTuitionOfClass(String classNumber, String schoolYear, int semester)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connectString;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = classNumber;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = schoolYear;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = semester;
            this.sqlDataSource1.Fill();
        }
        private void xrlblCurrencyToWords_BeforePrint(object sender, CancelEventArgs e)
        {
            String currencyToWords = Services.ConvertCurrencyToWords.ConvertMoneyToString(xrlblCurrency.Text.Replace(",", ""));

            xrlblCurrencyToWords.Text = Services.HandleString.UpperFirstCharInString(currencyToWords);
        }
    }
}
