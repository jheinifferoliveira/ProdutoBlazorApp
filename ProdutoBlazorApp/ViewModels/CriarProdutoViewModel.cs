using System.ComponentModel.DataAnnotations;

namespace ProdutoBlazorApp.ViewModels
{
    public class CriarProdutoViewModel
    {
        [MaxLength(50, ErrorMessage = "Por favor, informe o nome com no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome do produto.")]   
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Por favor, informe o preço da produto.")]
        public string? Preco { get; set; }

        [Required(ErrorMessage = "Por favor, informe a quantidade do produto.")]
        public string? Quantidade { get; set; }

        [Required(ErrorMessage = "Por favor, informe o ID do fornecedor.")]
        public string? FornecedorId { get; set; }
    }
}
