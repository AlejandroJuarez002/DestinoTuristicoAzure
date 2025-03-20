using ExploreSV.BusinessLogic.DTOs;
using ExploreSV.Entities;
using Mapster;

namespace ExploreSV.BusinessLogic.Mappings
{
    public class MappingRegister : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<TouristDestination, TouristDestinationResponse>()
                .Map(tdd => tdd.CategoryName, td => td.Category.CategoryName)
                .Map(tdd => tdd.DepartmentName, td => td.Department.DepartamentName);
            
            config.NewConfig<Gastronomy, GastronomyResponse>()
                .Map(gd => gd.TouristDestinationTitle, g => g.TouristDestination.TouristDestinationTitle);

            //config.NewConfig<Event, EventResponse>()
                //.Map(ed => ed.TouristDestinationTitle, e => e.TouristDestination.TouristDestinationTitle);
        }
    }
}