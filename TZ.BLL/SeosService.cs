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
    public class SeosService
    {
        private SeosManager seosm=new SeosManager();
        public int AddSeos(Seos seos)
        {
            return seosm.AddSeos(seos);
        }

        public int EditSeos(Seos seos)
        {
            return seosm.EditSeos(seos);
        }

        public int PutTrash(Guid id)
        {
            return seosm.PutTrash(id);
        }

        public int RemoveSeos(Guid id)
        {
            return seosm.RemoveSeos(id);
        }

        public List<Seos> GetAll()
        {
            return seosm.GetAll();
        }

        public Seos GetSeosById(Guid id)
        {
            return seosm.GetSeosById(id);
        }

        public List<Seos> GetSeosByTitle(string title)
        {
            return seosm.GetSeosByTitle(title);
        }
    }
}
