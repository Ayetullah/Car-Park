using CarPark.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CarPark.Core.Repository.Abstract
{
    public interface IRepository<TEntity> where TEntity: class, new()
    {
        #region GetAll
        GetManyResult<TEntity> GetAll();
        Task<GetManyResult<TEntity>> GetAllAsync();
        #endregion

        #region FilterBy
        GetManyResult<TEntity> FilterBy(Expression<Func<TEntity, bool>> filter);
        Task<GetManyResult<TEntity>> FilterByAsync(Expression<Func<TEntity, bool>> filter);
        #endregion

        #region GetById
        GetOneResult<TEntity> GetById(Guid id);
        Task<GetOneResult<TEntity>> GetByIdAsync(Guid id);
        #endregion

        #region InsertOne
        GetOneResult<TEntity> InsertOne(TEntity entity);
        Task<GetOneResult<TEntity>> InsertOneAsync(TEntity entity);
        #endregion

        #region InsertMany
        GetManyResult<TEntity> InsertMany(ICollection<TEntity> entity);
        Task<GetManyResult<TEntity>> InsertManyAsync(ICollection<TEntity> entity);
        #endregion

        #region Update
        GetOneResult<TEntity> ReplaceOne(TEntity entity, Guid id);
        Task<GetOneResult<TEntity>> ReplaceOneAsync(TEntity entity, Guid id);
        #endregion

        #region DeleteOne
        GetOneResult<TEntity> DeleteOne(Expression<Func<TEntity, bool>> filter);
        Task<GetOneResult<TEntity>> DeleteOneAsync(Expression<Func<TEntity, bool>> filter);
        #endregion

        #region DeleteMany
        GetManyResult<TEntity> DeleteMany(Expression<Func<TEntity, bool>> filter);
        Task<GetManyResult<TEntity>> DeleteManyAsync(Expression<Func<TEntity, bool>> filter);
        #endregion

        #region DeleteById
        GetOneResult<TEntity> DeleteById(Guid id);
        Task<GetOneResult<TEntity>> DeleteByIdAsync(Guid id);
        #endregion
    }
}
