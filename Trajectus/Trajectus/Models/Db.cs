namespace Trajectus.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Db : DbContext
    {
        // Votre contexte a été configuré pour utiliser une chaîne de connexion « Db » du fichier 
        // de configuration de votre application (App.config ou Web.config). Par défaut, cette chaîne de connexion cible 
        // la base de données « Trajectus.Db » sur votre instance LocalDb. 
        // 
        // Pour cibler une autre base de données et/ou un autre fournisseur de base de données, modifiez 
        // la chaîne de connexion « Db » dans le fichier de configuration de l'application.
        public Db()
            : base("name=Db")
        {
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Continent> Continents { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<GPSPosition> GPSPositions { get; set; }
        public DbSet<Path> Paths { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Step> Steps { get; set; }
        public DbSet<Travel> Travels { get; set; }
        public DbSet<User> Users { get; set; }

        // Ajoutez un DbSet pour chaque type d'entité à inclure dans votre modèle. Pour plus d'informations 
        // sur la configuration et l'utilisation du modèle Code First, consultez http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}