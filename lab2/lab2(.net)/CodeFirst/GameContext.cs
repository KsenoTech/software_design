using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirst
{
    public class GameContext : DbContext
    {
        // Контекст настроен для использования строки подключения "GameCS" из файла конфигурации  
        // приложения (App.config).
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "GameCS" 
        // в файле конфигурации приложения.
        public GameContext() : base("GameCS")
        { 
        
        }

        class MyContextInitializer : DropCreateDatabaseAlways<GameContext>
        {
            protected override void Seed(GameContext db)
            {
                //Phone p1 = new Phone { Name = "Samsung Galaxy S5", Price = 14000 };
                //Phone p2 = new Phone { Name = "Nokia Lumia 630", Price = 8000 };

                //db.Phones.Add(p1);
                //db.Phones.Add(p2);
                db.SaveChanges();
            }
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // использование Fluent API
            base.OnModelCreating(modelBuilder);

        }
        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.
        public DbSet<Player> Players { get; set; }

        public DbSet<Team> Teams { get; set; }
    }
}
