
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class AnnouncementDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public int CityId { get; set; }
        public string? CityName { get; set; }
        public string? Description { get; set; }
        public string ContactInformation { get; set; }
        public decimal Price { get; set; }
        public string SellerName { get; set; }
        public string ImageUrl { get; set; }
    }
}
