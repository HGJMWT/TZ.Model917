using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TZ.BLL;

namespace TZ.WebApp917.Admins.Roles
{
    public partial class Roles_Edit : System.Web.UI.Page
    {
        private RolesService rolesSvc = new RolesService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack)
                return;
            Bind();
        }

        private void Bind()
        {
            var id = Request.Params["action"] != null ? Guid.Parse(Request.Params["action"]) : Guid.Empty;
            if(id==Guid.Empty)
                Response.Write("<script>alert('数据丢失')；location.href='Roles_List.aspx'<.script>");
            var data = rolesSvc.GetRolesById(id);
            this.txtId.Text = data.Id.ToString();
            this.txtName.Text = data.Roles_Title;
        }

        protected void BtnSubmit_OnClick(object sender, EventArgs e)
        {
            var name = this.txtName.Text.Trim();
            Model917.Roles role = new Model917.Roles()
            {
                Id = Guid.Parse(this.txtId.Text),
                Roles_Title = name
            };
            var res = rolesSvc.EditRoles(role);
            if (res > 0)
            {
                Response.Write("<script>alert('修改成功');location.href='Roles_List.aspx'</script>");
            }
            else
            {
                Response.Write("<script>alert('修改失败');location.href='Roles_List.aspx'</script>");
            }
        }

        protected void BtnReset_OnClick(object sender, EventArgs e)
        {
            Bind();
        }
    }
}