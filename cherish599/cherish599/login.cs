using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace huodong
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //1.获取数据
            //从TextBox中获取用户输入信息
            string userName = this.txtUserName.Text;
            string userPassword = this.txtPassword.Text;

            //2. 验证数据
            // 验证用户输入是否为空，若为空，提示用户信息
            if (userName.Equals("") || userPassword.Equals(""))
            {
                MessageBox.Show("用户名或密码不能为空！");
            }
            // 若不为空，验证用户名和密码是否与数据库匹配
            // 这里只做字符串对比验证

            else
            {
                //用户名和密码验证正确，提示成功，并执行跳转界面。
                if (userName.Equals("13281835198") && userPassword.Equals("123456"))
                {
                    MessageBox.Show("登录成功！");

                    this.DialogResult = DialogResult.OK;
                    this.Dispose();
                    this.Close();
                }
                //用户名和密码验证错误，提示错误。
                else
                {
                    MessageBox.Show("用户名或密码错误！");
                }
            }

            //3. 处理数据
        }

        private string Notes1 = "请输入手机号";
        private string Notes2 = "请输入登录密码";
        private void txtUserName_Enter(object sender, EventArgs e)
        {
            //  进入时，清空
            if (txtUserName.Text == Notes1)
                this.txtUserName.Text = "";
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            //  退出时，重新显示
            if (string.IsNullOrEmpty(txtUserName.Text))
                this.txtUserName.Text = Notes1;
        }

        private void Login_Load(object sender, EventArgs e)
        {

            txtUserName.Text = Notes1;
            txtPassword.Text = Notes2;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            //  进入时，清空
            if (txtPassword.Text == Notes2)
                this.txtPassword.Text = "";
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            //  退出时，重新显示
            if (string.IsNullOrEmpty(txtPassword.Text))
                this.txtUserName.Text = Notes2;
        }
    }
}

