using DTT.BookStore.Core.ServiceResult;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTT.BookStore.Core.Interfaces
{
    public interface IBaseService<TEntity>
    {
        /// <summary>
        /// Lấy toàn bộ dữ liệu
        /// (Created by: thanhdt - 01.05.2021)
        /// </summary>
        /// <returns></returns>
        IEnumerable<TEntity> GetAll();

        /// <summary>
        /// Lấy dữ liệu theo Id
        /// (Created by: thanhdt - 01.05.2021)
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        TEntity GetById(int entityId);

        /// <summary>
        /// Thêm dữ liệu
        /// (Created by: thanhdt - 01.05.2021)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        DTTServiceResult Insert(TEntity entity);

        /// <summary>
        /// Cập nhật dữ liệu
        /// (Created by: thanhdt - 01.05.2021)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        DTTServiceResult Update(TEntity entity);

        /// <summary>
        /// Xóa dữ liệu
        /// (Created by: thanhdt - 01.05.2021)
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        DTTServiceResult Delete(int entityId);
    }
}
