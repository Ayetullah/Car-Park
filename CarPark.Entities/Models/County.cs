namespace CarPark.Entities.Models
{
    public class County : BaseModel
    {
        public string Name { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string PostCode { get; set; }
    }
}
