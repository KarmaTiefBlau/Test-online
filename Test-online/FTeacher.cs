using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Test_online
{
    public partial class FTeacher : Form
    {
        public FTeacher()
        {
            InitializeComponent();
        }
        public string TeacherId;

        private void FTeacher_Load(object sender, EventArgs e)
        {
            checkBox1.Text = "A.";
            checkBox2.Text = "B.";
            checkBox3.Text = "C.";

            checkBox4.Text = "D.";

            load_cb_exam_cate();
            load_cb_class();
            load_cb_time();
            dgv_exam.DataSource = Ado.SqlHelper.ExecuteDataTable(" SELECT * FROM ExamList  WHERE isDel =0  ");
            DAL.topics dal = new DAL.topics();
            dgv_exam_topic.DataSource = dal.get_all_topic_info();
        }


        void load_cb_exam_cate()
        {
            DataTable table = Ado.SqlHelper.ExecuteDataTable("SELECT * FROM Cate ");
            List<KeyValuePair<string, int>> issue = new List<KeyValuePair<string, int>>();
            foreach (DataRow a in table.Rows)
            {
                issue.Add(new KeyValuePair<string, int>(a[1].ToString(), Convert.ToInt32(a[0])));

            }
            cb_exam_cate.DisplayMember = "key";
            cb_exam_cate.ValueMember = "value";
            this.cb_exam_cate.DataSource = issue;
        }

        void load_cb_time()
        {
            List<KeyValuePair<string, int>> issue = new List<KeyValuePair<string, int>>();
            for (int i = 0; i < 120; i++)
            {
                issue.Add(new KeyValuePair<string, int>(i + "分钟", i));

            }
            cb_time.DisplayMember = "key";
            cb_time.ValueMember = "value";
            this.cb_time.DataSource = issue;
        }
        void load_cb_class()
        {
            DataTable table = Ado.SqlHelper.ExecuteDataTable("SELECT * FROM class where isDel =0");
            List<KeyValuePair<string, int>> issue = new List<KeyValuePair<string, int>>();
            foreach (DataRow a in table.Rows)
            {
                issue.Add(new KeyValuePair<string, int>(a[1].ToString(), Convert.ToInt32(a[0])));

            }
            cb_class.DisplayMember = "key";
            cb_class.ValueMember = "value";
            this.cb_class.DataSource = issue;
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_addtopic_Click(object sender, EventArgs e)
        {
            if (tb_stem.Text.Trim() == string.Empty || tb_selectItem_A.Text.Trim() == string.Empty || tb_selectItem_B.Text.Trim() == string.Empty || tb_selectItem_C.Text.Trim() == string.Empty || tb_selectItem_C.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请保证任何一项不可为空 ");
            }

            else if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false)
            {
                MessageBox.Show("请保证答案至少有一项 ");
            }
            else
            {


                DAL.topics dal = new DAL.topics();

                string stem = tb_stem.Text;

                stem += "A." + tb_selectItem_A.Text;
                stem += "B." + tb_selectItem_B.Text;
                stem += "C." + tb_selectItem_C.Text;
                stem += "D." + tb_selectItem_D.Text;






                string TopicAnswer = "";
                int answers = 0;

                foreach (var a in this.tabControl1.TabPages[0].Controls)
                {
                    CheckBox onecheckbox = a as CheckBox;
                    if (onecheckbox != null && onecheckbox.Checked == true)
                    {
                        TopicAnswer += onecheckbox.Text.Substring(0, 2);
                        answers += 1;

                    }
                }



                int cate = Convert.ToInt32(cb_cate.SelectedValue);
                int topiclevel = Convert.ToInt32(cb_level.SelectedValue);

                int topicType = 0;
                if (answers > 1)
                {
                    topicType = 2;

                }
                else
                {
                    topicType = 1;
                }




                if (dal.insert_topics_info(stem, TopicAnswer, cate, topiclevel, topicType, 0) >= 1)
                {

                    MessageBox.Show("添加成功 ");

                }

                this.dgv_topics.DataSource = dal.get_all_topic_info();



            }
        }

        private void tabPage_giveTopiv_Click(object sender, EventArgs e)
        {
        }

        void load_cb_level()
        {
            List<KeyValuePair<string, int>> issue = new List<KeyValuePair<string, int>>();

            issue.Add(new KeyValuePair<string, int>("容易", 1));
            issue.Add(new KeyValuePair<string, int>("较容易", 2));
            issue.Add(new KeyValuePair<string, int>("一般", 3));
            issue.Add(new KeyValuePair<string, int>("较难", 4));
            issue.Add(new KeyValuePair<string, int>("难", 5));
            cb_level.DisplayMember = "key";
            cb_level.ValueMember = "value";
            this.cb_level.DataSource = issue;
        }

        void load_cb_cate()
        {
            DataTable table = Ado.SqlHelper.ExecuteDataTable("SELECT * FROM Cate ");
            List<KeyValuePair<string, int>> issue = new List<KeyValuePair<string, int>>();
            foreach (DataRow a in table.Rows)
            {
                issue.Add(new KeyValuePair<string, int>(a[1].ToString(), Convert.ToInt32(a[0])));

            }
            cb_cate.DisplayMember = "key";
            cb_cate.ValueMember = "value";
            this.cb_cate.DataSource = issue;
        }

        private void tabPage_giveTopiv_Enter(object sender, EventArgs e)
        {
            DAL.topics dal = new DAL.topics();
            this.dgv_topics.DataSource = dal.get_all_topic_info();
            load_cb_level();
            load_cb_cate();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        int selected_id = -1;
        private void dgv_topics_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            selected_id = Convert.ToInt32(dgv_topics.SelectedRows[0].Cells[0].Value);//获取选中id

            DAL.topics dal = new DAL.topics();

            DataRow dt = dal.get_real_topic_info
                (selected_id).Rows[0];
            string[] stems = dt[1].ToString().Split(new string[] { "A.", "B.", "C", "D" }, StringSplitOptions.RemoveEmptyEntries);
            if (stems.Count() == 0)
            {
                tb_stem.Text = "";
                return;
            }
            else
            {
                tb_stem.Text = stems[0];
            }

            if (stems.Count() > 1)
            {
                tb_selectItem_A.Text = stems[1];
            }
            if (stems.Count() > 2)
            {
                tb_selectItem_B.Text = stems[2];
            }
            if (stems.Count() > 3)
            {
                tb_selectItem_C.Text = stems[3];
            }
            if (stems.Count() > 4)
            {
                tb_selectItem_D.Text = stems[4];
            }
            string[] answers = dt[2].ToString().Split(new string[] { "." }, StringSplitOptions.RemoveEmptyEntries);

            if (answers.Contains("A"))
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;

            }
            if (answers.Contains("B"))
            {
                checkBox2.Checked = true;
            }
            else
            {
                checkBox2.Checked = false;

            }
            if (answers.Contains("C"))
            {
                checkBox3.Checked = true;
            }
            else
            {
                checkBox3.Checked = false;

            }
            if (answers.Contains("D"))
            {
                checkBox4.Checked = true;
            }
            else
            {
                checkBox4.Checked = false;

            }
            cb_cate.SelectedValue = Convert.ToInt32(dt[3]);
            cb_level.SelectedValue = Convert.ToInt32(dt[4]);
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if (selected_id != -1)
            {


                if (tb_stem.Text.Trim() == string.Empty || tb_selectItem_A.Text.Trim() == string.Empty || tb_selectItem_B.Text.Trim() == string.Empty || tb_selectItem_C.Text.Trim() == string.Empty || tb_selectItem_C.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("请保证任何一项不可为空 ");
                }

                else if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false)
                {
                    MessageBox.Show("请保证答案至少有一项 ");
                }
                else
                {

                    DAL.topics bll = new DAL.topics();

                    #region 关于文本整理
                    string TopicAnswer = "";
                    int answers = 0;

                    foreach (var a in this.tabControl1.TabPages[0].Controls)
                    {
                        CheckBox onecheckbox = a as CheckBox;
                        if (onecheckbox != null && onecheckbox.Checked == true)
                        {
                            TopicAnswer += onecheckbox.Text.Substring(0, 2);
                            answers += 1;

                        }
                    }



                    int cate = Convert.ToInt32(cb_cate.SelectedValue);
                    int topiclevel = Convert.ToInt32(cb_level.SelectedValue);

                    int topicType = 0;
                    if (answers > 1)
                    {
                        topicType = 2;

                    }
                    else
                    {
                        topicType = 1;
                    }
                    #endregion



                    string stem = tb_stem.Text;

                    stem += "A." + tb_selectItem_A.Text;
                    stem += "B." + tb_selectItem_B.Text;
                    stem += "C." + tb_selectItem_C.Text;
                    stem += "D." + tb_selectItem_D.Text;

                    if (bll.update_topic_info(selected_id, stem, TopicAnswer, cate, topiclevel, topicType, 0) > 0)
                    {
                        MessageBox.Show("修改成功");
                        this.dgv_topics.DataSource = bll.get_all_topic_info();
                    }
                }


            }
            else
            {
                MessageBox.Show("请先单击选中任何行");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (selected_id != -1)
            {

                DAL.topics dal = new DAL.topics();
                dal.delete_topic_info(selected_id);
                this.dgv_topics.DataSource = dal.get_all_topic_info();
            }
            else
            {
                MessageBox.Show("请先单击选中任何行");
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_exam_name.Text))
            {
                Ado.SqlHelper.ExecuteNonQuery(" INSERT INTO ExamList VALUES  ( @ExamName,@ExamClass,@ExamTitles,@ExamTime,@ExamCate,0, 0) ",
                               new SqlParameter("@ExamName", tb_exam_name.Text),
                                 new SqlParameter("@ExamClass", cb_class.SelectedValue),
                                   new SqlParameter("@ExamTitles", ""),
                                         new SqlParameter("@ExamTime", cb_time.SelectedValue),
                                         new SqlParameter("@ExamCate", cb_cate.SelectedValue)
);
                dgv_exam.DataSource = Ado.SqlHelper.ExecuteDataTable(" SELECT * FROM ExamList  WHERE isDel =0  ");


            }
            else
            {
                MessageBox.Show("请先输入考试名称");
            }

        }




        int selected_exam_id = -1;
        int selected_exam_topic_id = -1;
        private void button2_Click_1(object sender, EventArgs e)
        {
            selected_exam_id = Convert.ToInt32(dgv_exam.SelectedRows[0].Cells[0].Value);//获取选中id
            selected_exam_topic_id = Convert.ToInt32(dgv_topics.SelectedRows[0].Cells[0].Value);


            Ado.SqlHelper.ExecuteNonQuery("UPDATE ExamList SET ExamTitles = @ExamTitles WHERE isDel =0 AND ExamID =@ExamID",
    new SqlParameter("@ExamTitles", dgv_exam.SelectedRows[0].Cells[3].Value.ToString() + "," + selected_exam_topic_id.ToString()),
              new SqlParameter("@ExamID", selected_exam_id));
            dgv_exam.DataSource = Ado.SqlHelper.ExecuteDataTable(" SELECT * FROM ExamList  WHERE isDel =0  ");
        }

        private void tabPage_statistic_Click(object sender, EventArgs e)
        {

        }

        private void tabPage_statistic_Enter(object sender, EventArgs e)
        {
            dgv_exam_statistic.DataSource = Ado.SqlHelper.ExecuteDataTable(" SELECT * FROM ExamList  WHERE isDel =0  ");




        }

        private void chart1_Enter(object sender, EventArgs e)
        {

        }

        int exam_statistic_id;
        private void btn_assert_Click(object sender, EventArgs e)
        {
            exam_statistic_id = Convert.ToInt32(dgv_exam_statistic.SelectedRows[0].Cells[0].Value);
            DAL.ExamResult dal = new DAL.ExamResult();

            tb_average.Text = dal.get_ExamResult_statistic_info_avg(exam_statistic_id).Rows[0][0].ToString();
            tb_highest.Text = dal.get_ExamResult_statistic_info_max(exam_statistic_id).Rows[0][0].ToString();
            tb_last.Text = dal.get_ExamResult_statistic_info_min(exam_statistic_id).Rows[0][0].ToString();
            tb_oknumber.Text = dal.get_ExamResult_statistic_info(exam_statistic_id, 100, 60).Rows[0][0].ToString();
            chart();
        }


        void chart()
        {
            chart_exam.Series.Clear();


            DAL.ExamResult dal = new DAL.ExamResult();
            Series Strength = new Series("人数");
            Strength.Points.AddXY("60以下", Convert.ToInt32(dal.get_ExamResult_statistic_info(exam_statistic_id, 60, 0).Rows[0][0]));
            Strength.Points.AddXY("60-70", Convert.ToInt32(dal.get_ExamResult_statistic_info(exam_statistic_id, 60, 0).Rows[0][0]));
            Strength.Points.AddXY("70-80", Convert.ToInt32(dal.get_ExamResult_statistic_info(exam_statistic_id, 80, 70).Rows[0][0]));
            Strength.Points.AddXY("80-90", Convert.ToInt32(dal.get_ExamResult_statistic_info(exam_statistic_id, 90, 80).Rows[0][0]));
            Strength.Points.AddXY("90-100", Convert.ToInt32(dal.get_ExamResult_statistic_info(exam_statistic_id, 100, 90).Rows[0][0]));
            chart_exam.Series.Add(Strength);

        }

        private void tp_cate_Enter(object sender, EventArgs e)
        {
            dgv_cate.DataSource = Ado.SqlHelper.ExecuteDataTable("SELECT * FROM Cate");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_cate_name.Text))
            {
                Ado.SqlHelper.ExecuteNonQuery("insert into Cate values(@CateName)", new SqlParameter("@CateName", tb_cate_name.Text));

            }


            dgv_cate.DataSource = Ado.SqlHelper.ExecuteDataTable("SELECT * FROM Cate");
        }

        //private void charshow()
        //{
        //    DAL.dal dal = new DAL.dal();
        //    chart1.Series.Clear();
        //    string t = dal.get_subjectnum(subject).Rows[0][0].ToString();
        //    object a1 = dal.get_fennum("0", "60", t).Rows[0][0];
        //    object b1 = dal.get_fennum("60", "70", t).Rows[0][0];
        //    object c1 = dal.get_fennum("70", "80", t).Rows[0][0];
        //    object d1 = dal.get_fennum("80", "90", t).Rows[0][0];
        //    object e1 = dal.get_fennum("90", "100", t).Rows[0][0];

        //    Series Strength = new Series("人数");
        //    Strength.Points.AddXY("60以下", a);
        //    Strength.Points.AddXY("60-70", b);
        //    Strength.Points.AddXY("70-80", c);
        //    Strength.Points.AddXY("80-90", d);
        //    Strength.Points.AddXY("90-100", e);
        //    chart1.Series.Add(Strength);
        //}//显示图表

    }
}
