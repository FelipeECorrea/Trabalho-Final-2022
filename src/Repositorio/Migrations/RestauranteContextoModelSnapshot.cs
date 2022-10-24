﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositorio.BancoDados;

#nullable disable

namespace Repositorio.Migrations
{
    [DbContext(typeof(RestauranteContexto))]
    partial class RestauranteContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Repositorio.Entidades.Administrador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("VARCHAR(11)")
                        .HasColumnName("cpf");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("VARCHAR(40)")
                        .HasColumnName("nome");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR(20)")
                        .HasColumnName("senha");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("VARCHAR(11)")
                        .HasColumnName("telefone");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("administrador", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cpf = "10437548902",
                            Email = "admin@admin.com",
                            Nome = "ADM",
                            Senha = "admin123",
                            Telefone = "47991392902"
                        },
                        new
                        {
                            Id = 2,
                            Cpf = "10639142990",
                            Email = "joaomarti755@gmail.com",
                            Nome = "João",
                            Senha = "admin123",
                            Telefone = "47988278800"
                        });
                });

            modelBuilder.Entity("Repositorio.Entidades.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte?>("Autorizacao")
                        .HasColumnType("TINYINT")
                        .HasColumnName("autorizacao");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("VARCHAR(14)")
                        .HasColumnName("cpf");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("VARCHAR(40)")
                        .HasColumnName("nome");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR(20)")
                        .HasColumnName("senha");

                    b.Property<byte?>("Status")
                        .HasColumnType("TINYINT")
                        .HasColumnName("statusCliente");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("VARCHAR(14)")
                        .HasColumnName("telefone");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("clientes", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Autorizacao = (byte)0,
                            Cpf = "10437548902",
                            Email = "cristyanalexandrino.od@gmail.com",
                            Nome = "Cristyan",
                            Senha = "admin001",
                            Status = (byte)2,
                            Telefone = "47991392902"
                        },
                        new
                        {
                            Id = 2,
                            Autorizacao = (byte)0,
                            Cpf = "10639142990",
                            Email = "pessoal@gmail.com",
                            Nome = "Felipe",
                            Senha = "admin002",
                            Status = (byte)3,
                            Telefone = "47988278800"
                        },
                        new
                        {
                            Id = 3,
                            Autorizacao = (byte)0,
                            Cpf = "11073394999",
                            Email = "alan786k@gmail.com",
                            Nome = "Alan",
                            Senha = "admin003",
                            Status = (byte)2,
                            Telefone = "47996250612"
                        },
                        new
                        {
                            Id = 4,
                            Autorizacao = (byte)0,
                            Cpf = "10687634507",
                            Email = "marina@gmail.com",
                            Nome = "Marina",
                            Senha = "admin004",
                            Status = (byte)2,
                            Telefone = "47991785490"
                        },
                        new
                        {
                            Id = 5,
                            Autorizacao = (byte)0,
                            Cpf = "10167898534",
                            Email = "joão@gmail.com",
                            Nome = "João",
                            Senha = "admin005",
                            Status = (byte)2,
                            Telefone = "47999674309"
                        });
                });

            modelBuilder.Entity("Repositorio.Entidades.Mesa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte>("NumeroMesa")
                        .HasColumnType("TINYINT")
                        .HasColumnName("NumeroMesa");

                    b.Property<byte>("Status")
                        .HasColumnType("TINYINT")
                        .HasColumnName("statusMesa");

                    b.HasKey("Id");

                    b.ToTable("mesas", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NumeroMesa = (byte)1,
                            Status = (byte)0
                        },
                        new
                        {
                            Id = 2,
                            NumeroMesa = (byte)2,
                            Status = (byte)0
                        },
                        new
                        {
                            Id = 3,
                            NumeroMesa = (byte)3,
                            Status = (byte)0
                        },
                        new
                        {
                            Id = 4,
                            NumeroMesa = (byte)4,
                            Status = (byte)0
                        },
                        new
                        {
                            Id = 5,
                            NumeroMesa = (byte)5,
                            Status = (byte)0
                        },
                        new
                        {
                            Id = 6,
                            NumeroMesa = (byte)6,
                            Status = (byte)0
                        });
                });

            modelBuilder.Entity("Repositorio.Entidades.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ClienteId")
                        .HasColumnType("INT")
                        .HasColumnName("id_cliente");

                    b.Property<int>("MesaId")
                        .HasColumnType("INT")
                        .HasColumnName("id_mesa");

                    b.Property<string>("Observacao")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("VARCHAR(150)")
                        .HasColumnName("observacao");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("MesaId");

                    b.ToTable("pedidos", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClienteId = 1,
                            MesaId = 1,
                            Observacao = "Bem quente"
                        },
                        new
                        {
                            Id = 2,
                            ClienteId = 2,
                            MesaId = 2,
                            Observacao = "Bem quente"
                        });
                });

            modelBuilder.Entity("Repositorio.Entidades.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("VARCHAR(1000)")
                        .HasColumnName("categoria");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)")
                        .HasColumnName("descricao");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("VARCHAR(40)")
                        .HasColumnName("nome");

                    b.Property<string>("ProdutoCaminho")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("VARCHAR(1000)")
                        .HasColumnName("produto_caminho");

                    b.Property<byte>("Status")
                        .HasColumnType("TINYINT")
                        .HasColumnName("statusProduto");

                    b.Property<decimal>("Valor")
                        .HasPrecision(5, 2)
                        .HasColumnType("DECIMAL(5,2)")
                        .HasColumnName("valor");

                    b.HasKey("Id");

                    b.ToTable("produtos", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Categoria = "Tradicionais",
                            Descricao = "X-Salada Tradicional da Casa",
                            Nome = "X-Salada Tradicional",
                            ProdutoCaminho = "X-Burguer.png",
                            Status = (byte)1,
                            Valor = 19.50m
                        },
                        new
                        {
                            Id = 2,
                            Categoria = "Massas",
                            Descricao = "Yakissoba Tradicional",
                            Nome = "Yakissoba",
                            ProdutoCaminho = "yakisoba.jpg",
                            Status = (byte)1,
                            Valor = 21.63m
                        },
                        new
                        {
                            Id = 3,
                            Categoria = "Sobremesas",
                            Descricao = "Pudim de Leite 400g",
                            Nome = "Pudim de Leite",
                            ProdutoCaminho = "pudim.jpg",
                            Status = (byte)1,
                            Valor = 8.60m
                        },
                        new
                        {
                            Id = 4,
                            Categoria = "Extras",
                            Descricao = "Batata Rústica com Alecrim",
                            Nome = "Batata Rústica com Alecrim",
                            ProdutoCaminho = "batata-rustica.jpg",
                            Status = (byte)1,
                            Valor = 12.50m
                        },
                        new
                        {
                            Id = 5,
                            Categoria = "Extras",
                            Descricao = "Batata Frita - Porção Media",
                            Nome = "Batata Frita Media",
                            ProdutoCaminho = "BatataFritaM.png",
                            Status = (byte)1,
                            Valor = 14.80m
                        },
                        new
                        {
                            Id = 6,
                            Categoria = "Extras",
                            Descricao = "Batata Frita - Porção Grande",
                            Nome = "Batata Frita Grande",
                            ProdutoCaminho = "BatataFritaG.png",
                            Status = (byte)1,
                            Valor = 25.90m
                        },
                        new
                        {
                            Id = 7,
                            Categoria = "Tradicionais",
                            Descricao = "Feijoada Brasileirinha, Porção para 2 pessoas.",
                            Nome = "Feijoada Brasileira",
                            ProdutoCaminho = "FeijoadaBrasileira.png",
                            Status = (byte)1,
                            Valor = 28.90m
                        },
                        new
                        {
                            Id = 8,
                            Categoria = "Bebidas",
                            Descricao = "Pepsi Twist 200ml",
                            Nome = "Pepsi Twist 200ml",
                            ProdutoCaminho = "PepsiTwistLata.png",
                            Status = (byte)1,
                            Valor = 6.00m
                        },
                        new
                        {
                            Id = 9,
                            Categoria = "Tradicionais",
                            Descricao = "Salpicão de Frango",
                            Nome = "Salpicão de Frango",
                            ProdutoCaminho = "Salpicao-Frango.png",
                            Status = (byte)1,
                            Valor = 19.90m
                        },
                        new
                        {
                            Id = 10,
                            Categoria = "Sobremesas",
                            Descricao = "Torta de morango - Fatia",
                            Nome = "Torta de Morango",
                            ProdutoCaminho = "TortaMorango.png",
                            Status = (byte)1,
                            Valor = 14.99m
                        },
                        new
                        {
                            Id = 11,
                            Categoria = "Bebidas",
                            Descricao = "Pina Coloda c/ Vodka e Laranja",
                            Nome = "Pina Coloda c/ Vodka",
                            ProdutoCaminho = "PinaColada.png",
                            Status = (byte)1,
                            Valor = 16.50m
                        },
                        new
                        {
                            Id = 12,
                            Categoria = "Bebidas",
                            Descricao = "Cerveja Capivara Pilsen 400ml",
                            Nome = "Cerveja Capivara Pilsen 400ml",
                            ProdutoCaminho = "CervejaBlumenau.png",
                            Status = (byte)1,
                            Valor = 12.50m
                        });
                });

            modelBuilder.Entity("Repositorio.Entidades.ProdutoPedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("PedidoId")
                        .HasColumnType("INT")
                        .HasColumnName("pedido_id");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("INT")
                        .HasColumnName("id_produto");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("DECIMAL")
                        .HasColumnName("valor");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("produtos_pedidos", (string)null);
                });

            modelBuilder.Entity("Repositorio.Entidades.Pedido", b =>
                {
                    b.HasOne("Repositorio.Entidades.Cliente", "Cliente")
                        .WithMany("Pedidos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Repositorio.Entidades.Mesa", "Mesa")
                        .WithMany("Pedidos")
                        .HasForeignKey("MesaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Mesa");
                });

            modelBuilder.Entity("Repositorio.Entidades.ProdutoPedido", b =>
                {
                    b.HasOne("Repositorio.Entidades.Pedido", "Pedido")
                        .WithMany("ProdutosPedidos")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Repositorio.Entidades.Produto", "Produto")
                        .WithMany("ProdutosPedidos")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Repositorio.Entidades.Cliente", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("Repositorio.Entidades.Mesa", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("Repositorio.Entidades.Pedido", b =>
                {
                    b.Navigation("ProdutosPedidos");
                });

            modelBuilder.Entity("Repositorio.Entidades.Produto", b =>
                {
                    b.Navigation("ProdutosPedidos");
                });
#pragma warning restore 612, 618
        }
    }
}
