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
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Post> Posts { get; set; }
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

            CreateBalances(context);

            CreatePosts(context);

            
            context.SaveChanges();
        }

        private static void CreatePosts(SymposiumDataContext context)
        {
            var post = new Post
                           {
                               Author = "Julias Caesar",
                               Created = DateTime.Now.AddDays(-10),
                               Content =
                                   "Integer erat nunc, mollis quis malesuada pharetra, lacinia nec metus. Nunc bibendum, ligula ut dictum pellentesque, leo ipsum ultrices lectus, non vulputate lectus dolor nec odio. Nam id nisl dolor, vitae dapibus leo. Sed dui nibh, bibendum et adipiscing vitae, facilisis nec velit. Sed quis orci risus. Quisque non lorem et felis eleifend commodo et quis neque. Sed blandit enim et libero gravida interdum. Aenean et blandit elit. Proin suscipit eros luctus velit ornare vehicula. Sed mollis augue nec dolor mollis eget eleifend metus auctor. Sed imperdiet tincidunt commodo. Nunc feugiat semper sapien, ac placerat urna vehicula a. Nulla facilisi. Praesent quis nisl vitae ante sagittis mollis. "
                           };

            var post2 = new Post
                            {

                                Author = "Pliny the Elder",
                                Created = DateTime.Now.AddDays(-25),
                                Content =
                                    "Aenean et nisi sed nibh euismod bibendum eget rutrum neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce volutpat mollis feugiat. Proin at lacus ut ipsum hendrerit tincidunt nec id nunc. Sed quis ipsum ac sapien tempus scelerisque in auctor purus. Donec quis varius sem. Duis ut auctor elit. Nullam arcu nulla, dapibus at fringilla nec, ultrices a quam. Duis at rutrum magna. Maecenas cursus lacus nec justo scelerisque id iaculis arcu eleifend. Morbi eget sapien ut diam fermentum auctor. Cras vestibulum condimentum metus non eleifend. Sed tincidunt nisl malesuada erat posuere quis adipiscing eros pretium. Nulla auctor magna a ipsum vulputate et lacinia elit lobortis. Nam dignissim, diam a iaculis mollis, risus magna consequat lacus, at dignissim augue nisi sit amet massa. Aenean ultrices tincidunt pulvinar. Nulla facilisi. "
                            };

            var comment = new Comment
            {
                Post = post,
                Author = "Agustus",
                Created = DateTime.Now.AddDays(-9),
                Content =
                    "You suck."
            };

            var comment2 = new Comment
            {
                Post = post2,
                Author = "Steve",
                Created = DateTime.Now.AddDays(-24),
                Content =
                    "First!"
            };

            post.Comments.Add(comment);
            post2.Comments.Add(comment2);

            context.Posts.Add(post);
            context.Posts.Add(post2);
        }

        private static void CreateBalances(SymposiumDataContext context)
        {
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
        }

        private static void CreateMembershipUsers()
        {
            MembershipCreateStatus createStatus;
            Membership.CreateUser("srkirkland", "Devel$$", "srkirkland@ucdavis.edu", null, null, true, null, out createStatus);
            Membership.CreateUser("anlai", "Devel$$", "anlai@ucdavis.edu", null, null, true, null, out createStatus);
        }
    }
}