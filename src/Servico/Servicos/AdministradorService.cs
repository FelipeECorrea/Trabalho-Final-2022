using Repositorio.BancoDados;
using Repositorio.Entidades;
using Repositorio.Repositorios;
using Servico.MapeamentoEntidades;
using Servico.ViewModels;
using Servico.ViewModels.Administrador;

namespace Servico.Servicos
{
    public class AdministradorService : IAdministradorService
    {
        private readonly IAdministradorRepositorio _administradorRepositorio;
        private readonly IAdministradorMapeamentoEntidade _mapeamentoEntidade;
        private readonly RestauranteContexto _contexto;

        public AdministradorService(
            IAdministradorRepositorio administradorRepositorio,
            IAdministradorMapeamentoEntidade mapeamentoEntidade)
        {
            _administradorRepositorio = administradorRepositorio;
            _mapeamentoEntidade = mapeamentoEntidade;
        }

        public bool Apagar(int id) =>
            _administradorRepositorio.Apagar(id);

        public Administrador Cadastrar(AdministradorCadastrarViewModel viewModel)
        {
            var administrador = _mapeamentoEntidade.ConstruirCom(viewModel);

            _administradorRepositorio.Cadastrar(administrador);

            return administrador;
        }

        public bool Editar(AdministradorEditarViewModel viewModel)
        {
            var administrador = _administradorRepositorio.ObterPorId(viewModel.Id);

            if (administrador == null)
                return false;

            _mapeamentoEntidade.AtualizarCom(administrador, viewModel);

            _administradorRepositorio.Editar(administrador);

            return true;
        }

        public Administrador? ObterPorEmail(string Email)
        {
            Administrador administrador = _administradorRepositorio.ObterPorEmail(Email);

            return administrador;
        }

        public Administrador? ObterPorId(int id) =>
            _administradorRepositorio.ObterPorId(id);

        public IList<SelectViewModel> ObterPorSelect2()
        {
            var administradores = _administradorRepositorio.ObterTodos();

            var selectViewModels = administradores
                .Select(x => new SelectViewModel
                {
                    Id = x.Id,
                    Text = x.Nome
                })
                .ToList();

            return selectViewModels;
        }

        public IList<Administrador> Cadastrar() =>
            _administradorRepositorio.ObterTodos();

        public bool SenhaValida(string senha)
        {
            Administrador administrador = new Administrador();

            return administrador.Senha == senha;
        }
    }
}
