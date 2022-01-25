using DTT.BookStore.Core.Interfaces;
using DTT.BookStore.Core.ServiceResult;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTT.BookStore.Core.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity>
    {
        IBaseRepository<TEntity> _baseRepository;
        DTTServiceResult _serviceResult;

        public BaseService(IBaseRepository<TEntity> baseRepository)
        {
            _baseRepository = baseRepository;
            _serviceResult = new DTTServiceResult();
        }
        public IEnumerable<TEntity> GetAll()
        {
            return _baseRepository.GetAll();
        }

        public TEntity GetById(int entityId)
        {
            return _baseRepository.GetById(entityId);
        }

        public virtual DTTServiceResult Insert(TEntity entity)
        {    
            var isValidate = Validation(entity);
            if (isValidate)
            {
                _serviceResult.ResultData = null;
                _serviceResult.ResultCode = Enum.DTTCode.Failure;
                _serviceResult.ResultMessage = "Thêm dữ liệu thất bại.";
                try
                {
                    var rowAffects = _baseRepository.Insert(entity);
                    _serviceResult.ResultData = rowAffects;
                    _serviceResult.ResultCode = Enum.DTTCode.Success;
                    _serviceResult.ResultMessage = "Thêm dữ liệu thành công.";
                }
                catch (Exception e)
                {
                    //
                }
            }
            else
            {
                _serviceResult.ResultData = null;
                _serviceResult.ResultCode = Enum.DTTCode.NotValid;
                _serviceResult.ResultMessage = "Lỗi dữ liệu.";
            }
            return _serviceResult;
        }

        public virtual DTTServiceResult Update(TEntity entity)
        {
            var isValidate = Validation(entity);
            if (isValidate)
            {
                _serviceResult.ResultData = null;
                _serviceResult.ResultCode = Enum.DTTCode.Failure;
                _serviceResult.ResultMessage = "Cập nhật dữ liệu thất bại.";
                try
                {
                    var rowAffects = _baseRepository.Update(entity);
                    _serviceResult.ResultData = rowAffects;
                    _serviceResult.ResultCode = Enum.DTTCode.Success;
                    _serviceResult.ResultMessage = "Cập nhật dữ liệu thành công.";
                }
                catch (Exception e)
                {
                    //
                }
            }
            else
            {
                _serviceResult.ResultData = null;
                _serviceResult.ResultCode = Enum.DTTCode.IsValid;
                _serviceResult.ResultMessage = "Lỗi dữ liệu.";
            }
            return _serviceResult;
        }

        public virtual DTTServiceResult Delete(int entityId)
        {
            var rowAffects = _baseRepository.Delete(entityId);
            _serviceResult.ResultData = rowAffects;
            _serviceResult.ResultCode = Enum.DTTCode.Success;
            _serviceResult.ResultMessage = "Xóa dữ liệu thành công.";
            if(rowAffects == 0)
            {
                _serviceResult.ResultMessage = "Không có bản ghi nào được xóa.";
            }
            return _serviceResult;
        }

        /// <summary>
        /// Hàm validate dữ liệu
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Validation(TEntity entity)
        {
            return true;
        }

    }
}
