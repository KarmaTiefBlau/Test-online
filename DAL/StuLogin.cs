using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StuLogin
    {
        public DataTable get_user_info(string stuNumber)
        {
            return Ado.SqlHelper.ExecuteDataTable("select * from StuLogin where stuNumber = @stuNumber ", new System.Data.SqlClient.SqlParameter("@stuNumber", stuNumber));
        }

    }
}
