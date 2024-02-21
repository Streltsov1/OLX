using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.DTOs;

namespace BusinessLogic.Interfaces
{
    public interface IFavoriteService
    {
        IEnumerable<AnnouncementDto> GetAnnouncements();
        IEnumerable<int> GetAnnouncementIds();
        void Add(int id);
        void Remove(int id);
        int GetCount();
        bool IsExists(int id);
    }
}
