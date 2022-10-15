using Repositorio.Entidades;
using Servico.ViewModels.Cliente;

namespace Servico.MapeamentoViewModels
{
    public interface IClienteMapeamentoViewModel
    {
        ClienteEditarViewModel ConstruirCom(Cliente cliente);
    }
}
