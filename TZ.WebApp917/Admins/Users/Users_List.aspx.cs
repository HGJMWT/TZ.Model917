using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TZ.BLL;

namespace TZ.WebApp917.Admins.Users
{
    public partial class Users_List : System.Web.UI.Page
    {
        private UsersService usersSvc = new UsersService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            var list = usersSvc.GetAll();
            this.RepUsersList.DataSource = list;
            this.RepUsersList.DataBind();
        }
    }
}