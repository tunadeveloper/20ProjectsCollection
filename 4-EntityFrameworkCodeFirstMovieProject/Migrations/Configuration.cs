﻿namespace _4_EntityFrameworkCodeFirstMovieProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<_4_EntityFrameworkCodeFirstMovieProject.DataAccess.Context.MovieContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(_4_EntityFrameworkCodeFirstMovieProject.DataAccess.Context.MovieContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
