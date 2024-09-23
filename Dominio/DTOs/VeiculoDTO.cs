using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal_Api.Dominio.DTOs.VeiculoDTO
{
    public record VeiculoDTO
    {

        public string Nome { get; set; } = default!; // propriedade não nulo


        public string Marca { get; set; } = default!; // propriedade não nulo

        public int Ano { get; set; } = default!; // propriedade não nulo
    }
}