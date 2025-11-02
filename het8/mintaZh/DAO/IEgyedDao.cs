using mintaZh.Model;

namespace mintaZh.DAO
{
    public interface IEgyedDao
    {
        bool AddEged(Egyed egyed);
        bool ModifyEgyed(Egyed egyed);
        IEnumerable<Egyed> GetEgyeds();





        decimal? GetAverageWeightBySpeciesAndGender(string species, string gender);
    }
}
