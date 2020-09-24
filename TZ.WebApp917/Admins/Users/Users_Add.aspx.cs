using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TZ.BLL;

namespace TZ.WebApp917.Admins.Users
{
    public partial class Users_Add : System.Web.UI.Page
    {
        private UsersService usersSvc =new UsersService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
        }

        protected void BtnSubmit_OnClick(object sender, EventArgs e)
        {
            var account = this.txtAccount.Text.Trim();
            var password = this.txtPassword.Text.Trim();
            var nickname = this.txtNickName.Text.Trim();
            var photo = this.txtPhoto.Text.Trim();
            var rolesid = this.txtRolesId.Text.Trim();

            var users=new Model917.Users()
            {
                Users_Account=account,
                Users_Password=password,
                Users_NickName = nickname,
                Users_Photo = photo,
                Users_RolesId = new Guid(rolesid)
            };

            var res = usersSvc.AddUsers(users);
            if (res > 0)
            {
                Response.Write("<script>alert('添加成功');location.href='Users_List.aspx'</script>");
            }
            else
            {
                Response.Write("<script>alert('添加失败');location.href='Users_List.aspx'</script>");
            }
        }

        protected void BtnReset_OnClick(object sender, EventArgs e)
        {
            this.txtAccount.Text = "";
            this.txtPassword.Text = "";
            this.txtNickName.Text = "";
            this.txtPhoto.Text = "";
            this.txtRolesId.Text = "";
        }
    }
}