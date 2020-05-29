using System;

namespace CQRSPattern.Domain.Entities
{
    public class Book
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public int Year { get; set; }
    }
}
