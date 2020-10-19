using APICliente.Application.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace APICliente.Application.Interfaces
{
    public interface IApplicationServiceEndereco
    {
        void Adicionar(EnderecoDTO obj);

        EnderecoDTO ObterPorId(int id);

        IEnumerable<EnderecoDTO> ObterTodos();

        void Atualizar(EnderecoDTO obj);

        void Excluir(EnderecoDTO obj);

        void Dispose();
    }
}
