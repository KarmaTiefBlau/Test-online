using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class topics



    {
        public DataTable get_topic_info(int TopicID)
        {
            return Ado.SqlHelper.ExecuteDataTable("select * from Topics where TopicID = @TopicID ", new System.Data.SqlClient.SqlParameter("@TopicID", TopicID));
        }


    }
}
