using DTT.BookStore.Core.Interfaces;
using DTT.BookStore.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTT.BookStore.Core.Services
{
    public class PayloadService : BaseService<Payload>, IPayloadService
    {
        IPayloadRepository _payloadRepository;
        public PayloadService(IPayloadRepository payloadRepository) : base(payloadRepository)
        {
            _payloadRepository = payloadRepository;
        }
    }
}
