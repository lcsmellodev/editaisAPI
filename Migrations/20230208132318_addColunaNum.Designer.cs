﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using editaisAPI.Context;

#nullable disable

namespace editaisAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230208132318_addColunaNum")]
    partial class addColunaNum
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("editaisAPI.Models.Concurso", b =>
                {
                    b.Property<int>("ConcursoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Banca")
                        .HasMaxLength(180)
                        .HasColumnType("varchar(180)");

                    b.Property<DateTime>("ConcursoData")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Orgao")
                        .HasMaxLength(180)
                        .HasColumnType("varchar(180)");

                    b.HasKey("ConcursoId");

                    b.ToTable("Concursos");
                });

            modelBuilder.Entity("editaisAPI.Models.Disciplina", b =>
                {
                    b.Property<int>("DisciplinaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DisciplinaNome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ProvaId")
                        .HasColumnType("int");

                    b.HasKey("DisciplinaId");

                    b.HasIndex("ProvaId");

                    b.ToTable("Disciplinas");
                });

            modelBuilder.Entity("editaisAPI.Models.Prova", b =>
                {
                    b.Property<int>("ProvaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasMaxLength(180)
                        .HasColumnType("varchar(180)");

                    b.Property<int>("ConcursoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ProvaData")
                        .HasColumnType("datetime(6)");

                    b.HasKey("ProvaId");

                    b.HasIndex("ConcursoId");

                    b.ToTable("Provas");
                });

            modelBuilder.Entity("editaisAPI.Models.TopicoFilho", b =>
                {
                    b.Property<int>("TopicoFilhoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("NumTopicoFilho")
                        .HasColumnType("int");

                    b.Property<string>("TopicoFilhoNome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("TopicoPaiId")
                        .HasColumnType("int");

                    b.HasKey("TopicoFilhoId");

                    b.HasIndex("TopicoPaiId");

                    b.ToTable("TopicoFilhos");
                });

            modelBuilder.Entity("editaisAPI.Models.TopicoNeto", b =>
                {
                    b.Property<int>("TopicoNetoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("NumTopicoNeto")
                        .HasColumnType("int");

                    b.Property<int>("TopicoFilhoId")
                        .HasColumnType("int");

                    b.Property<string>("TopicoNetoNome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("TopicoNetoId");

                    b.HasIndex("TopicoFilhoId");

                    b.ToTable("TopicoNetos");
                });

            modelBuilder.Entity("editaisAPI.Models.TopicoPai", b =>
                {
                    b.Property<int>("TopicoPaiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DisciplinaId")
                        .HasColumnType("int");

                    b.Property<int?>("NumTopicoPai")
                        .HasColumnType("int");

                    b.Property<string>("TopicoPaiNome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("TopicoPaiId");

                    b.HasIndex("DisciplinaId");

                    b.ToTable("TopicoPais");
                });

            modelBuilder.Entity("editaisAPI.Models.Disciplina", b =>
                {
                    b.HasOne("editaisAPI.Models.Prova", "Prova")
                        .WithMany("Disciplinas")
                        .HasForeignKey("ProvaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Prova");
                });

            modelBuilder.Entity("editaisAPI.Models.Prova", b =>
                {
                    b.HasOne("editaisAPI.Models.Concurso", "Concurso")
                        .WithMany("Provas")
                        .HasForeignKey("ConcursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Concurso");
                });

            modelBuilder.Entity("editaisAPI.Models.TopicoFilho", b =>
                {
                    b.HasOne("editaisAPI.Models.TopicoPai", "TopicoPai")
                        .WithMany("TopicoFilhos")
                        .HasForeignKey("TopicoPaiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TopicoPai");
                });

            modelBuilder.Entity("editaisAPI.Models.TopicoNeto", b =>
                {
                    b.HasOne("editaisAPI.Models.TopicoFilho", "TopicoFilho")
                        .WithMany("TopicoNetos")
                        .HasForeignKey("TopicoFilhoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TopicoFilho");
                });

            modelBuilder.Entity("editaisAPI.Models.TopicoPai", b =>
                {
                    b.HasOne("editaisAPI.Models.Disciplina", "Disciplina")
                        .WithMany("TopicoPais")
                        .HasForeignKey("DisciplinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Disciplina");
                });

            modelBuilder.Entity("editaisAPI.Models.Concurso", b =>
                {
                    b.Navigation("Provas");
                });

            modelBuilder.Entity("editaisAPI.Models.Disciplina", b =>
                {
                    b.Navigation("TopicoPais");
                });

            modelBuilder.Entity("editaisAPI.Models.Prova", b =>
                {
                    b.Navigation("Disciplinas");
                });

            modelBuilder.Entity("editaisAPI.Models.TopicoFilho", b =>
                {
                    b.Navigation("TopicoNetos");
                });

            modelBuilder.Entity("editaisAPI.Models.TopicoPai", b =>
                {
                    b.Navigation("TopicoFilhos");
                });
#pragma warning restore 612, 618
        }
    }
}
