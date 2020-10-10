using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TZ.Model917
{
    public class SystemMenus: BaseEntity
    {
        public String SystemMenus_Title { get; set; }
        public String SystemMenus_Link { get; set; }
        public Guid SystemMenus_ParentId { get; set; }=Guid.NewGuid();
        public String SystemMenus_Icon { get; set; }
    }
}
