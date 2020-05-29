using CQRSPattern.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRSPattern.Domain.Interfaces.Repositories
{
    public interface IBookRepository
    {
        Task<bool> Create(Book book);
        Task<IEnumerable<Book>> GetBooksByYear(int year);
    }
}
