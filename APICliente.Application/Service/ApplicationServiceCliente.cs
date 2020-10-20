using APICliente.Application.DTO.DTO;
using APICliente.Application.Interfaces;
using APICliente.Domain.Core.Interfaces.Services;
using APICliente.Infrastructure.CrossCutting.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace APICliente.Application.Service
{
    public class ApplicationServiceCliente : IApplicationServiceCliente
    {
        private readonly IServiceCliente _serviceCliente;
        private readonly IMapperCliente _mapperCliente;

        public ApplicationServiceCliente(IServiceCliente ServiceCliente, IMapperCliente MapperCliente)
        {
            _serviceCliente = ServiceCliente;
            _mapperCliente = MapperCliente;
        }

        public void Adicionar(ClienteDTO obj)
        {
            var objCliente = _mapperCliente.MapeadorPorEntidade(obj);
            _serviceCliente.Adicionar(objCliente);
        }

        public ClienteDTO ObterPorId(int id)
        {
            var objcliente = _serviceCliente.ObterPorId(id);
            return _mapperCliente.MapeadorPorDTO(objcliente);
        }

        public IEnumerable<ClienteDTO> ObterTodos()
        {
            var objEnderecos = _serviceCliente.ObterTodos();
            return _mapperCliente.MapeadorListaClientes(objEnderecos);
        }

        public void Atualizar(ClienteDTO obj)
        {
            var objCliente = _mapperCliente.MapeadorPorEntidade(obj);
            _serviceCliente.Atualizar(objCliente);
        }

        public void Excluir(ClienteDTO obj)
        {
            var objCliente = _mapperCliente.MapeadorPorEntidade(obj);
            _serviceCliente.Atualizar(objCliente);
        }
    }
}
