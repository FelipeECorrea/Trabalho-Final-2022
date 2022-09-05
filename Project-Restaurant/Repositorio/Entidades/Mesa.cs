﻿namespace Repositorio.Entidades
{
    public class Mesa : EntidadeBase
    {
        public int NumeroMesa { get; set; }
        public string StatusMesa { get; set; }
        public IList<Pedido> Pedidos { get; set; }
    }
}
