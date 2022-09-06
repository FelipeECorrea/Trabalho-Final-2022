using Repositorio.Entidades;

namespace Servico.MapeamentoEntidades
{
    public interface IPedidoMapeamentoEntidade
    {
        PedidoMapeamentoEntidade AtualizarCom(Pedido pedido);
    }
}