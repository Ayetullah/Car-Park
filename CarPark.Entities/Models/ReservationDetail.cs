using System;

namespace CarPark.Entities.Models
{
    public class ReservationDetail
    {
        public Guid SlootId { get; set; }
        public Guid FloorId { get; set; }
        public Guid CarParkId { get; set; }
    }
}
