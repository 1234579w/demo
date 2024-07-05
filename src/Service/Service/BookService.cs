using Repository.Model;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public  class BookService
    {
        private readonly BookRepository _bookRepository;

        public BookService(BookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public async Task<List<Book>> GetBookListAsync()
        {
            return await _bookRepository.GetBookListAsync();
        }
    }
}
