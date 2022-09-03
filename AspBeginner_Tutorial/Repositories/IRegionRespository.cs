using AspBeginner_Tutorial.Models.Domain;

namespace AspBeginner_Tutorial.Repositories
{
    public interface IRegionRespository
    {
        IEnumerable<Region> GetAll();
    }
}
