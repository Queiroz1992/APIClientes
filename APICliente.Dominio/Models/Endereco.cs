using System;
using System.Collections.Generic;
using System.Text;

namespace APICliente.Domain.Models
{
    public class Endereco
    {
        public int EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int ClienteId { get; set; }
        public virtual Cliente Cliente{ get; set; }
    }
}
