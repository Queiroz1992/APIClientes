using APICliente.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace APICliente.Domain.Core.Interfaces.Services
{
    public interface IServiceEndereco 
    {
        void Adicionar(Endereco endereco);

        Endereco ObterPorId(int id);

        IEnumerable<Endereco> ObterTodos();

        void Atualizar(Endereco endereco);

        void Excluir(Endereco endereco);
    }
}
