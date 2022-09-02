using Microsoft.EntityFrameworkCore;
using Dominio;


namespace Persistencia
{
    public class AppContext: DbContext
    {
        //Definir Propiedades
        //por cada clase que creemos que vaya a la base de datos debemos crear un DBset
        public DbSet<Municipio> Municipios {get;set;}
        public DbSet<Patrocinador> Patrocinadores {get;set;}
        public DbSet<Colegio> Colegios {get;set;}
        public DbSet<Torneo> Torneos {get;set;}

        //Metodo para crear la BD si no Existe, con una sobrecarga      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {   //le decimos al OptionsBuilder que use el SqlServer
                optionsBuilder.UseSqlServer("Data Source = DIEGOFERCHO; Initial Catalog = BDGestionEventos; Integrated Security = True");
                /**
                *!La instruccion Intregrated Security = True Nos conecta a la BD con nuestro usuario de Windows.
                */
            }
        }

    }
    
}