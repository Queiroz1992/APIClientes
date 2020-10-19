using System;
using System.Collections.Generic;
using System.Text;

namespace APICliente.Domain.Models
{
    public class Cliente : Base
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade { get; set; }
    }
}
