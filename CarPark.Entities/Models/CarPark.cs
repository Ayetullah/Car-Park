using System.Collections.Generic;

namespace CarPark.Entities.Models
{
    public class CarPark : BaseModel
    {
        public string Name { get; set; }
        public string[] PhoneNumbers { get; set; }
        public Address Address { get; set; }
        public string[] Personels { get; set; }
        public string webSite { get; set; }
        public string[] EmailAddresses { get; set; }
        public ICollection<WorkingDay> WorkingDays { get; set; }
        public ICollection<FloorInformation> Floors { get; set; }
    }
}
