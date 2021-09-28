using RestApiDecomposeNumber.Domain.Core.Interfaces.Repositorys;
using RestApiDecomposeNumber.Domain.Entitys;

namespace RestApiDecomposeNumber.Infrastructure.Data.Repositorys
{
    public class RepositoryNumber : RepositoryBase<Number>, IRepositoryNumber
    {
        private readonly SqlContext sqlContext;

        public RepositoryNumber(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
