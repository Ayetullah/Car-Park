using CarPark.Business.Abstract;
using CarPark.Core.Models;
using CarPark.Data.Access.Abstract;
using CarPark.Entities.Models;
using System;
using System.Collections.Generic;

namespace CarPark.Business.Concrete
{
    public class PersonelManager : IPersonelService
    {
        private readonly IPersonelDataAccess _personelDataAccess;
        public PersonelManager(IPersonelDataAccess personelDataAccess)
        {
            _personelDataAccess = personelDataAccess;
        }
        public GetManyResult<Personel> GetPersonelsByAge()
        {
            var personels = _personelDataAccess.GetAll();
            return personels;
        }
    }
}
