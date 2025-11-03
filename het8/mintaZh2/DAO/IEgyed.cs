using mintaZh2.Model;

namespace mintaZh2.DAO
{
    public interface IEgyed
    {
        bool AddEgyed (Egyed egyed);
        bool ModifyEgyed(Egyed egyed);
        IEnumerable<Egyed> GetEgyeds();
    }
}
