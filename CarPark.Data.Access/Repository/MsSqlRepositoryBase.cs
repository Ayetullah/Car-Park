using CarPark.Core.Models;
using CarPark.Core.Repository.Abstract;
using CarPark.Data.Access.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CarPark.Data.Access.Repository
{
    public class MsSqlRepositoryBase<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {
        private readonly MsSqlDbContext _context;

        public MsSqlRepositoryBase(MsSqlDbContext context)
        {
            _context = context;
        }

        #region GetAll
        public GetManyResult<TEntity> GetAll()
        {
            var result = new GetManyResult<TEntity>();
            try
            {
                var data = _context.Set<TEntity>().ToList();
                if(data.Any())
                {
                    result.Entities = data;
                }
            }
            catch (Exception ex)
            {
                result.Message = $"AsQueryable {ex.Message}";
                result.Success = false;
                result.Entities = null;
            }

            return result;
        }

        public async Task<GetManyResult<TEntity>> GetAllAsync()
        {
            var result = new GetManyResult<TEntity>();
            try
            {
                var data = await _context.Set<TEntity>().ToListAsync();
                if (data.Any())
                {
                    result.Entities = data;
                }
            }
            catch (Exception ex)
            {
                result.Message = $"AsQueryableAsync {ex.Message}";
                result.Success = false;
                result.Entities = null;
            }

            return result;
        }
        #endregion

        #region FilterBy
        public GetManyResult<TEntity> FilterBy(Expression<Func<TEntity, bool>> filter)
        {
            var result = new GetManyResult<TEntity>();
            try
            {
                var data = _context.Set<TEntity>().Where(filter).ToList();
                if (data.Any())
                {
                    result.Entities = data;
                }
            }
            catch (Exception ex)
            {
                result.Message = $"FilterBy {ex.Message}";
                result.Success = false;
                result.Entities = null;
            }

            return result;
        }

        public async Task<GetManyResult<TEntity>> FilterByAsync(Expression<Func<TEntity, bool>> filter)
        {
            var result = new GetManyResult<TEntity>();
            try
            {
                var data = await _context.Set<TEntity>().Where(filter).ToListAsync();
                if (data.Any())
                {
                    result.Entities = data;
                }
            }
            catch (Exception ex)
            {
                result.Message = $"FilterByAsync {ex.Message}";
                result.Success = false;
                result.Entities = null;
            }

            return result;
        }
        #endregion

        #region GetById
        public GetOneResult<TEntity> GetById(Guid id)
        {
            var result = new GetOneResult<TEntity>();
            try
            {
                var data = _context.Set<TEntity>().Find(id);
                if (data != null)
                {
                    result.Entity = data;
                }
            }
            catch (Exception ex)
            {
                result.Message = $"GetById {ex.Message}";
                result.Success = false;
                result.Entity = null;
            }

            return result;
        }

        public async Task<GetOneResult<TEntity>> GetByIdAsync(Guid id)
        {
            var result = new GetOneResult<TEntity>();
            try
            {
                var data = await _context.Set<TEntity>().FindAsync(id);
                if (data != null)
                {
                    result.Entity = data;
                }
            }
            catch (Exception ex)
            {
                result.Message = $"GetByIdAsync {ex.Message}";
                result.Success = false;
                result.Entity = null;
            }

            return result;
        }
        #endregion

        #region InsertOne
        public GetOneResult<TEntity> InsertOne(TEntity entity)
        {
            var result = new GetOneResult<TEntity>();
            try
            {
                _context.Set<TEntity>().Add(entity);
                _context.SaveChanges();
                result.Entity = entity;
            }
            catch (Exception ex)
            {
                result.Message = $"InsertOne {ex.Message}";
                result.Success = false;
                result.Entity = null;
            }

            return result;
        }

        public async Task<GetOneResult<TEntity>> InsertOneAsync(TEntity entity)
        {
            var result = new GetOneResult<TEntity>();
            try
            {
                await _context.Set<TEntity>().AddAsync(entity);
                await _context.SaveChangesAsync();
                result.Entity = entity;
            }
            catch (Exception ex)
            {
                result.Message = $"InsertOneAsync {ex.Message}";
                result.Success = false;
                result.Entity = null;
            }

            return result;
        }
        #endregion

        #region InsertMany
        public GetManyResult<TEntity> InsertMany(ICollection<TEntity> entity)
        {
            var result = new GetManyResult<TEntity>();
            try
            {
                _context.Set<TEntity>().AddRange(entity);
                _context.SaveChanges();
                result.Entities = entity;
            }
            catch (Exception ex)
            {
                result.Message = $"InsertMany {ex.Message}";
                result.Success = false;
                result.Entities = null;
            }

            return result;
        }

        public async Task<GetManyResult<TEntity>> InsertManyAsync(ICollection<TEntity> entity)
        {
            var result = new GetManyResult<TEntity>();
            try
            {
                await _context.Set<TEntity>().AddRangeAsync(entity);
                await _context.SaveChangesAsync();
                result.Entities = entity;
            }
            catch (Exception ex)
            {
                result.Message = $"InsertManyAsync {ex.Message}";
                result.Success = false;
                result.Entities = null;
            }

            return result;
        }
        #endregion

        #region ReplaceOne
        // Düzenleme gerekebilir
        public GetOneResult<TEntity> ReplaceOne(TEntity entity, Guid id)
        {
            var result = new GetOneResult<TEntity>();
            try
            {
                var data = _context.Set<TEntity>().Find(id);
                if (data != null)
                {
                    data = entity;
                    _context.Update(entity);
                    _context.SaveChanges();
                    result.Entity = data;
                }
            }
            catch (Exception ex)
            {
                result.Message = $"ReplaceOne {ex.Message}";
                result.Success = false;
                result.Entity = null;
            }

            return result;
        }

        public async Task<GetOneResult<TEntity>> ReplaceOneAsync(TEntity entity, Guid id)
        {
            var result = new GetOneResult<TEntity>();
            try
            {
                var data = await _context.Set<TEntity>().FindAsync(id);
                if (data != null)
                {
                    data = entity;
                    _context.Update(entity);
                    await _context.SaveChangesAsync();
                    result.Entity = data;
                }
            }
            catch (Exception ex)
            {
                result.Message = $"ReplaceOne {ex.Message}";
                result.Success = false;
                result.Entity = null;
            }

            return result;
        }
        #endregion

        #region DeleteOne
        public GetOneResult<TEntity> DeleteOne(Expression<Func<TEntity, bool>> filter)
        {
            var result = new GetOneResult<TEntity>();
            try
            {
                var data = _context.Set<TEntity>().FirstOrDefault(filter);
                if (data == null)
                {
                    result.Entity = data;
                }

                _context.Set<TEntity>().Remove(data);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                result.Message = $"DeleteOne {ex.Message}";
                result.Success = false;
                result.Entity = null;
            }

            return result;
        }

        public async Task<GetOneResult<TEntity>> DeleteOneAsync(Expression<Func<TEntity, bool>> filter)
        {
            var result = new GetOneResult<TEntity>();
            try
            {
                var data = await _context.Set<TEntity>().FirstOrDefaultAsync(filter);
                if (data == null)
                {
                    result.Entity = data;
                }

                _context.Set<TEntity>().Remove(data);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                result.Message = $"DeleteOneAsync {ex.Message}";
                result.Success = false;
                result.Entity = null;
            }

            return result;
        }
        #endregion

        #region DeleteMany
        public GetManyResult<TEntity> DeleteMany(Expression<Func<TEntity, bool>> filter)
        {
            var result = new GetManyResult<TEntity>();
            try
            {
                var data = _context.Set<TEntity>().Where(filter).ToList();
                if (!data.Any())
                {
                    result.Entities = data;
                }

                _context.Set<TEntity>().RemoveRange(data);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                result.Message = $"DeleteMany {ex.Message}";
                result.Success = false;
                result.Entities = null;
            }

            return result;
        }

        public async Task<GetManyResult<TEntity>> DeleteManyAsync(Expression<Func<TEntity, bool>> filter)
        {
            var result = new GetManyResult<TEntity>();
            try
            {
                var data = await _context.Set<TEntity>().Where(filter).ToListAsync();
                if (!data.Any())
                {
                    result.Entities = data;
                }

                _context.Set<TEntity>().RemoveRange(data);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                result.Message = $"DeleteManyAsync {ex.Message}";
                result.Success = false;
                result.Entities = null;
            }

            return result;
        }
        #endregion

        #region DeleteById
        public GetOneResult<TEntity> DeleteById(Guid id)
        {
            var result = new GetOneResult<TEntity>();
            try
            {
                var data = _context.Set<TEntity>().Find(id);
                if (data == null)
                {
                    result.Entity = data;
                }

                _context.Set<TEntity>().Remove(data);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                result.Message = $"DeleteById {ex.Message}";
                result.Success = false;
                result.Entity = null;
            }

            return result;
        }

        public async Task<GetOneResult<TEntity>> DeleteByIdAsync(Guid id)
        {
            var result = new GetOneResult<TEntity>();
            try
            {
                var data = await _context.Set<TEntity>().FindAsync(id);
                if (data == null)
                {
                    result.Entity = data;
                }

                _context.Set<TEntity>().Remove(data);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                result.Message = $"DeleteByIdAsync {ex.Message}";
                result.Success = false;
                result.Entity = null;
            }

            return result;
        }
        #endregion
    }
}