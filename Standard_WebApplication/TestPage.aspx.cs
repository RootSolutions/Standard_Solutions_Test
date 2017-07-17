using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using DA = DataAccessLayer;
namespace Standard_WebApplication
{
    public partial class TestPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //try
            //{ 
            DA.Masters.DARegister objRegister = new DataAccessLayer.Masters.DARegister();
            DataTable dt = new DataTable();
            dt = objRegister.GetData(0);
            
            //}
            //catch
            //{
            //    throw;
            //}
        }
    }
}