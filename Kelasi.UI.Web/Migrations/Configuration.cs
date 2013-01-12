using Kelasi.Model;
using System.Data.Entity.Migrations;

namespace Kelasi.UI.Web.Migrations
{

    internal sealed class Configuration : DbMigrationsConfiguration<Repository.Repositories.Kelasi>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Repository.Repositories.Kelasi context)
        {
            context.Topics.AddOrUpdate(
                t => t.Title,
                new Topic {Title = "Software Development"},
                new Topic {Title = "Mathematics"},
                new Topic {Title = "Science"}
                );
        }
    }
}
