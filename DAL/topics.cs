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
            //return Ado.SqlHelper.ExecuteDataTable("select TopicID, TopicDetil, TopicAnwser, Cate, TopicLevel, TopicType from Topics where TopicID = @TopicID and isDel =0", new System.Data.SqlClient.SqlParameter("@TopicID", TopicID));

            return Ado.SqlHelper.ExecuteDataTable(" select TopicID, TopicDetil, TopicAnwser, CateName, TopicLevel, [description] from Topics join cate on CateID = Cate  JOIN TopicType on TypeId = TopicType  where Topics.isDel = 0 and  TopicID = @TopicID", new System.Data.SqlClient.SqlParameter("@TopicID", TopicID));

        }

        public DataTable get_real_topic_info(int TopicID)
        {
            //return Ado.SqlHelper.ExecuteDataTable("select TopicID, TopicDetil, TopicAnwser, Cate, TopicLevel, TopicType from Topics where TopicID = @TopicID and isDel =0", new System.Data.SqlClient.SqlParameter("@TopicID", TopicID));

            return Ado.SqlHelper.ExecuteDataTable(" select * from Topics   where Topics.isDel = 0 and  TopicID = @TopicID", new System.Data.SqlClient.SqlParameter("@TopicID", TopicID));

        }

        public DataTable get_all_topic_info()
        {
            return Ado.SqlHelper.ExecuteDataTable(" select TopicID, TopicDetil, TopicAnwser, CateName, TopicLevel, [description] from Topics join cate on CateID = Cate  JOIN TopicType on TypeId = TopicType  where Topics.isDel = 0");
        }

        public int update_topic_info(int TopicID,string TopicDetil,string TopicAnwser,int cate,int TopicLevel,int TopicType,int isDel)
        {
            return Ado.SqlHelper.ExecuteNonQuery("UPDATE Topics SET TopicDetil=@TopicDetil ,TopicAnwser=@TopicAnwser,Cate=@Cate,TopicLevel=@TopicLevel,TopicType=@TopicType WHERE TopicID=@TopicID ",
                 new System.Data.SqlClient.SqlParameter("@TopicID", TopicID),
                new System.Data.SqlClient.SqlParameter("@TopicDetil", TopicDetil), 
                new System.Data.SqlClient.SqlParameter("@TopicAnwser", TopicAnwser),
               new System.Data.SqlClient.SqlParameter("@Cate", cate),
               new System.Data.SqlClient.SqlParameter("@TopicLevel", TopicLevel),
                new System.Data.SqlClient.SqlParameter("@TopicType", TopicType)
                );
        }

        public int delete_topic_info(int TopicID)
        {
            return Ado.SqlHelper.ExecuteNonQuery("UPDATE Topics SET isDel=1 WHERE TopicID=@TopicID ",
                 new System.Data.SqlClient.SqlParameter("@TopicID", TopicID)
                );
        }

        public int insert_topics_info(string stem, string TopicAnswer, int cate,int topiclevel, int topicType,int isDel)
        {
            return Ado.SqlHelper.ExecuteNonQuery("insert into Topics values(@stem,@TopicAnswer,@cate,@topiclevel,@topicType,@isDel)",
                new System.Data.SqlClient.SqlParameter("@stem", stem),
                new System.Data.SqlClient.SqlParameter("@TopicAnswer", TopicAnswer),
               new System.Data.SqlClient.SqlParameter("@cate", cate),
               new System.Data.SqlClient.SqlParameter("@topiclevel", topiclevel),
                new System.Data.SqlClient.SqlParameter("@topicType", topicType)
                ,
                new System.Data.SqlClient.SqlParameter("@isDel", isDel)
                );

        }
    }
}
