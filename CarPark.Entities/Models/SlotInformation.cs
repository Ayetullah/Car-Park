using System.Collections.Generic;

namespace CarPark.Entities.Models
{
    public class SlotInformation : BaseModel
    {
        public ICollection<Translation> Translations { get; set; }
    }
}
