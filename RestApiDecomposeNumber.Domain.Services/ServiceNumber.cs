using RestApiDecomposeNumber.Domain.Core.Interfaces.Repositorys;
using RestApiDecomposeNumber.Domain.Core.Interfaces.Services;
using RestApiDecomposeNumber.Domain.Entitys;

namespace RestApiDecomposeNumber.Domain.Services
{
    public class ServiceNumber : ServiceBase<Number>, IServiceNumber
    {
        private readonly IRepositoryNumber repositoryNumber;

        public ServiceNumber(IRepositoryNumber repositoryNumber) : base(repositoryNumber)
        {
            this.repositoryNumber = repositoryNumber;
        }
    }
}
