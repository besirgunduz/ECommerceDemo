using AutoMapper;
using ECommerceDemo.Business.Engines.Interfaces;
using ECommerceDemo.Core.Entities;
using ECommerceDemo.Core.Repository;
using ECommerceDemo.Core.UnitOfWork;
using ECommerceDemo.Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ECommerceDemo.Business.Engines.Implementations
{
    public class BaseService<TModel, TEntity> : IBaseService<TModel, TEntity>
        where TModel : BaseModel
        where TEntity : BaseEntity
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<TEntity> _repository;
        private readonly IMapper _mapper;

        public BaseService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _repository = _unitOfWork.GetRepository<TEntity>();
            _mapper = mapper;
        }
        public IResult Add(TModel entity)
        {
            try
            {
                _repository.Add(_mapper.Map<TEntity>(entity));
                _unitOfWork.SaveChanges();
                return new SuccessResult("Added");
            }
            catch (Exception ex)
            {
                return new ErrorResult($"Error:{ex.Message}");
            }
        }

        public IResult Delete(TModel entity)
        {
            try
            {
                _repository.Delete(_mapper.Map<TEntity>(entity));
                _unitOfWork.SaveChanges();
                return new SuccessResult("Deleted");
            }
            catch (Exception ex)
            {

                return new ErrorResult($"Error:{ex.Message}");
            }
        }

        public IResult DeleteById(int id)
        {
            try
            {
                _repository.Delete(id);
                _unitOfWork.SaveChanges();
                return new SuccessResult("Deleted");
            }
            catch (Exception ex)
            {

                return new ErrorResult($"Error:{ex.Message}");
            }
        }

        public IDataResult<List<TModel>> GetAll()
        {
            try
            {
                var entities = _repository.GetAll().Select(x => _mapper.Map<TModel>(x)).ToList();
                return new SuccessDataResult<List<TModel>>(entities, "Listed");
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<List<TModel>>($"Error:{ex.Message}");

            }
        }

        public IDataResult<TModel> GetById(int id)
        {
            try
            {
                var result = _mapper.Map<TEntity, TModel>(_repository.GetById(id));
                return new SuccessDataResult<TModel>(result, "Listed");
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<TModel>($"Error:{ex.Message}");
            }

        }

        public IResult Update(TModel entity)
        {
            try
            {
                _repository.Update(_mapper.Map<TEntity>(entity));
                _unitOfWork.SaveChanges();
                return new SuccessResult("Updated");
            }
            catch (Exception ex)
            {
                return new ErrorResult($"Error:{ex.Message}");
            }

        }
    }
}
