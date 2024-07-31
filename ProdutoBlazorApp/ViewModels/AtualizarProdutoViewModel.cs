using System.ComponentModel.DataAnnotations;

namespace ProdutoBlazorApp.ViewModels
{
    public class AtualizarProdutoViewModel
    {
        public Guid? Id { get; set; }

        [MaxLength(50, ErrorMessage = "Por favor, informe o nome com no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome do produto.")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Por favor, informe o preço da tarefa.")]
        public string? Preco { get; set; }

        [Required(ErrorMessage = "Por favor, informe a quantidade de produto no estoque.")]
        public string? Quantidade { get; set; }

        [Required(ErrorMessage = "Por favor, informe o ID do fornecedor deste produto.")]
        public string? FornecedorId { get; set; }
    }
}
