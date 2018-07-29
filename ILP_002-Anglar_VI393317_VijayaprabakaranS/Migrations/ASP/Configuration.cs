namespace ILP_002_Anglar_VI393317_VijayaprabakaranS.Migrations.ASP
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ILP_002_Anglar_VI393317_VijayaprabakaranS.Models.AspContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\ASP";
        }

        protected override void Seed(ILP_002_Anglar_VI393317_VijayaprabakaranS.Models.AspContext context)
        {
            context.supervisors.AddOrUpdate(
                a => new { a.EmailID }, Data.Data.GetSupervisors().ToArray());
            context.SaveChanges();

            context.employees.AddOrUpdate(
                e => new { e.EmailID }, Data.Data.GetEmployees().ToArray());
            context.SaveChanges();

        }
    }
}
