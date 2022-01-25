using DTT.BookStore.Core.Interfaces;
using DTT.BookStore.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTT.BookStore.Core.Services
{
    public class StorageService : BaseService<Storage>, IStorageService
    {
        IStorageRepository _storageRepository;
        public StorageService(IStorageRepository storageRepository) : base(storageRepository)
        {
            _storageRepository = storageRepository;
        }

        public IEnumerable<int> getAmountInstorage(ParamBook_Id param)
        {
            return _storageRepository.getAmountInstorage(param);
        }
    }
}
