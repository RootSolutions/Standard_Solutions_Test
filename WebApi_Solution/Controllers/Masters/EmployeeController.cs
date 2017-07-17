using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using DA= DataAccessLayer.Masters;
namespace WebApi_Solution.Controllers.Masters
{
    public class EmployeeController : ApiController
    {
        [HttpGet]
        protected DataTable GetEmployee(int intEmpID)
        {
            DataTable dt = new DataTable();
            DA.DARegister objRegister = new DA.DARegister();
            return dt = objRegister.GetData(intEmpID);
        }
    }
}
