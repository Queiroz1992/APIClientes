using APICliente.Application.Interfaces;
using APICliente.Application.Service;
using APICliente.Domain.Core.Interfaces.Repositorys;
using APICliente.Domain.Core.Interfaces.Services;
using APICliente.Domain.Services.Services;
using APICliente.Infrastructure.CrossCutting.Adapter.Interfaces;
using APICliente.Infrastructure.CrossCutting.Adapter.Map;
using APICliente.Infrastruture.Repository.Repositorys;
using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace APICliente.InfrastrutureCrossCutting.IOC
{
    public class ConfigurationIOC
    {

        public static void Load(ContainerBuilder builder)
        {
            #region Registra IOC

            #region IOC Application
            builder.RegisterType<ApplicationServiceCliente>().As<IApplicationServiceCliente>();
            builder.RegisterType<ApplicationServiceEndereco>().As<IApplicationServiceEndereco>();
            #endregion

            #region IOC Services
            builder.RegisterType<ServiceCliente>().As<IServiceCliente>();
            builder.RegisterType<IServiceEndereco>().As<IServiceEndereco>();
            #endregion

            #region IOC Repositorys SQL
            builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
            builder.RegisterType<RepositoryEndereco>().As<IRepositoryEndereco>();
            #endregion

            #region IOC Mapper
            builder.RegisterType<MapperCliente>().As<IMapperCliente>();
            builder.RegisterType<MapperEndereco>().As<IMapperEndereco>();
            #endregion

            #endregion
        }

    }
}
