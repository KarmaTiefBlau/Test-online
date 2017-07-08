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

namespace Test_online
{
    public partial class FRunTest : Form
    {

        public int ExamId;
        public string stuNumber;
        KeyValuePair<string, string>[] stuAnswers;
        int type;//记录当前问题的类型
        string topic_stem;
        public FRunTest()
        {
            InitializeComponent();
        }

        private void FRunTest_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FRunTest_Load(object sender, EventArgs e)
        {
            DataTable dt = Ado.SqlHelper.ExecuteDataTable("SELECT  ExamID as 考试编号,ExamName as 考试名称, CateName as 考试科目,ExamClass as 考试班级, ExamTitles,CreateDate as 开始时间, ExamTime as 考试时长 FROM ExamList join Cate on CateID = ExamCate WHERE ExamClass = (SELECT  StuClass from StuLogin WHERE StuNumber =@StuNumber)", new SqlParameter("@StuNumber", this.stuNumber));
            string titles = dt.Rows[0][4].ToString();
            string[] titlesArray = titles.Split(','); //表明是哪些题目；
            stuAnswers = new KeyValuePair<string, string>[titlesArray.Count()];//用来存储学生的答案

            List<KeyValuePair<string, int>> list = new List<KeyValuePair<string, int>>();
            int i = 1;
            foreach (var a in titlesArray)
            {
                list.Add(new KeyValuePair<string, int>("第" + i + "题", Convert.ToInt32(a)));
                i++;

            }

            clb_title.DataSource = list;


        }

        private void clb_title_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<string, int> item = (KeyValuePair<string, int>)(clb_title.SelectedValue);
            DataTable dt_topic = new BLL.topics().get_topic_info(item.Value);


            type = Convert.ToInt32(dt_topic.Rows[0][6]);

            #region 多选题
            if (type == 2)//多选题
            {


                List<string> answers = dt_topic.Rows[0][1].ToString().Split(new string[] { "A.", "B.", "C.", "D.", "A,", "B,", "C,", "D," }, StringSplitOptions.RemoveEmptyEntries).ToList();
                while (answers.Count < 5)
                {

                    answers.Add(" ");
                }
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                checkBox3.Visible = true;
                checkBox4.Visible = true;

                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;


                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;


                label_topic_title.Text = answers[0];
                topic_stem = answers[0];
                checkBox1.Text = "A" + answers[1];
                checkBox2.Text = "B" + answers[2];
                checkBox3.Text = "C" + answers[3];

                checkBox4.Text = "D" + answers[4];


            }
            #endregion

            #region 单选题
            if (type == 1)//多选题
            {

                List<string> answers = dt_topic.Rows[0][1].ToString().Split(new string[] { "A.", "B.", "C.", "D.", "A,", "B,", "C,", "D," }, StringSplitOptions.RemoveEmptyEntries).ToList();
                while (answers.Count < 5)
                {

                    answers.Add(" ");
                }

                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;

                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;


                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                checkBox4.Visible = false;

                label_topic_title.Text = answers[0];
                topic_stem = answers[0];

                this.stuAnswers[clb_title.SelectedIndex] = new KeyValuePair<string, string>(answers[0], "");
                radioButton1.Text = "A" + answers[1];
                radioButton2.Text = "B" + answers[2];
                radioButton3.Text = "C" + answers[3];

                radioButton4.Text = "D" + answers[4];
            }
            #endregion






        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_last_topic_Click(object sender, EventArgs e)
        {
            if (clb_title.SelectedIndex > 0)
            {


                clb_title.SelectedIndex = clb_title.SelectedIndex - 1;
            }
            else
            {

                MessageBox.Show("没有上一题啦");
            }

        }

        private void btn_next_topic_Click(object sender, EventArgs e)
        {
            if (clb_title.SelectedIndex < clb_title.Items.Count - 1)
            {


                clb_title.SelectedIndex = clb_title.SelectedIndex + 1;
            }
            else
            {

                MessageBox.Show("没有下一题啦");
            }

        }

        private void btn_ascert_Click(object sender, EventArgs e)
        {

            this.clb_title.SetItemChecked(clb_title.SelectedIndex, true);

            string temp = " ";



            if (type == 1)//单选
            {
                foreach (var a in this.Controls)
                {
                    RadioButton oneRadioButton = a as RadioButton;
                    if (oneRadioButton != null && oneRadioButton.Checked == true)
                    {
                        temp = "" + oneRadioButton.Text.Substring(0, 1);


                    }
                    this.stuAnswers[this.clb_title.SelectedIndex] = new KeyValuePair<string, string>(topic_stem, temp);
                }
            }

            else if (type == 2)//多选
            {
                foreach (var a in this.Controls)
                {
                    CheckBox onecheckbox = a as CheckBox;
                    if (onecheckbox != null && onecheckbox.Checked == true)
                    {
                        temp = "" + onecheckbox.Text.Substring(0, 1);


                    }
                    this.stuAnswers[this.clb_title.SelectedIndex] = new KeyValuePair<string, string>(topic_stem, temp);
                }
            }

            #region 下一题
            if (clb_title.SelectedIndex < clb_title.Items.Count - 1)
            {


                clb_title.SelectedIndex = clb_title.SelectedIndex + 1;
            }
            else
            {

                MessageBox.Show("没有下一题啦");
            }
            #endregion


        }
    }
}
