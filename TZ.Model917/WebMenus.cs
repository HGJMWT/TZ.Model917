using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TZ.Model917
{
    public class WebMenus:BaseEntity
    {
        public String WebMenus_Title { get; set; }
        public String WebMenus_Link { get; set; }
        public Guid WebMenus_ParentId { get; set; }= Guid.NewGuid();
        public String WebMenus_Icon { get; set; }
    }
}
