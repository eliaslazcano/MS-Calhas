﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using MS_Calhas.Model;
using System;

namespace MS_Calhas.Migrations
{
    [DbContext(typeof(Banco))]
    partial class BancoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("MS_Calhas.Model.Cheque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Banco");

                    b.Property<string>("Cliente");

                    b.Property<string>("CodBanco");

                    b.Property<bool>("Compensado");

                    b.Property<string>("Conta");

                    b.Property<string>("DataCheque");

                    b.Property<string>("DataCompensacao");

                    b.Property<string>("NumCheque");

                    b.Property<double>("Valor");

                    b.HasKey("Id");

                    b.ToTable("Cheques");
                });

            modelBuilder.Entity("MS_Calhas.Model.Funcionario", b =>
                {
                    b.Property<int>("FuncionarioId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cargo");

                    b.Property<string>("Nome");

                    b.HasKey("FuncionarioId");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("MS_Calhas.Model.RegistroCarga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FuncionarioId");

                    b.Property<string>("data");

                    b.Property<string>("hora");

                    b.Property<int>("material");

                    b.Property<int>("quantidade");

                    b.Property<int>("tipo");

                    b.HasKey("Id");

                    b.HasIndex("FuncionarioId");

                    b.ToTable("Registros");
                });

            modelBuilder.Entity("MS_Calhas.Model.Section", b =>
                {
                    b.Property<string>("unification")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("inauguracao");

                    b.HasKey("unification");

                    b.ToTable("Otimizacao");
                });

            modelBuilder.Entity("MS_Calhas.Model.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DataCadastro");

                    b.Property<string>("DataViolacao");

                    b.Property<string>("HoraViolacao");

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.Property<bool>("Violacao");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("MS_Calhas.Model.RegistroCarga", b =>
                {
                    b.HasOne("MS_Calhas.Model.Funcionario", "funcionario")
                        .WithMany("RegistrosCarga")
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
