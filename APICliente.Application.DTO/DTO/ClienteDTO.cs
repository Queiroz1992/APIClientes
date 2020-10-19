using System;
using System.Collections.Generic;
using System.Text;

namespace APICliente.Application.DTO.DTO
{
    public class ClienteDTO
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade { get; set; }
    }
}
