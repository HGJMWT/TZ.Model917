using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TZ.BLL;
using Wuqi.Webdiyer;

namespace TZ.WebApp917.Admins.Users
{
    public partial class Users_List : System.Web.UI.Page
    {
        private UsersService usersSvc = new UsersService();
        private RolesService rolesSvc =new RolesService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            Bind("");
        }

        public string GetRolesName(Guid id)
        {
            return rolesSvc.GetRolesById(id).Roles_Title;
        }
        public void Bind(string title)
        {
            var list = usersSvc.GetAll();
            PagedDataSource pds = new PagedDataSource();
            pds.DataSource = list;
            pds.AllowPaging = true;
            pds.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1; 
            pds.PageSize = AspNetPager1.PageSize;
            AspNetPager1.RecordCount = list.Count;
            this.RepUsersList.DataSource = usersSvc.GetAll();
            this.RepUsersList.DataBind();
        }
        protected void AspNetPager1_OnPageChanging(object src, PageChangingEventArgs e)
        {
            AspNetPager1.CurrentPageIndex = e.NewPageIndex;
            Bind(this.txtSearch.Text);
        }

        protected void btnSearch_OnClick(object sender, EventArgs e)
        {
            Bind(this.txtSearch.Text);
        }
    }
}