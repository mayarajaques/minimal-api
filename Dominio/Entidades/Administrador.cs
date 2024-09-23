using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinimalApi.Dominio.Entidades;

public class Administrador
{
    [Key] //chave unica
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; } = default!; // propriedade não nulo

    [Required] //obrigatorio
    [StringLength(255)]// tamanho do campo
    public string Email { get; set; } = default!; // propriedade não nulo

    [Required] // obrigatorio
    [StringLength(50)] // tamanho do campo
    public string Senha { get; set; } = default!; // propriedade não nulo

[Required] // obrigatorio
    [StringLength(10)] // tamanho do campo
    public string Perfil { get; set; } = default!; // propriedade não nulo
}

