using RestApiDecomposeNumber.Domain.Core.Interfaces.Repositorys;
using RestApiDecomposeNumber.Domain.Core.Interfaces.Services;
using RestApiDecomposeNumber.Domain.Entitys;

namespace RestApiDecomposeNumber.Domain.Services
{
    public class ServiceUser : ServiceBase<User>, IServiceUser
    {
        private readonly IRepositoryUser repositoryUser;

        public ServiceUser(IRepositoryUser repositoryUser) : base(repositoryUser)
        {
            this.repositoryUser = repositoryUser;
        }
    }
}
