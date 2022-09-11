using Repositorio.Entidades;
using Servico.ViewModels.Cliente;

namespace Servico.MapeamentoViewModels
{
    public interface IClienteViewModelMapeamentoViewModel
    {
        ClienteEditarViewModel ConstruirCom(Cliente cliente);
    }
}
