using APICliente.Application.DTO.DTO;
using APICliente.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace APICliente.Infrastructure.CrossCutting.Adapter.Interfaces
{
    public interface IMapperEndereco
    {
        #region

        Endereco MapeadorPorEntidade(EnderecoDTO enderecoDTO);

        IEnumerable<EnderecoDTO> MapeadorListaEnderecos(IEnumerable<Endereco> enderecos);

        EnderecoDTO MapeadorPorDTO(Endereco endereco);

        #endregion
    }
}
