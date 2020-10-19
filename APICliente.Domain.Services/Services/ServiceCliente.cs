using APICliente.Domain.Core.Interfaces.Repositorys;
using APICliente.Domain.Core.Interfaces.Services;
using APICliente.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace APICliente.Domain.Services.Services
{
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {
        public readonly IRepositoryCliente _repositoryCliente;

        public ServiceCliente(IRepositoryCliente RepositoryCliente)
            : base(RepositoryCliente)
        {
            _repositoryCliente = RepositoryCliente;
        }
    }
}
