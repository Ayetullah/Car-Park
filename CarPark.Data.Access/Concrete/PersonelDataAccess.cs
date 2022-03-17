using CarPark.Data.Access.Abstract;
using CarPark.Data.Access.Context;
using CarPark.Data.Access.Repository;
using CarPark.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarPark.Data.Access.Concrete
{
    public class PersonelDataAccess : MsSqlRepositoryBase<Personel>, IPersonelDataAccess
    {
        private readonly MsSqlDbContext _context;
        public PersonelDataAccess(MsSqlDbContext context) : base(context)
        {
            _context = context;
        }

    }
}
