using CQRSPattern.Domain.Common;
using CQRSPattern.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace CQRSPattern.Domain.Features.TransactionFeature.Query
{
    public class GetBooksByYearQuery : IRequest<HandlerResult<IEnumerable<Book>>>
    {
        public int Year { get; set; }
        public GetBooksByYearQuery(int year)
        {
            Year = year;
        }
    }
}
