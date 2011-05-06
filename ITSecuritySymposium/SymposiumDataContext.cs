using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ITSecuritySymposium.Models;

namespace ITSecuritySymposium
{
    public class SymposiumDataContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, add the following
        // code to the Application_Start method in your Global.asax file.
        // Note: this will destroy and re-create your database with every model change.
        // 
        //System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<Bingo.Web.BingoContext>());

        public DbSet<Balance> Balances { get; set; }
        /*
        public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<GameBall> GameBalls { get; set; }
        public DbSet<BingoCall> BingoCalls { get; set; }
        public DbSet<Message> Messages { get; set; }
         */
    }

    public class SymposiumDbInitializer : DropCreateDatabaseAlways<SymposiumDataContext>
    {
        protected override void Seed(SymposiumDataContext context)
        {
            var balanceScott = new Balance {UserName = "srkirkland", Amount = 1000};
            var balanceAlan = new Balance {UserName = "anlai", Amount = 1000};
            var balance2 = new Balance {UserName = "mghandi", Amount = 0};
            var balance3 = new Balance {UserName = "mzuckerburg", Amount = 10000000000000000};
            var balance4 = new Balance {UserName = "hsimpson", Amount = 12.84};

            context.Balances.Add(balanceScott);
            context.Balances.Add(balanceAlan);
            context.Balances.Add(balance2);
            context.Balances.Add(balance3);
            context.Balances.Add(balance4);
            
            context.SaveChanges();
        }
    }
}