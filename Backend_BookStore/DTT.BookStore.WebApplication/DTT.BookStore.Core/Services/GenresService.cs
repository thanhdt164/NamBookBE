using DTT.BookStore.Core.Interfaces;
using DTT.BookStore.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTT.BookStore.Core.Services
{
    public class GenresService : BaseService<Genres>, IGenresService
    {
        #region Declare
        IGenresRepository _genresRepository;
        #endregion
        #region Constructor
        public GenresService(IGenresRepository genresRepository) : base(genresRepository)
        {
            _genresRepository = genresRepository;
        }
        #endregion
    }
}
