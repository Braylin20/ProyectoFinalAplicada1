﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectFinal.Data;

#nullable disable

namespace ProyectFinal.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ProyectFinal.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("AbogadoId")
                        .HasColumnType("int");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("Cedula")
                        .HasColumnType("bigint");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("AbogadoId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Share.Models.Alguaciles", b =>
                {
                    b.Property<int>("AlguacilId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AlguacilId"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AlguacilId");

                    b.ToTable("Alguaciles");
                });

            modelBuilder.Entity("Share.Models.Audiencias", b =>
                {
                    b.Property<int>("AudienciaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AudienciaId"));

                    b.Property<string>("Comentario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaAudiencia")
                        .HasColumnType("datetime2");

                    b.HasKey("AudienciaId");

                    b.ToTable("Audiencias");
                });

            modelBuilder.Entity("Share.Models.Demandas", b =>
                {
                    b.Property<int>("DemandaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DemandaId"));

                    b.Property<int?>("AlguacilId")
                        .HasColumnType("int");

                    b.Property<int?>("AudienciaId")
                        .HasColumnType("int");

                    b.Property<long?>("Cedula")
                        .HasColumnType("bigint");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Documento")
                        .HasColumnType("varbinary(max)");

                    b.Property<int?>("EstadoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("FotoCedula")
                        .HasColumnType("varbinary(max)");

                    b.Property<int?>("TiposDemandasId")
                        .HasColumnType("int");

                    b.HasKey("DemandaId");

                    b.HasIndex("AlguacilId");

                    b.HasIndex("AudienciaId");

                    b.HasIndex("EstadoId");

                    b.HasIndex("TiposDemandasId");

                    b.ToTable("Demandas");
                });

            modelBuilder.Entity("Share.Models.DemandasDetalle", b =>
                {
                    b.Property<int>("DetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DetalleId"));

                    b.Property<int>("DemandaId")
                        .HasColumnType("int");

                    b.Property<string>("NombreDemandado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumCedulaDemandado")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DetalleId");

                    b.HasIndex("DemandaId");

                    b.ToTable("DemandaDetalles");
                });

            modelBuilder.Entity("Share.Models.Empleados", b =>
                {
                    b.Property<int>("EmpleadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmpleadoId"));

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("EmpleadoId");

                    b.HasIndex("UserId");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("Share.Models.EstadosDemandas", b =>
                {
                    b.Property<int>("EstadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EstadoId"));

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EstadoId");

                    b.ToTable("EstadosDemandas");
                });

            modelBuilder.Entity("Share.Models.Expedientes", b =>
                {
                    b.Property<int>("ExpedienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExpedienteId"));

                    b.Property<string>("Comentario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DemandaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("SentenciaId")
                        .HasColumnType("int");

                    b.HasKey("ExpedienteId");

                    b.HasIndex("DemandaId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("SentenciaId");

                    b.ToTable("Expedientes");
                });

            modelBuilder.Entity("Share.Models.NinoDetalle", b =>
                {
                    b.Property<int>("DetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DetalleId"));

                    b.Property<int>("DemandaId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaNacimientoNino")
                        .HasColumnType("datetime2");

                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreNino")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DetalleId");

                    b.HasIndex("DemandaId");

                    b.ToTable("NinoDetalles");
                });

            modelBuilder.Entity("Share.Models.Sentencias", b =>
                {
                    b.Property<int>("SentenciaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SentenciaId"));

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreMinisterio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ResolucionId")
                        .HasColumnType("int");

                    b.HasKey("SentenciaId");

                    b.HasIndex("ResolucionId");

                    b.ToTable("Sentencias");
                });

            modelBuilder.Entity("Share.Models.TelefonoDetalles", b =>
                {
                    b.Property<int>("DetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DetalleId"));

                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoId")
                        .HasColumnType("int");

                    b.HasKey("DetalleId");

                    b.HasIndex("Id");

                    b.HasIndex("TipoId");

                    b.ToTable("TelefonoDetalles");
                });

            modelBuilder.Entity("Share.Models.TipoResoluciones", b =>
                {
                    b.Property<int>("ResolucionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResolucionId"));

                    b.Property<string>("TipoResolcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ResolucionId");

                    b.ToTable("TipoResoluciones");
                });

            modelBuilder.Entity("Share.Models.TipoTelefonos", b =>
                {
                    b.Property<int>("TipoTelefonoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoTelefonoId"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipoTelefonoId");

                    b.ToTable("TipoTelefonos");
                });

            modelBuilder.Entity("Share.Models.TiposDemandas", b =>
                {
                    b.Property<int>("TiposDemandasId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TiposDemandasId"));

                    b.Property<string>("TipoDemanda")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TiposDemandasId");

                    b.ToTable("TiposDemandas");
                });

            modelBuilder.Entity("Share.Models.UsuarioDetalle", b =>
                {
                    b.Property<int>("DetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DetalleId"));

                    b.Property<int?>("ColegioAbogadoId")
                        .HasColumnType("int");

                    b.Property<string>("Id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NombreAbogado")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DetalleId");

                    b.HasIndex("Id");

                    b.ToTable("UsuarioDetalles");
                });

            modelBuilder.Entity("Shared1.Models.EmpleadoSentencia", b =>
                {
                    b.Property<int>("EmpleadoSentenciaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmpleadoSentenciaId"));

                    b.Property<int>("EmpleadoId")
                        .HasColumnType("int");

                    b.Property<int>("SentenciaId")
                        .HasColumnType("int");

                    b.HasKey("EmpleadoSentenciaId");

                    b.HasIndex("EmpleadoId");

                    b.HasIndex("SentenciaId");

                    b.ToTable("EmpleadoSentencia");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ProyectFinal.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ProyectFinal.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProyectFinal.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ProyectFinal.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProyectFinal.Data.ApplicationUser", b =>
                {
                    b.HasOne("Share.Models.UsuarioDetalle", "Abogado")
                        .WithMany()
                        .HasForeignKey("AbogadoId");

                    b.Navigation("Abogado");
                });

            modelBuilder.Entity("Share.Models.Demandas", b =>
                {
                    b.HasOne("Share.Models.Alguaciles", "Alguacil")
                        .WithMany()
                        .HasForeignKey("AlguacilId");

                    b.HasOne("Share.Models.Audiencias", "Audiencia")
                        .WithMany()
                        .HasForeignKey("AudienciaId");

                    b.HasOne("Share.Models.EstadosDemandas", "EstadoDemanda")
                        .WithMany()
                        .HasForeignKey("EstadoId");

                    b.HasOne("Share.Models.TiposDemandas", "TipoDemanda")
                        .WithMany()
                        .HasForeignKey("TiposDemandasId");

                    b.Navigation("Alguacil");

                    b.Navigation("Audiencia");

                    b.Navigation("EstadoDemanda");

                    b.Navigation("TipoDemanda");
                });

            modelBuilder.Entity("Share.Models.DemandasDetalle", b =>
                {
                    b.HasOne("Share.Models.Demandas", null)
                        .WithMany("DemandaDetalles")
                        .HasForeignKey("DemandaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Share.Models.Empleados", b =>
                {
                    b.HasOne("ProyectFinal.Data.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Share.Models.Expedientes", b =>
                {
                    b.HasOne("Share.Models.Demandas", "Demandas")
                        .WithMany()
                        .HasForeignKey("DemandaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProyectFinal.Data.ApplicationUser", "User")
                        .WithOne("Expedientes")
                        .HasForeignKey("Share.Models.Expedientes", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Share.Models.Sentencias", "Sentencia")
                        .WithMany()
                        .HasForeignKey("SentenciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Demandas");

                    b.Navigation("Sentencia");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Share.Models.NinoDetalle", b =>
                {
                    b.HasOne("Share.Models.Demandas", null)
                        .WithMany("UsuarioNinoDetalles")
                        .HasForeignKey("DemandaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Share.Models.Sentencias", b =>
                {
                    b.HasOne("Share.Models.TipoResoluciones", "TipoResoluciones")
                        .WithMany()
                        .HasForeignKey("ResolucionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoResoluciones");
                });

            modelBuilder.Entity("Share.Models.TelefonoDetalles", b =>
                {
                    b.HasOne("ProyectFinal.Data.ApplicationUser", null)
                        .WithMany("TelefonoDetalles")
                        .HasForeignKey("Id");

                    b.HasOne("Share.Models.TipoTelefonos", "TipoTelefono")
                        .WithMany()
                        .HasForeignKey("TipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoTelefono");
                });

            modelBuilder.Entity("Share.Models.UsuarioDetalle", b =>
                {
                    b.HasOne("ProyectFinal.Data.ApplicationUser", null)
                        .WithMany("UsuarioDetalle")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Shared1.Models.EmpleadoSentencia", b =>
                {
                    b.HasOne("Share.Models.Empleados", "Empleado")
                        .WithMany()
                        .HasForeignKey("EmpleadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Share.Models.Sentencias", "Sentencia")
                        .WithMany()
                        .HasForeignKey("SentenciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empleado");

                    b.Navigation("Sentencia");
                });

            modelBuilder.Entity("ProyectFinal.Data.ApplicationUser", b =>
                {
                    b.Navigation("Expedientes");

                    b.Navigation("TelefonoDetalles");

                    b.Navigation("UsuarioDetalle");
                });

            modelBuilder.Entity("Share.Models.Demandas", b =>
                {
                    b.Navigation("DemandaDetalles");

                    b.Navigation("UsuarioNinoDetalles");
                });
#pragma warning restore 612, 618
        }
    }
}
