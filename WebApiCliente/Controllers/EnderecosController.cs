using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APICliente.Application.DTO.DTO;
using APICliente.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiCliente.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecosController : ControllerBase
    {
        private readonly IApplicationServiceEndereco _applicationServiceEndereco;

        public EnderecosController(IApplicationServiceEndereco applicationServiceEndereco)
        {
            _applicationServiceEndereco = applicationServiceEndereco;
        }

        //GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceEndereco.ObterTodos());
        }

        //GET api/values/id
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceEndereco.ObterPorId(id));
        }

        //POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] EnderecoDTO enderecoDTO)
        {
            try
            {
                if (enderecoDTO == null)
                    return NotFound();

                _applicationServiceEndereco.Adicionar(enderecoDTO);
                return Ok("Endereço Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //PUT api/values
        [HttpPut]
        public ActionResult Put([FromBody] EnderecoDTO enderecoDTO)
        {
            try
            {
                if (enderecoDTO == null)
                    return NotFound();

                _applicationServiceEndereco.Atualizar(enderecoDTO);
                return Ok("Endereço Atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //DELETE api/values
        [HttpDelete()]
        public ActionResult Delete([FromBody] EnderecoDTO enderecoDTO)
        {
            try
            {
                if (enderecoDTO == null)
                    return NotFound();

                _applicationServiceEndereco.Excluir(enderecoDTO);
                return Ok("Endereço Removido com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
