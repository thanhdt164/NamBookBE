using DTT.BookStore.Core.Interfaces;
using DTT.BookStore.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTT.BookStore.Core.Services
{
    public class PublisherService : BaseService<Publisher>, IPublisherService
    {
        IPublisherRepository _publisherRepository;
        public PublisherService(IPublisherRepository publisherRepository) : base(publisherRepository)
        {
            _publisherRepository = publisherRepository;
        }
    }
}
