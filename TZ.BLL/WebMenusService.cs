using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TZ.DAL;
using TZ.Model917;

namespace TZ.BLL
{
    public class WebMenusService
    {
        private WebMenusManager wm=new WebMenusManager();
        public int AddWebMenus(WebMenus webMenus)
        {
            return wm.AddWebMenus(webMenus);
        }

        public int EditWebMenus(WebMenus webMenus)
        {
            return wm.EditWebMenus(webMenus);
        }

        public int PutTrash(Guid id)
        {
            return wm.PutTrash(id);
        }

        public int RemoveWebMenus(Guid id)
        {
            return wm.RemoveWebMenus(id);
        }

        public List<WebMenus> GetAll()
        {
            return wm.GetAll();
        }

        public WebMenus GetWebMenusById(Guid id)
        {
            return wm.GetWebMenusById(id);
        }

        public List<WebMenus> GetWebMenusByTitle(string title)
        {
            return wm.GetWebMenusByTitle(title);
        }
    }
}
