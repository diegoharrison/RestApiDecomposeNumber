using Autofac;
using AutoMapper;
using RestApiDecomposeNumber.Application;
using RestApiDecomposeNumber.Application.Interfaces;
using RestApiDecomposeNumber.Domain.Core.Interfaces.Repositorys;
using RestApiDecomposeNumber.Domain.Core.Interfaces.Services;
using RestApiDecomposeNumber.Domain.Services;
using RestApiDecomposeNumber.Infrastructure.Data.Repositorys;
using RestApiModeloDDD.Application;
using RestApiModeloDDD.Application.Interfaces;
using RestApiModeloDDD.Application.Mappers;
using RestApiModeloDDD.Domain.Core.Interfaces.Repositorys;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using RestApiModeloDDD.Domain.Services;
using RestApiModeloDDD.Infrastructure.Data.Repositorys;

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
            builder.Register(ctx => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DtoToModelMappingUser());
                cfg.AddProfile(new ModelToDtoMappingUser());
                cfg.AddProfile(new DtoToModelMappingNumber());
                cfg.AddProfile(new ModelToDtoMappingNumber());

            }));

            builder.Register(ctx => ctx.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>().InstancePerLifetimeScope();
        }

        #endregion IOC
    }

}