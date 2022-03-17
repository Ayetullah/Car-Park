using System.Collections.Generic;

namespace CarPark.Entities.Models
{
    public class WorkingDay : BaseModel
    {
        public ICollection<Translation> Translations { get; set; }
        public ICollection<WorkingHour> WorkingHours { get; set; }
    }
}
