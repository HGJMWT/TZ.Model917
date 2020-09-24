using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TZ.BLL;

namespace TZ.WebApp917.Admins.Roles
{
    public partial class Roles_Add : System.Web.UI.Page
    {
        private RolesService rolesSvc =new RolesService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack)
                return;
        }
           protected void BtnSubmit_OnClick(object sender, EventArgs e)
           {
               var name = this.txtName.Text.Trim();

               var roles = new Model917.Roles()
               {
                   Roles_Title = name
               };

               var res = rolesSvc.AddRoles(roles);
               if (res > 0)
               {
                   Response.Write("<script>alert('添加成功');location.href='Roles_List.aspx'</script>");
               }
               else
               {
                   Response.Write("<script>alert('添加失败');location.href='Roles_List.aspx'</script>");
                }
           }

           protected void BtnReset_OnClick(object sender, EventArgs e)
           {
               this.txtName.Text = "";
           }
    }
}