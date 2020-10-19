using APICliente.Domain.Core.Interfaces.Repositorys;
using APICliente.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace APICliente.Domain.Services.Services
{
    public abstract class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> Repository)
        {
            _repository = Repository;
        }

        public virtual void Adicionar(TEntity obj)
        {
            _repository.Adicionar(obj);
        }

        public virtual void Atualizar(TEntity obj)
        {
            _repository.Atualizar(obj);
        }

        public virtual void Excluir(TEntity obj)
        {
            _repository.Excluir(obj);
        }

        public virtual void Dispose()
        {
            _repository.Dispose();
        }

        public virtual TEntity ObterPorId(int id)
        {
            return _repository.ObterPorId(id);
        }

        public virtual IEnumerable<TEntity> ObterTodos()
        {
            return _repository.ObterTodos();
        }
    }
}
