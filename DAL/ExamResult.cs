using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ExamResult
    {

        public DataTable get_ExamResult_statistic_info(int ExamID, int high, int low)
        {
            return Ado.SqlHelper.ExecuteDataTable("select count(Result) from ExamResult where ExamID = @ExamID and Result<@high and Result>@low", new System.Data.SqlClient.SqlParameter("@ExamID", ExamID)
                , new System.Data.SqlClient.SqlParameter("@high", high)
                , new System.Data.SqlClient.SqlParameter("@low", low)

                );
        }


        public DataTable get_ExamResult_statistic_info_max(int ExamID)
        {
            return Ado.SqlHelper.ExecuteDataTable("select max(Result) from ExamResult where ExamID = @ExamID ", new System.Data.SqlClient.SqlParameter("@ExamID", ExamID)

                );

        }

        public DataTable get_ExamResult_statistic_info_min(int ExamID)
        {
            return Ado.SqlHelper.ExecuteDataTable("select min(Result) from ExamResult where ExamID = @ExamID ", new System.Data.SqlClient.SqlParameter("@ExamID", ExamID)

                );

        }

        public DataTable get_ExamResult_statistic_info_avg(int ExamID)
        {
            return Ado.SqlHelper.ExecuteDataTable("select avg(Result) from ExamResult where ExamID = @ExamID ", new System.Data.SqlClient.SqlParameter("@ExamID", ExamID)

                );

        }
    }
}
