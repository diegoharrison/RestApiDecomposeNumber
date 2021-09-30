using Autofac;
using AutoMapper;
using RestApiDecomposeNumber.Application;
using RestApiDecomposeNumber.Application.Interfaces;
using RestApiDecomposeNumber.Application.Interfaces.Mappers;
using RestApiDecomposeNumber.Application.Mappers;
using RestApiDecomposeNumber.Domain.Core.Interfaces.Repositorys;
using RestApiDecomposeNumber.Domain.Core.Interfaces.Services;
using RestApiDecomposeNumber.Domain.Services;
using RestApiDecomposeNumber.Infrastructure.Data.Repositorys;

namespace RestApiModeloDDD.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServiceUser>().As<IApplicationServiceUser>();
            builder.RegisterType<ApplicationServiceNumber>().As<IApplicationServiceNumber>();
            builder.RegisterType<ServiceUser>().As<IServiceUser>();
            builder.RegisterType<ServiceNumber>().As<IServiceNumber>();
            builder.RegisterType<RepositoryUser>().As<IRepositoryUser>();
            builder.RegisterType<RepositoryNumber>().As<IRepositoryNumber>();
            builder.RegisterType<MapperUser>().As<IMapperUser>();
            builder.RegisterType<MapperNumber>().As<IMapperNumber>();            
        }

        #endregion IOC
    }

}