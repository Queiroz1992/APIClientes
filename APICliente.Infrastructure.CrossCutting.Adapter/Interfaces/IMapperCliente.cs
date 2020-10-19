using APICliente.Application.DTO.DTO;
using APICliente.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace APICliente.Infrastructure.CrossCutting.Adapter.Interfaces
{
    public interface IMapperCliente
    {
        #region Mappers

        Cliente MapeadorPorEntidade(ClienteDTO clienteDTO);

        IEnumerable<ClienteDTO> MapeadorListaClientes(IEnumerable<Cliente> clientes);

        ClienteDTO MapeadorPorDTO(Cliente cliente);

        #endregion
    }
}
