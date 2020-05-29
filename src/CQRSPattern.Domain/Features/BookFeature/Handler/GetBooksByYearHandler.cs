using CQRSPattern.Domain.Common;
using CQRSPattern.Domain.Entities;
using CQRSPattern.Domain.Features.TransactionFeature.Query;
using CQRSPattern.Domain.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSPattern.Domain.Features.TransactionFeature.Handler
{
    public class GetBooksByYearHandler : IRequestHandler<GetBooksByYearQuery, HandlerResult<IEnumerable<Book>>>
    {
        private readonly IBookRepository _repository;

        public GetBooksByYearHandler(IBookRepository repository)
        {
            _repository = repository;
        }

        public async Task<HandlerResult<IEnumerable<Book>>> Handle(GetBooksByYearQuery request, CancellationToken cancellationToken)
        {
            var handlerResult = new HandlerResult<IEnumerable<Book>>();


            try
            {
                handlerResult.Data = await _repository.GetBooksByYear(request.Year);
            }
            catch (Exception e)
            {
                handlerResult.AddError(e.Message);
            }

            return handlerResult;
        }
    }
}
