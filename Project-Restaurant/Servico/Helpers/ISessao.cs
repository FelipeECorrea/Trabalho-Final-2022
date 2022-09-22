using Repositorio.Entidades;
using Servico.ViewModels.Cliente;

namespace Project_Restaurant_2022.Helpers
{
    public interface ISessao
    {
        void CriarSessaoDoUsiario(Cliente cliente);
        void RemoverSessaoUsuario();
        Cliente BuscarSessaoDoUsuario();
    }
}
