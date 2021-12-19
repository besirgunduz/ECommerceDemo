using ECommerceDemo.Core.Entities;
using ECommerceDemo.Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ECommerceDemo.Business.Engines.Interfaces
{
    public interface IBaseService<TModel, TEntity>
        where TModel : BaseModel
        where TEntity : BaseEntity
    {

        IDataResult<List<TModel>> GetAll();
        IDataResult<TModel> GetById(int id);
        IResult Add(TModel model);
        IResult Update(TModel model);
        IResult Delete(TModel model);
        IResult DeleteById(int id);

    }
}
