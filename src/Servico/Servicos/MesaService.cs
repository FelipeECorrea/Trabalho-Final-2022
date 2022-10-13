using Repositorio.Entidades;
using Repositorio.Repositorios;
using Servico.MapeamentoEntidades;
using Servico.MapeamentoViewModels;
using Servico.ViewModels;
using Servico.ViewModels.Mesa;

namespace Servico.Servicos
{
    public class MesaService : IMesaService
    {
        private readonly IMesaRepositorio _mesaRepositorio;
        private readonly IMesaMapeamentoEntidade _mapeamentoEntidade;
        private readonly IMesaViewModelMapeamentoViewModels _mapeamentoViewModel;

        public MesaService(
            IMesaRepositorio mesaRepositorio,
            IMesaMapeamentoEntidade mapeamentoEntidade,
            IMesaViewModelMapeamentoViewModels mapeamentoViewModel)
        {
            _mesaRepositorio = mesaRepositorio;
            _mapeamentoEntidade = mapeamentoEntidade;
            _mapeamentoViewModel = mapeamentoViewModel;
        }

        public bool Apagar(int id)
        {
            return _mesaRepositorio.Apagar(id);
        }

        public Mesa Cadastrar(MesaCadastrarViewModel viewModel)
        {
            var mesa = _mapeamentoEntidade.ConstruirCom(viewModel);

            _mesaRepositorio.Cadastrar(mesa);

            return mesa;
        }

        public bool Editar(MesaEditarViewModel viewModel)
        {
            var mesa = _mesaRepositorio.ObterPorId(viewModel.Id);

            if (mesa == null)
                return false;

            _mapeamentoEntidade.AtualizarCampos(mesa, viewModel);

            _mesaRepositorio.Editar(mesa);

            return true;
        }

        public bool MesaEscolhida(int idMesa)
        {
          var mesaEscolhida =  _mesaRepositorio.ObterMesaEscolhida(idMesa);
            if (mesaEscolhida == null)
            {
                return false;
            }
            return true;
        }

        public Mesa? ObterPorId(int id) =>
            _mesaRepositorio.ObterPorId(id);

        public IList<Mesa> ObterTodos() =>
            _mesaRepositorio.ObterTodos();

        public IList<SelectViewModel> ObterTodosSelect2()
        {
            var mesas = _mesaRepositorio.ObterTodos();

            var selectViewModels = mesas
                .Select(x => new SelectViewModel
                {
                    Id = x.Id,
                    Text = x.NumeroMesa.ToString()
                })
                .ToList();

            return selectViewModels;
        }

    }


}
