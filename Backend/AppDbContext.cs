//Needed to access IdentityDbContext
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

//access DbContectOptions
using Microsoft.EntityFrameworkCore;

//reference User class
using Backend.Models;

namespace Backend
{
    //DbContext is Entity Framwork, 
    //IdentityDbContext tables, roles, logins, claims
    //pass custom user class to IdentityDbContext 
    public class AppDbContext : IdentityDbContext<User>
    {
        //constructor, pass options to base class
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            //add Dbset Props later
        }
    }
}