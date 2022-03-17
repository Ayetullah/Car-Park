using System.Collections.Generic;

namespace CarPark.Entities.Models
{
    public class WorkingHour
    {
        public ICollection<Translation> Translations { get; set; }
    }
}
