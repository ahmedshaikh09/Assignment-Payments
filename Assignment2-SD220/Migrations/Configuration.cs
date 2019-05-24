namespace Assignment2_SD220.Migrations
{
    using Assignment2_SD220.Models.Domain;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Assignment2_SD220.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Assignment2_SD220.Models.ApplicationDbContext context)
        {
            var CC1 = new CreditCard();
            CC1.IdentificationNumber = "011";
            CC1.Brand = "Visa";

            context.CreditCards.AddOrUpdate(p => p.IdentificationNumber, CC1);

            var CC2 = new CreditCard();
            CC2.IdentificationNumber = "021";
            CC2.Brand = "MasterCard";

            context.CreditCards.AddOrUpdate(p => p.IdentificationNumber, CC2);

            var CC3 = new CreditCard();
            CC3.IdentificationNumber = "031";
            CC3.Brand = "American Express";

            context.CreditCards.AddOrUpdate(p => p.IdentificationNumber, CC3);

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
