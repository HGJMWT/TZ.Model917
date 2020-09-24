using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ApplicationServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using TZ.BLL;

namespace TZ.WebApp917.Admins.Roles
{
    public partial class Roles_List : System.Web.UI.Page
    {
        private RolesService rolesSvc =new RolesService();
        protected void Page_Load(object sender, EventArgs e)
        {
                if(IsPostBack)
                    return;
                var list = rolesSvc.GetAll();
                this.RepRolesList.DataSource = list;
                this.RepRolesList.DataBind();
        }
    }
}