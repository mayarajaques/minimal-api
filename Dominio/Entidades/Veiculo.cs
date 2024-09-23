using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MinimalApi.Dominio.Entidades
{
    public class Veiculo
    {
     [Key] //chave unica
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; } = default!; // propriedade não nulo

    [Required] //obrigatorio
    [StringLength(150)]// tamanho do campo
    public string Nome { get; set; } = default!; // propriedade não nulo

    [StringLength(100)] // tamanho do campo
    public string Marca { get; set; } = default!; // propriedade não nulo

    [StringLength(10)] // tamanho do campo
    public int Ano { get; set; } = default!; // propriedade não nulo
    }
}