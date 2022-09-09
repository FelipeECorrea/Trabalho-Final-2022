using Repositorio.Entidades;
using Repositorio.Repositorios;
using Servico.MapeamentoViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico.Servicos
{
    public class MesaService : IMesaService
    {
        private readonly IMesaRepositorio _mesaRepositorio;
        private readonly IMesaViewModelMapeamentoViewModels _mapeamentoViewModel;

        public MesaService(
            IMesaRepositorio mesaRepositorio,
            IMesaViewModelMapeamentoViewModels mapeamentoViewModel)
        {
            _mesaRepositorio = mesaRepositorio;
            _mapeamentoViewModel = mapeamentoViewModel;
        }
        public Mesa? ObterPorId(int id) =>
            _mesaRepositorio.ObterPorId(id);

        public IList<Mesa> ObterTodos() =>
            _mesaRepositorio.ObterTodos();

    }


}
