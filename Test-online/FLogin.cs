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
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {



        }

        public string stuNumber;

        private void btnOK_Click(object sender, EventArgs e)
        {





            BLL.login bll = new BLL.login();

            bool type;
            if (cb_user_type.SelectedIndex == 0)
            {
                type = true;//教师

            }
            else
            {
                type = false;//管理员

            }
            switch (bll.check_user_info(tBName.Text, tBPwd.Text, type))
            {
                case Common.LogState.None:
                    MessageBox.Show("用户不存在");
                    break;

                case Common.LogState.adminSuccess:
                    MessageBox.Show("管理员登陆成功");
                    this.DialogResult = DialogResult.OK;//标记为管理员登录
                    stuNumber = tBName.Text;
                    break;
                case Common.LogState.teacherSuccess:
                    MessageBox.Show("教师登陆成功");
                    this.DialogResult = DialogResult.Abort;//标记为教师登录
                    stuNumber = tBName.Text;
                    break;
                case Common.LogState.PwdErr:
                    MessageBox.Show("密码错误");
                    break;
                default:
                    break;
            }

        }

        private void FLogin_Load(object sender, EventArgs e)
        {
            cb_user_type.SelectedIndex = 0;

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            //FRegister fr = new FRegister();
            //fr.ShowDialog();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tBName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
