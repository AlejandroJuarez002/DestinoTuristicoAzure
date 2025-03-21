using Ardalis.Specification;
using ExploreSV.Entities;

namespace ExploreSV.BusinessLogic.UseCases.Gastronomies.Specifications
{
    public class GetGastronomyWithTouristDestinationSpec : Specification<Gastronomy>
    {
        public GetGastronomyWithTouristDestinationSpec()
        {
            Query.Include(td => td.TouristDestination);
        }
    }
}
