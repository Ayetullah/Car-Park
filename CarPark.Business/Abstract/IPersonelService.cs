using CarPark.Core.Models;
using CarPark.Entities.Models;

namespace CarPark.Business.Abstract
{
    public interface IPersonelService
    {
        GetManyResult<Personel> GetPersonelsByAge();
    }
}
