using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Reporting.WebForms;
namespace Standard_WebApplication
{
    public partial class Attendance_Report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DisplayReport();
        }
        protected void DisplayReport()
        {
            try
            {
                ReportParameter[] Param = new ReportParameter[4];
                Param[0] = new Microsoft.Reporting.WebForms.ReportParameter("RPYear", "2017");
                Param[1] = new Microsoft.Reporting.WebForms.ReportParameter("RPMonth", "March");
                Param[2] = new Microsoft.Reporting.WebForms.ReportParameter("RPOrgGroup", "(Select All)");
                Param[3] = new Microsoft.Reporting.WebForms.ReportParameter("RPDeptName", "(Select All)");

                ReportViewer1.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Remote;
                ReportViewer1.ServerReport.ReportServerUrl = new Uri("http://azfcbsqltest/ReportServer");
                ReportViewer1.ServerReport.ReportPath = "/SSRS2016_ProfitabilityTabular/Attendance_Delhi_Leadership";
                ReportViewer1.ServerReport.SetParameters(Param);
                ReportViewer1.ServerReport.Refresh();
            }
            catch
            {
                throw;
            }
        }
    }
   
}