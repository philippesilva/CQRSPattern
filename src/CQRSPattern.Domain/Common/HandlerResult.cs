using System.Collections.Generic;
using System.Linq;

namespace CQRSPattern.Domain.Common
{
    public class HandlerResult<T>
    {
        public bool Successfully => !_errors.Any();

        private readonly IList<string> _errors = new List<string>();
        public IEnumerable<string> Errors => _errors;
        public T Data { get; set; }

        public void SetData(T data)
        {
            Data = data;
        }

        public void AddError(string message)
        {
            _errors.Add(message);
        }
    }
}
