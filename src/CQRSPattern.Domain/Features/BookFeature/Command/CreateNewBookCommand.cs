using CQRSPattern.Domain.Common;
using CQRSPattern.Domain.Entities;
using MediatR;
using System;

namespace CQRSPattern.Domain.Features.BookFeature.Command
{
    public class CreateNewBookCommand : IRequest<HandlerResult<Book>>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public CreateNewBookCommand(Guid id, string title, int year)
        {
            Id = id;
            Title = title;
            Year = year;
        }
    }
}
