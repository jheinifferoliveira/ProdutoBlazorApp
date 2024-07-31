using Microsoft.AspNetCore.Components.Forms;
using ProdutoBlazorApp.Reponses;
using ProdutoBlazorApp.Settings;
using ProdutoBlazorApp.ViewModels;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using System.Reflection;
using System.Threading;
using System;

namespace ProdutoBlazorApp.Reponses
{
    public class ProdutoResponse
    {
        public Guid? Id { get; set; }
        public string? Nome { get; set; }
        public decimal? Preco { get; set; }
        public int? Quantidade { get; set; }
        public Guid? FornecedorId { get; set; }
       
    }
}
