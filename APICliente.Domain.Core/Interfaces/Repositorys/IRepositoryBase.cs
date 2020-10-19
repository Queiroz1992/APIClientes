using System;
using System.Collections.Generic;
using System.Text;

namespace APICliente.Domain.Core.Interfaces.Repositorys
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Adicionar(TEntity obj);
        
        TEntity ObterPorId(int id);
        
        IEnumerable<TEntity> ObterTodos();
        
        void Atualizar(TEntity obj);
        
        void Excluir(TEntity obj);
        
        void Dispose();
    }
}
