using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TZ.BLL;

namespace TZ.WebApp917.Admins.Users
{
    public partial class Users_Edit : System.Web.UI.Page
    {
        private UsersService usersSvc = new UsersService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            Bind();
        }
        private void Bind()
        {
            var id = Request.Params["action"] != null ? Guid.Parse(Request.Params["action"]) : Guid.Empty;
            if (id == Guid.Empty)
                Response.Write("<script>alert('数据丢失')；location.href='Users_List.aspx'<.script>");
            var data = usersSvc.GetUsersById(id);
            this.txtId.Text = data.Id.ToString();
            this.txtAccount.Text = data.Users_Account;
            this.txtPassword.Text = data.Users_Password;
            this.txtNickName.Text = data.Users_NickName;
            this.txtPhoto.Text = data.Users_Photo;
            this.txtRolesId.Text = data.Users_RolesId.ToString();
        }

        protected void BtnSubmit_OnClick(object sender, EventArgs e)
        {
            var Account = this.txtAccount.Text.Trim();
            var Password = this.txtPassword.Text.Trim();
            var NickName = this.txtNickName.Text.Trim();
            var Photo = this.txtPhoto.Text.Trim();
            var RolesId = this.txtRolesId.Text.Trim();
            Model917.Users user = new Model917.Users()
            {
                Id = Guid.Parse(this.txtId.Text),
                Users_Account = Account,
                Users_Password = Password,
                Users_NickName = NickName,
                Users_Photo = Photo,
                Users_RolesId = Guid.Parse(RolesId)
            };
            var res = usersSvc.EditUsers(user);
            if (res > 0)
            {
                Response.Write("<script>alert('修改成功');location.href='Users_List.aspx'</script>");
            }
            else
            {
                Response.Write("<script>alert('修改失败');location.href='Users_List.aspx'</script>");
            }
        }

        protected void BtnReset_OnClick(object sender, EventArgs e)
        {
            Bind();
        }
    }
}