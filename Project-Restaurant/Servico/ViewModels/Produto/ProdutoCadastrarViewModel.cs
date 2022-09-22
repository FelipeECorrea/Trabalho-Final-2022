using Microsoft.AspNetCore.Http;

namespace Servico.ViewModels.Produto
{
    public class ProdutoCadastrarViewModel : ProdutoViewModel
    {
        public IFormFile? File { get; set; }
    }
}
