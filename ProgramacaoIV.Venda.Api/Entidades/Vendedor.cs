using System.ComponentModel.DataAnnotations;

namespace ProgramacaoIV.Venda.Api.Entidades
{
    public sealed class Vendedor : AbstractEntity
    {
        [Required]
        public string Nome { get; set; } = string.Empty;

        [EmailAddress]
        public string Email { get; set; } = string.Empty;
    }
}
