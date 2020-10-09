﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SaldoFacil.API.Context;

namespace SaldoFacil.API.Migrations
{
    [DbContext(typeof(MainContext))]
    [Migration("20201009021656_length-campo-telefone")]
    partial class lengthcampotelefone
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SaldoFacil.API.Entities.CartaoTransporte", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Numero")
                        .HasColumnType("varchar(15) CHARACTER SET utf8mb4")
                        .HasMaxLength(15);

                    b.Property<float>("Saldo")
                        .HasColumnType("float");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.Property<float>("Tarifa")
                        .HasColumnType("float");

                    b.Property<int>("TipoCartaoId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TipoCartaoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("CartaoTransporte");
                });

            modelBuilder.Entity("SaldoFacil.API.Entities.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CEP")
                        .HasColumnType("varchar(9) CHARACTER SET utf8mb4")
                        .HasMaxLength(9);

                    b.Property<string>("Cidade")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<string>("Complemento")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<string>("Estado")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<string>("Logradouro")
                        .HasColumnType("varchar(518) CHARACTER SET utf8mb4")
                        .HasMaxLength(518);

                    b.Property<string>("Numero")
                        .HasColumnType("varchar(10) CHARACTER SET utf8mb4")
                        .HasMaxLength(10);

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("SaldoFacil.API.Entities.LoginUsuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("SenhaAntiga")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UsuarioCPF")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UsuarioEmail")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("LoginUsuario");
                });

            modelBuilder.Entity("SaldoFacil.API.Entities.MotivoBloqueio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NomeMotivo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("MotivoBloqueio");
                });

            modelBuilder.Entity("SaldoFacil.API.Entities.SolicitacaoBloqueio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CartaoTransporteId")
                        .HasColumnType("int");

                    b.Property<int>("MotivoBloqueioId")
                        .HasColumnType("int");

                    b.Property<int>("StatusPedidoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CartaoTransporteId");

                    b.HasIndex("StatusPedidoId");

                    b.ToTable("SolicitacaoBloqueio");
                });

            modelBuilder.Entity("SaldoFacil.API.Entities.SolicitacaoCartao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CartaoTransporteId")
                        .HasColumnType("int");

                    b.Property<int>("MotivoBloqueioId")
                        .HasColumnType("int");

                    b.Property<int>("StatusPedidoId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CartaoTransporteId");

                    b.HasIndex("MotivoBloqueioId");

                    b.HasIndex("StatusPedidoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("SolicitacaoCartao");
                });

            modelBuilder.Entity("SaldoFacil.API.Entities.SolicitacaoRecarga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CartaoId")
                        .HasColumnType("int");

                    b.Property<int?>("CartaoTransporteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataFinal")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("StatusPedidoId")
                        .HasColumnType("int");

                    b.Property<float>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CartaoTransporteId");

                    b.HasIndex("StatusPedidoId");

                    b.ToTable("SolicitacaoRecarga");
                });

            modelBuilder.Entity("SaldoFacil.API.Entities.StatusPedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NomeStatus")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("StatusPedido");
                });

            modelBuilder.Entity("SaldoFacil.API.Entities.TipoCartao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NomeTipo")
                        .HasColumnType("varchar(40) CHARACTER SET utf8mb4")
                        .HasMaxLength(40);

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("TipoCartao");
                });

            modelBuilder.Entity("SaldoFacil.API.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("varchar(14) CHARACTER SET utf8mb4")
                        .HasMaxLength(14);

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(200) CHARACTER SET utf8mb4")
                        .HasMaxLength(200);

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("varchar(14) CHARACTER SET utf8mb4")
                        .HasMaxLength(14);

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("SaldoFacil.API.Entities.CartaoTransporte", b =>
                {
                    b.HasOne("SaldoFacil.API.Entities.TipoCartao", "TipoCartao")
                        .WithMany()
                        .HasForeignKey("TipoCartaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SaldoFacil.API.Entities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SaldoFacil.API.Entities.Endereco", b =>
                {
                    b.HasOne("SaldoFacil.API.Entities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SaldoFacil.API.Entities.LoginUsuario", b =>
                {
                    b.HasOne("SaldoFacil.API.Entities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("SaldoFacil.API.Entities.SolicitacaoBloqueio", b =>
                {
                    b.HasOne("SaldoFacil.API.Entities.CartaoTransporte", "CartaoTransporte")
                        .WithMany()
                        .HasForeignKey("CartaoTransporteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SaldoFacil.API.Entities.StatusPedido", "StatusPedido")
                        .WithMany()
                        .HasForeignKey("StatusPedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SaldoFacil.API.Entities.SolicitacaoCartao", b =>
                {
                    b.HasOne("SaldoFacil.API.Entities.CartaoTransporte", "CartaoTransporte")
                        .WithMany()
                        .HasForeignKey("CartaoTransporteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SaldoFacil.API.Entities.MotivoBloqueio", "MotivoBloqueio")
                        .WithMany()
                        .HasForeignKey("MotivoBloqueioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SaldoFacil.API.Entities.StatusPedido", "StatusPedido")
                        .WithMany()
                        .HasForeignKey("StatusPedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SaldoFacil.API.Entities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SaldoFacil.API.Entities.SolicitacaoRecarga", b =>
                {
                    b.HasOne("SaldoFacil.API.Entities.CartaoTransporte", "CartaoTransporte")
                        .WithMany()
                        .HasForeignKey("CartaoTransporteId");

                    b.HasOne("SaldoFacil.API.Entities.StatusPedido", "StatusPedido")
                        .WithMany()
                        .HasForeignKey("StatusPedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
