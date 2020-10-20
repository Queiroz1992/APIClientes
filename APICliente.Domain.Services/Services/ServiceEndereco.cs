using APICliente.Domain.Core.Interfaces.Repositorys;
using APICliente.Domain.Core.Interfaces.Services;
using APICliente.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace APICliente.Domain.Services.Services
{
    public class ServiceEndereco : IServiceEndereco
    {
        private readonly IRepositoryEndereco _repository;

        public ServiceEndereco(IRepositoryEndereco Repository)
        {
            _repository = Repository;
        }

        public void Adicionar(Endereco endereco)
        {
            _repository.Adicionar(endereco);
        }

        public void Atualizar(Endereco endereco)
        {
            _repository.Atualizar(endereco);
        }

        public void Excluir(Endereco endereco)
        {
            _repository.Excluir(endereco);
        }

        public Endereco ObterPorId(int id)
        {
            return _repository.ObterPorId(id);
        }

        public IEnumerable<Endereco> ObterTodos()
        {
            return _repository.ObterTodos();
        }
    }
}
