using CQRSPattern.Domain.Common;
using CQRSPattern.Domain.Entities;
using CQRSPattern.Domain.Features.BookFeature.Command;
using CQRSPattern.Domain.Interfaces.Repositories;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSPattern.Domain.Features.BookFeature.Handler
{
    public class CreateNewBookHandler : IRequestHandler<CreateNewBookCommand, HandlerResult<Book>>
    {
        private readonly IBookRepository _repository;

        public CreateNewBookHandler(IBookRepository repository)
        {
            _repository = repository;
        }

        public async Task<HandlerResult<Book>> Handle(CreateNewBookCommand request, CancellationToken cancellationToken)
        {
            var handlerResult = new HandlerResult<Book>();


            try
            {
                var book = new Book
                {
                    Id = request.Id,
                    Title = request.Title,
                    Year = request.Year
                };

                var result = await _repository.Create(book);

                if (result)
                {
                    handlerResult.Data = book;

                    return handlerResult;
                }

            }
            catch (Exception e)
            {
                handlerResult.AddError(e.Message);
            }

            return handlerResult;
        }
    }
}
