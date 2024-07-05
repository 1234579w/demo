using Repository.Model;
using Repository.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public  class BookRepository
    {
        public async Task <List<Book>> GetBookListAsync()
        {
            return await SqlSugarHelper.Db.Queryable<Book>()
                .Where(x=>x.IsDeleted!=true)
                .ToListAsync();
        }

    }
}
