using System;

namespace CarPark.Entities.Models
{
    public class Address : BaseModel
    {
        public Guid CountyId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
