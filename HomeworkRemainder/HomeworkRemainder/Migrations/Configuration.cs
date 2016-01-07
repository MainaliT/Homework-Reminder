namespace HomeworkRemainder.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HomeworkRemainder.Models.HomeworkDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HomeworkRemainder.Models.HomeworkDBContext context)
        {
            context.Homeworks.AddOrUpdate(i => i.ClassID,
            new Models.Homework
            {
                ClassID = 12,
                RemainderName = "Appointment With IRS",
                StartDate = DateTime.Parse("12/21/2015"),
                EndDate = DateTime.Parse("12/21/2015")

            }
                );
        }
    }
}
