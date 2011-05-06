using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Security;
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
            CreateMembershipUsers();

            var balanceScott = new Balance {UserName = "srkirkland", Amount = 1000};
            var balanceAlan = new Balance {UserName = "anlai", Amount = 1000};
            var balance2 = new Balance {UserName = "mgandhi", Amount = 0};
            var balance3 = new Balance {UserName = "mzuckerburg", Amount = 10000000000000000};
            var balance4 = new Balance {UserName = "hsimpson", Amount = 12.84};
            var balance5 = new Balance {UserName = "tsoprano", Amount = 1000};

            context.Balances.Add(balanceScott);
            context.Balances.Add(balanceAlan);
            context.Balances.Add(balance2);
            context.Balances.Add(balance3);
            context.Balances.Add(balance4);
            context.Balances.Add(balance5);
            
            context.SaveChanges();
        }

        private static void CreateMembershipUsers()
        {
            MembershipCreateStatus createStatus;
            Membership.CreateUser("srkirkland", "Devel$$", "srkirkland@ucdavis.edu", null, null, true, null, out createStatus);
            Membership.CreateUser("anlai", "Devel$$", "anlai@ucdavis.edu", null, null, true, null, out createStatus);
        }
    }
}