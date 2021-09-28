using RestApiDecomposeNumber.Domain.Core.Interfaces.Repositorys;
using RestApiDecomposeNumber.Domain.Entitys;

namespace RestApiDecomposeNumber.Infrastructure.Data.Repositorys
{
    public class RepositoryUser : RepositoryBase<User>, IRepositoryUser 
    {
        private readonly SqlContext sqlContext;

        public RepositoryUser(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
