namespace OLX.Data.Entities
{
    public class Announcement
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string City { get; set; }
        public string? Description { get; set; }
        public string ContactInformation { get; set; }
        public decimal Price { get; set; }
        public string SellerName { get; set; }
    }
}
