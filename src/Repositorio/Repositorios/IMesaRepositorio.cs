﻿using Repositorio.Entidades;

namespace Repositorio.Repositorios
{
    public interface IMesaRepositorio
    {
        Mesa Cadastrar(Mesa mesa);
        IList<Mesa> ObterTodos();
        void Editar(Mesa mesa);
        bool Apagar(int id);
        Mesa? ObterPorId(int id);
        IList<Mesa> ObterTodos();
        Mesa? ObterMesaEscolhida(int idMesa);
        
    }
}
