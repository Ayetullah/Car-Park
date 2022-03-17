using System.Collections.Generic;

namespace CarPark.Entities.Models
{
    public class FloorInformation : BaseModel
    {
        public int Number { get; set; }
        public ICollection<SlotInformation> Slots { get; set; }
    }
}
