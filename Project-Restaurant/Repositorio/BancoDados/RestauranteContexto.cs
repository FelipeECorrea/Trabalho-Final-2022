﻿using Microsoft.EntityFrameworkCore;
using Repositorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.BancoDados
{
    public class RestauranteContexto : DbContext
    {

        public DbSet<Produto> Produtos { get; set; }

        public RestauranteContexto(
         DbContextOptions<RestauranteContexto> options)
         : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}