using APICliente.Application.DTO.DTO;
using APICliente.Domain.Models;
using APICliente.Infrastructure.CrossCutting.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace APICliente.Infrastructure.CrossCutting.Adapter.Map
{
    public class MapperClientes : IMapperCliente
    {
        #region propriedades
        
        List<ClienteDTO> clienteDTOs = new List<ClienteDTO>();

        #endregion

        #region metodos

        public Cliente MapeadorPorEntidade(ClienteDTO clienteDTO)
        {
            Cliente cliente = new Cliente
            {
                Id = clienteDTO.Id
                ,
                Nome = clienteDTO.Nome
                ,
                DataNascimento = clienteDTO.DataNascimento
                ,
                Idade = clienteDTO.Idade               
            };

            return cliente;
        }

        public IEnumerable<ClienteDTO> MapeadorListaClientes(IEnumerable<Cliente> clientes)
        {
            foreach (var cliente in clientes)
            {
                ClienteDTO clienteDTO = new ClienteDTO
                {
                    Id = cliente.Id
                    , 
                    Nome = cliente.Nome
                    , 
                    DataNascimento = cliente.DataNascimento
                    , 
                    Idade = cliente.Idade
                };

                clienteDTOs.Add(clienteDTO);
            }

            return clienteDTOs;
        }

        public ClienteDTO MapeadorPorDTO(Cliente cliente)
        {
            ClienteDTO clienteDTO = new ClienteDTO
            {
                Id = cliente.Id
                , 
                Nome = cliente.Nome
                , 
                DataNascimento = cliente.DataNascimento
                , 
                Idade = cliente.Idade
            };

            return clienteDTO;
        }

        #endregion

    }
}
