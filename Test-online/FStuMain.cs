using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Test_online
{
    public partial class FStuMain : Form
    {
        public string stuNumber;
        public FStuMain()
        {
            InitializeComponent();
        }

        private void FStuMain_Load(object sender, EventArgs e)
        {
            
            dgv_examList.DataSource = Ado.SqlHelper.ExecuteDataTable(" SELECT  ExamID as 考试编号,ExamName as 考试名称, CateName as 考试科目,ExamClass as 考试班级, CreateDate as 开始时间, ExamTime as 考试时长 FROM ExamList join Cate on CateID = ExamCate WHERE ExamClass = (SELECT  StuClass from StuLogin WHERE StuNumber =@StuNumber)", new SqlParameter("@StuNumber", this.stuNumber));
        }

        private void btn_text_Click(object sender, EventArgs e)
        {
            FRunTest faj = new FRunTest();
            if (dgv_examList.SelectedRows.Count >= 1)
            {
                faj.ExamId = Convert.ToInt32(dgv_examList.SelectedRows[0].Cells[0].Value);
                faj.stuNumber = this.stuNumber;
                faj.ShowDialog();
            }
            else {

                MessageBox.Show("未选中任何项");

                    }


        }

        private void dgv_examList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
