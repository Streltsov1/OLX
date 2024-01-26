﻿namespace OLX.Data.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Announcement>? Announcements { get; set; }
    }
}
