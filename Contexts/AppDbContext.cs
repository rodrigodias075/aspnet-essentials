using AplicativoWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;
using AplicativoWeb.EntityConfigs;





public class AppDbContext:DbContext{

    public DbSet<Curso> Cursos => Set<Curso>();

//overide(sobrescrever)
//NaoTrair( ) - Contrato
//protected
protected override void OnConfiguring(DbContextOptionsBuilder builder){
    builder.UseSqlServer("Server=LAB-F08-11;Database=EscolaDotNet;User Id=sa;Password=senai@123;TrustServerCertificate=True");
}
protected override void OnModelCreating(ModelBuilder builder){
    builder.ApplyConfiguration(new CursoEntityConfig());

}




}