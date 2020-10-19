using APICliente.Domain.Core.Interfaces.Repositorys;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace APICliente.Infrastruture.Repository.Repositorys
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        IConfiguration _configuration;

        public virtual void Adicionar(TEntity obj)
        {
            
        }

        public virtual TEntity ObterPorId(int id)
        {

        }

        public virtual IEnumerable<TEntity> ObterTodos()
        {

        }

        public virtual void Atualizar(TEntity obj)
        {
            
        }

        public void Excluir(TEntity obj)
        {

        }

        public virtual void Dispose()
        {
            
        }    
    }
}
