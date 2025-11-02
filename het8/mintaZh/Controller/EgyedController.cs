using mintaZh.DAO;
using mintaZh.Model;

namespace mintaZh.Controller
{
    public class EgyedController
    {
        private readonly IEgyedDao dao;

        public EgyedController(IEgyedDao dao) 
        {
            this.dao = dao;
        }

        public bool AddEged(Egyed egyed)
        {

            decimal? avgWeight = dao.GetAverageWeightBySpeciesAndGender(egyed.Species, egyed.Gender);


            // Ha nincs még ilyen adat az adatbázisban, engedjük hozzáadni
            if (avgWeight == null)
                return dao.AddEged(egyed);

            decimal minAllowed = avgWeight.Value * 0.9m;
            decimal maxAllowed = avgWeight.Value * 1.1m;

            if (egyed.Weigh < minAllowed || egyed.Weigh > maxAllowed)
            {
                // eltér az átlagtól 10%-nál jobban → nem engedjük
                MessageBox.Show(
                    $"A(z) {egyed.Species} ({egyed.Gender}) átlagtömege {avgWeight:F1}, " +
                    $"de a megadott tömeg {egyed.Weigh}. Ez kívül esik a 10%-os határon.",
                    "Hiba",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return false;
            }

            return dao.AddEged(egyed);
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
