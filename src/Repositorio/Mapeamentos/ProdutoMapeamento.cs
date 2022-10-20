﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Repositorio.Entidades;
using Repositorio.Enums;

namespace Repositorio.Mapeamentos
{
    internal class ProdutoMapeamento : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("produtos");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Valor)
               .HasColumnType("DECIMAL")
               .HasPrecision(5, 2)
               .IsRequired()
               .HasColumnName("valor");

            builder.Property(x => x.Nome)
              .HasColumnType("VARCHAR")
              .HasMaxLength(40)
              .IsRequired()
              .HasColumnName("nome");

            builder.Property(x => x.Categoria)
               .HasColumnType("VARCHAR")
               .HasMaxLength(1000)
               .IsRequired()
               .HasColumnName("categoria");

            builder.Property(x => x.Descricao)
             .HasColumnType("VARCHAR")
             .HasMaxLength(200)
             .IsRequired()
             .HasColumnName("descricao");

            builder.Property(x => x.ProdutoCaminho)
               .HasColumnType("VARCHAR")
               .HasMaxLength(1000)
               .IsRequired()
               .HasColumnName("produto_caminho");

            builder.Property(x => x.Status)
            .HasColumnType("TINYINT")
            .IsRequired()
            .HasColumnName("statusProduto");

            builder.HasData(
               new Produto
               {
                   Id = 1,
                   Valor = 19.50m,
                   Nome = "X-Salada Tradicional",
                   Categoria = "Tradicionais",
                   Descricao = "X-Salada Tradicional da Casa",
                   ProdutoCaminho = "X-Burguer.png",
                   Status = StatusProduto.Disponivel
               },
               new Produto
               {
                   Id = 2,
                   Valor = 21.63m,
                   Nome = "Yakissoba",
                   Categoria = "Massas",
                   Descricao = "Yakissoba Tradicional",
                   ProdutoCaminho = "yakisoba.jpg",
                   Status = StatusProduto.Disponivel
               },
               new Produto
               {
                   Id = 3,
                   Valor = 8.60m,
                   Nome = "Pudim de Leite",
                   Categoria = "Sobremesas",
                   Descricao = "Pudim de Leite 400g",
                   ProdutoCaminho = "pudim.jpg",
                   Status = StatusProduto.Disponivel
               },
               new Produto
               {
                   Id = 4,
                   Valor = 12.50m,
                   Nome = "Batata Rústica com Alecrim",
                   Categoria = "Extras",
                   Descricao = "Batata Rústica com Alecrim",
                   ProdutoCaminho = "batata-rustica.jpg",
                   Status = StatusProduto.Disponivel
               },
               new Produto
               {
                   Id = 5,
                   Valor = 14.80m,
                   Nome = "Batata Frita Media",
                   Categoria = "Extras",
                   Descricao = "Batata Frita - Porção Media",
                   ProdutoCaminho = "BatataFritaM.png",
                   Status = StatusProduto.Disponivel
               },
               new Produto
               {
                   Id = 6,
                   Valor = 25.90m,
                   Nome = "Batata Frita Grande",
                   Categoria = "Extras",
                   Descricao = "Batata Frita - Porção Grande",
                   ProdutoCaminho = "BatataFritaG.png",
                   Status = StatusProduto.Disponivel
               },
               new Produto
               {
                   Id = 7,
                   Valor = 28.90m,
                   Nome = "Feijoada Brasileira",
                   Categoria = "Tradicionais",
                   Descricao = "Feijoada Brasileirinha, Porção para 2 pessoas.",
                   ProdutoCaminho = "FeijoadaBrasileira.png",
                   Status = StatusProduto.Disponivel
               },
               new Produto
               {
                   Id = 8,
                   Valor = 6.00m,
                   Nome = "Pepsi Twist 200ml",
                   Categoria = "Bebidas",
                   Descricao = "Pepsi Twist 200ml",
                   ProdutoCaminho = "PepsiTwistLata.png",
                   Status = StatusProduto.Disponivel
               },
               new Produto
               {
                   Id = 9,
                   Valor = 19.90m,
                   Nome = "Salpicão de Frango",
                   Categoria = "Tradicionais",
                   Descricao = "Salpicão de Frango",
                   ProdutoCaminho = "Salpicao-Frango.png",
                   Status = StatusProduto.Disponivel
               },
               new Produto
               {
                   Id = 10,
                   Valor = 14.99m,
                   Nome = "Torta de Morango",
                   Categoria = "Sobremesas",
                   Descricao = "Torta de morango - Fatia",
                   ProdutoCaminho = "TortaMorango.png",
                   Status = StatusProduto.Disponivel
               },
               new Produto
               {
                   Id = 11,
                   Valor = 16.50m,
                   Nome = "Pina Coloda c/ Vodka",
                   Categoria = "Bebidas",
                   Descricao = "Pina Coloda c/ Vodka e Laranja",
                   ProdutoCaminho = "PinaColada.png",
                   Status = StatusProduto.Disponivel
               },
               new Produto
               {
                   Id = 12,
                   Valor = 12.50m,
                   Nome = "Cerveja Capivara Pilsen 400ml",
                   Categoria = "Bebidas",
                   Descricao = "Cerveja Capivara Pilsen 400ml",
                   ProdutoCaminho = "CervejaBlumenau.png",
                   Status = StatusProduto.Disponivel
               });
        }
    }
}