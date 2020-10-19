using APICliente.Domain.Core.Interfaces.Repositorys;
using APICliente.Domain.Core.Interfaces.Services;
using APICliente.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace APICliente.Domain.Services.Services
{
    public class ServiceEndereco : ServiceBase<Endereco>, IServiceEndereco
    {
        private readonly IRepositoryEndereco _repositoryEndereco;

        public ServiceEndereco(IRepositoryEndereco RepositoryEndereco)
            : base(RepositoryEndereco)
        {
            _repositoryEndereco = RepositoryEndereco;   
        }
    }
}
