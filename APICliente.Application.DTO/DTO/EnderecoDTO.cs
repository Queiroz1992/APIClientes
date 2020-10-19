using System;
using System.Collections.Generic;
using System.Text;

namespace APICliente.Application.DTO.DTO
{
    public class EnderecoDTO
    {
        public int? Id { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }        
        public string Estado { get; set; }
    }
}
