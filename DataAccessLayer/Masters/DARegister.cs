using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Common;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Diagnostics;
using UtilityClassLibrary;
namespace DataAccessLayer.Masters
{
   public class DARegister
    {
        public DataTable GetData(int intRegisterID)
        {
            try
            {
                DataTable dt = new DataTable();
                DatabaseProviderFactory factory = new DatabaseProviderFactory();
                Database objDB = factory.Create(DataBaseConstat.ConnectionString);//factory.Create("DBConnection");
                DbCommand cmd;
                cmd = objDB.GetStoredProcCommand(DataBaseConstat.spGetUserByID);
                objDB.AddInParameter(cmd, "@RegisterID", DbType.Int32, intRegisterID);
                dt = objDB.ExecuteDataSet(cmd).Tables[0];
                return dt;
            }
            catch
            {
                throw;
            }
        }
    }
}
