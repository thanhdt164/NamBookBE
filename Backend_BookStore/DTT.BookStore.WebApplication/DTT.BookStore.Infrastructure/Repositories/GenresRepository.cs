using DTT.BookStore.Core.Interfaces;
using DTT.BookStore.Core.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTT.BookStore.Infrastructure.Repositories
{
    public class GenresRepository : BaseRepository<Genres>, IGenresRepository
    {
        #region Declare
        #endregion
        #region Constructor
        public GenresRepository(IConfiguration configuration):base(configuration) { }
        #endregion
    }
}
