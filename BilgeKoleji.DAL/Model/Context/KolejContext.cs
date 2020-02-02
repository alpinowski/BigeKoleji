using BilgeKoleji.MAPS.Maps;
using BilgeKoleji.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BilgeKoleji.DAL.Model.Context
{
   public class KolejContext:DbContext
    {
        public KolejContext()
        {
            Database.Connection.ConnectionString = ConfigurationManager.ConnectionStrings["OkulDB"].ConnectionString; 
            Database.SetInitializer<KolejContext>(new DropCreateDatabaseIfModelChanges<KolejContext>());
            Database.SetInitializer<KolejContext>(new SampleData());

            //var mail= ConfigurationManager.AppSettings["mailhesabı"];
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ArticleMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new CommentMap());
            modelBuilder.Configurations.Add(new ManagementRegisterMap());
            modelBuilder.Configurations.Add(new RegisterMap());
            modelBuilder.Configurations.Add(new StudentsMap());
            modelBuilder.Configurations.Add(new TagMap());
            modelBuilder.Configurations.Add(new TeachersMap());
            modelBuilder.Configurations.Add(new TodoMap());
            modelBuilder.Configurations.Add(new UserMap());

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Todo> Todos { get; set; }
    }
}
