using CQRSPattern.Domain.Entities;
using CQRSPattern.Domain.Interfaces.Repositories;
using CQRSPattern.Infra.Repositories.Common;
using Dapper;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace CQRSPattern.Infra.Repositories
{
    public class BookRepository : Repository, IBookRepository
    {
        public BookRepository(DbConnection connection) : base(connection)
        {

        }

        public async Task<bool> Create(Book book)
        {
            var rows = await Connection.ExecuteAsync("INSERT INTO Book VALUES (@Id, @Title, @Year)", book);

            return rows > 0;
        }

        public async Task<IEnumerable<Book>> GetBooksByYear(int year)
        {
            return await Connection.QueryAsync<Book>("SELECT * FROM [Book] WHERE Year = @Year", new { Year = year });
        }
    }
}
