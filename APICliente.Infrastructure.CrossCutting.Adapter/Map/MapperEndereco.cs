using APICliente.Application.DTO.DTO;
using APICliente.Domain.Models;
using APICliente.Infrastructure.CrossCutting.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace APICliente.Infrastructure.CrossCutting.Adapter.Map
{
    public class MapperEndereco : IMapperEndereco
    {
        #region Propriedades

        List<EnderecoDTO> enderecoDTOs = new List<EnderecoDTO>();

        #endregion

        #region Metodos
        public Endereco MapeadorPorEntidade(EnderecoDTO enderecoDTO)
        {
            Endereco endereco = new Endereco
            {
                EnderecoId = enderecoDTO.EnderecoId
                , 
                Logradouro = enderecoDTO.Logradouro
                ,
                Bairro = enderecoDTO.Bairro
                ,
                Cidade = enderecoDTO.Cidade                     
                ,
                Estado = enderecoDTO.Estado
            };

            return endereco;
        }

        public IEnumerable<EnderecoDTO> MapeadorListaEnderecos(IEnumerable<Endereco> enderecos)
        {
            foreach (var  endereco in enderecos)
            {
                EnderecoDTO enderecoDTO = new EnderecoDTO
                {
                    EnderecoId = endereco.EnderecoId
                    , 
                    Logradouro = endereco.Logradouro
                    , 
                    Bairro = endereco.Bairro
                    , 
                    Cidade = endereco.Cidade
                    ,
                    Estado = endereco.Estado
                };

                enderecoDTOs.Add(enderecoDTO);
            }

            return enderecoDTOs;
        }

        public EnderecoDTO MapeadorPorDTO(Endereco endereco)
        {
            EnderecoDTO enderecoDTO = new EnderecoDTO
            {
                EnderecoId = endereco.EnderecoId
                , 
                Logradouro = endereco.Logradouro
                ,
                Bairro = endereco.Bairro
                ,
                Cidade = endereco.Cidade
                ,
                Estado = endereco.Estado
            };
            return enderecoDTO;
        }

        #endregion


    }
}
