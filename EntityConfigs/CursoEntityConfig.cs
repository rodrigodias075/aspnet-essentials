using AplicativoWeb.Models;//chamando a camada modelo
using Microsoft.EntityFrameworkCore;//EF framework
using Microsoft.EntityFrameworkCore.Metadata.Builders;//Fluent API
namespace AplicativoWeb.EntityConfigs;//Novo namespace

public class CursoEntityConfig : IEntityTypeConfiguration<Curso>
{
    public void Configure(EntityTypeBuilder<Curso> builder)
    { 
        builder.ToTable("Curso ");


        builder.HasKey(c=>c.Id);

        //Titulo Marketing
        builder.Property(c=>c.TituloMarketing)
        .HasColumnType("nvarchar(80)")
        .IsRequired();

        //Titulo Interno
        builder.Property(c=>c.TituloInterno)
        .HasColumnType("nvarchar(80)")
        .IsRequired();

        //Descrição
        builder.Property(c=>c.Descricao)
        .HasColumnType("text")
        .IsRequired();


    } 
}