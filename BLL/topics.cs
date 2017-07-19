using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public  class topics
    {

        public DataTable get_topic_info(int TopicID)
        {
            return new DAL.topics().get_topic_info(TopicID);
        }


    }
}
