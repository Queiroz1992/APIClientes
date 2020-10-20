
using APICliente.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace APICliente.Domain.Core.Interfaces.Repositorys
{
    public interface IRepositoryCliente 
    {
        void Adicionar(Cliente cliente);

        Cliente ObterPorId(int id);

        IEnumerable<Cliente> ObterTodos();

        void Atualizar(Cliente cliente);

        void Excluir(int id);

    }
}
