using Repositorio.Entidades;
using Servico.ViewModels.Cliente;
using Servico.ViewModels.Produto;

namespace Servico.MapeamentoViewModels
{
    internal interface IClienteViewModelMapeamento
    {
        ClienteEditarViewModel ConstruirCom(Cliente cliente);

    }
}