using System.ComponentModel.DataAnnotations;

namespace ProdutoBlazorApp.ViewModels
{
    public class AtualizarFornecedorViewModel
    {
        public Guid? Id { get; set; }

        [MaxLength(50, ErrorMessage = "Por favor, informe o nome com no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome do produto.")]
        public string? Nome { get; set; }
    }
}
