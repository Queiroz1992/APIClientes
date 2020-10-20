using APICliente.Application.DTO.DTO;
using APICliente.Application.Interfaces;
using APICliente.Domain.Core.Interfaces.Services;
using APICliente.Infrastructure.CrossCutting.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace APICliente.Application.Service
{
    public class ApplicationServiceEndereco : IApplicationServiceEndereco
    {
        private readonly IServiceEndereco _serviceEndereco;
        private readonly IMapperEndereco _mapperEndereco;

        public ApplicationServiceEndereco(IServiceEndereco serviceEndereco, IMapperEndereco mapperEndereco)
        {
            _serviceEndereco = serviceEndereco;
            _mapperEndereco = mapperEndereco;
        }

        public void Adicionar(EnderecoDTO obj)
        {
            var objEndereco = _mapperEndereco.MapeadorPorEntidade(obj);
            _serviceEndereco.Adicionar(objEndereco);
        }

        public void Atualizar(EnderecoDTO obj)
        {
            var objEndereco = _mapperEndereco.MapeadorPorEntidade(obj);
            _serviceEndereco.Atualizar(objEndereco);
        }

        public void Excluir(EnderecoDTO obj)
        {
            var objEndereco = _mapperEndereco.MapeadorPorEntidade(obj);
            _serviceEndereco.Excluir(objEndereco);
        }

        public EnderecoDTO ObterPorId(int id)
        {
            var objEndereco = _serviceEndereco.ObterPorId(id);
            return _mapperEndereco.MapeadorPorDTO(objEndereco);
        }

        public IEnumerable<EnderecoDTO> ObterTodos()
        {
            var objEnderecos = _serviceEndereco.ObterTodos();
            return _mapperEndereco.MapeadorListaEnderecos(objEnderecos);
        }
    }
}


