using APICliente.Application.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace APICliente.Application.Interfaces
{
    public interface IApplicationServiceCliente
    {
        void Adicionar(ClienteDTO obj);

        ClienteDTO ObterPorId(int id);

        IEnumerable<ClienteDTO> ObterTodos();

        void Atualizar(ClienteDTO obj);

        void Excluir(ClienteDTO obj);
    }
}
