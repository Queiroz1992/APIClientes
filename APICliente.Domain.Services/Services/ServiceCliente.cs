using APICliente.Domain.Core.Interfaces.Repositorys;
using APICliente.Domain.Core.Interfaces.Services;
using APICliente.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace APICliente.Domain.Services.Services
{
    public class ServiceCliente : IServiceCliente
    {
        private readonly IRepositoryCliente _repository;

        public ServiceCliente(IRepositoryCliente Repository)
        {
            _repository = Repository;
        }

        public void Adicionar(Cliente cliente)
        {
            _repository.Adicionar(cliente);
        }

        public void Atualizar(Cliente cliente)
        {
            _repository.Atualizar(cliente);
        }

        public void Excluir(int id)
        {
            _repository.Excluir(id);
        }

        public Cliente ObterPorId(int id)
        {
            return _repository.ObterPorId(id);
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            return _repository.ObterTodos();
        }
    }
}
