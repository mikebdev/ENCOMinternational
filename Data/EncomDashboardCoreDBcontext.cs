using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EncomDashboardCore.Models;


namespace EncomDashboardCore.Data
{
    
    public class EncomDashboardCoreDBcontext : DbContext
    {

        public EncomDashboardCoreDBcontext(DbContextOptions<EncomDashboardCoreDBcontext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Application> Applications { get; set; }
    }
}


//IdentityDisk will contain all data related to the Company websites:
//Note: at this time there is no need to save anything to the database, this is simply here for future expansion. 

//For the initial launch, the dashboard will just have the three company websites hard coded.

//I have included two tables for the possible future dashboard expansion: 
//1. Application: to store websites and services to check
//2. User: to store user to be used for logins.

