using AspBeginner_Tutorial.Data;
using AspBeginner_Tutorial.Models.Domain;

namespace AspBeginner_Tutorial.Repositories
{
    public class RegionRespository : IRegionRespository
    {
        private readonly AppDbContext _db;
        public RegionRespository(AppDbContext db)
        {
            _db = db;
        }
        public IEnumerable<Region> GetAll()
        {
            return _db.Regions;

        }
    }
}
