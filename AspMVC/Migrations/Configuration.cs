
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace AspMVC.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<AspMVC.Models.CollegeDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
    } 
}