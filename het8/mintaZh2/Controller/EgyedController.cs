using mintaZh2.DAO;
using mintaZh2.Model;

namespace mintaZh2.Controller
{
    public class EgyedController
    {
        private readonly IEgyed dao;
        public EgyedController(IEgyed dao)
        {
            this.dao = dao;
        }
        public bool AddEgyed(Egyed egyed)
        {
            return dao.AddEgyed(egyed);
        }
        public bool ModifyEgyed(Egyed egyed)
        {
            return dao.ModifyEgyed(egyed);
        }
        public IEnumerable<Egyed> GetEgyeds()
        {
            return dao.GetEgyeds();
        }
    }
}
