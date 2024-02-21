using BusinessLogic.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IAnnouncementService
    {
        IEnumerable<AnnouncementDto> GetAll();
        IEnumerable<AnnouncementDto> Get(IEnumerable<int> ids);
        AnnouncementDto? Get(int id);
        int GetCount();
        IEnumerable<CategoryDto> GetAllCategories();
        IEnumerable<CityDto> GetAllCities();
        void Create(CreateAnnouncementModel model);
        void Edit(EditAnnouncementModel model);
        void Delete(int id);
    }
}
