using System.Data.Common;

namespace CQRSPattern.Infra.Repositories.Common
{
    public class Repository
    {
        public readonly DbConnection Connection;

        public Repository(DbConnection connection)
        {
            Connection = connection;
        }
    }
}
